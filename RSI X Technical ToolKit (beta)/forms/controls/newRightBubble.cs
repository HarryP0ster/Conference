#region сборка ReaLTaiizor, Version=3.7.8.5, Culture=neutral, PublicKeyToken=null
// C:\Users\karah\.nuget\packages\realtaiizor\3.7.8.5\lib\net5.0-windows7.0\ReaLTaiizor.dll
// Decompiled with ICSharpCode.Decompiler 6.1.0.5902
#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RSI_X_Desktop.forms.HelpingClass
{
    public class newRightBubble : Control
    {
        private GraphicsPath Shape;

        private Color _TextColor = Color.FromArgb(52, 52, 52);

        private Color _BubbleColor = Color.White;

        private bool _DrawBubbleArrow = true;

        private bool _SizeAuto = true;

        private bool _SizeAutoW = true;

        private bool _SizeAutoH = true;

        private bool _SizeWidthLeft;
        private bool _ArrowRight = false;
        public override Color ForeColor
        {
            get
            {
                return _TextColor;
            }
            set
            {
                _TextColor = value;
                Invalidate();
            }
        }

        public Color BubbleColor
        {
            get
            {
                return _BubbleColor;
            }
            set
            {
                _BubbleColor = value;
                Invalidate();
            }
        }

        public bool DrawBubbleArrow
        {
            get
            {
                return _DrawBubbleArrow;
            }
            set
            {
                _DrawBubbleArrow = value;
                Invalidate();
            }
        }

        public bool SizeAuto
        {
            get
            {
                return _SizeAuto;
            }
            set
            {
                _SizeAuto = value;
                Invalidate();
            }
        }

        public bool SizeAutoW
        {
            get
            {
                return _SizeAutoW;
            }
            set
            {
                _SizeAutoW = value;
                Invalidate();
            }
        }

        public bool SizeAutoH
        {
            get
            {
                return _SizeAutoH;
            }
            set
            {
                _SizeAutoH = value;
                Invalidate();
            }
        }

        public bool SizeWidthLeft
        {
            get
            {
                return _SizeWidthLeft;
            }
            set
            {
                _SizeWidthLeft = value;
                Invalidate();
            }
        }

        public bool ArrowRight
        {
            get { return _ArrowRight; }
            set
            {
                _ArrowRight = value;
                Invalidate();
            }
        }

        public newRightBubble()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
            DoubleBuffered = true;
            base.Size = new Size(130, 40);
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(52, 52, 52);
            Font = new Font("Segoe UI", 10f);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Shape = new GraphicsPath();
            GraphicsPath shape = Shape;
            shape.AddArc(9, 0, 10, 10, 180f, 90f);
            shape.AddArc(base.Width - 18, 0, 10, 10, -90f, 90f);
            shape.AddArc(base.Width - 18, base.Height - 11, 10, 10, 0f, 90f);
            shape.AddArc(9, base.Height - 11, 10, 10, 90f, 90f);
            shape.CloseAllFigures();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_SizeAuto)
            {
                int width = base.Width;
                if (_SizeAutoW && _SizeAutoH)
                {
                    //base.Width = TextRenderer.MeasureText(Text, Font).Width + 17;
                    //base.Height = TextRenderer.MeasureText(Text, Font).Height + 15;
                    if (_SizeWidthLeft)
                    {
                        base.Location = new Point(base.Location.X - (base.Width - width), base.Location.Y);
                    }
                }
                else if (_SizeAutoW)
                {
                    //base.Width = TextRenderer.MeasureText(Text, Font).Width + 15;
                    if (_SizeWidthLeft)
                    {
                        base.Location = new Point(base.Location.X - (base.Width - width), base.Location.Y);
                    }
                }
                else
                {
                    //base.Height = TextRenderer.MeasureText(Text, Font).Height + 15;
                }
            }

            string[] txt = Text.Split('\n');
            Size textSize = TextRenderer.MeasureText(Text, Font);
            Size lineSize = TextRenderer.MeasureText(txt[0], Font);

            int textOffsetW = _ArrowRight ? 22 : 15;

            base.Height = 15 + textSize.Height;
            base.Width = textSize.Width + textOffsetW + 6;

            Bitmap bitmap = new Bitmap(base.Width, base.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Graphics graphics2 = graphics;
            graphics2.SmoothingMode = SmoothingMode.HighQuality;
            graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics2.Clear(BackColor);
            graphics2.FillPath(new SolidBrush(_BubbleColor), Shape);


            for (int i = 0; i < txt.Length; i++)
            {
                graphics2.DrawString(txt[i], Font,
                    new SolidBrush(ForeColor),
                    textOffsetW, 7 + i * lineSize.Height);
            }
            //graphics2.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(6, 7, base.Width - 15, base.Height));


            if (_DrawBubbleArrow)
            {
                Point[] points = new Point[0];
                if (_ArrowRight)
                    points = new Point[3]
                   {
                        new Point(base.Width - 8, base.Height - 19),
                        new Point(base.Width, base.Height - 25),
                        new Point(base.Width - 8, base.Height - 30)
                   };
                else
                    points = new Point[3]
                    {
                        new Point(9, base.Height - 19),
                        new Point(0, base.Height - 25),
                        new Point(9, base.Height - 30)
                    };
                graphics2.FillPolygon(new SolidBrush(_BubbleColor), points);
                graphics2.DrawPolygon(new Pen(new SolidBrush(_BubbleColor)), points);
            }

            graphics.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
            bitmap.Dispose();
        }
    }
}