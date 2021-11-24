using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using RSI_X_Desktop.forms;
using System.Collections.Generic;
using RSI_X_Desktop.forms.HelpingClass;
using agorartc;

namespace RSI_X_Desktop
{
    public partial class Broadcaster : Form, IFormHostHolder
    {
        private Devices devices;
        private ChatWnd chat = new ChatWnd();
        private FireBaseReader GetFireBase = new();
        internal static IntPtr LocalWinId;

        private bool IsSharingScreen = false;
        private bool AddOrder = false;
        private bool[] TakenPages = new bool[1];
        private Dictionary<uint, PictureBox> hostBroadcasters = new();

        private int srcLangIndex = -1;

        public Broadcaster()
        {
            InitializeComponent();
            AgoraObject.SetWndEventHandler(this);
        }

        private void Conference_Load(object sender, EventArgs e)
        {
            LangSelectDlg dlg = new();
            dlg.ShowDialog();

            if (dlg.GetOutCode) 
            {
                LocalWinId = pictureBoxLocalVideo.Handle;
                srcLangIndex = dlg.PrimaryLang;

                GetFireBase.SetChannelName(
                    AgoraObject.GetComplexToken().GetHostName);
                chat.HandleCreated += (s, e) =>
                {
                    chat.UpdateFireBase(GetFireBase);
                    GetFireBase.Connect();
                };

                RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;
                Init();
            } 
            else
                Close();
        }

        private void Init()
        {
            AgoraObject.Rtc.EnableVideo();
            AgoraObject.Rtc.EnableAudio();
            AgoraObject.Rtc.SetChannelProfile(CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_LIVE_BROADCASTING);
            AgoraObject.Rtc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            AgoraObject.Rtc.EnableLocalVideo(true);
            AgoraObject.UpdateNickName("Host");
            hostBroadcasters.Add(0, pictureBoxLocalVideo);

            TakenPages[0] = true;

            this.DoubleBuffered = true;
            AgoraObject.JoinChannelHost(
                AgoraObject.GetComplexToken().GetHostName,
                AgoraObject.GetComplexToken().GetToken, 0, "");

            AgoraObject.MuteLocalAudioStream(false);
            AgoraObject.MuteLocalVideoStream(false);

            labelMicrophone.ForeColor = Color.Red;
            labelVideo.ForeColor = Color.Red;

            SetLocalVideoPreview();
            StreamLayout.ColumnStyles[1].SizeType = SizeType.Absolute;
            StreamLayout.ColumnStyles[0].Width = 100;
            StreamLayout.ColumnStyles[1].Width = 0;
        }

        public void SetLocalVideoPreview()
        {
            AgoraObject.Rtc.EnableLocalVideo(true);
            pictureBoxLocalVideo.Refresh();

            var canv = new VideoCanvas((ulong)LocalWinId, 0);
            canv.renderMode = ((int)RENDER_MODE_TYPE.RENDER_MODE_FIT);

            AgoraObject.Rtc.SetupLocalVideo(canv);
            AgoraObject.Rtc.StartPreview();
        }
        public void RefreshLocalWnd() => pictureBoxLocalVideo.Refresh();
        public void NewBroadcaster(uint uid, UserInfo info) 
        {
            if (info.userAccount.StartsWith("HOST") && !hostBroadcasters.ContainsKey(uid))
            {
                if (IsDisposed) return;
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        AddNewMember(uid);
                    });
                else
                    AddNewMember(uid);
            }
        }
        public void BroadcasterUpdateInfo(uint uid, UserInfo info)
        {
            if (info.userAccount.StartsWith("HOST") && !hostBroadcasters.ContainsKey(uid))
            {
                if (IsDisposed) return;
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        AddNewMember(uid);
                    });
                else
                    AddNewMember(uid);
            }
        }
        public void BroadcasterLeave(uint uid)
        {
            if (hostBroadcasters.ContainsKey(uid))
            {
                if (IsDisposed) return;
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        RemoveMember(uid);
                    });
                else
                    RemoveMember(uid);
            }
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
            streamsTable.SuspendLayout();
            for (int ind = 0; ind < itterations; ind++)
            {
                StreamLayout.ColumnStyles[1].Width = StreamLayout.ColumnStyles[1].Width - offset_x;
                streamsTable.Size = new Size(streamsTable.Size.Width - offset_x, streamsTable.Size.Height);
                //Thread.Sleep(1);
            }
            streamsTable.ResumeLayout();
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
        public void SetTrackBarVolume(int volume) => trackBar1.Value = volume;
        

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
            pictureBoxLocalVideo.Visible = !AgoraObject.IsLocalVideoMute;

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
                DevicesClosed(devices);
            if (chat.Visible == false)
            {
                chat.ButtonsVisibility(true);
                CallSidePanel(chat);
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
            AgoraObject.LeaveHostChannel();
            AgoraObject.Rtc.EnableLocalVideo(false);
            AgoraObject.Rtc.DisableVideo();
            AgoraObject.Rtc.DisableAudio();
            GC.Collect();

            Owner.Show();
        }

        #region MembersControl

        private void AddNewMember(uint uid)
        {
            PictureBox newPreview = new();

            string channelId = AgoraObject.GetHostName();

            newPreview.Dock = DockStyle.Fill;
            newPreview.BackgroundImage = Properties.Resources.video_call_empty;
            newPreview.BackgroundImageLayout = ImageLayout.Center;
            newPreview.BackColor = Color.FromArgb(85,85,85);
            newPreview.Margin = Padding.Empty;
            List<bool> temp_list = new List<bool>(TakenPages);
            if (temp_list.Contains(false) == false)
            {
                if (AddOrder == false)
                {
                    streamsTable.ColumnCount++;
                    streamsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    foreach (ColumnStyle col in streamsTable.ColumnStyles)
                        col.Width = 100F;
                    AddOrder = true;
                }
                else
                {
                    streamsTable.RowCount++;
                    streamsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    foreach (RowStyle row in streamsTable.RowStyles)
                        row.Height = 100F;
                    AddOrder = false;
                }
            }
            int index = streamsTable.ColumnCount * streamsTable.RowCount;
            hostBroadcasters.Add(uid, newPreview);
            TakenPages = new bool[index];
            streamsTable.Controls.Clear();

            int current_row = 0;
            int current_col = 0;
            foreach (PictureBox hwnd in hostBroadcasters.Values)
            {
                for (int i = 0; i < TakenPages.Length; i++)
                {
                    if (TakenPages[i] == false)
                    {
                        TakenPages[i] = true;
                        streamsTable.Controls.Add(hwnd, current_col, current_row);
                        current_col++;
                        if (current_col >= streamsTable.ColumnStyles.Count)
                        {
                            current_col = 0;
                            current_row++;
                        }
                        break;
                    }
                }
            }

            var ret = new VideoCanvas((ulong)newPreview.Handle, uid);
            ret.renderMode = (int)RENDER_MODE_TYPE.RENDER_MODE_FIT;
            ret.channelId = channelId;
            ret.uid = uid;

            AgoraObject.Rtc.SetupRemoteVideo(ret);
            streamsTable.Refresh();
        }

        private void RemoveMember(uint uid)
        {
            int index = streamsTable.ColumnCount * streamsTable.RowCount;
            hostBroadcasters.Remove(uid);

            if (index - hostBroadcasters.Count <= streamsTable.ColumnCount && AddOrder)
            {
                streamsTable.ColumnStyles.RemoveAt(streamsTable.ColumnStyles.Count - 1);
                streamsTable.ColumnCount--;
                foreach (ColumnStyle col in streamsTable.ColumnStyles)
                    col.Width = 100F;
                AddOrder = false;
            }
            else if (index - hostBroadcasters.Count >= streamsTable.RowCount && !AddOrder)
            {
                streamsTable.RowStyles.RemoveAt(streamsTable.RowStyles.Count - 1);
                streamsTable.RowCount--;
                foreach (RowStyle row in streamsTable.RowStyles)
                    row.Height = 100F;
                AddOrder = true;
            }

            index = streamsTable.ColumnCount * streamsTable.RowCount;
            TakenPages = new bool[index];
            streamsTable.Controls.Clear();

            int current_row = 0;
            int current_col = 0;
            foreach (PictureBox hwnd in hostBroadcasters.Values)
            {
                for (int i = 0; i < TakenPages.Length; i++)
                {
                    if (TakenPages[i] == false)
                    {
                        TakenPages[i] = true;
                        streamsTable.Controls.Add(hwnd, current_col, current_row);
                        current_col++;
                        if (current_col >= streamsTable.ColumnStyles.Count)
                        {
                            current_col = 0;
                            current_row++;
                        }
                        break;
                    }
                }
            }
            streamsTable.Refresh();
        }
        #endregion
    }
}
