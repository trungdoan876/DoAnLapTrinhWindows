using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;

namespace DoANLapTrinhWin
{
    public class DropdownMenu : ContextMenuStrip
    {
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.DimGray;
        private Color primaryColor = Color.MediumVioletRed;
        private Bitmap menuItemHeaderSize;

        public DropdownMenu(IContainer container) : base(container)
        {

        }
        [Browsable(false)]
        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }
        [Browsable(false)]
        public int MenuItemHeight { get => menuItemHeight; set => menuItemHeight = value; }
        [Browsable(false)]
        public Color MenuItemTextColor { get => menuItemTextColor; set => menuItemTextColor = value; }
        [Browsable(false)]
        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }
        [Browsable(false)]
        private void LoadMenuItemAppearance()
        {
            if (isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.Gainsboro;
            }
            else
            {
                menuItemHeaderSize = new Bitmap(15, menuItemHeight);
            }
            foreach(ToolStripMenuItem menuItem1 in this.Items)
            {
                menuItem1.ForeColor = menuItemTextColor;
                menuItem1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItem1.Image == null) menuItem1.Image = menuItemHeaderSize;
                foreach (ToolStripMenuItem menuItem2 in menuItem1.DropDownItems)
                {
                    menuItem2.ForeColor = menuItemTextColor;
                    menuItem2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItem2.Image == null) menuItem2.Image = menuItemHeaderSize;
                    foreach (ToolStripMenuItem menuItem3 in menuItem1.DropDownItems)
                    {
                        menuItem3.ForeColor = menuItemTextColor;
                        menuItem3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItem3.Image == null) menuItem3.Image = menuItemHeaderSize;

                    }

                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if(this.DesignMode == false )
            {
                LoadMenuItemAppearance();
                this.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
            }
        }
    }   
}
