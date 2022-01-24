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
    public partial class ChatForm
    {
        public static void UpdateChat()
        {
            switch ((int)instance_.CurPanel)
            {
                case (int)PANEL.GENERAL:
                    instance_.Chat_SizeChanged(instance_.PGeneral, null);
                    break;
                case (int)PANEL.SUPPORT:
                    instance_.Chat_SizeChanged(instance_.PSupport, null);
                    break;
                case (int)PANEL.BOOTH:
                    instance_.Chat_SizeChanged(instance_.PBooth, null);
                    break;
            }
        }
    }

    public partial class MessagePanelL : System.Windows.Forms.TableLayoutPanel
    {
        public const string MyOwn = "Me";
        readonly int maxSymbol;
        newRightBubble buble;
        Font font;
        Label Sender;
        Control Owner;

        public MessagePanelL(string text, string sender, Control owner)
        {
            int dpi = this.DeviceDpi;

            if (dpi >= (int)Constants.DPI.P175)
            {
                font = Constants.Bahnschrift10;
                maxSymbol = 14;
            }
            else if (dpi >= (int)Constants.DPI.P150)
            {
                font = Constants.Bahnschrift12;
                maxSymbol = 15;
            }
            else if (dpi >= (int)Constants.DPI.P125)
            {
                font = Constants.Bahnschrift14;
                maxSymbol = 20;
            }
            else if (dpi >= (int)Constants.DPI.P100)
            {
                font = Constants.Bahnschrift14;
                maxSymbol = 25;
            }

            Owner = owner;
            Owner.SizeChanged += delegate
            {
                Width = Owner.Width;
            };

            this.AutoSize = true;
            Width = Owner.Width;
            Sender = new Label();

            Sender.Text = sender;
            Sender.AutoSize = true;
            Sender.TextAlign = ContentAlignment.BottomLeft;
            Sender.Font = font;
            BackColor = Color.White;
            RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            RowStyles.Add(new RowStyle(SizeType.AutoSize, 100));

            buble = new newRightBubble();
            buble.Text = CutMessage(text, buble.Font, 300);

            if (sender == MyOwn)
            {
                ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                ColumnStyles[0].SizeType = SizeType.Percent;
                ColumnStyles[0].Width = 100;
                buble.ForeColor = Color.White;
                buble.ArrowRight = true;
                buble.BubbleColor = Color.FromArgb(254, 1, 143);
                buble.Margin = new Padding(0, 0, 13, 0);
                Sender.TextAlign = ContentAlignment.BottomRight;
                Sender.Dock = DockStyle.Right;
                Sender.Text += "\t";
                Name = "Right";
                Controls.Add(buble, 1, 1);
                Controls.Add(Sender, 1, 0);
            }
            else
            {
                buble.BubbleColor = Color.FromArgb(217, 217, 217);
                buble.ArrowRight = false;

                Name = "Left";
                Controls.Add(buble, 0, 1);
                Controls.Add(Sender, 0, 0);
            }

            buble.Margin = new Padding(5, 5, 5, 5);

            buble.Show();
            buble.SuspendLayout();
            buble.Enabled = false;
            Sender.SuspendLayout();
            ChatForm.UpdateChat();
        }

        private string CutMessage(string _text, Font _font, int _width)
        {
            var _words = _text.Split(' ');
            int _line = 0;
            string output = "";

            if (_words.Length > 0)
            {
                foreach (var word in _words)
                {
                    Size word_size = TextRenderer.MeasureText(word, _font);

                    if (word_size.Width >= _width)
                    {
                        foreach (char _letter in word)
                        {
                            Size char_size = TextRenderer.MeasureText(_letter.ToString(), _font);

                            if (_line + char_size.Width < _width)
                            {
                                _line += char_size.Width;
                                output += _letter;
                            }
                            else
                            {
                                output += "\n" + _letter;
                                _line = char_size.Width;
                            }
                        }
                        output += " ";
                    }
                    else
                    {
                        if (_line + word_size.Width < _width)
                        {
                            _line += word_size.Width;
                            output += word + " ";
                        }
                        else
                        {
                            output += "\n" + word + " ";
                            _line = word_size.Width;
                        }
                    }
                }

                return output;
            }

            return _text;
        }
    }
}
