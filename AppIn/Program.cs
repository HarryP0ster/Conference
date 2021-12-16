using System;
using agorartc;
using System.Threading;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace ConsoleAppIn
{
    enum TARGET_MESSAGES
    {
        MUTE = 0,
        UNMUTE = 1
    }
    class Program
    {
        static int parentID;
        static System.Diagnostics.Process proc;
        const string PipeName = "PipeIn";
        static XAgoraObject agoraObject;

        //appIn [token] [channelId] [record device] [name]
        static void Main(string[] args)
        {
            agoraObject = new XAgoraObject();

            var retInput = agoraObject.SetupInputDevices(args[2]);
            var retPubl = agoraObject.Publish(args[0], args[1], args[4]);

            if (retInput != ERROR_CODE.ERR_OK ||
                retPubl != ERROR_CODE.ERR_OK)
                return;
            
            proc = System.Diagnostics.Process.GetProcessById(parentID);
            parentID = System.Convert.ToInt32(args[3]);

            while (true)
            {
                string s = Console.ReadLine();
                if (s.Contains(":") == false) return;

                switch (s.Split(':')[0])
                {
                    case "msg":
                        NewMsg(s);
                        break;
                }
            }

            //proc.WaitForExit();
        }

        static void NewMsg(string msg) 
        {
            string index = msg.Split(':')[1];
            TARGET_MESSAGES message =
                (TARGET_MESSAGES)Convert.ToUInt32(index);

            Console.WriteLine(message);

            switch (message)
            {
                case TARGET_MESSAGES.MUTE:
                    agoraObject.Rtc.MuteLocalAudioStream(true);
                    break;
                case TARGET_MESSAGES.UNMUTE:
                    agoraObject.Rtc.MuteLocalAudioStream(false);
                    break;
                default:
                    break;

            }
        }
    }
    class XAgoraObject
    {
        public AgoraRtcEngine Rtc;
        AgoraAudioRecordingDeviceManager audioInDeviceManager;

        public const string AppID = "31f0e571a89542b09049087e3283417f";
        public string nameDevice;
        public bool IsJoin { get; private set; }

        public XAgoraObject()
        {
            Rtc = AgoraRtcEngine.CreateRtcEngine();
            Rtc.InitEventHandler(new AEngineEventHandler());
            Rtc.MuteLocalVideoStream(true);
            Rtc.Initialize(new RtcEngineContext(AppID));
            Rtc.SetAudioProfile(AUDIO_PROFILE_TYPE.AUDIO_PROFILE_MUSIC_HIGH_QUALITY, AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_CHATROOM_GAMING);


            audioInDeviceManager = Rtc.CreateAudioRecordingDeviceManager();
        }

        public ERROR_CODE SetupInputDevices(string ind)
        {
            //audioInDeviceManager.GetDeviceInfoByIndex(ind, out string nameOUT, out string idOUT);
            //nameDevice = nameOUT;
            return audioInDeviceManager.SetCurrentDevice(ind);
        }

        public ERROR_CODE Publish(string token, string channel, string account = null)
        {
            Rtc.MuteAllRemoteAudioStreams(true);
            Rtc.MuteAllRemoteVideoStreams(true);
            ERROR_CODE res = ERROR_CODE.ERR_NOT_READY;

            if (account == null)
                res = Rtc.JoinChannel(token, channel, "", 0);
            else
                res = Rtc.JoinChannelWithUserAccount(token, channel, account);

            if (res == ERROR_CODE.ERR_OK)
                IsJoin = true;

            audioInDeviceManager.GetCurrentDeviceInfo(out string idOUT, out string nameOUT);
            nameDevice = nameOUT;
            //Console.WriteLine("\n\n\n\nHello World!");
            return res;
        }

        public void UnPublish()
        {
            Rtc.LeaveChannel();
            IsJoin = false;
        }
    }
}
