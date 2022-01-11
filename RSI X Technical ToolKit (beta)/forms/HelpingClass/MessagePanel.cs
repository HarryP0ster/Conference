using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace RSI_X_Desktop.forms.HelpingClass
{
    public partial class MessagePanelL : System.Windows.Forms.TableLayoutPanel
    {
        public const string MyOwn = "Me";
        const int maxSymbol = 25;
        ChatBubbleLeft labelL;
        newRightBubble labelR;
        Font font;
        Label Sender;
        Control Owner;

        public MessagePanelL(string text, string sender, Control owner)
        {
            int dpi = this.DeviceDpi;

            if (dpi >= (int)Constants.DPI.P175)
                font = Constants.Bahnschrift10;
            else if (dpi >= (int)Constants.DPI.P150)
                font = Constants.Bahnschrift12;
            else if (dpi >= (int)Constants.DPI.P125)
                font = Constants.Bahnschrift14;
            else if (dpi >= (int)Constants.DPI.P100)
                font = Constants.Bahnschrift14;

            Owner = owner;
            Owner.SizeChanged += delegate
            {
                Width = Owner.Width;
            };
            this.AutoSize = true;
            Width = Owner.Width;
            Height = 65;
            Sender = new Label();

            Sender.Text = sender;
            Sender.AutoSize = true;
            Sender.TextAlign = ContentAlignment.BottomLeft;
            Sender.Font = font;
            BackColor = Color.White;
            RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            RowStyles.Add(new RowStyle(SizeType.AutoSize, 100));

            //Date = new Label();

            if (sender == MyOwn)
            {
                ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                ColumnStyles[0].SizeType = SizeType.Percent;
                ColumnStyles[0].Width = 100;
                labelR = new newRightBubble();
                labelR.ForeColor = Color.White;
                labelR.SizeAuto = true;
                labelR.SizeAutoW = true;
                labelR.SizeAutoH = true;
                labelR.Margin = new Padding(0, 0, 13, 0);
                Sender.TextAlign = ContentAlignment.BottomRight;

                if (text.Length > 0) labelR.Text += text[0];

                labelR.Text = text;

                for (int i = maxSymbol - 1; i < text.Length; i += maxSymbol)
                {
                    labelR.Text = labelR.Text.Insert(i, " \n");
                }

                labelR.Show();
                Name = "Right";
                Controls.Add(labelR, 1, 1);
                Controls.Add(Sender, 1, 0);
                labelR.SuspendLayout();
                labelR.Enabled = false;
                Sender.SuspendLayout();
            }
            else
            {
                labelL = new ChatBubbleLeft();
                labelL.SizeAuto = true;
                labelL.SizeAutoW = true;
                labelL.SizeAutoH = true;

                if (text.Length > 0) labelL.Text += text[0];

                labelL.Text = text + " ";

                for (int i = maxSymbol - 1; i < text.Length; i += maxSymbol)
                {
                    labelL.Text = labelL.Text.Insert(i, " \n");
                }
                labelL.Show();
                Name = "Left";
                Controls.Add(labelL, 0, 1);
                Controls.Add(Sender, 0, 0);
                labelL.SuspendLayout();
                labelL.Enabled = false;
                Sender.SuspendLayout();
            }
        }
    }
}
