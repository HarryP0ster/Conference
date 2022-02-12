using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using agorartc;

namespace RSI_X_Desktop
{
    internal static class ScreenCapture
    {
        public static bool IsCapture { get; private set; }
        static System.Diagnostics.Process proc = null;

        internal static void StartScreenCapture(ScreenCaptureParameters capParam)
        {
            StopScreenCapture();

            if (AgoraObject.IsLocalAudioMute == false)
                StartAudioCapture();

            if (capParam.bitrate == 0)
                capParam = forms.PopUpForm.resolutionsSize[
                    forms.PopUpForm.oldResolution];
            Rectangle region = new();

            region.width = Screen.PrimaryScreen.Bounds.Width;
            region.height = Screen.PrimaryScreen.Bounds.Height;
            capParam.bitrate = 1200;
            capParam.frameRate = 15;

            IsCapture =
                (int)ERROR_CODE.ERR_OK == AgoraObject.Rtc.StartScreenCaptureByScreenRect(region, region, capParam);

            DebugWriter.WriteTime($"ScreenCapture. screen sharing enable ({IsCapture})");
        }

        private static void proc_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            DebugWriter.Write($"ScreenCapture. {e.Data}");

            if (e.Data == null ||
                e.Data.StartsWith("uid:") == false) return;

            uint selfSpeakerUid = Convert.ToUInt32(
                e.Data.Split(':')[1]);

            if (selfSpeakerUid != 0) 
                UidChecker.MuteUid(selfSpeakerUid);
        }
        public static void StartAudioCapture() 
        {
            List<string> args = new()
            {
                AgoraObject.GetHostToken(),
                AgoraObject.GetHostName(),
                System.Diagnostics.Process.GetCurrentProcess().Id.ToString(),
            };

            string arguments = "";
            foreach (var a in args)
                arguments += $"\"{a}\" ";

            proc = new();
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.FileName = "appInDesctop.exe";
            proc.OutputDataReceived += proc_OutputDataReceived;

            proc.Start();
            proc.BeginOutputReadLine();
        }

        public static void StopAudioCapture() 
        {
            proc?.Kill();
            proc = null;
            UidChecker.ClearMuteUids();
        }

        internal static void StopScreenCapture()
        {
            AgoraObject.Rtc.StopScreenCapture();
            StopAudioCapture();

            IsCapture = false;
        }
    }
}
