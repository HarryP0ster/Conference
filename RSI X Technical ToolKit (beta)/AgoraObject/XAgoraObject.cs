using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agorartc;

namespace RSI_X_Desktop
{
    enum STATE_AGORA
    {
        SPECTR,
        BROADCAST,
        INDEFINIT
    }
    class XAgoraObject
    {
        private AgoraRtcEngine Rtc;
        private AgoraAudioRecordingDeviceManager audioInDeviceManager;
        private AgoraRtcChannel channel;
        private AGChannelEventHandler channelHandler;
        public STATE_AGORA state { get; private set; } = STATE_AGORA.INDEFINIT;
        public bool IsJoin { get; private set; } = false;
        public bool IsPublish { get; private set; } = false;
        private IFormHostHolder workForm; 
        public IFormHostHolder GetWorkForm
        {
            get
            {
                return (workForm == null || (workForm as System.Windows.Forms.Form).IsDisposed) ?
                    null :
                    workForm;
            }
        }
        public XAgoraObject() 
        {
            Rtc = AgoraRtcEngine.CreateRtcEngine();
            Rtc.Initialize(new RtcEngineContext(AgoraObject.AppID));
            audioInDeviceManager = Rtc.CreateAudioRecordingDeviceManager();
        }

        public bool JoinAsSpectarator(langHolder lang) 
        {
            LeaveChannel();

            channelHandler = new AGChannelEventHandler(workForm, CHANNEL_TYPE.SRC);

            channel = Rtc.CreateChannel(lang.langFull);
            channel.InitChannelEventHandler(channelHandler);
            channel.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_AUDIENCE);

            ChannelMediaOptions options = new();
            options.autoSubscribeAudio = true;
            options.autoSubscribeVideo = false;

            ERROR_CODE ret = channel.JoinChannel(lang.token, "", 0, options);

            IsJoin = (0 == ret);
            state = STATE_AGORA.SPECTR;
            return 0 == ret;
        }
        public bool JoinAsBroacaster(langHolder lang)
        {
            LeaveChannel();
            channelHandler = new AGChannelEventHandler(workForm, CHANNEL_TYPE.HOST);

            channel = Rtc.CreateChannel(lang.langFull);
            channel.InitChannelEventHandler(channelHandler);
            channel.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);

            ChannelMediaOptions options = new();
            options.autoSubscribeAudio = false;
            options.autoSubscribeVideo = false;

            ERROR_CODE ret = channel.JoinChannel(lang.token, "", 0, options);
            IsJoin = (0 == ret);
            state = STATE_AGORA.BROADCAST;

            return 0 == ret;
        }
        public bool TogglePublishBroacaster(bool publish) 
        {
            ERROR_CODE ret;
            if (!IsJoin || state != STATE_AGORA.BROADCAST) 
                return false;

            if (publish)
            {
                ret = channel.Publish();
                IsPublish = ret == ERROR_CODE.ERR_OK;
            }
            else 
            {
                ret = channel.Unpublish();
                IsPublish = ret == ERROR_CODE.ERR_OK;
            }

            return ret == ERROR_CODE.ERR_OK;
        }
        private void LeaveChannel()
        {
            if (IsPublish)
                channel?.Unpublish();
            if (IsJoin)
                channel?.LeaveChannel();

            channel?.Dispose();
            channel = null;
        }
        public ERROR_CODE SetupInputDevices(int ind) 
        {
            audioInDeviceManager.GetDeviceInfoByIndex(ind, out string nameOUT, out string idOUT);
            return audioInDeviceManager.SetCurrentDevice(idOUT);
        }

        public ERROR_CODE Publish(langHolder langDest) 
        {
            ERROR_CODE res = Rtc.JoinChannel(langDest.token, langDest.langFull, "", 0);

            if (res == ERROR_CODE.ERR_OK)
                IsJoin = true;

            return res;
        }

        public void UnPublish() 
        {
            Rtc.LeaveChannel();
            IsJoin = false;
        }
    }
}
