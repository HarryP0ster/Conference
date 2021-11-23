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
        public LangSelectDlg()
        {
            InitializeComponent();
            var langsShort = new List<string>();
            foreach (var lang in AgoraObject.GetComplexToken().GetTranslLangs) 
            {
                langsShort.Append(lang.langShort);
            }
            cmblang.DataSource = langsShort;
        }
    }
}
