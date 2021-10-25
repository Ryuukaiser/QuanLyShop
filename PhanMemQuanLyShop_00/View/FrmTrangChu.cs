using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace PhanMemQuanLyShop_00.View
{
    public partial class FrmTrangChu : DevExpress.XtraEditors.XtraForm
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }

       
        private byte[] ChuyenThanhDangByte()
        {
            FileStream fs;
            fs = new FileStream(txtLinkAnh.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}