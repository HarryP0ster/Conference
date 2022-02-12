using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using RSI_X_Desktop.forms;
using RSI_X_Desktop.forms.HelpingClass;
using agorartc;
using RSI_X_Desktop.other;

namespace RSI_X_Desktop
{
    public struct Data
    {
        public int RoomIndex;
        public bool CamControl;
        public bool MicControl;
        public string Nickname;
        public Data(int room, bool camera, bool mic, string name)
        {
            RoomIndex = room;
            CamControl = camera;
            MicControl = mic;
            Nickname = name;
        }
    }

    enum TARGET_MESSAGES
    { 
        MUTE = 0,
        UNMUTE = 1
    }
    enum STATE 
    {
        UNDEFINED,
        FLOOR,
        TRANSl
    }
    public partial class Broadcaster : Form, IFormHostHolder
    {

        private const int MIN_VOLUME = 3;
        private const int MAX_VOLUME = 100;
        private readonly Color InactiveColor = Color.FromArgb(85, 85, 85);

        private PopUpForm devices;
        private ChatForm chat = new();
        BottomPanelWnd bottomPanel = new();
        internal Designer ExternWnd = new();
        private FireBaseReader GetFireBase = new();
        private Process TargetPublisher = null;
        Data InitData;

        private static IntPtr LocalWinId;
        private bool IsSharingScreen = false;

        private bool AddOrder = false;
        private bool[] TakenPages = new bool[1];
        private Dictionary<uint, PictureBox> hostBroadcasters = new();
        internal string PreviewFilePath = "";
        private int srcLangIndex = -2;
        private STATE getAudioFrom = STATE.UNDEFINED;

        public Broadcaster()
        {
            InitializeComponent();

            AgoraObject.SetWndEventHandler(this);
            Messager.SetPermission((int)(PERMISSIONS.GLOBAL | PERMISSIONS.CONFERENCE));
        }

        internal ChatForm GetChat
        {
            get => chat;
        }

        public Data SetTransData
        {
            set
            {
                InitData = value;
            }
        }

        private void Conference_Load(object sender, EventArgs e)
        {
            StreamLayout.ColumnStyles[1].SizeType = SizeType.Absolute;
            StreamLayout.ColumnStyles[0].Width = 100;
            StreamLayout.ColumnStyles[1].Width = 0;

            Show();
            CenterToScreen();

            LocalWinId = pictureBoxLocalVideo.Handle;
            AgoraObject.UpdateNickName(InitData.Nickname);
            Init();

            // srcLangIndex < 0 //IS HOST


            GetFireBase.SetChannelName(
                AgoraObject.GetComplexToken().GetHostName);
            chat.HandleCreated += (s, e) =>
            {
                chat.UpdateFireBase(GetFireBase);
                GetFireBase.Connect();
            };

            bottomPanel.Show(this);
            bottomPanel.Enabled = false;
            ExternWnd.Show(this);

            List<string> langsShort = new();
            langsShort.Add("FLOOR");
            foreach (var lang in AgoraObject.GetComplexToken().GetTranslLangs)
            { langsShort.Add(lang.langShort); }
            ExternWnd.cmblang.DataSource = langsShort;

            srcLangIndex = InitData.RoomIndex;
            if (langsShort.Count < 0)
            {
                ExternWnd.cmblang.Enabled = false;
                ExternWnd.cmblang.Hide();
                getAudioFrom = STATE.FLOOR;
            }
            else
            {
                getAudioFrom = srcLangIndex == 0 ?
                    STATE.FLOOR :
                    STATE.TRANSl;

                ExternWnd.cmblang.SelectedIndex = Math.Max(0, srcLangIndex);
                cmblang_SelectedIndexChanged(null, new());
                floor_CheckedChanged(getAudioFrom);
            }
        }
        private void Init()
        {
            //Un4seen.Bass.BassNet.Registration("rhenrhee@gmail.com", "2X37312318152222");
            streamsTable.Click += Mouse_Click;
            streamsTable.MouseMove += Mouse_MouseMove;
            pictureBoxLocalVideo.Click += Mouse_Click;
            pictureBoxLocalVideo.MouseMove += Mouse_MouseMove;

            Nothing.Click += Mouse_Click;
            Nothing.MouseMove += Mouse_MouseMove;

            AgoraObject.Rtc.EnableVideo();
            AgoraObject.Rtc.EnableAudio();
            AgoraObject.Rtc.EnableLocalVideo(true);

            AgoraObject.MuteLocalVideoStream(false);
            AgoraObject.MuteLocalAudioStream(true);
            AgoraObject.Rtc.SetChannelProfile(CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_LIVE_BROADCASTING);
            AgoraObject.Rtc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            hostBroadcasters.Add(0, pictureBoxLocalVideo);

            TakenPages[0] = true;

            this.DoubleBuffered = true;
            AgoraObject.JoinChannelHost(
                AgoraObject.GetComplexToken().GetHostName,
                AgoraObject.GetComplexToken().GetHostToken, 0, "");

            SetLocalVideoPreview();
            AgoraObject.MuteLocalVideoStream(!InitData.CamControl);
            AgoraObject.MuteLocalAudioStream(!InitData.MicControl);
            pictureBoxLocalVideo.Visible = !AgoraObject.IsLocalVideoMute;
        }

        public void SetLocalVideoPreview()
        {
            AgoraObject.Rtc.EnableLocalVideo(true);
            pictureBoxLocalVideo.Update();

            var canv = AgoraObject.IsLocalVideoMute ? 
                new VideoCanvas(0, 0):
                new VideoCanvas((ulong)LocalWinId, 0);
            canv.renderMode = ((int)RENDER_MODE_TYPE.RENDER_MODE_FIT);

            ImageSender.SetLocalCanvas(this);

            AgoraObject.Rtc.SetupLocalVideo(canv);
            AgoraObject.Rtc.StartPreview();
        }
        public void InvokeSetLocalFrame(Bitmap bmp)
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate
                {
                    SetLocalFrame(bmp);
                });
            else { SetLocalFrame(bmp); }

        }
        private void SetLocalFrame(Bitmap bmp)
        {
            pictureBoxLocalVideo.BackColor = bmp != null ?
                Color.Black : 
                InactiveColor;

            //pictureBoxRemoteVideo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLocalVideo.Image = bmp;
        }
        public void RefreshLocalWnd() => pictureBoxLocalVideo.Refresh();
        
        #region Press Events
        private void btnScreenShare_Click(object sender, EventArgs e)
        {
            if (AgoraObject.IsLocalVideoMute) return;
            enableScreenShare(IsSharingScreen);
        }
        private void labelSettings_Click(object sender, EventArgs e)
        {
            if (devices == null || devices.IsDisposed)
            {
                AgoraObject.Rtc.DisableAudio();
                BlurWnd blur = new();
                devices = new PopUpForm();
                blur.Show(this);
                devices.ShowDialog(this);
                SetLocalVideoPreview();
                devices.Dispose();
                blur.Dispose();
                Focus();
            }
            else
            {
                devices.Dispose();
                AgoraObject.Rtc.EnableAudio();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Owner.
            Owner.Close();
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
        internal void SettingButton_Click(object sender, EventArgs e)
        {
            labelSettings_Click(null, e);
        }
        internal void cmblang_SelectedIndexChanged(object sender, EventArgs e)
        {
            srcLangIndex = ExternWnd.cmblang.SelectedIndex;
            var l = AgoraObject.GetComplexToken().GetTargetRoomsAt(srcLangIndex);

            getAudioFrom = (l.langShort == "HOST" || l.langShort == "FLOOR") ?
                STATE.FLOOR : STATE.TRANSl;
            floor_CheckedChanged(getAudioFrom);
        }

        //public void SetTrackBarVolume(int volume) => trackBar1.Value = volume;


        //private void labelVolume_Click(object sender, EventArgs e)
        //{
        //    trackBar1.Visible = !trackBar1.Visible;
        //    labelVolume.ForeColor = !trackBar1.Visible ?
        //        Color.White :
        //        Color.Red;
        //}
        #endregion

        #region otherEvents
        public void enableScreenShare(bool enable)
        {
            if (enable)
            {
                agorartc.ScreenCaptureParameters capParam = new();
                AgoraObject.StartScreenCapture(capParam);
            }
            else
            {
                AgoraObject.StopScreenCapture();
                PopUpForm.tryReAcceptVideoDevice();
                
                pictureBoxLocalVideo.Refresh ();
            }

            IsSharingScreen = !IsSharingScreen;
        }
        private void MuteTargetPublisher(bool mute)
        {
            var state = mute ?
                TARGET_MESSAGES.MUTE :
                TARGET_MESSAGES.UNMUTE;
            TargetPublisher?.StandardInput
                .WriteLine(String.Format("msg:{0}", (int)state));
        }

        private void nightControlBox1_MouseMove(object sender, MouseEventArgs e)
        {
            GC.Collect();
        }
        private void Broadcaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Owner.Show();

            enableScreenShare(false);
            stopPublishToTarget();
            
            AgoraObject.LeaveHostChannel();
            AgoraObject.Rtc.LeaveChannel();
            AgoraObject.Rtc.EnableLocalVideo(false);
            AgoraObject.Rtc.DisableVideo();
            AgoraObject.Rtc.DisableAudio();

            if (ImageSender.IsEnable)
                ImageSender.EnableImageSender(false);
            ImageSender.Dispose();
            
            PopUpForm.ClearOldDevices();
            PopUpForm.Clear();
            
            Application.Exit();
            GC.Collect();
        }
        #endregion

        #region Events Action
        
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

        private void floor_CheckedChanged(STATE state)
        {
            switch (state)
            {
                case STATE.TRANSl:
                    foreach (var br in hostBroadcasters.Keys)
                    {
                        if (br == 0) continue;
                        AgoraObject.UpdateUserVolume(br, MIN_VOLUME, CHANNEL_TYPE.HOST);
                    }

                    var l = AgoraObject.GetComplexToken().GetTargetRoomsAt(srcLangIndex);
                    AgoraObject.JoinChannelSrc(l);
                    startPublishToTarget(l);

                    //cmblang.Enabled = true;
                    //labelFloor.ForeColor = Color.White;
                    break;
                case STATE.FLOOR:
                    foreach (var br in hostBroadcasters.Keys)
                    {
                        if (br == 0) continue;
                        AgoraObject.UpdateUserVolume(br, MAX_VOLUME, CHANNEL_TYPE.HOST);
                    }
                    AgoraObject.LeaveSrcChannel();
                    stopPublishToTarget();

                    //cmblang.Enabled = false;
                    //labelFloor.ForeColor = Color.Red;
                    break;
                case STATE.UNDEFINED:
                default:
                    break;
            }
        }

        private void startPublishToTarget(langHolder lh) 
        {
            if (TargetPublisher != null)
                stopPublishToTarget();

            List<string> args = new() { 
                lh.token, lh.langFull, 
                PopUpForm.oldRecorder,
                Process.GetCurrentProcess().Id.ToString(),
                AgoraObject.NickName};

            string arguments = "";
            foreach (var a in args)
                arguments += "\"" + a + "\" ";

            TargetPublisher = new Process();
            TargetPublisher.StartInfo.Arguments = arguments;
            TargetPublisher.StartInfo.CreateNoWindow = true;
            TargetPublisher.StartInfo.RedirectStandardOutput = true;
            TargetPublisher.StartInfo.RedirectStandardInput = true;
            TargetPublisher.StartInfo.FileName = "appIn.exe";
            TargetPublisher.OutputDataReceived += TargetPublisher_OutputDataReceived;

            TargetPublisher.Start();
            TargetPublisher.BeginOutputReadLine();
        }
        private void stopPublishToTarget() 
        {
            TargetPublisher?.Kill();
            TargetPublisher = null;
        }
        private void TargetPublisher_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null ||
                e.Data.StartsWith("uid:") == false) return;

            uint selfSpeakerUid = Convert.ToUInt32(
                e.Data.Split(':')[1]);
            MuteTargetPublisher(AgoraObject.IsLocalAudioMute);

            if (selfSpeakerUid != 0)
                AgoraObject.UpdateUserVolume(selfSpeakerUid, 0, CHANNEL_TYPE.SRC);
        }
        #endregion
        
        public void GetMessage(string message, string nickname, CHANNEL_TYPE channel)
        {
            if (chat != null && chat.IsHandleCreated)
                chat.chat_NewMessageInvoke(message, nickname, channel);
        }

        public void NewBroadcaster(uint uid, UserInfo info) 
        {
            if (NickCenter.IsHost(info.userAccount) &&
                !hostBroadcasters.ContainsKey(uid))
            {
                if (IsDisposed) return;
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        AddNewMember(uid);
                    });
                else
                    AddNewMember(uid);

                AgoraObject.UpdateUserVolume(uid, 
                    getAudioFrom == STATE.FLOOR ? MAX_VOLUME : MIN_VOLUME, 
                    CHANNEL_TYPE.HOST);
            }
        }
        public void BroadcasterUpdateInfo(uint uid, UserInfo info)
        {
            if (NickCenter.IsHost(info.userAccount) && 
                !hostBroadcasters.ContainsKey(uid))
            {
                if (IsDisposed) return;
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        AddNewMember(uid);
                    });
                else
                    AddNewMember(uid);

                AgoraObject.UpdateUserVolume(uid,
                    getAudioFrom == STATE.FLOOR ? MAX_VOLUME : MIN_VOLUME,
                    CHANNEL_TYPE.HOST);
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

        private void Mouse_Click(object sender, EventArgs e)
        {
            if (ExternWnd.LabelAudioRect.Contains(Cursor.Position))
                ExternWnd.labelMicrophone_Click(sender, e);
            else if (ExternWnd.LabelVideoRect.Contains(Cursor.Position))
                ExternWnd.labelVideo_Click(sender, e);
            else if (ExternWnd.DevicesLblRect.Contains(Cursor.Position))
                SettingButton_Click(sender, e);
            else if (ExternWnd.ScreenShareRectangle.Contains(Cursor.Position))
                ExternWnd.btnScreenShare_Click(sender, e);
            else if (ExternWnd.ChatRect.Contains(Cursor.Position))
                ExternWnd.Chat_Click(sender, e);
            else if (ExternWnd.LangsRect.Contains(Cursor.Position))
                ExternWnd.Langs_Click(sender, e);
            else if (ExternWnd.HomeBtnRect.Contains(Cursor.Position))
                ExternWnd.HomeBtn_Click(null, null);
        }
        private void Mouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (Disposing || IsDisposed ||
                ExternWnd.Disposing || ExternWnd.IsDisposed)
            {
                Close();
                return;
            }

            bool cursorUpd = false;
            if (ExternWnd.LabelAudioRect.Contains(Cursor.Position))
            {
                ExternWnd.audioLabel_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.audioLabel_MouseLeave(sender, e);

            if (ExternWnd.LabelVideoRect.Contains(Cursor.Position))
            {
                ExternWnd.videoLabel_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.videoLabel_MouseLeave(sender, e);

            if (ExternWnd.DevicesLblRect.Contains(Cursor.Position))
            {
                ExternWnd.devicesLabel_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.devicesLabel_MouseLeave(sender, e);

            if (ExternWnd.ScreenShareRectangle.Contains(Cursor.Position))
            {
                ExternWnd.ScreenShare_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.ScreenShare_MouseLeave(sender, e);

            if (ExternWnd.ChatRect.Contains(Cursor.Position))
            {
                ExternWnd.Chat_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.Chat_MouseLeave(sender, e);

            if (ExternWnd.LangsRect.Contains(Cursor.Position))
            {
                cursorUpd = true;
            }

            Cursor.Current = cursorUpd ? Cursors.Hand : Cursors.Default;
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
            newPreview.Click += Mouse_Click;
            newPreview.MouseMove += Mouse_MouseMove;
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
        public void UpdateMember(uint uid)
        {
            if (hostBroadcasters.ContainsKey(uid))
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        hostBroadcasters[uid].Invalidate();
                    });
                }
                else
                    hostBroadcasters[uid].Invalidate();
            }
        }
        public void UpdateMember(uint uid, string channelId)
        {
            if (hostBroadcasters.ContainsKey(uid))
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        var ret = new VideoCanvas((ulong)hostBroadcasters[uid].Handle, uid);
                        ret.renderMode = (int)RENDER_MODE_TYPE.RENDER_MODE_FIT;
                        ret.channelId = channelId;
                        ret.uid = uid;

                        AgoraObject.Rtc.SetupRemoteVideo(ret);
                    });
                }
                else
                {
                    var ret = new VideoCanvas((ulong)hostBroadcasters[uid].Handle, uid);
                    ret.renderMode = (int)RENDER_MODE_TYPE.RENDER_MODE_FIT;
                    ret.channelId = channelId;
                    ret.uid = uid;

                    AgoraObject.Rtc.SetupRemoteVideo(ret);
                }
            }
        }
        #endregion

        public void CloseChat()
        {
            ExternWnd.Chat_Click(null, null);
        }

        public void ExitApp()
        {
            ExternWnd.Hide();
            bottomPanel.Hide();
            Hide();

            AgoraObject.LeaveHostChannel();
            AgoraObject.MuteAllRemoteAudioStream(false);
            AgoraObject.MuteAllRemoteVideoStream(false);
            
            if (AgoraObject.IsScreenCapture)
                AgoraObject.StopScreenCapture();

            chat.DisconnectFireBase();
            //PopUpForm.waveOutSetVolume(IntPtr.Zero, uint.MaxValue);

            Owner.Show();
            Owner.Refresh();
        }
    }
}
