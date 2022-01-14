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

namespace RSI_X_Desktop.forms.HelpingClass
{
    public partial class LangWnd : DevExpress.XtraEditors.XtraForm
    {
        NicknameInput nicknameInput = new();
        public bool GetOutCode { get; private set; } = false;
        public string NickName { get; private set; } = string.Empty;
        public int RoomIndex { get; private set; } = 0;

        bool EnableCamera = true;
        bool EnableMic = true;

        readonly Color ButtonPushColor = Color.FromArgb(245, 245, 245);
        readonly Color ButtonDefaultColor = Color.FromArgb(165, 37, 37);
        readonly Color ButtonPushColorText = Color.FromArgb(27, 94, 137);
        readonly Color ButtonDefaultColorText = Color.White;
        readonly Color ButtonPushBorderColor = Color.FromArgb(66, 66, 66);
        readonly Color ButtonDefaultBorderColor = Color.FromArgb(192, 0, 0);

        private int selectedTargetLangs;

        private forms.PopUpForm devices;
        public LangWnd()
        {
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            InitializeComponent();
        }

        private void LangWnd_Load(object sender, EventArgs e)
        {
            Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2, Owner.Location.Y + Owner.Height / 2 - 4 * Height / 9 - 20);
            Owner.LocationChanged += delegate { Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2, Owner.Location.Y + Owner.Height / 2 - 4 * Height / 9 - 20); };
            nicknameInput.Show(this);
            UpdateInterpreterRoomCB();
        }

        private void UpdateInterpreterRoomCB()
        {
            List<string> langsShort = new();
            var t = AgoraObject.room;
            foreach (var lang in AgoraObject.GetComplexToken().GetTargetLangs)
            {
                langsShort.Add(lang.langShort);
            }
            langBox.DataSource = langsShort;

            if (langsShort.Count == 0)
            { return; }

            langBox.SelectedIndex = 0;
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomIndex = langBox.SelectedIndex;
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = "";
            Font fnt = new Font("Bahnschrift SemiCondensed", 16);
            Brush br = new SolidBrush(label1.ForeColor);

            e.Graphics.DrawString("Source language", fnt, br, 0, 0);
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            NickName = nicknameInput.Nickname;

            if (NickName == "")
            {
                MessageBox.Show("Your name must be longer");
                return;
            }
            else if (NickName.Length > 16) //If you change this, consider also chaning limit in IChannel
            {
                MessageBox.Show("Your name is too long");
                return;
            }
            else if (NickName == "Your name")
            {
                MessageBox.Show("Invalid name");
                return;
            }
            foreach (var ch in NickName)
            {
                if (Convert.ToInt32(ch) > 255)
                {
                    MessageBox.Show("Nickname contains unsupported characters");
                    return;
                }
            }

            Hide();
            EntranceForm._instance.Hide();
            AgoraObject.CurrentForm = CurForm.FormBroadcaster;

            EntranceForm.TransLater = new();
            EntranceForm.TransLater.SetTransData = new Data(langBox.SelectedIndex, EnableCamera, EnableMic, NickName);
            EntranceForm.TransLater.Show(EntranceForm._instance);
        }

        private void MuteCam_Click(object sender, EventArgs e)
        {
            EnableCamera = !EnableCamera;
            AgoraObject.MuteLocalVideoStream(!EnableCamera);
            MuteCam.ItemAppearance.Normal.FillColor = EnableCamera ? Color.FromArgb(240, 240, 240) : Color.Empty;
        }

        private void MuteMic_Click(object sender, EventArgs e)
        {
            EnableMic = !EnableMic;
            AgoraObject.MuteLocalAudioStream(!EnableMic);
            MuteMic.ItemAppearance.Normal.FillColor = EnableMic ? Color.FromArgb(240, 240, 240) : Color.Empty;
        }

        private void DevicesBtn_Click(object sender, EventArgs e)
        {
            PopUpForm dlg = new();
            dlg.ShowDialog(this);
        }
    }
}