using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using agorartc;
using RSI_X_Desktop.forms;

namespace RSI_X_Desktop
{
    public enum CHANNEL_TYPE
    {
        SRC,
        TRANSL,
        DEST,
        HOST,
        CONFERENCE,
        UNKNOWN
    };
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
        public static bool IsScreenCapture { get; private set; } = false;
        public static bool IsAllRemoteAudioMute { get; private set; }
        public static bool IsAllRemoteVideoMute { get; private set; }


        public static string CodeRoom { get; private set; } = String.Empty;
        public static string NickName { get; private set; } = String.Empty;
        public static string ClientID { get; private set; } = String.Empty;
        public static string RoomLang { get => RoomName.Split('_')[0]; }
        public static string RoomName { get; private set; } = String.Empty; //Full name of the interpreters room without 8 digits
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
        public static IFormHostHolder GetWorkForm
        {
            get
            {
                return (workForm == null || (workForm as Form).IsDisposed) ?
                    null :
                    workForm;
            }
        }

        internal static Dictionary<uint, UserInfo> hostBroacsters = new();


        public static bool ChannelSrcJoin { get; private set; } = false;
        public static bool ChannelHostJoin { get; private set; } = false;

        public static readonly System.Text.UTF8Encoding utf8enc = new();

        [DllImport("USER32.DLL")]
        static extern bool GetWindowRect(IntPtr hWnd, out System.Drawing.Rectangle lpRect);

        static AgoraObject()
        {
            Rtc = AgoraRtcEngine.CreateRtcEngine();
            Rtc.Initialize(new RtcEngineContext(AppID));
            
            UpdateAudioQualiti(AUDIO_QUALITY.Medium);
            Rtc.SetVideoEncoderConfiguration(new VideoEncoderConfiguration(new VideoDimensions(1024, 720), FRAME_RATE.FRAME_RATE_FPS_15, 1040, ORIENTATION_MODE.ORIENTATION_MODE_ADAPTIVE));
        }
        private static void SetPublishProfile()
        {
            Rtc.SetAudioProfile(AUDIO_PROFILE_TYPE.AUDIO_PROFILE_MUSIC_HIGH_QUALITY, AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_CHATROOM_GAMING);
        }
        static public void UpdateNickName(string nick)
        { 
            NickName = NickCenter.ToConferenceNick(nick);
            DebugWriter.WriteTime($"AgoraObject. New nickname {NickName}");
        }
        static public void UpdateRoomName(string name)
        { RoomName = name; }
        static public void UpdateClientID(string uid)
        { ClientID = uid; }
        static public void SetWndEventHandler(IFormHostHolder form)
        {
            Rtc.InitEventHandler(new AGEngineEventHandler(form));
            srcHandler = new AGChannelEventHandler(form, CHANNEL_TYPE.SRC);
            hostHandler = new AGChannelEventHandler(form, CHANNEL_TYPE.HOST);
            workForm = form;
        }

        #region token logic
        static public bool JoinRoom(string code)
        {
            CodeRoom = code;
            return room.TakeToken(code);
        }
        public static Tokens GetComplexToken() => room;
        public static string GetHostToken() => room.GetHostToken;
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
        public static void UpdateUserVolume(uint uid, int volume, CHANNEL_TYPE channel)
        {
            switch (channel)
            {
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.SRC:
                    m_channelSrc?.SetRemoteVoicePosition(uid, 0, volume);
                    break;
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.HOST:
                    m_channelHost?.SetRemoteVoicePosition(uid, 0, volume);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Screen/Window capture
        public static void StartScreenCapture(ScreenCaptureParameters capParam)
        {
            //if (capParam)
            //    capParam = forms.Devices.GetVideoParam();
            ScreenCapture.StartScreenCapture(capParam);
        }
        public static void StopScreenCapture()
        {
            ScreenCapture.StopScreenCapture();
            PopUpForm.AcceptAllOldDevices();
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

            ChannelSrcJoin = (0 == ret);

            return 0 == ret;
        }
        public static void LeaveSrcChannel()
        {
            if (ChannelSrcJoin)
                m_channelSrc?.LeaveChannel();
            ChannelSrcJoin = false;

        }
        #endregion

        #region Channel host
        internal static void JoinChannelHost()
        {
            JoinChannelHost(room.GetHostName, room.GetHostToken, 0, "");
        }
        public static bool JoinChannelHost(langHolder lh)
        {
            return JoinChannelHost(lh.langFull, lh.token, 0, "");
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
            ret = m_channelHost.JoinChannelWithUserAccount(token,
                NickName,
                options);

            Rtc.MuteLocalAudioStream(IsLocalAudioMute);
            Rtc.MuteLocalVideoStream(IsLocalVideoMute);

            m_channelHost.Publish();
            m_channelHost.CreateDataStream(out _hostStreamID, true, true);

            ChannelHostJoin = (0 == ret);
            return 0 == ret;
        }
        public static void LeaveHostChannel()
        {
            if (ChannelHostJoin)
                m_channelHost?.Unpublish();
                m_channelHost?.LeaveChannel();
            ChannelHostJoin = false;
        }
        #endregion

        internal static void NewUserOnHost(uint uid, UserInfo user, string channelId)
        {
            if (hostBroacsters.ContainsKey(uid))
                hostBroacsters[uid] = user; 
            else
                hostBroacsters.Add(uid, user);
            workForm.NewBroadcaster(uid, user);
            
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: New user {user.userAccount} {uid}");
        }
        internal static void UpdateHostUserInfo(uint uid, UserInfo user)
        {
            if (hostBroacsters.ContainsKey(uid)) 
            {
                hostBroacsters[uid] = user;
                workForm.BroadcasterUpdateInfo(uid, user);
                System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: update user {user.userAccount} {uid}");
            }
        }
        internal static void RemoveHostUserInfo(uint uid)
        {
            if (hostBroacsters.ContainsKey(uid))
            {
                hostBroacsters.Remove(uid);
                workForm.BroadcasterLeave(uid);

                System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: remove conf {uid}");
            }
        }
        public static void SendMessageToGlobal(string msg)
        {
            var buffer = other.Messager.PrepareToGlobal(msg);
            m_channelHost.SendStreamMessage(_hostStreamID, buffer);
        }
        public static void SendMessageToConference(string msg)
        {
            var buffer = other.Messager.PrepareToConference(msg);
            m_channelHost.SendStreamMessage(_hostStreamID, buffer);
        }

        internal static void UpdateAudioQualiti(AUDIO_QUALITY quality)
        {
            LeaveHostChannel();

            switch (quality)
            {
                case AUDIO_QUALITY.Low:
                    Rtc.SetAudioProfile(
                        AUDIO_PROFILE_TYPE.AUDIO_PROFILE_SPEECH_STANDARD,
                        AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_DEFAULT);
                    break;
                case AUDIO_QUALITY.Medium:
                    Rtc.SetAudioProfile(
                        AUDIO_PROFILE_TYPE.AUDIO_PROFILE_MUSIC_STANDARD,
                        AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_DEFAULT);
                    break;
                case AUDIO_QUALITY.High:
                    Rtc.SetAudioProfile(
                        AUDIO_PROFILE_TYPE.AUDIO_PROFILE_MUSIC_HIGH_QUALITY,
                        AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_DEFAULT);
                    break;
            }
            DebugWriter.WriteTime($"AgoraObject. {quality}");
            JoinChannelHost();
        }
    }
}