using System;

using agorartc;

namespace RSI_X_Desktop
{
    internal class AGEngineEventHandler : IRtcEngineEventHandlerBase
    {
        private IFormHostHolder form;
        public AGEngineEventHandler(IFormHostHolder form) 
        {
            this.form = form;
        }
        public override void OnJoinChannelSuccess(string channel, uint uid, int elapsed)
        {
            Console.WriteLine("OnJoinChannelSuccess");
        }

        public override void OnReJoinChannelSuccess(string channel, uint uid, int elapsed)
        {
            Console.WriteLine("OnReJoinChannelSuccess");
        }

        public override void OnConnectionLost()
        {
            Console.WriteLine("OnConnectionLost");
        }

        public override void OnConnectionInterrupted()
        {
            Console.WriteLine("OnConnectionInterrupted");
        }

        public override void OnLeaveChannel(RtcStats stats)
        {
            Console.WriteLine("OnLeaveChannel");
        }

        public override void OnRequestToken()
        {
            Console.WriteLine("OnRequestToken");
        }

        public override void OnUserJoined(uint uid, int elapsed)
        {
            UserInfo info;

            AgoraObject.Rtc.GetUserInfoByUid(uid, out info);
        }

        public override void OnUserOffline(uint uid, USER_OFFLINE_REASON_TYPE reason)
        {
            Console.WriteLine("OnUserOffline");
        }

        public override void OnAudioVolumeIndication(AudioVolumeInfo[] speakers, uint speakerNumber, int totalVolume)
        {
            Console.WriteLine("OnAudioVolumeIndication");
        }

        public override void OnUserMuteAudio(uint uid, bool muted)
        {
            Console.WriteLine("OnUserMuteAudio");
        }

        public override void OnWarning(WARN_CODE_TYPE warn, string msg)
        {
            Console.WriteLine("OnWarning {0}", warn);
        }

        public override void OnError(ERROR_CODE error, string msg)
        {
            Console.WriteLine("OnError {0}", error);
        }

        public override void OnRtcStats(RtcStats stats)
        {
            Console.WriteLine("OnRtcStats");
        }

        public override void OnAudioMixingFinished()
        {
            Console.WriteLine("OnAudioMixingFinished");
        }

        public override void OnAudioRouteChanged(AUDIO_ROUTE_TYPE routing)
        {
            Console.WriteLine("OnAudioRouteChanged");
        }

        public override void OnFirstRemoteVideoDecoded(uint uid, int width, int height, int elapsed)
        {
            Console.WriteLine("OnFirstRemoteVideoDecoded");
        }

        public override void OnVideoSizeChanged(uint uid, int width, int height, int rotation)
        {
            Console.WriteLine("OnVideoSizeChanged");
        }

        public override void OnClientRoleChanged(CLIENT_ROLE_TYPE oldRole, CLIENT_ROLE_TYPE newRole)
        {
            Console.WriteLine("OnClientRoleChanged");
        }

        public override void OnUserMuteVideo(uint uid, bool muted)
        {
            Console.WriteLine("OnUserMuteVideo");
        }

        public override void OnMicrophoneEnabled(bool enabled)
        {
            Console.WriteLine("OnMicrophoneEnabled");
        }

        public override void OnApiCallExecuted(ERROR_CODE err, string api, string result)
        {
            Console.WriteLine("OnApiCallExecuted");
        }

        public override void OnFirstLocalAudioFrame(int elapsed)
        {
            Console.WriteLine("OnFirstLocalAudioFrame");
        }

        public override void OnFirstLocalAudioFramePublished(int elapsed)
        {
            Console.WriteLine("OnFirstLocalAudioFramePublished");
        }

        public override void OnFirstRemoteAudioFrame(uint uid, int elapsed)
        {
            Console.WriteLine("OnFirstRemoteAudioFrame");
        }

        public override void OnLastmileQuality(int quality)
        {
            Console.WriteLine("OnLastmileQuality");
        }

        public override void OnAudioQuality(uint uid, int quality, ushort delay, ushort lost)
        {
            Console.WriteLine("OnAudioQuality");
        }

        public override void OnStreamInjectedStatus(string url, uint uid, int status)
        {
            Console.WriteLine("OnStreamInjectedStatus");
        }

        public override void OnStreamUnpublished(string url)
        {
            Console.WriteLine("OnStreamUnpublished");
        }

        public override void OnStreamPublished(string url, ERROR_CODE error)
        {
            Console.WriteLine("OnStreamPublished");
        }

        public override void OnStreamMessageError(uint uid, int streamId, int code, int missed, int cached)
        {
        }

        public override void OnStreamMessage(uint uid, int streamId, byte[] data, uint length)
        {
            UserInfo name;
            string Message = AgoraObject.utf8enc.GetString(data);

            AgoraObject.Rtc.GetUserInfoByUid(uid, out name);
            string UserName = name.userAccount;
            var formInterpr = (form as Broadcaster);
            formInterpr.GetMessage(Message, UserName, CHANNEL_TYPE.HOST);
            Console.WriteLine("OnStreamMessage");
        }

        public override void OnUserInfoUpdated(uint uid, UserInfo info)
        {
            AgoraObject.UpdateHostUserInfo(uid, info);
            Console.WriteLine("OnUserInfoUpdated");
        }

        public override void OnLocalVideoStateChanged(LOCAL_VIDEO_STREAM_STATE localVideoState,
            LOCAL_VIDEO_STREAM_ERROR error)
        {
            Console.WriteLine("OnLocalVideoStateChanged");

            switch (localVideoState)
            {
                case LOCAL_VIDEO_STREAM_STATE.LOCAL_VIDEO_STREAM_STATE_CAPTURING:
                case LOCAL_VIDEO_STREAM_STATE.LOCAL_VIDEO_STREAM_STATE_ENCODING:
                    DebugWriter.WriteTime($"{localVideoState}, {error}");
                    if (ImageSender.IsEnable)
                    {
                        ImageSender.SetLocalFrame();
                        forms.PopUpForm.SetImageSend(true);
                    }
                    else
                        ImageSender.SetLocalFrame(clear: true);
                    break;
                case LOCAL_VIDEO_STREAM_STATE.LOCAL_VIDEO_STREAM_STATE_FAILED:
                case LOCAL_VIDEO_STREAM_STATE.LOCAL_VIDEO_STREAM_STATE_STOPPED:
                default:
                    break;
            }
        }
    }
}
