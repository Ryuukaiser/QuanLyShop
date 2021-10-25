using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace PhanMemQuanLyShop_00.Model
{
    class HoaDonMod
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
        //load dữ liệu cho grid
        public DataTable HienThiThongTinHoaDon()
        {
            MoKetNoi();
            string sql = "SELECT * FROM [VitaminHouse].[dbo].[ChiTietHoaDon]";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongKetNoi();
            return dt;
        }
        //Thêm 1 hóa dơn mới
        public bool ThemHoaDon(string maChiTietHoaDon, string maBanHang, string maHang, string soLuong, string giaBan, string thanhTien, string tenHang)
        {
            string sqlThem = "INSERT INTO [VitaminHouse].[dbo].[ChiTietHoaDon] ([MaChiTietHoaDon],[MaBanHang],[MaHang],[SoLuong],[GiaBan],[ThanhTien],[TenHang]) VALUES ('" + maChiTietHoaDon + "','" + maBanHang + "', '" + maHang + "', '" + soLuong + "','" + giaBan + "','" + thanhTien + "',N'" + tenHang + "')";
            bool kt = false;
            if (ExecuteNonQuery(sqlThem) > 0)
            {
                kt = true;
            }
            return kt;
        }
        //Sửa thông tin hóa đơn
        public bool SuaHoaDon(string maChiTietHoaDon, string maBanHang, string maHang, string soLuong, string giaBan, string thanhTien, string tenHang)
        {
            string sqlSua = " UPDATE [VitaminHouse].[dbo].[ChiTietHoaDon] SET [MaChiTietHoaDon] = '" + maChiTietHoaDon + "',[MaBanHang] = '" + maBanHang + "',[MaHang] = '" + maHang + "',[SoLuong] = '" + soLuong + "',[GiaBan] = '" + giaBan + "',[ThanhTien] = '" + thanhTien + "',[TenHang]='" + tenHang + "' WHERE [MachiTietHoaDon] = '" + maChiTietHoaDon + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlSua) > 0)
            {
                kt = true;
            }
            return kt;
        }
        //Xóa hóa đơn
        public bool XoaHoaDon(string machiTietHoaDon)
        {
            string sqlXoa = "DELETE FROM [VitaminHouse].[dbo].[ChiTietHoaDon] WHERE MaChiTietHoaDon='" + machiTietHoaDon + "'";
            bool kt = false;
            if (ExecuteNonQuery(sqlXoa) > 0)
            {
                kt = true;
            }
            return kt;
        }
    }
}
