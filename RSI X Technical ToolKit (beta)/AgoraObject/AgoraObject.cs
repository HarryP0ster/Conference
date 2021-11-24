using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using agorartc;
using HWND = System.IntPtr;

namespace RSI_X_Desktop
{
    enum CurForm
    {
        workFormater,
        FormBroadcaster,
        FormAudience,
        FormEngineer,
        FormEngineer2,
        None
    }
    static class AgoraObject
    {

        public const string AppID = "31f0e571a89542b09049087e3283417f";

        public static bool IsLocalAudioMute { get; private set; }
        public static bool IsLocalVideoMute { get; private set; }
        public static bool IsAllRemoteAudioMute { get; private set; }
        public static bool IsAllRemoteVideoMute { get; private set; }


        public static string CodeRoom { get; private set; } = "";
        public static string NickName { get; private set; } = "";
        public static string ClientID { get; private set; } = "";
        public static string RoomLang { get => RoomName.Split('_')[0]; }
        public static string RoomName { get; private set; } = ""; //Full name of the interpreters room without 8 digits
        public static string RoomTarg { get; private set; } = ""; //Full name of the target room without 8 digits
        public static CurForm CurrentForm = CurForm.None;

        internal static AgoraRtcEngine Rtc;

        internal static Tokens room = new Tokens();

        internal static AgoraRtcChannel m_channelSrc;
        internal static AgoraRtcChannel m_channelHost;

        private static int _hostStreamID;
        internal static int hostStreamID { get => _hostStreamID; }
        internal static AGChannelEventHandler srcHandler;
        internal static AGChannelEventHandler hostHandler;
        private static IFormHostHolder workForm;

        internal static Dictionary<uint, UserInfo> hostBroacsters = new();

        public static IFormHostHolder GetWorkForm
        {
            get
            {
                return (workForm == null || (workForm as Form).IsDisposed) ?
                    null :
                    workForm;
            }
        }

        public static bool m_channelSrcJoin { get; private set; } = false;
        public static bool m_channelHostJoin { get; private set; } = false;
        public readonly static System.Text.UTF8Encoding utf8enc = new();

        [DllImport("USER32.DLL")]
        static extern bool GetWindowRect(IntPtr hWnd, out System.Drawing.Rectangle lpRect);

        static AgoraObject()
        {
            Rtc = AgoraRtcEngine.CreateRtcEngine();
            Rtc.Initialize(new RtcEngineContext(AppID));

            SetPublishProfile();
        }

        private static void SetPublishProfile()
        {
            Rtc.SetAudioProfile(AUDIO_PROFILE_TYPE.AUDIO_PROFILE_MUSIC_HIGH_QUALITY, AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_CHATROOM_GAMING);
            Rtc.SetVideoProfile(VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_180P_3, false);
        }

        static public void UpdateNickName(string nick)
        { NickName = nick; }
        static public void UpdateRoomName(string name)
        { RoomName = name; }
        static public void UpdateClientID(string uid)
        { ClientID = uid; }

        #region token logic
        static public bool JoinRoom(string code)
        {
            CodeRoom = code;
            return room.TakeToken(code);
        }

        public static Tokens GetComplexToken() => room;
        public static string GetHostToken() => room.GetToken;
        public static string GetHostName() => room.GetHostName;
        #endregion

        #region Mute local audio/video
        static public ERROR_CODE MuteLocalAudioStream(bool mute)
        {
            ERROR_CODE res = Rtc.MuteLocalAudioStream(mute);

            if (res == ERROR_CODE.ERR_OK)
                IsLocalAudioMute = mute;

            return res;
        }

        static public ERROR_CODE MuteLocalVideoStream(bool mute)
        {
            ERROR_CODE res = Rtc.MuteLocalVideoStream(mute);

            if (res == ERROR_CODE.ERR_OK)
                IsLocalVideoMute = mute;

            return res;
        }
        #endregion

        #region  mute remote video/audio
        static public void MuteAllRemoteAudioStream(bool mute)
        {
            Rtc.MuteAllRemoteAudioStreams(mute);
            m_channelHost?.MuteAllRemoteAudioStreams(mute);
            m_channelSrc?.MuteAllRemoteAudioStreams(mute);

            IsAllRemoteAudioMute = mute;
        }

        static public void MuteAllRemoteVideoStream(bool mute)
        {
            Rtc.MuteAllRemoteVideoStreams(mute);
            m_channelHost?.MuteAllRemoteVideoStreams(mute);

            IsAllRemoteVideoMute = mute;
        }
        #endregion

        static public void SetWndEventHandler(IFormHostHolder form)
        {
            Rtc.InitEventHandler(new AGEngineEventHandler(form));
            srcHandler = new AGChannelEventHandler(form, CHANNEL_TYPE.SRC);
            hostHandler = new AGChannelEventHandler(form, CHANNEL_TYPE.HOST);
            workForm = form;
        }

        #region Screen/Window capture
        public static bool EnableScreenCapture()
        {
            int wdth = Screen.PrimaryScreen.Bounds.Width;
            int hgt = Screen.PrimaryScreen.Bounds.Height;
            ScreenCaptureParameters capParam = new ScreenCaptureParameters(wdth, hgt);
            Rectangle region = new Rectangle();
            region.width = wdth;
            region.height = hgt;
            capParam.bitrate = 1200;
            capParam.frameRate = 30;
            Rtc.StartScreenCaptureByScreenRect(region, region, capParam);
            return true;
        }
        public static bool EnableWindowCapture(HWND index)
        {
            Rectangle region = new Rectangle();
            System.Drawing.Rectangle Rectangle2 = new();
            GetWindowRect((System.IntPtr)index, out Rectangle2);
            int wdth = Rectangle2.Width;
            int hgt = Rectangle2.Height;
            ScreenCaptureParameters capParam = new ScreenCaptureParameters(wdth, hgt);
            region.x = 0;
            region.y = 0;
            region.width = wdth;
            region.height = hgt;
            capParam.bitrate = 1200;
            capParam.frameRate = 30;
            Rtc.StartScreenCaptureByWindowId((ulong)index, region, capParam);
            return true;
        }
        #endregion

        #region Channel src
        public static bool JoinChannelSrc(langHolder lh_holder)
        {
            return JoinChannelSrc(lh_holder.langFull, lh_holder.token, 0, "");
        }
        public static bool JoinChannelSrc(string lpChannelName, string token, uint nUID, string info)
        {
            LeaveSrcChannel();

            m_channelSrc = Rtc.CreateChannel(lpChannelName);
            m_channelSrc.InitChannelEventHandler(srcHandler);
            m_channelSrc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_AUDIENCE);

            ChannelMediaOptions options = new();
            options.autoSubscribeAudio = true;
            options.autoSubscribeVideo = false;

            ERROR_CODE ret = m_channelSrc.JoinChannel(token, info, nUID, options);

            m_channelSrcJoin = (0 == ret);

            return 0 == ret;
        }
        public static void LeaveSrcChannel()
        {
            if (m_channelSrcJoin)
                m_channelSrc?.LeaveChannel();
            m_channelSrcJoin = false;

        }
        #endregion

        #region Channel host
        public static bool JoinChannelHost(langHolder lh_holder)
        {
            return JoinChannelHost(lh_holder.langFull, lh_holder.token, 0, "");
        }
        public static bool JoinChannelHost(string lpChannelName, string token, uint nUID, string info)
        {
            ERROR_CODE ret;
            LeaveHostChannel();

            m_channelHost = Rtc.CreateChannel(lpChannelName);
            m_channelHost.InitChannelEventHandler(hostHandler);
            m_channelHost.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            m_channelHost.SetDefaultMuteAllRemoteVideoStreams(false);

            ChannelMediaOptions options = new();
            options.autoSubscribeAudio = true;
            options.autoSubscribeVideo = true;
            Random rnd = new Random();
            var str = string.Format("{0}_{1}", "HOST", (ulong)rnd.Next());
            ret = m_channelHost.JoinChannelWithUserAccount(token,
                str,
                options);

            m_channelHost.Publish();
            m_channelHost.CreateDataStream(out _hostStreamID, true, true);

            m_channelHostJoin = (0 == ret);
            return 0 == ret;
        }
        public static void LeaveHostChannel()
        {
            if (m_channelHostJoin)
                m_channelHost?.Unpublish();
                m_channelHost?.LeaveChannel();
            m_channelHostJoin = false;
        }
        #endregion

        internal static void NewUserOnHost(uint uid, UserInfo user, string channelId)
        {
            if (hostBroacsters.ContainsKey(uid))
                hostBroacsters[uid] = user; 
            else
                hostBroacsters.Add(uid, user);
            workForm.NewBroadcaster(uid, user);
        }
        internal static void UpdateHostUserInfo(uint uid, UserInfo user)
        {
            if (hostBroacsters.ContainsKey(uid)) 
            {
                hostBroacsters[uid] = user;
                workForm.BroadcasterUpdateInfo(uid, user);
            }
        }
        internal static void RemoveHostUserInfo(uint uid)
        {
            if (hostBroacsters.ContainsKey(uid))
            {
                hostBroacsters.Remove(uid);
                workForm.BroadcasterLeave(uid);
            }
        }
        internal static void UpdateTargRoom(string langFull)
        {
            if (langFull != string.Empty)
                langFull = langFull.Remove(3, 2);

            RoomTarg = langFull;
        }
        public static void SendMessageToHost(string msg)
        {
            Rtc.SendStreamMessage(_hostStreamID, utf8enc.GetBytes(msg));
        }
    }
}