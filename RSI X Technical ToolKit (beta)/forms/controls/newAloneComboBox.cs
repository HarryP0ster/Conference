using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ReaLTaiizor.Util;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RSI_X_Desktop.forms.HelpingClass
{
    public class newAloneComboBox : ComboBox
    {
        private Graphics G;

        private Rectangle Rect;

        private bool _EnabledCalc;

        public new bool Enabled
        {
            get
            {
                return EnabledCalc;
            }
            set
            {
                _EnabledCalc = value;
                Invalidate();
            }
        }

        [DisplayName("Enabled")]
        public bool EnabledCalc
        {
            get
            {
                return _EnabledCalc;
            }
            set
            {
                base.Enabled = value;
                Enabled = value;
                Invalidate();
            }
        }

        public newAloneComboBox()
        {
            DoubleBuffered = true;
            base.DropDownStyle = ComboBoxStyle.DropDownList;
            Cursor = Cursors.Hand;
            Enabled = true;
            base.DrawMode = DrawMode.OwnerDrawFixed;
            base.ItemHeight = 20;
            base.Size = new Size(64, 26);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetStyle(ControlStyles.UserPaint, value: true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            base.OnPaint(e);
            G.Clear(Color.White);
            checked
            {
                if (Enabled)
                {
                    using (Pen pen = new Pen(AloneLibrary.ColorFromHex("#D0D5D9")))
                    {
                        using (SolidBrush brush = new SolidBrush(AloneLibrary.ColorFromHex("#7C858E")))
                        {
                            using (Font font = new Font("Marlett", 14F))
                            {
                                G.DrawPath(pen, AloneLibrary.RoundRect(AloneLibrary.FullRectangle(base.Size, Subtract: true), 6));
                                G.DrawString("6", font, brush, new Point(base.Width - 22, 3));
                            }
                        }
                    }
                }
                else
                {
                    using (Pen pen2 = new Pen(AloneLibrary.ColorFromHex("#E1E1E2")))
                    {
                        using (SolidBrush brush2 = new SolidBrush(AloneLibrary.ColorFromHex("#D0D3D7")))
                        {
                            using (Font font2 = new Font("Marlett", 14F))
                            {
                                G.DrawPath(pen2, AloneLibrary.RoundRect(AloneLibrary.FullRectangle(base.Size, Subtract: true), 6));
                                G.DrawString("6", font2, brush2, new Point(base.Width - 22, 3));
                            }
                        }
                    }
                }

                if (Information.IsNothing(base.Items))
                {
                    return;
                }

                using (SolidBrush brush3 = new SolidBrush(AloneLibrary.ColorFromHex("#7C858E")))
                {
                    if (Enabled)
                    {
                        if (SelectedIndex != -1)
                        {
                            G.DrawString(GetItemText(RuntimeHelpers.GetObjectValue(base.Items[SelectedIndex])), Font, brush3, new Point(7, 4));
                            return;
                        }

                        try
                        {
                            G.DrawString(GetItemText(RuntimeHelpers.GetObjectValue(base.Items[0])), Font, brush3, new Point(7, 4));
                        }
                        catch (Exception projectError)
                        {
                            ProjectData.SetProjectError(projectError);
                            ProjectData.ClearProjectError();
                        }

                        return;
                    }

                    using (SolidBrush brush4 = new SolidBrush(AloneLibrary.ColorFromHex("#D0D3D7")))
                    {
                        if (SelectedIndex != -1)
                        {
                            G.DrawString(GetItemText(RuntimeHelpers.GetObjectValue(base.Items[SelectedIndex])), Font, brush4, new Point(7, 4));
                        }
                        else
                        {
                            G.DrawString(GetItemText(RuntimeHelpers.GetObjectValue(base.Items[0])), Font, brush4, new Point(7, 4));
                        }
                    }
                }
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            if (!Enabled)
            {
                return;
            }

            e.DrawBackground();
            Rect = e.Bounds;
            checked
            {
                try
                {
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    {
                        using (SolidBrush brush = new SolidBrush(AloneLibrary.ColorFromHex("#78B7E6")))
                        {
                            G.FillRectangle(brush, Rect);
                            G.DrawString(GetItemText(RuntimeHelpers.GetObjectValue(base.Items[e.Index])), Font, Brushes.White, new Point(Rect.X + 5, Rect.Y + 1));
                        }
                    }
                    else
                    {
                        using (SolidBrush brush2 = new SolidBrush(AloneLibrary.ColorFromHex("#7C858E")))
                        {
                            G.FillRectangle(Brushes.White, Rect);
                            G.DrawString(GetItemText(RuntimeHelpers.GetObjectValue(base.Items[e.Index])), Font, brush2, new Point(Rect.X + 5, Rect.Y + 1));
                        }
                    }
                }
                catch (Exception projectError)
                {
                    ProjectData.SetProjectError(projectError);
                    ProjectData.ClearProjectError();
                }
            }
        }

        protected override void OnSelectedItemChanged(EventArgs e)
        {
            base.OnSelectedItemChanged(e);
            Invalidate();
        }
    }
}