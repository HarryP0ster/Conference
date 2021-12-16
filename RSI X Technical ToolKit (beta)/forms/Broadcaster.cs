﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using RSI_X_Desktop.forms;
using RSI_X_Desktop.forms.HelpingClass;
using agorartc;
using System.IO.Pipes;

namespace RSI_X_Desktop
{
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

        private Devices devices;
        private ChatWnd chat = new ChatWnd();
        private FireBaseReader GetFireBase = new();
        private Process TargetPublisher = null;

        private static IntPtr LocalWinId;
        private bool IsSharingScreen = false;

        private bool AddOrder = false;
        private bool[] TakenPages = new bool[1];
        private Dictionary<uint, PictureBox> hostBroadcasters = new();

        private int srcLangIndex = -2;
        private STATE getAudioFrom = STATE.UNDEFINED;

        public Broadcaster()
        {
            InitializeComponent();
            AgoraObject.SetWndEventHandler(this);
        }
        private void Conference_Load(object sender, EventArgs e)
        {
            StreamLayout.ColumnStyles[1].SizeType = SizeType.Absolute;
            StreamLayout.ColumnStyles[0].Width = 100;
            StreamLayout.ColumnStyles[1].Width = 0;
            RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;
            
            LangSelectDlg dlg = new();
            Show();
            CenterToScreen();
            dlg.ShowDialog(this);
            dlg.BringToFront();

            if (dlg.GetOutCode)
            {
                LocalWinId = pictureBoxLocalVideo.Handle;
                // srcLangIndex < 0 //IS HOST

                GetFireBase.SetChannelName(
                    AgoraObject.GetComplexToken().GetHostName);
                chat.HandleCreated += (s, e) =>
                {
                    chat.UpdateFireBase(GetFireBase);
                    GetFireBase.Connect();
                };

                List<string> langsShort = new();
                langsShort.Add("HOST");
                foreach (var lang in AgoraObject.GetComplexToken().GetTranslLangs)
                { langsShort.Add(lang.langShort); }
                cmblang.DataSource = langsShort;

                srcLangIndex = dlg.PrimaryLang;
                if (langsShort.Count < 0)
                {
                    cmblang.Enabled = false;
                    cmblang.Hide();
                    getAudioFrom = STATE.FLOOR;
                }
                else
                {
                    getAudioFrom = srcLangIndex == 0 ?
                        STATE.FLOOR :
                        STATE.TRANSl;

                    cmblang.SelectedIndex = Math.Max(0, srcLangIndex);
                    cmblang_SelectedIndexChanged(cmblang, new());
                    floor_CheckedChanged(getAudioFrom);
                }
                Init();

                MuteMic(dlg.MicMute);
                MuteCam(dlg.CamMute);
            }
            else
            {
                Owner.Show();
                Dispose();
                GC.Collect();
            }
                
                //ResetButton_Click(this, new EventArgs());
        }
        private void Init()
        {
            Un4seen.Bass.BassNet.Registration("rhenrhee@gmail.com", "2X37312318152222");

            AgoraObject.Rtc.EnableVideo();
            AgoraObject.Rtc.EnableAudio();
            AgoraObject.Rtc.EnableLocalVideo(true);
            AgoraObject.MuteLocalAudioStream(true);
            AgoraObject.MuteLocalVideoStream(true);
            AgoraObject.Rtc.SetChannelProfile(CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_LIVE_BROADCASTING);
            AgoraObject.Rtc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            hostBroadcasters.Add(0, pictureBoxLocalVideo);

            TakenPages[0] = true;

            this.DoubleBuffered = true;
            AgoraObject.JoinChannelHost(
                AgoraObject.GetComplexToken().GetHostName,
                AgoraObject.GetComplexToken().GetHostToken, 0, "");

            AgoraObject.MuteLocalAudioStream(AgoraObject.IsLocalAudioMute);
            AgoraObject.MuteLocalVideoStream(AgoraObject.IsLocalVideoMute);

            labelVideo.ForeColor = AgoraObject.IsLocalVideoMute ?
                Color.White :
                Color.Red;

            labelMicrophone.ForeColor = AgoraObject.IsLocalAudioMute ?
                Color.White :
                Color.Red;

            MuteCam(AgoraObject.IsLocalVideoMute);
            /*
            * Chat initial loading, this way it'd load messages
            * in the background from the very moment you enter a channel
            */
            chat.TopLevel = false;
            chat.Dock = DockStyle.Fill;
            panel1.Controls.Add(chat);
            chat.Show();
            chat.Hide(); //You need to hide it, otherwise Animator'd get confused
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

        private void labelMicrophone_Click(object sender, EventArgs e)
        {
            MuteMic(!AgoraObject.IsLocalAudioMute);
        }
        private void labelVideo_Click(object sender, EventArgs e)
        {
            MuteCam(!AgoraObject.IsLocalVideoMute);
        }
        private void labelChat_Click(object sender, EventArgs e)
        {
            labelSettings.ForeColor = Color.White;
            if (devices != null && !(devices.IsDisposed))
                DevicesClosed(devices);
            if (chat.Visible == false)
            {
                chat.ResumeLayout();
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
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Owner.
            Owner.Show();
            Close();
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
        private void labelFloor_Click(object sender, EventArgs e)
        {
            getAudioFrom = getAudioFrom == STATE.FLOOR ?
                STATE.TRANSl : STATE.FLOOR;

            floor_CheckedChanged(getAudioFrom);
        }
        private void SettingButton_Click(object sender, EventArgs e)
        {
            labelSettings_Click(SettingButton, e);
        }
        private void cmblang_SelectedIndexChanged(object sender, EventArgs e)
        {
            srcLangIndex = cmblang.SelectedIndex;
            var l = AgoraObject.GetComplexToken().GetTargetRoomsAt(srcLangIndex);

            getAudioFrom = l.langShort != "HOST" ?
                STATE.TRANSl : STATE.FLOOR;
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
                AgoraObject.EnableScreenCapture();
                labelScreenShare.ForeColor = Color.Red;
            }
            else
            {
                AgoraObject.StopScreenCapture();
                labelScreenShare.ForeColor = Color.White;
                pictureBoxLocalVideo.Update ();

                Devices.tryReAcceptVideoDevice();
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
            Owner.Show();

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
            
            Devices.ClearOldDevices();
            Devices.Clear();
            
            if (!Owner.Visible) Application.Exit();
            GC.Collect();
        }
        #endregion

        #region Events Action
        private void MuteMic(bool mute)
        {
            MuteTargetPublisher(mute);
            AgoraObject.MuteLocalAudioStream(mute);

            labelMicrophone.ForeColor = AgoraObject.IsLocalAudioMute ?
                Color.White :
                Color.Red;
        }
        private void MuteCam(bool mute)
        {
            AgoraObject.MuteLocalVideoStream(mute);

            labelVideo.ForeColor = AgoraObject.IsLocalVideoMute ?
                Color.White :
                Color.Red;



            if (AgoraObject.IsLocalVideoMute) 
            {
                pictureBoxLocalVideo.Refresh();
                enableScreenShare(false);
                AgoraObject.Rtc.SetupLocalVideo(new VideoCanvas(0, 0));
                pictureBoxLocalVideo.BackgroundImage = Properties.Resources.video_call_empty;
                pictureBoxLocalVideo.BackgroundImageLayout = ImageLayout.Center;
                pictureBoxLocalVideo.BackColor = InactiveColor;

            }
            else
            {
                SetLocalVideoPreview();
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
                Devices.oldRecorder,
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

        #region SidePanel
        public void Animator(System.Windows.Forms.Panel panel, int offset_x, int offset_y, int itterations, int delay)
        {
            Thread.Sleep(delay);
            streamsTable.SuspendLayout();
            for (int ind = 0; ind < itterations; ind++)
            {
                StreamLayout.ColumnStyles[1].Width = StreamLayout.ColumnStyles[1].Width - offset_x;
            }
            streamsTable.ResumeLayout();
        }
        public void RebuildChatPanel(Control panel)
        {
            chat.Chat_SizeChanged(panel, new EventArgs());
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
        private void ChatClosed(Form Wnd) 
        {
            Wnd.SuspendLayout();
            Animator(panel1, 9, 0, 50, 1);
            panel1.Hide();
            Wnd.Hide();
            labelChat.ForeColor = Color.White;
            GC.Collect();
        }
        public void DevicesClosed(Form Wnd) 
        {
            Wnd.Close();
            Animator(panel1, 9, 0, 50, 1);
            panel1.Hide();
            labelSettings.ForeColor = Color.White;
            GC.Collect();
        }
        #endregion

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


    }
}
