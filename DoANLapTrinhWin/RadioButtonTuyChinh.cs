using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DoANLapTrinhWin
{
    internal class RadioButtonTuyChinh:RadioButton
    {
        //Fields
        private Color checkedColor = Color.MediumBlue;
        private Color unCheckedColor = Color.Gray;

        //Properties
        public Color CheckedColor
        {
            get
            {
                return checkedColor;
            }
            set
            {
                checkedColor = value;
                this.Invalidate();
            }
        }
        public Color UnCheckedColor
        {
            get
            {
                return unCheckedColor;
            }
            set
            {
                unCheckedColor = value;
                this.Invalidate();
            }
        }
        public RadioButtonTuyChinh()
        {
            this.MinimumSize = new Size(0, 21);
        }
        //Overridden methodds
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //Fields
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;
            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (this.Height - rbBorderSize) / 2,
                Width = rbBorderSize,
                Height = rbBorderSize,
            };
            RectangleF recRbCheck = new RectangleF()
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbBorderSize) / 2), //Center
                Y = (this.Height - rbCheckSize) / 2, //Center
                Width = rbCheckSize,
                Height = rbCheckSize,
            };

            //Ve
            using (Pen penBorder=new Pen(checkedColor,1.6F))
            using (SolidBrush brushBorder=new SolidBrush(checkedColor))
            using (SolidBrush brushText =new SolidBrush(this.ForeColor))
            {
                //Draw surface 
                graphics.Clear(this.BackColor);
                //Draw Radio Button
                if(this.Checked)
                {
                    graphics.DrawEllipse(penBorder, recRbCheck);
                    graphics.FillEllipse(brushBorder, recRbCheck);
                }
                else
                {
                    penBorder.Color = unCheckedColor;
                    graphics.DrawEllipse(penBorder, recRbCheck );
                }
                //Draw text 
                graphics.DrawString(this.Text, this.Font, brushText, 
                    rbBorderSize +8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height)/2);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = TextRenderer.MeasureText (this.Text, this.Font).Width +30;   
        }
    }
}
