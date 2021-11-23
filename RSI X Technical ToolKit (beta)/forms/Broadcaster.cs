using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using RSI_X_Desktop.forms;
using agorartc;

namespace RSI_X_Desktop
{
    public partial class Broadcaster : Form, IFormHostHolder
    {
        private forms.HelpingClass.FireBaseReader GetFireBase = new();
        internal static IntPtr LocalWinId;
        public IntPtr RemoteWnd { get => LocalWinId; }
        private Devices devices;
        private ScreenSharing sharingDig;
        private ChatWnd chat = new ChatWnd();

        private bool IsSharingScreen = false;

        public Broadcaster()
        {
            InitializeComponent();
            AgoraObject.SetWndEventHandler(this);
            LocalWinId = pictureBoxRemoteVideo.Handle;
        }

        private void Conference_Load(object sender, EventArgs e)
        {
            AgoraObject.Rtc.EnableVideo();
            AgoraObject.Rtc.EnableAudio();
            AgoraObject.Rtc.SetChannelProfile(CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_LIVE_BROADCASTING);
            AgoraObject.Rtc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            AgoraObject.Rtc.EnableLocalVideo(true);
            AgoraObject.UpdateNickName("Host");
            RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;

            this.DoubleBuffered = true;
            var ret = AgoraObject.JoinChannel(
                AgoraObject.GetComplexToken().GetHostName,
                AgoraObject.GetComplexToken().GetToken);

            AgoraObject.MuteLocalAudioStream(false);
            AgoraObject.MuteLocalVideoStream(false);
            labelMicrophone.ForeColor = Color.Red;
            labelVideo.ForeColor = Color.Red;
            SetLocalVideoPreview();
            StreamLayout.ColumnStyles[1].SizeType = SizeType.Absolute;
            StreamLayout.ColumnStyles[0].Width = 100;
            StreamLayout.ColumnStyles[1].Width = 0;

            GetFireBase.SetChannelName(
                AgoraObject.GetComplexToken().GetHostName);
            chat.HandleCreated += (s, e) => {
                chat.UpdateFireBase(GetFireBase);
                GetFireBase.Connect();
            };

        }
        public void SetLocalVideoPreview()
        {
            AgoraObject.Rtc.EnableLocalVideo(true);
            pictureBoxRemoteVideo.Refresh();

            var canv = new VideoCanvas((ulong)LocalWinId, 0);
            canv.renderMode = ((int)RENDER_MODE_TYPE.RENDER_MODE_FIT);

            AgoraObject.Rtc.SetupLocalVideo(canv);
            AgoraObject.Rtc.StartPreview();
        }
        public void RefreshLocalWnd()
        {
            pictureBoxRemoteVideo.Refresh();
        }
        private void btnScreenShare_Click(object sender, EventArgs e)
        {
            if (AgoraObject.IsLocalVideoMute) return;
            enableScreenShare(!IsSharingScreen);
        }
        public void enableScreenShare(bool enable)
        {
            if (enable)
            {
                AgoraObject.EnableScreenCapture();
                labelScreenShare.ForeColor = Color.Red;
            }
            else
            {
                AgoraObject.Rtc.StopScreenCapture();
                labelScreenShare.ForeColor = Color.White;
            }
            IsSharingScreen = !IsSharingScreen;
        }

        private void labelSettings_Click(object sender, EventArgs e)
        {
            if (chat.Visible == true)
            {
                ChatClosed(chat);
            }

            if (devices == null || devices.IsDisposed)
            {
                devices = new Devices();
                devices.Location = new Point(150, 0);
                CallSidePanel(devices);
                devices.typeOfAlligment(true);
                //devices.SetAudienceSettings();
                labelSettings.ForeColor = Color.Red;
            }
            else
            {
                DevicesClosed(devices);
                labelSettings.ForeColor = Color.White;
            }
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            labelSettings_Click(SettingButton, e);
        }
        private void CallSidePanel(Form Wnd) 
        {
            panel1.SuspendLayout();
            Wnd.Size = panel1.Size;
            Wnd.Location = panel1.Location;
            Wnd.TopLevel = false;
            Wnd.Dock = DockStyle.Fill;
            panel1.Controls.Add(Wnd);
            panel1.BringToFront();
            if (panel1.Visible == false || Wnd.Visible == false)
            {
                panel1.ResumeLayout();
                panel1.Location = new Point(Size.Width, panel1.Location.Y);
                panel1.Show();
                Animator(panel1, -9, 0, 50, 1);
                Wnd.Show();
            }
        }

        public void Animator(System.Windows.Forms.Panel panel, int offset_x, int offset_y, int itterations, int delay)
        {
            //pictureBoxRemoteVideo.Refresh();
            Thread.Sleep(delay);
            pictureBoxRemoteVideo.SuspendLayout();
            for (int ind = 0; ind < itterations; ind++)
            {
                StreamLayout.ColumnStyles[1].Width = StreamLayout.ColumnStyles[1].Width - offset_x;
                pictureBoxRemoteVideo.Size = new Size(pictureBoxRemoteVideo.Size.Width - offset_x, pictureBoxRemoteVideo.Size.Height);
                //Thread.Sleep(1);
            }
            pictureBoxRemoteVideo.ResumeLayout();
        }
        public void GetMessage(string message, string nickname, CHANNEL_TYPE channel)
        {
            if (chat != null && chat.IsHandleCreated)
                chat.chat_NewMessageInvoke(message, nickname, channel);
        }
        private void ChatClosed(Form Wnd) 
        {
            Wnd.Hide();
            Animator(panel1, 9, 0, 50, 1);
            panel1.Hide();
            GC.Collect();
        }
        public void RebuildChatPanel(Control panel)
        {
            chat.Chat_SizeChanged(panel, new EventArgs());
        }
        public void DevicesClosed(Form Wnd) 
        {
            Wnd.Close();
            Animator(panel1, 9, 0, 50, 1);
            panel1.Hide();
            labelSettings.ForeColor = Color.White;
            GC.Collect();
        }
        public void SetTrackBarVolume(int volume)
        {
            trackBar1.Value = volume;
        }

        private void labelVolume_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = !trackBar1.Visible;
            labelVolume.ForeColor = !trackBar1.Visible ?
                Color.White :
                Color.Red;
        }

        private void labelMicrophone_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteLocalAudioStream(!AgoraObject.IsLocalAudioMute);
            labelMicrophone.ForeColor = AgoraObject.IsLocalAudioMute ?
                Color.White :
                Color.Red;
        }

        private void labelVideo_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteLocalVideoStream(!AgoraObject.IsLocalVideoMute);
            pictureBoxRemoteVideo.Visible = !AgoraObject.IsLocalVideoMute;

            labelVideo.ForeColor = AgoraObject.IsLocalVideoMute ?
                Color.White :
                Color.Red;

            if (AgoraObject.IsLocalVideoMute)
                enableScreenShare(false);
        }

        private void labelChat_Click(object sender, EventArgs e)
        {
            labelSettings.ForeColor = Color.White;
            if (devices != null && !(devices.IsDisposed))
            {
                DevicesClosed(devices);
                //Thread.Sleep(100);
            }
            if (chat.Visible == false)
            {
                CallSidePanel(chat);
                chat.ButtonsVisibility(true);
                labelChat.ForeColor = Color.Red;
            }
            else
            {
                chat.ButtonsVisibility(false);
                ChatClosed(chat);
                labelChat.ForeColor = Color.White;
            }
        }

        private void nightControlBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point ptn = e.Location;
            if (!(ptn.X > 46 && ptn.X < 94)) return;
            this.BringToFront();
            if (this.Size.Width == 1280)
            {
                ResizeForm(Screen.PrimaryScreen.WorkingArea.Size, this);
                ResizeForm(Screen.PrimaryScreen.WorkingArea.Size, formTheme1);
            }
            else
            {
                ResizeForm(new Size(1280, 800), this);
                ResizeForm(new Size(1280, 800), formTheme1);
            }
        }
        private void ResizeForm(Size size, Form target)
        {
            target.MaximumSize = size;
            target.MinimumSize = size;
            target.Size = size;
        }
        private void ResizeForm(Size size, ReaLTaiizor.Forms.FormTheme target)
        {
            target.MaximumSize = size;
            target.MinimumSize = size;
            target.Size = size;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
        private void Broadcaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            enableScreenShare(false);
            AgoraObject.LeaveChannel();
            AgoraObject.Rtc.EnableLocalVideo(false);
            AgoraObject.Rtc.DisableVideo();
            AgoraObject.Rtc.DisableAudio();
            GC.Collect();
        }
    }
}
