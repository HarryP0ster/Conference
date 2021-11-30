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
            GetOutCode = true;
            Close();
        }
        private void BClose_Click(object sender, EventArgs e)
        { 
            Close();
        }
        private void cmblang_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrimaryLang = cmblang.SelectedIndex;
        }

        private void CheckBoxMic_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void LangSelectDlg_FormClosed(object sender, FormClosedEventArgs e)
        {

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
            (Owner as Broadcaster).ChildClosed();
            Dispose();
        }
    }
}
