using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DoANLapTrinhWin
{
    public class MoreMenu : ProfessionalColorTable
    {
        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuSelectedBorderColor;

        public MoreMenu(bool isMainMenu, Color primaryColor)
        {
            if (isMainMenu)
            {
                backColor = Color.FromArgb(37, 39, 60);
                leftColumnColor = Color.FromArgb(32, 33, 51);
                borderColor = Color.FromArgb(32, 33, 51);
                menuItemBorderColor = primaryColor;
                menuSelectedBorderColor = primaryColor;
            }
            else
            {
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBorderColor = primaryColor;
                menuSelectedBorderColor = primaryColor;
            }
        }
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backColor;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return borderColor;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return menuItemBorderColor;
            }
        }
        public override Color MenuItemSelected
        {
            get
            {
                return menuSelectedBorderColor;
            }
        }
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return leftColumnColor;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return leftColumnColor;
            }
        }
        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return leftColumnColor;
            }
        }
    }
}
