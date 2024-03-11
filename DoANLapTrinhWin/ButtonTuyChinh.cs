using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace DoANLapTrinhWin
{
    public class ButtonTuyChinh : Button
    {
        //fields - cac truong (thuoc tinh)
        private int kichThuocKhung = 0; //borderSize
        private int banKinhKhung = 20; //borderRadius
        private Color mauKhung = Color.PaleVioletRed; //borderColor
        //tao thuoc tinh de hien thi cac truong tren
        //constructor - khoi tao mot so thuoc tinh mac dinh cua button
        public ButtonTuyChinh()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }
        //methods ve duong dan 
        private GraphicsPath GetFigurePath(RectangleF hinhChuNhat, float banKinh)
        {
            GraphicsPath path = new GraphicsPath(); //tao mot doi tuong path moi
            path.StartFigure(); //bat dau ve
            path.AddArc(hinhChuNhat.X, hinhChuNhat.Y, banKinh, banKinh, 180, 90); //ve mot goc 90 theo ban kinh
            path.AddArc(hinhChuNhat.Width - banKinh, hinhChuNhat.Y, banKinh, banKinh, 270, 90); 
            path.AddArc(hinhChuNhat.Width - banKinh, hinhChuNhat.Height - banKinh, banKinh, banKinh, 0, 90);
            path.AddArc(hinhChuNhat.X, hinhChuNhat.Height - banKinh, banKinh, banKinh, 90, 90);
            path.CloseFigure();
            return path;
        }
        //ghi đè phương thức onpaint để mở rộng/sửa đổi giao diện button 
        //vẽ button khung tròn tùy thuộc vào bán kính khung
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (banKinhKhung > 2) //button ve khung tron
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, banKinhKhung))
                //button surface
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, banKinhKhung - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(mauKhung, kichThuocKhung))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //button border
                    if (kichThuocKhung >= 1)
                        //draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //button binh thuong
            {
                this.Region = new Region(rectSurface);
                if (kichThuocKhung >= 1)
                {
                    using (Pen penBorder = new Pen(mauKhung, kichThuocKhung))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
