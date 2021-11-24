using System;
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
            InitializeComponent();
            List<string> langsShort = new();
            foreach (var lang in AgoraObject.GetComplexToken().GetTranslLangs)
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
#if false
            NickName = textBoxNickName.Text;

            if (NickName == "")
            {
                MessageBox.Show("Your name must be longer");
                return;
            }
            else if (NickName.Length > MAX_NICK_LEN)
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
#endif
            GetOutCode = true;
            Close();
        }
        private void BClose_Click(object sender, EventArgs e)
        { Close(); }
        private void cmblang_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrimaryLang = cmblang.SelectedIndex;
        }
    }
}
