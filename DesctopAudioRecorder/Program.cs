using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using agorartc;

namespace DesctopAudioRecorder
{
    internal static class Program
    {
        enum ARGS 
        {
            TOKEN,
            CHANNEL_ID,
            PID
        }
        static internal int parentID;
        static internal string token;
        static internal string chname;
        static System.Diagnostics.Process proc;

        //args [token] [channelId] [pid]
        static void Main(string[] args)
        {
            //Console.ReadLine();

            parentID = System.Convert.ToInt32(args[(int)ARGS.PID]);
            token = args[(int)ARGS.TOKEN];
            chname = args[(int)ARGS.CHANNEL_ID];

            XAgoraObject.JoinChannel(token, chname);
            proc = System.Diagnostics.Process.GetProcessById(parentID);

            proc.WaitForExit();

            XAgoraObject.StopScreenCapture();
            
        }
    }
}