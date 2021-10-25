using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PhanMemQuanLyShop_00.View;

namespace PhanMemQuanLyShop_00.View
{
    public partial class FrmTrangHienThi : DevExpress.XtraEditors.XtraForm
    {
        public FrmTrangHienThi()
        {
            InitializeComponent();
        }
        public void OpenForm<T>()
        {
            var f = MdiChildren.FirstOrDefault(i => i is T); //Kiểm tra form có phải là T ko (cái T là tên form)
            if (f == null)
            {
                f = Activator.CreateInstance<T>() as Form;
                f.MdiParent = this;
                f.Show();
            }
            else f.Activate();
        }

        private void FrmTrangHienThi_Load(object sender, EventArgs e)
        {
            OpenForm<FrmTrangChu>();
            btnTrangChinh.Enabled = btnChuyenTk.Enabled = false;
        }
                private void FrmTrangHienThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FrmDangNhap f = new FrmDangNhap();
            f.ShowDialog();
        }

        private void btnThoatCt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnBanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MessageBox.Show("Đăng nhập để sử dụng tính năng này.","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void btnNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MessageBox.Show("Đăng nhập để sử dụng tính năng này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnDiDong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MessageBox.Show("Đăng nhập để sử dụng tính năng này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void navBarControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập để sử dụng tính năng này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnThongBao_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MessageBox.Show("Đăng nhập để sử dụng tính năng này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
              
    }
}