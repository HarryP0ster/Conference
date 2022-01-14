using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Svg;
using RSI_X_Desktop.forms.HelpingClass;

namespace RSI_X_Desktop.forms
{
    public partial class Designer : DevExpress.XtraEditors.XtraForm
    {
        bool canSelect = true;
        bool IsChatActive = false;
        private bool IsSharingScreen = false;
        #region Rectangles
        public Rectangle HomeBtnRect
        {
            get => new Rectangle(
                signOff.PointToScreen(Point.Empty).X,
                signOff.PointToScreen(Point.Empty).Y,
                signOff.Width,
                signOff.Height);
        }
        public Rectangle LangsRect
        {
            get => new Rectangle(
                cmblang.PointToScreen(Point.Empty).X,
                cmblang.PointToScreen(Point.Empty).Y,
                cmblang.Width,
                cmblang.Height);
        }
        public Rectangle ChatRect
        {
            get => new Rectangle(
                Chat.PointToScreen(Point.Empty).X,
                Chat.PointToScreen(Point.Empty).Y,
                Chat.Width,
                Chat.Height);
        }
        public Rectangle DevicesLblRect
        {
            get => new Rectangle(
                devicesLabel.PointToScreen(Point.Empty).X,
                devicesLabel.PointToScreen(Point.Empty).Y,
                devicesLabel.Width,
                devicesLabel.Height);
        }
        public Rectangle ScreenShareRectangle
        {
            get => new Rectangle(
                ScreenShare.PointToScreen(Point.Empty).X,
                ScreenShare.PointToScreen(Point.Empty).Y,
                ScreenShare.Width,
                ScreenShare.Height);
        }
        public Rectangle LabelVideoRect
        {
            get => new Rectangle(
            videoLabel.PointToScreen(Point.Empty).X,
            videoLabel.PointToScreen(Point.Empty).Y,
            videoLabel.Width,
            videoLabel.Height);
        }
        public Rectangle LabelAudioRect
        {
            get => new Rectangle(
            audioLabel.PointToScreen(Point.Empty).X,
            audioLabel.PointToScreen(Point.Empty).Y,
            audioLabel.Width,
            audioLabel.Height);
        }
        #endregion
        public Designer()
        {
            InitializeComponent();
        }

        private void Designer_Load(object sender, EventArgs e)
        {
            Owner.SizeChanged += delegate {
                MaximumSize = Owner.Size;
                MinimumSize = Owner.Size;
                Size = Owner.Size;
                SetLeftSidePanelRegion();
                ChatRgn();
                SighnOffToCenter();
            };
            cmblang.SelectedIndexChanged += (Owner as Broadcaster).cmblang_SelectedIndexChanged;
            (Owner as Broadcaster).GetChat.TopLevel = false;
            (Owner as Broadcaster).GetChat.Dock = DockStyle.Fill;
            panelChat.Controls.Add((Owner as Broadcaster).GetChat);
            (Owner as Broadcaster).GetChat.Show();
            Owner.LocationChanged += (s, e) => { Location = new Point(Owner.Location.X, Owner.Location.Y); };
            RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;
            CenterPanel.Columns[1].Width = 0;
            //ChatRgn();
            //CenterPanel.Columns[1].Width = 0;
            SetLeftSidePanelRegion();
            AudioColorUpdate();
            VideoColorUpdate();
            SighnOffToCenter();
        }

        #region RealtimeDesigner

        private void ChatRgn()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 25;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(0, 0, panelChat.Width + 25, panelChat.Height);
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            path.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            panelChat.Region = new Region(path);
        }
        private void SetLeftSidePanelRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 30;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(-20, 0, LeftSidePanel.Width, LeftSidePanel.Height);
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width, r.Y, d - 10, d - 15, 270, -90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            path.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            LeftSidePanel.Region = new Region(path);
        }

        private void SighnOffToCenter()
        {
            int leftSide = audioLabel.Width + videoLabel.Width + ScreenShare.Width;
            IconsPanel.Columns[7].Width = 0;
            IconsPanel.Columns[3].Width = 0;
            int rightSide = devicesLabel.Width + Chat.Width + cmblang.Width;
            if (leftSide + rightSide + signOff.Width < IconsPanel.Width)
            {
                if (leftSide > rightSide)
                {
                    IconsPanel.Columns[7].Width = leftSide - rightSide;
                    IconsPanel.Columns[3].Width = 0;
                }
                else
                {
                    IconsPanel.Columns[3].Width = rightSide - leftSide;
                    IconsPanel.Columns[7].Width = 0;
                }
            }
        }
        private void AudioColorUpdate()
        {
            audioLabel.ItemAppearance.Normal.BorderColor = AgoraObject.IsLocalAudioMute ?
                Color.WhiteSmoke :
                Color.White;

            audioLabel.ItemAppearance.Normal.FillColor = AgoraObject.IsLocalAudioMute ?
                Color.Empty :
                Color.White;

            audioLabel.SvgImage = AgoraObject.IsLocalAudioMute ?
                SvgImage.FromFile("Resources\\Muted.svg") :
                SvgImage.FromFile("Resources\\mute.svg");
        }
        private void VideoColorUpdate()
        {
            videoLabel.ItemAppearance.Normal.BorderColor = AgoraObject.IsLocalVideoMute ?
                Color.WhiteSmoke :
                Color.White;

            videoLabel.ItemAppearance.Normal.FillColor = AgoraObject.IsLocalVideoMute ?
                Color.Empty :
                Color.White;

            videoLabel.SvgImage = AgoraObject.IsLocalVideoMute ?
                SvgImage.FromFile("Resources\\Hidden.svg") :
                SvgImage.FromFile("Resources\\video.svg");
        }
        private void SShareColorUpdate()
        {
            ScreenShare.SvgImage = IsSharingScreen ?
                SvgImage.FromFile("Resources\\sharing.svg") :
                SvgImage.FromFile("Resources\\screen_sharing.svg");
        }

        internal void MuteLocalAudio(bool mute)
        {
            AgoraObject.MuteLocalAudioStream(mute);
            AudioColorUpdate();
        }

        internal void MuteLocalVideo(bool mute)
        {
            AgoraObject.MuteLocalVideoStream(mute);
            VideoColorUpdate();
        }
        #endregion

        #region EventHandlers
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point oldPos = Cursor.Position;
            timer1.Stop();
            Cursor.Hide();
            Cursor.Position = PointToScreen(new Point(Width / 2, Height / 2));
            AudioColorUpdate();
            VideoColorUpdate();
            SShareColorUpdate();
            Cursor.Position = oldPos;
            System.Threading.Thread.Sleep(100);
            canSelect = true;
            Cursor.Show();
        }
        internal void labelMicrophone_Click(object sender, EventArgs e)
        {
            if (canSelect)
            {
                canSelect = false;
                AgoraObject.MuteLocalAudioStream(!AgoraObject.IsLocalAudioMute);
                timer1.Start();
            }
        }
        internal void labelVideo_Click(object sender, EventArgs e)
        {
            if (canSelect)
            {
                canSelect = false;
                AgoraObject.MuteLocalVideoStream(!AgoraObject.IsLocalVideoMute);
                (Owner as Broadcaster).pictureBoxLocalVideo.Visible = !AgoraObject.IsLocalVideoMute;
                timer1.Start();

                if (AgoraObject.IsLocalVideoMute)
                    enableScreenShare(false);
            }
        }
        public void HomeBtn_Click(object sender, EventArgs e)
        {
            AgoraObject.GetWorkForm?.ExitApp();
        }

        internal void audioLabel_MouseLeave(object sender, EventArgs e)
        {
            audioLabel.ItemAppearance.Normal.BorderThickness = 0;
        }

        internal void audioLabel_MouseMove(object sender, MouseEventArgs e)
        {
            audioLabel.ItemAppearance.Normal.BorderThickness = 1;
        }

        internal void videoLabel_MouseMove(object sender, MouseEventArgs e)
        {
            videoLabel.ItemAppearance.Normal.BorderThickness = 1;
        }

        internal void videoLabel_MouseLeave(object sender, EventArgs e)
        {
            videoLabel.ItemAppearance.Normal.BorderThickness = 0;
        }

        private void devicesLabel_Click(object sender, EventArgs e)
        {
            (Owner as Broadcaster).SettingButton_Click(sender, e);
        }

        internal void devicesLabel_MouseMove(object sender, MouseEventArgs e)
        {
            devicesLabel.ItemAppearance.Normal.BorderThickness = 1;
        }

        internal void devicesLabel_MouseLeave(object sender, EventArgs e)
        {
            devicesLabel.ItemAppearance.Normal.BorderThickness = 0;
        }
        internal void Langs_Click(object sender, EventArgs e)
        {
            cmblang.DroppedDown = !cmblang.DroppedDown;
        }

        internal void ScreenShare_MouseMove(object sender, MouseEventArgs e)
        {
            ScreenShare.ItemAppearance.Normal.BorderThickness = 1;
        }

        internal void ScreenShare_MouseLeave(object sender, EventArgs e)
        {
            ScreenShare.ItemAppearance.Normal.BorderThickness = 0;
        }
        internal void btnScreenShare_Click(object sender, EventArgs e)
        {
            if (AgoraObject.IsLocalVideoMute) return;

            if (PopUpForm.IsImageSend)
                ImageSender.EnableImageSender(IsSharingScreen);

            enableScreenShare(!IsSharingScreen);
            timer1.Start();
        }
        public void enableScreenShare(bool enable)
        {
            if (enable)
            {
                agorartc.ScreenCaptureParameters capParam = new();
                AgoraObject.StartScreenCapture(capParam);
                (Owner as Broadcaster).SetLocalVideoPreview();
            }
            else
            {
                AgoraObject.StopScreenCapture();
            }

            (Owner as Broadcaster).pictureBoxLocalVideo.Update();
            IsSharingScreen = enable;
        }

        internal void Chat_Click(object sender, EventArgs e)
        {
            IsChatActive = !IsChatActive;
            if (IsChatActive)
            {
                IconsPanel.Columns[3].Width = 0;
                IconsPanel.Columns[7].Width = 0;
                CenterPanel.Columns[1].Width = 450;
                (Owner as Broadcaster).StreamLayout.ColumnStyles[1].Width = 450;
                Chat.Hide();
                devicesLabel.Hide();
                ChatRgn();
                SighnOffToCenter();
            }
            else
            {
                CenterPanel.Columns[1].Width = 0;
                (Owner as Broadcaster).StreamLayout.ColumnStyles[1].Width = 0;
                Chat.Show();
                devicesLabel.Show();
                SighnOffToCenter();
            }
        }
        internal void Chat_MouseMove(object sender, MouseEventArgs e)
        {
            Chat.ItemAppearance.Normal.BorderThickness = 1;

        }

        internal void Chat_MouseLeave(object sender, MouseEventArgs e)
        {
            Chat.ItemAppearance.Normal.BorderThickness = 0;

        }
        #endregion
    }
}