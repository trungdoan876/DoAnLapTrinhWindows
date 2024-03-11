using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class UCTextBox : UserControl
    {
        //fields
        private Color mauKhung = Color.MediumPurple;
        private int kichThuocKhung = 2;
        private bool gachChan = false;
        //private Color borderFocusColor = Color.MediumVioletRed;
        //private bool co = false;
        private int banKinhKhung = 0;
        //constructor
        public UCTextBox()
        {
            InitializeComponent();
        }
        //properties
        public Color MauKhung
        {
            get 
            { 
                return mauKhung; 
            }
            set 
            { 
                mauKhung = value; 
                this.Invalidate();
            }
        }
        public int KichThuocKhung 
        {
            get 
            { 
                return kichThuocKhung; 
            } 
            set 
            { 
                kichThuocKhung = value; 
                this.Invalidate(); 
            }
        }
        public bool GachChan
        {
            get 
            { 
                return gachChan; 
            }
            set 
            { 
                gachChan = value; 
                this.Invalidate ();
            }
        }
        public int BanKinhKhung
        {
            get
            {
                return banKinhKhung;
            }
            set
            {
                if (value >= 0)
                {
                    banKinhKhung = value;
                    this.Invalidate();
                }
            }
        }
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (banKinhKhung > 1) //rounded textbox
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -kichThuocKhung, -kichThuocKhung);
                int smoothSize = kichThuocKhung > 0 ? kichThuocKhung : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, banKinhKhung))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, banKinhKhung - kichThuocKhung))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, kichThuocKhung))
                using (Pen penBorder = new Pen(mauKhung, kichThuocKhung))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (banKinhKhung > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    //if (!co) penBorder.Color = borderFocusColor;
                    if (gachChan)
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.SmoothingMode |= SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                using (Pen penBorder = new Pen(mauKhung, kichThuocKhung))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    //if (!co) penBorder.Color = borderFocusColor;
                    if (gachChan)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);

                }
            }
        }
        private GraphicsPath GetFigurePath(RectangleF rect, float banKinh)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, banKinh, banKinh, 180, 90);
            path.AddArc(rect.Width - banKinh, rect.Y, banKinh, banKinh, 270, 90);
            path.AddArc(rect.Width - banKinh, rect.Height - banKinh, banKinh, banKinh, 0, 90);
            path.AddArc(rect.X, rect.Height - banKinh, banKinh, banKinh, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            //throw new NotImplementedException();
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, banKinhKhung - kichThuocKhung);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, kichThuocKhung * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }
    }
}
