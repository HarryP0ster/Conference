﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSI_X_Desktop.other;
using agorartc;


namespace RSI_X_Desktop
{
    public class AGChannelEventHandler : IRtcChannelEventHandlerBase
    {
        private IFormHostHolder form;
        public CHANNEL_TYPE chType { get; private set; }

        public AGChannelEventHandler(IFormHostHolder form_new, CHANNEL_TYPE new_chType)
        {
            form = form_new;
            chType = new_chType;
        }

        public override void OnChannelJoinChannelSuccess(string channelId, uint uid, int elapsed)
        {
            DebugWriter.WriteTime($"ChannelCallback. i [{uid}] succ join to [{chType}]{channelId}");
            switch (chType)
            {
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.HOST:
                    AgoraObject.UpdateClientID(uid.ToString());
                    AgoraObject.UpdateRoomName(channelId);
                    break;
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }

        public override void OnChannelReJoinChannelSuccess(string channelId, uint uid, int elapsed)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.HOST:
                    AgoraObject.UpdateClientID(uid.ToString());
                    AgoraObject.UpdateRoomName(channelId);
                    break;
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }


        public override void OnChannelLeaveChannel(string channelId, RtcStats stats)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.HOST:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }

        public override void OnChannelClientRoleChanged(string channelId, CLIENT_ROLE_TYPE oldRole,
            CLIENT_ROLE_TYPE newRole)
        {
        }

        public override void OnChannelUserJoined(string channelId, uint uid, int elapsed)
        {
            switch (chType) 
            {
                case CHANNEL_TYPE.HOST:
                    AgoraObject.Rtc.GetUserInfoByUid(uid, out UserInfo user);
                    AgoraObject.NewUserOnHost(uid, user, channelId);
                    break;
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }

        public override void OnChannelUserOffLine(string channelId, uint uid, USER_OFFLINE_REASON_TYPE reason)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.HOST:
                    AgoraObject.RemoveHostUserInfo(uid);
                    break;
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }
        

        public override void OnChannelConnectionLost(string channelId)
        {
        }

        public override void OnChannelRequestToken(string channelId)
        {
        }

        public override void OnChannelTokenPrivilegeWillExpire(string channelId, string token)
        {
        }

        public override void OnChannelRtcStats(string channelId, RtcStats stats)
        {
        }

        public override void OnChannelNetworkQuality(string channelId, uint uid, int txQuality, int rxQuality)
        {
        }


        public override void OnChannelRemoteVideoStats(string channelId, RemoteVideoStats stats)
        {
        }

        public override void OnChannelRemoteAudioStats(string channelId, RemoteAudioStats stats)
        {
        }

        public override void OnChannelRemoteAudioStateChanged(string channelId, uint uid, REMOTE_AUDIO_STATE state,
            REMOTE_AUDIO_STATE_REASON reason, int elapsed)
        {
            
        }

        public override void OnChannelAudioPublishStateChanged(string channelId, STREAM_PUBLISH_STATE oldState,
            STREAM_PUBLISH_STATE newState, int elapseSinceLastState)
        {
        }

        public override void OnChannelVideoPublishStateChanged(string channelId, STREAM_PUBLISH_STATE oldState,
            STREAM_PUBLISH_STATE newState, int elapseSinceLastState)
        {
        }

        public override void OnChannelAudioSubscribeStateChanged(string channelId, uint uid,
            STREAM_SUBSCRIBE_STATE oldState,
            STREAM_SUBSCRIBE_STATE newState, int elapseSinceLastState)
        {
        }

        public override void OnChannelVideoSubscribeStateChanged(string channelId, uint uid,
            STREAM_SUBSCRIBE_STATE oldState,
            STREAM_SUBSCRIBE_STATE newState, int elapseSinceLastState)
        {
        }

        public override void OnChannelUserSuperResolutionEnabled(string channelId, uint uid, bool enabled,
            SUPER_RESOLUTION_STATE_REASON reason)
        {
        }

        public override void OnChannelActiveSpeaker(string channelId, uint uid)
        {
        }

        public override void
            OnChannelVideoSizeChanged(string channelId, uint uid, int width, int height, int rotation)
        {
        }

        public override void OnChannelRemoteVideoStateChanged(string channelId, uint uid, REMOTE_VIDEO_STATE state,
            REMOTE_VIDEO_STATE_REASON reason, int elapsed)
        {
            
            switch (state) {
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_DECODING:
                    if (chType == CHANNEL_TYPE.HOST)
                        (form as Broadcaster).UpdateMember(uid, channelId);
                    FirstFrameDecoding(channelId, uid, reason);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_STOPPED:
                    VideoStreamHasStopped(channelId, uid, reason);
                    if (chType == CHANNEL_TYPE.HOST)
                        (form as Broadcaster).UpdateMember(uid);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_FROZEN:
                    if (chType == CHANNEL_TYPE.HOST)
                        (form as Broadcaster).UpdateMember(uid);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_FAILED:
                    if (chType == CHANNEL_TYPE.HOST)
                        (form as Broadcaster).UpdateMember(uid);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_STARTING:
                    break;
                default:
                    break;

            }

        }

        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|
        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|
        private void VideoStreamHasStopped(string channelId, uint uid, REMOTE_VIDEO_STATE_REASON reason)
        {
            UserInfo user;
            AgoraObject.Rtc.GetUserInfoByUid(uid, out user);

            switch (chType)
            {
                case CHANNEL_TYPE.HOST:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }

        private void FirstFrameDecoding(string channelId, uint uid, REMOTE_VIDEO_STATE_REASON reason)
        {
            VideoCanvas canv;

            switch (chType)
            {
                case CHANNEL_TYPE.HOST:
                    //if (form.RemoteWnd == IntPtr.Zero) return;

                    //canv = new((ulong)form.RemoteWnd, uid);
                    //canv.renderMode = (int)RENDER_MODE_TYPE.RENDER_MODE_FIT;
                    //canv.channelId = channelId;

                    //AgoraObject.Rtc.SetupRemoteVideo(canv);
                    //(form as Broadcaster).AddNewMember(channelId, uid);
                    break;
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }
        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|
        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|

        public string message = "";

        public override void
            OnChannelStreamMessage(string channelId, uint uid, int streamId, byte[] data, uint length)
        {
            UserInfo name;
            string Message = AgoraObject.utf8enc.GetString(data);
            string UserName = "";
            
            var formInterpr = (form as Broadcaster);

            AgoraObject.Rtc.GetUserInfoByUid(uid, out name);
            
            UserName = name.userAccount;
            byte perm = Messager.CheckMsgPerm(Message);

            if ((perm & (byte)PERMISSIONS.GLOBAL) > 0)
                formInterpr.GetMessage(Message, UserName, chType);
            if ((perm & (byte)PERMISSIONS.CONFERENCE) > 0)
                formInterpr.GetMessage(Message, UserName, CHANNEL_TYPE.CONFERENCE);
        }

        public override void OnChannelStreamMessageError(string channelId, uint uid, int streamId, int code,
            int missed, int cached)
        {
        }

        public override void OnChannelMediaRelayStateChanged(string channelId, CHANNEL_MEDIA_RELAY_STATE state,
            CHANNEL_MEDIA_RELAY_ERROR code)
        {
        }

        public override void OnChannelMediaRelayEvent(string channelId, CHANNEL_MEDIA_RELAY_EVENT code)
        {
        }

        public override void OnChannelRtmpStreamingStateChanged(string channelId, string url,
            RTMP_STREAM_PUBLISH_STATE state, RTMP_STREAM_PUBLISH_ERROR errCode)
        {
        }

        public override void OnChannelRtmpStreamingEvent(string channelId, string url, RTMP_STREAMING_EVENT eventCode)
        {
        }

        public override void OnChannelTranscodingUpdated(string channelId)
        {
        }

        public override void OnChannelStreamInjectedStatus(string channelId, string url, uint uid, int status)
        {
        }

        public override void OnChannelRemoteSubscribeFallbackToAudioOnly(string channelId, uint uid,
            bool isFallbackOrRecover)
        {
        }

        public override void OnChannelConnectionStateChanged(string channelId, CONNECTION_STATE_TYPE state,
            CONNECTION_CHANGED_REASON_TYPE reason)
        {
        }

        public override void OnChannelLocalPublishFallbackToAudioOnly(string channelId, bool isFallbackOrRecover)
        {
        }

        public override void OnChannelApiTest(int apiType, string @params)
        {
        }
    }

}
