using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PhanMemQuanLyShop_00.View
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        public class LuuNguoiDangNhap
        {
            public static string ten; //gán tên này cho tên hiển thị trên chương trình, biết người đang dùng phần mềm
            public static string quyen;
        }

        string path;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            path = Path.GetFullPath(Environment.CurrentDirectory);
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VitaminHouse;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTaiKhoan.Text.Trim();
                string mk = txtMatKhau.Text.Trim();
                string quyen = cbBoxLoaiTk.Text.Trim();
                string sql = "SELECT *FROM DangNhap where TenDangNhap = '" + tk + "'and MatKhau='" + mk + "'and LoaiTaiKhoan='" + quyen + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    LuuNguoiDangNhap.ten = txtTaiKhoan.Text.Trim();
                    LuuNguoiDangNhap.quyen = cbBoxLoaiTk.Text.Trim();
                    this.Hide();
                    FrmMain f = new FrmMain();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai tên đăng nhập, hoặc tài khoản");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình? ", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;

        }
    }
}
