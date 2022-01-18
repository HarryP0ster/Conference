using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils.Svg;
using System.Windows.Forms;

namespace RSI_X_Desktop.forms.HelpingClass
{
    enum PANEL
    {
        BOOTH = 0,
        GENERAL = 1,
        SUPPORT = 2
    }
    public partial class ChatForm : DevExpress.XtraEditors.XtraForm
    {
        private static ChatForm instance_;

        const int TAB_COUNT = 3;
        int[] scroll_offset = new int[TAB_COUNT * 2];
        List<Control>[] messages_list = new List<Control>[TAB_COUNT];
        bool[] ScrollEnabled = new bool[TAB_COUNT] { true, true, true };
        ReaLTaiizor.Controls.PoisonScrollBar[] chat_scrolls = new ReaLTaiizor.Controls.PoisonScrollBar[TAB_COUNT];

        HelpingClass.FireBaseReader FireBase;

        PANEL CurPanel;
        Padding MarginNormal = new Padding(10);
        Padding Hovered = new Padding(8);

        ToolTip GlobalTip = new();
        ToolTip SupportTip = new();
        ToolTip BoothTip = new();

        public ChatForm()
        {
            InitializeComponent();

            GlobalTip.SetToolTip(General, "Global chat");
            SupportTip.SetToolTip(Support, "Technical chat");
            BoothTip.SetToolTip(Booth, "Conference chat");

            Font font = Constants.Leelawadee14;
            int dpi = this.DeviceDpi;

            if (dpi >= (int)Constants.DPI.P175)
                font = Constants.GetLeelawadee(10F);
            else if (dpi >= (int)Constants.DPI.P150)
                font = Constants.GetLeelawadee(12F);
            else if (dpi >= (int)Constants.DPI.P125)
                font = Constants.GetLeelawadee(12F);
            else if (dpi >= (int)Constants.DPI.P100)
                font = Constants.GetLeelawadee(14F);
            ChatTextBox.Font = font;

            foreach (Control ctr in Controls)
            {
                ctr.KeyDown += Enter_KeyDown;
                try
                {
                    ctr.MouseWheel += Scrolled;
                }
                catch
                {

                }
            }
            for (int i = 0; i < TAB_COUNT; i++)
            {
                messages_list[i] = new List<Control>();
                scroll_offset[i] = 0;
            }
            chat_scrolls[(int)PANEL.BOOTH] = BoothScroll;
            chat_scrolls[(int)PANEL.GENERAL] = GeneralScroll;
            chat_scrolls[(int)PANEL.SUPPORT] = SupportScroll;
            PBooth.Resize += Chat_SizeChanged;
            PGeneral.Resize += Chat_SizeChanged;
            PSupport.Resize += Chat_SizeChanged;

            instance_ = this;
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            Booth_Click(null, null);
        }
        private void ChatWnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FireBase != null)
                FireBase.OnNewMessage -= chat_NewMessageSupInvoke;
            Dispose();
        }

        private void Scrolled(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (scroll_offset[(int)CurPanel] + 1 <= chat_scrolls[(int)CurPanel].Maximum && ScrollEnabled[(int)CurPanel])
                    scroll_offset[(int)CurPanel]++;
                else
                    return;
            }
            else
            {
                if (scroll_offset[(int)CurPanel] - 1 >= 0 && ScrollEnabled[(int)CurPanel])
                    scroll_offset[(int)CurPanel]--;
                else
                    return;
            }

            switch ((int)CurPanel)
            {
                case (int)PANEL.BOOTH:
                    chat_scrolls[(int)PANEL.BOOTH].Value = chat_scrolls[(int)PANEL.BOOTH].Maximum - scroll_offset[(int)PANEL.BOOTH];
                    Chat_SizeChanged(PBooth, new EventArgs());
                    break;
                case (int)PANEL.GENERAL:
                    chat_scrolls[(int)PANEL.GENERAL].Value = chat_scrolls[(int)PANEL.GENERAL].Maximum - scroll_offset[(int)PANEL.GENERAL];
                    Chat_SizeChanged(PGeneral, new EventArgs());
                    break;
                case (int)PANEL.SUPPORT:
                    chat_scrolls[(int)PANEL.SUPPORT].Value = chat_scrolls[(int)PANEL.SUPPORT].Maximum - scroll_offset[(int)PANEL.SUPPORT];
                    Chat_SizeChanged(PSupport, new EventArgs());
                    break;
            }
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (ChatTextBox.Text != "" && e.KeyCode == Keys.Enter)
                chatButtonRight2_Click(sender, null);
        }

        private void chatButtonRight2_Click(object sender, EventArgs e)
        {
            if (ChatTextBox.Text != "" && ChatTextBox.ForeColor != Color.FromArgb(185, 185, 185))
            {
                if (CurPanel == PANEL.GENERAL)
                {
                    AgoraObject.SendMessageToGlobal(ChatTextBox.Text);
                    AddOwnMessageGeneral(ChatTextBox.Text);
                    ChatTextBox.Text = "";
                }
                else if (CurPanel == PANEL.SUPPORT)
                {
                    FireBase.SendMessage(ChatTextBox.Text);
                    ChatTextBox.Text = "";
                }
                else
                {
                    AgoraObject.SendMessageToConference(ChatTextBox.Text);
                    AddOwnMessageLocal(ChatTextBox.Text);
                    ChatTextBox.Text = "";
                }
            }
        }

        private void AddOwnMessageLocal(string msg)
        {
            RelocateBubbles(new HelpingClass.MessagePanelL(msg, HelpingClass.MessagePanelL.MyOwn, PBooth), PBooth, (int)PANEL.BOOTH);
        }

        public void chat_NewMessageInvoke(string message, string nickname, CHANNEL_TYPE channel)
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate
                { chat_NewMessage(message, nickname, channel); });
            else
                chat_NewMessage(message, nickname, channel);
        }
        private void chat_NewMessage(string message, string nickname, CHANNEL_TYPE channel)
        {
            string senderNick = NickCenter.GetNickHostFromMsg(nickname);
            switch (channel)
            {
                case CHANNEL_TYPE.HOST:
                    RelocateBubbles(new MessagePanelL(message, senderNick, PGeneral), PGeneral, (int)PANEL.GENERAL);
                    break;
                case CHANNEL_TYPE.CONFERENCE:
                    RelocateBubbles(new MessagePanelL(message, senderNick, PBooth), PBooth, (int)PANEL.BOOTH);
                    break;
            }
        }

        public void chat_NewMessageSupInvoke(object sender, HelpingClass.FireBaseUpdateEventArgs arg)
        {
            if (instance_ == null || instance_.IsDisposed || instance_.Disposing)
                return;
            if (instance_.InvokeRequired)
                instance_.Invoke((MethodInvoker)delegate
                { instance_.chat_NewMessageSup(sender, arg); });
            else
                instance_.chat_NewMessageSup(sender, arg);
        }
        public void chat_NewMessageSup(object sender, HelpingClass.FireBaseUpdateEventArgs arg)
        {
            string senderNick;

            if (IsHandleCreated)
            {
                senderNick = NickCenter.GetNickHostFromMsg(arg.Msg.username);
                RelocateBubbles(new MessagePanelL(arg.Msg.msg, senderNick, PSupport), PSupport, (int)PANEL.SUPPORT);
            }
        }
        private void AddOwnMessageGeneral(string msg)
        {
            RelocateBubbles(new HelpingClass.MessagePanelL(msg, HelpingClass.MessagePanelL.MyOwn, PGeneral), PGeneral, (int)PANEL.GENERAL);
        }

        private void RelocateBubbles(Control new_ctr, Control panel, int index)
        {
            //panel.Controls.Add(new_ctr);
            messages_list[index].Add(new_ctr);
            Chat_SizeChanged(panel, new EventArgs());
            if (ScrollEnabled[index])
            {
                chat_scrolls[index].Maximum = messages_list[index].Count - scroll_offset[TAB_COUNT + index];
                chat_scrolls[index].Value = chat_scrolls[index].Maximum - scroll_offset[index];
            }
        }

        public void UpdateFireBase(HelpingClass.FireBaseReader FireBaseReader)
        {
            FireBase = FireBaseReader;
            FireBase.OnNewMessage += chat_NewMessageSupInvoke;
        }
        public void DisconnectFireBase()
        {
            if (FireBase != null)
                FireBase.OnNewMessage -= chat_NewMessageSupInvoke;
            FireBase = null;
        }
        internal void Chat_SizeChanged(object sender, EventArgs e) //Actually Updates chat wnd
        {
            if (Visible)
            {
                Control prev_ctr = null;
                ((Control)sender).Controls.Clear();
                int ind = (int)CurPanel;

                var controls = messages_list[ind].ToArray();


                for (int i = messages_list[ind].Count - 1 - scroll_offset[ind]; i >= 0; i--)
                {
                    if (prev_ctr != null)
                        controls[i].Location = new Point(controls[i].Location.X, prev_ctr.Location.Y - controls[i].Height);
                    else
                        controls[i].Location = new Point(controls[i].Location.X, ((Control)sender).Height - controls[i].Height - 5);

                    prev_ctr = controls[i];

                    ((Control)sender).Controls.Add(controls[i]);
                    ((Control)sender).Controls[((Control)sender).Controls.Count - 1].Update();
                    if (controls[i].Location.Y > ((Control)sender).Height || controls[i].Location.Y < 0)
                    {
                        if (!ScrollEnabled[ind])
                        {
                            scroll_offset[TAB_COUNT + ind] = ((Control)sender).Controls.Count - 1;
                            ScrollEnabled[ind] = true;
                            chat_scrolls[ind].Maximum = messages_list[ind].Count - scroll_offset[TAB_COUNT + ind];
                            chat_scrolls[ind].Value = chat_scrolls[ind].Maximum - scroll_offset[ind];
                        }
                        return;
                    }
                }
            }
        }

        private void UpdateSelectedPanel()
        {
            if (CurPanel == PANEL.GENERAL)
            {
                General.SvgImage = SvgImage.FromFile("Resources\\GeneralChatSelected.svg");
                Support.SvgImage = SvgImage.FromFile("Resources\\SupportChat.svg");
                Booth.SvgImage = SvgImage.FromFile("Resources\\LocalChat.svg");
            }
            else if (CurPanel == PANEL.SUPPORT)
            {
                General.SvgImage = SvgImage.FromFile("Resources\\GeneralChat.svg");
                Support.SvgImage = SvgImage.FromFile("Resources\\SupportChatSelected.svg");
                Booth.SvgImage = SvgImage.FromFile("Resources\\LocalChat.svg");
            }
            else
            {
                General.SvgImage = SvgImage.FromFile("Resources\\GeneralChat.svg");
                Support.SvgImage = SvgImage.FromFile("Resources\\SupportChat.svg");
                Booth.SvgImage = SvgImage.FromFile("Resources\\LocalChatSelected.svg");
            }
        }

        internal void ButtonsVisibility(bool state)
        {
            //bigTextBox2.Visible = state;
            //chatButtonRight2.Visible = state;
            //bigTextBox3.Visible = state;
            //chatButtonRight3.Visible = state;
        }

        private void SupportScroll_ValueChanged(object sender, int newValue)
        {
            scroll_offset[(int)PANEL.SUPPORT] = SupportScroll.Maximum - newValue;
            Chat_SizeChanged(PSupport, new EventArgs());
        }

        private void GeneralScroll_ValueChanged(object sender, int newValue)
        {
            scroll_offset[(int)PANEL.GENERAL] = GeneralScroll.Maximum - newValue;
            Chat_SizeChanged(PGeneral, new EventArgs());
        }

        private void BoothScroll_ValueChanged(object sender, int newValue)
        {
            scroll_offset[(int)PANEL.BOOTH] = BoothScroll.Maximum - newValue;
            Chat_SizeChanged(PBooth, new EventArgs());
        }

        private void bigTextBox2_Enter(object sender, EventArgs e)
        {
            ChatTextBox.ForeColor = Color.Black;
            if (ChatTextBox.Text == "Type in your message")
                ChatTextBox.Text = "";
        }

        private void bigTextBox2_Leave(object sender, EventArgs e)
        {
            ChatTextBox.ForeColor = Color.FromArgb(185, 185, 185);
            if (ChatTextBox.Text == "")
                ChatTextBox.Text = "Type in your message";
        }

        private void General_Click(object sender, EventArgs e)
        {
            CurPanel = PANEL.GENERAL;
            TablePanels.Hide();
            TablePanels.Columns[(int)PANEL.BOOTH].Width = 0;
            TablePanels.Columns[(int)PANEL.GENERAL].Width = 100;
            TablePanels.Columns[(int)PANEL.SUPPORT].Width = 0;
            timer1.Start();
            General.Enabled = false;
        }

        private void Support_Click(object sender, EventArgs e)
        {
            CurPanel = PANEL.SUPPORT;
            TablePanels.Hide();
            TablePanels.Columns[(int)PANEL.BOOTH].Width = 0;
            TablePanels.Columns[(int)PANEL.GENERAL].Width = 0;
            TablePanels.Columns[(int)PANEL.SUPPORT].Width = 100;
            timer1.Start();
            Support.Enabled = false;
        }

        private void Booth_Click(object sender, EventArgs e)
        {
            CurPanel = PANEL.BOOTH;
            TablePanels.Hide();
            TablePanels.Columns[(int)PANEL.BOOTH].Width = 100;
            TablePanels.Columns[(int)PANEL.GENERAL].Width = 0;
            TablePanels.Columns[(int)PANEL.SUPPORT].Width = 0;
            timer1.Start();
            Booth.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point oldPos = Cursor.Position;
            timer1.Stop();
            Cursor.Hide();
            Cursor.Position = PointToScreen(new Point(Width / 2, Height / 2));
            UpdateSelectedPanel();
            TablePanels.Show();
            Cursor.Position = oldPos;
            Cursor.Show();
            System.Threading.Thread.Sleep(100);
            General.Enabled = true;
            Support.Enabled = true;
            Booth.Enabled = true;
        }

        private void SendMsgBtn_MouseHover(object sender, EventArgs e)
        {
            SendMsgBtn.Margin = Hovered;
        }

        private void SendMsgBtn_MouseLeave(object sender, EventArgs e)
        {
            SendMsgBtn.Margin = MarginNormal;
        }

        private void ChatClose_MouseEnter(object sender, EventArgs e)
        {
            ChatClose.ItemAppearance.Normal.FillColor = Color.FromArgb(200, 200, 200);
        }

        private void ChatClose_MouseLeave(object sender, EventArgs e)
        {
            ChatClose.ItemAppearance.Normal.FillColor = Color.Gray;
        }

        private void ChatClose_Click(object sender, EventArgs e)
        {
            AgoraObject.GetWorkForm?.CloseChat();
        }

        private void bigTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (ChatTextBox.Text != "" && e.KeyCode == Keys.Enter)
                ChatTextBox.Text = "";
        }
    }
}