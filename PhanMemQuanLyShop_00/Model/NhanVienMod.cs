using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;


namespace PhanMemQuanLyShop_00.Model
{
    class NhanVienMod
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        string path;
        //đóng mở kết nối csdl
        public void MoKetNoi()
        {
            try
            {
                if (conn == null)
                {
                    path = Path.GetFullPath(Environment.CurrentDirectory);
                    conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VitaminHouse;Integrated Security=True");
                }
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu");
            }
        }
        public void DongKetNoi()
        {
            try
            {
                if ((conn != null) && (conn.State == ConnectionState.Open))
                    conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!!!");
            }
        }
        //Load dữ liệu cho datagidview
        public DataTable HienThiDuLieu() //trả về 1 bảng
        {
            MoKetNoi();
            string sql = "SELECT * FROM [VitaminHouse].[dbo].[NhanVien]";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongKetNoi();
            return dt;
        }
        //Phương thức sử dụng cho thêm sửa xóa
        public int ExecuteNonQuery(string sql)
        {
            int dung = 0;
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dung = cmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            { }
            return dung;
        }

        //Thêm 1 tài khoản mới
        public bool ThemNhanVien(string maNhanVien, string hoTen,string CMND ,string diaChi, string soDienThoai)
        {
            string sqlThem = "INSERT INTO [VitaminHouse].[dbo].[NhanVien]([MaNhanVien],[HoTen],[CMND],[DiaChi],[SDT]) VALUES (N'" + maNhanVien + "',N'" + hoTen + "',N'" + CMND + "',N'" + diaChi + "',N'" + soDienThoai + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        //Sửa thông tin tài khoản
        public bool SuaNhanVien(string maNhanVien, string hoTen, string CMND, string diaChi, string soDienThoai)
        {
            string sqlSua = "UPDATE [VitaminHouse].[dbo].[NhanVien] SET [MaNhanVien] = N'" + maNhanVien + "',[HoTen] =  N'" + hoTen + "',[CMND] =  N'" + CMND + "',[DiaChi] = N'" + diaChi + "',[SDT] =  N'" + soDienThoai + "' WHERE maNhanVien='"+maNhanVien+"'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
        //Xóa tài khoản
        public bool XoaNhanVien(string maNhanVien)
        {
            string sqlXoa = "DELETE FROM [VitaminHouse].[dbo].[NhanVien] WHERE MaNhanVien='" + maNhanVien+ "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
    }
}
