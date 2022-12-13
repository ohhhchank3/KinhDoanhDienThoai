using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class ChiTietSanPhamDAO : DBConnection
    {
        public ChiTietSanPhamDAO() : base() { }

        public DataTable LoadSP(string str)
        {
            string sql = "select * from SANPHAM where  MaSP = '" + str + "'";
            return executeDisplayQuery(sql);
        }
        public DataTable loadMaDH(string str)
        {
            string sql = "select MaDH from DONHANG where TaiKhoan = '"+str+"'";
            return executeDisplayQuery(sql);
        }
        public DataTable TimSP(string maSP)
        {
            string sql = "TIMKIEM_SANPHAM '" + maSP + "'";
            return executeDisplayQuery(sql);
        }
        public DataTable TimMaDH(DateTime ngaymua, string taikhoan)
        {
            string sql = "select MaDH from DONHANG where NgayBan = @Ngaymua and TaiKhoan = @taikhoan";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Ngaymua", SqlDbType.Date);
            sqlParameters[0].Value = Convert.ToDateTime(ngaymua);
            sqlParameters[1] = new SqlParameter("@taikhoan", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(taikhoan);
            return executeFindQuery(sql,sqlParameters);
        }
        public void MuaHang(ChiTietSanPham ctdh)
        {

            string sql = "THEM_CHITIETDONHANG @MaDH,@MaSP,@SoLuong,@DonGia,@ThanhTien";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@MaDH", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(ctdh.Madonhang);
            sqlParameters[1] = new SqlParameter("@MaSP", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(ctdh.Masanpham);
            sqlParameters[2] = new SqlParameter("@SoLuong", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(ctdh.Soluong);
            sqlParameters[3] = new SqlParameter("@DonGia", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(ctdh.Dongia);
            sqlParameters[4] = new SqlParameter("@ThanhTien", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(ctdh.Thanhtien);

            executeInsertQuery(sql, sqlParameters);
        }
        public void ThemDonHang(ChiTietSanPham dh)
        {
            const string sql = "THEMDONHANG @NgayBan,@TaiKhoan,@TongTien";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@NgayBan", SqlDbType.Date);
            sqlParameters[0].Value = Convert.ToDateTime(dh.Ngayban);
            sqlParameters[1] = new SqlParameter("TaiKhoan", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(dh.Taikhoan);
            sqlParameters[2] = new SqlParameter("@TongTien", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(dh.Tongtien);

            executeInsertQuery(sql, sqlParameters);
        }
    }
}
