﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FDangNhap());
            NguoiMua ngmua = new NguoiMua("NM01");
            Application.Run(new FNguoiMua(ngmua));
            //Application.Run(new FNguoiBan("NB01"));
            //Application.Run(new FMuaHang("NM01"));
            //Application.Run(new Loading());
        }
    }
}
