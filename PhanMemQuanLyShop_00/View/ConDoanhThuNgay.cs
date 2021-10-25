using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PhanMemQuanLyShop_00.Controller;

namespace PhanMemQuanLyShop_00.View
{
    public partial class ConDoanhThuNgay : DevExpress.XtraEditors.XtraForm
    {
        ThongKeDoanhThuControl TKdoanhThu = new ThongKeDoanhThuControl();
        public ConDoanhThuNgay()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTheoNgay = new DataTable();
                dtTheoNgay = TKdoanhThu.HienThiDoanhThuNgay(txtTuNgay.Text.Trim(), txtDenNgay.Text.Trim());
                gridControl1.DataSource = dtTheoNgay;
                txtTong.EditValue = colThanhTien.SummaryItem.SummaryValue;
            }
            catch { }
        }

        private void ConDoanhThuNgay_Load(object sender, EventArgs e)
        {
            txtTong.Text = "0";
        }

        private void grChucNang_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}