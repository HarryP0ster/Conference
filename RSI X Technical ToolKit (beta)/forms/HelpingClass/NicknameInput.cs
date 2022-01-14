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
    public partial class NicknameInput : DevExpress.XtraEditors.XtraForm
    {
        internal string Nickname
        {
            get => NewTextBox.Text;
        }
        public NicknameInput()
        {
            InitializeComponent();

            if (NewTextBox.DeviceDpi >= (int)Constants.DPI.P175)
                NewTextBox.Font = Constants.Bahnschrift16;
            else if (NewTextBox.DeviceDpi >= (int)Constants.DPI.P150)
                NewTextBox.Font = Constants.Bahnschrift18;
            else if (NewTextBox.DeviceDpi >= (int)Constants.DPI.P125)
                NewTextBox.Font = Constants.Bahnschrift20;
            else if (NewTextBox.DeviceDpi >= (int)Constants.DPI.P100)
                NewTextBox.Font = Constants.Bahnschrift24;
        }

        private void InputWnd_Load(object sender, EventArgs e)
        {
            Location = Owner.Location;
            Owner.LocationChanged += delegate { Location = Owner.Location; };
            Owner.VisibleChanged += delegate { Visible = Owner.Visible; };
            NewTextBox.Text = "Your name";
        }

        private void NewTextBox_Click(object sender, EventArgs e)
        {
            if (NewTextBox.Text == "Your name")
            {
                NewTextBox.Text = "";
                NewTextBox.ForeColor = Color.FromArgb(240, 240, 240);
            }
        }

        private void InputWnd_Shown(object sender, EventArgs e)
        {
            //Focus();
        }

        private void NewTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void NewTextBox_Leave(object sender, EventArgs e)
        {
            if (NewTextBox.Text == "")
            {
                NewTextBox.ForeColor = Color.FromArgb(190, 190, 190);
                NewTextBox.Text = "Your name";
            }
        }
    }
}