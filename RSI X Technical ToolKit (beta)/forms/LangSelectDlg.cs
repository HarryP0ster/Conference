﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSI_X_Desktop.forms
{
    public partial class LangSelectDlg : Form
    {
        const int MAX_NICK_LEN = 16;
        public bool GetOutCode { get; private set; } = false;
        public bool MicMute { get { return !CheckBoxMic.Checked; } }
        public bool CamMute { get { return !CheckBoxCam.Checked; } }
        public int PrimaryLang = -1;
        public langHolder getPrimaryLang { 
            get 
            {
                var langs = AgoraObject.GetComplexToken().GetTranslLangs;
                if (langs.Count > 0)
                    return langs[PrimaryLang]; 
                else
                    return langHolder.Empty;
            }
        }
        public string NickName { get; private set; } = string.Empty;

        public LangSelectDlg()
        {
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            List<string> langsShort = new();
            var t = AgoraObject.room;
            foreach (var lang in AgoraObject.GetComplexToken().GetTargetLangs)
            {
                langsShort.Add(lang.langShort);
            }
            cmblang.DataSource = langsShort;

            if (langsShort.Count == 0) 
            { return; }
            
            cmblang.SelectedIndex = 0;
            PrimaryLang = cmblang.SelectedIndex;
        }

        private void BAccept_Click(object sender, EventArgs e)
        {
            if (UpdateNick(textBoxNickName.Text)) 
            {
                GetOutCode = true;
                Close();
            }
        }
        private bool UpdateNick(string nick) 
        {

            if (nick == "")
            {
                MessageBox.Show("Your name must be longer");
                return false;
            }
            else if (nick.Length > 16) //If you change this, consider also chaning limit in IChannel
            {
                MessageBox.Show("Your name is too long");
                return false;
            }
            else if (nick == "Your name")
            {
                MessageBox.Show("Invalid name");
                return false;
            }
            foreach (var ch in nick)
            {
                if (Convert.ToInt32(ch) > 255)
                {
                    MessageBox.Show("Nickname contains unsupported characters");
                    return false;
                }
            }

            AgoraObject.UpdateNickName(nick);
            return true;
        }
        private void BClose_Click(object sender, EventArgs e)
        { 
            Close();
        }
        private void cmblang_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrimaryLang = cmblang.SelectedIndex;
        }

        private void textBoxNickName_Enter(object sender, EventArgs e)
        {
            if (textBoxNickName.Text == "Your name")
            {
                textBoxNickName.Text = "";
                textBoxNickName.ForeColor = Color.Black;
            }
        }

        private void textBoxNickName_Leave(object sender, EventArgs e)
        {
            if (textBoxNickName.Text == "")
            {
                textBoxNickName.Text = "Your name";
                textBoxNickName.ForeColor = Color.Gainsboro;
            }
        }

        private void LangSelectDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            AgoraObject.MuteLocalAudioStream(!CheckBoxMic.Checked);
            AgoraObject.MuteLocalVideoStream(!CheckBoxCam.Checked);
            Dispose();
        }
    }
}
