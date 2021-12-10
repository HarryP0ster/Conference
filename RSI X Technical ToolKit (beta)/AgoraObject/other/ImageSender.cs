using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using agorartc;

namespace RSI_X_Desktop
{
    internal class ImageSender
    {
        private static Timer timer;
        private static Bitmap frame = null;
        private static Broadcaster WorkForm;

        private static ExternalVideoFrame VideoFrame = new();
        private static bool isEnable = false;
        private static bool isJoin = false;
        private static int fps = 15;
        public static bool IsEnable { get { return isEnable; } }
        public static Bitmap GetFrame { get { return frame; } }
        static ImageSender() 
        {
            timer = new(Timer_Elapsed, null, dueTime:1000/ fps, period: 1000 / fps);
        }
        public static void SetLocalCanvas(Broadcaster form) 
        {
            WorkForm = form;
        }
        public static void configImageToSend(Bitmap img_, int fps_=15) 
        {
            if (img_ == null) 
            {
                VideoFrame = new()
                {
                    buffer = null,
                    height = 0,
                    stride = 0,
                    timestamp = 0
                };
                GC.Collect();
                return;
            }
            fps = fps_;

            var size = new Size(1920, 1080);
            var s =  Math.Min(
                (double)size.Height / img_.Height, 
                (double)size.Width / img_.Width);

            frame = new Bitmap(img_, 
                Convert.ToInt32(img_.Width * s),
                Convert.ToInt32(img_.Height * s));

            VideoFrame = new();
            VideoFrame.height = size.Height;
            VideoFrame.stride = size.Width;
            VideoFrame.type   = VIDEO_BUFFER_TYPE.VIDEO_BUFFER_RAW_DATA;
            VideoFrame.format = VIDEO_PIXEL_FORMAT.VIDEO_PIXEL_ARGB;
            VideoFrame.timestamp = 0;

            int index = -1;

            int offsetW = (size.Width - frame.Width) / 2;
            int offsetH = (size.Height - frame.Height) / 2;
            VideoFrame.buffer = new byte[size.Height * size.Width * 4];

            for (int h = 0; h < size.Height; h++) 
            {
                for (int w = 0; w < size.Width; w++)
                {
                    var pixel = Color.Black;
                    if (h < offsetH + frame.Height && h >= offsetH &&
                        w < offsetW + frame.Width && w >= offsetW)
                        pixel = frame.GetPixel(
                                    (w - offsetW),
                                    (h - offsetH));
                    //DebugWriter.Write($"{h}:{w} {pixel}");

                    VideoFrame.buffer[index + 1] = pixel.A;
                    VideoFrame.buffer[index + 2] = pixel.R;
                    VideoFrame.buffer[index + 3] = pixel.G;
                    VideoFrame.buffer[index + 4] = pixel.B;
                    index += 4;
                }
                //DebugWriter.Write($"{h}");
            }
            
            DebugWriter.WriteTime("load complete");
        }
        public static void EnableImageSender(bool enable) 
        {
            isJoin = AgoraObject.ChannelHostJoin;

            AgoraObject.LeaveHostChannel();
            isEnable = enable;

            if (enable)
            {
                DebugWriter.WriteTime("Image sender has start");
                timer = new(Timer_Elapsed, null, 
                    dueTime: 1000 / fps, 
                    period: 1000 / fps);
            }
            else 
            {
                DebugWriter.WriteTime("Image sender has stop");
                timer.Dispose();
                GC.Collect();
            }

            AgoraObject.Rtc.SetExternalVideoSource(isEnable, true);
            if (isJoin) AgoraObject.JoinChannelHost();
        }
        public static void SendOneFrame()
        {
            VideoFrame.timestamp += 1;
            AgoraObject.Rtc.PushVideoFrame(VideoFrame);
        }
        private static void Timer_Elapsed(object state)
        {
            if (isEnable)
                SendOneFrame();
            //DebugLogger.Write(e.SignalTime.ToString("ss:ff"));
        }
        public static void Dispose()
        {
            timer?.Dispose();
            frame?.Dispose();

            WorkForm = null;
            timer = null;
            frame = null;
        }
        internal static void SetLocalFrame(bool clear=false)
        {
            if (false == clear)
                WorkForm.InvokeSetLocalFrame(frame);
            else
                WorkForm.InvokeSetLocalFrame(null);
        }
    }
}
