using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using PhanMemQuanLyShop_00.View;

namespace PhanMemQuanLyShop_00
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            //Application.Run(new FrmTrangHienThi());
            //Application.Run(new FrmMain());
            Application.Run(new FrmDangNhap());
        }
    }
}