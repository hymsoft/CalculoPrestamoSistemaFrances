using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox
{
    class LineSeparator : Control
    {
        private int borderSize = 1;
        private bool isVertical;

        //Descriptores
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                if (Height < borderSize)
                    Height = borderSize;
                else
                    Invalidate();
            }
        }

        public bool IsVertical
        {
            get
            {
                return isVertical;
            }

            set
            {
                isVertical = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var sz = isVertical ? Height / 2 : Width / 2;
            e.Graphics.TranslateTransform(Width / 2f, Height / 2f);
            using(var pen = new Pen(ForeColor, borderSize))
            {
                if (!isVertical)
                {
                    e.Graphics.DrawLine(pen, -sz + Padding.Left, 0, sz - Padding.Right,0);
                }
                else
                {
                    e.Graphics.DrawLine(pen, 0,-sz + Padding.Top, 0, sz - Padding.Bottom);
                }
            }
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Invalidate();
        }
    }
}
