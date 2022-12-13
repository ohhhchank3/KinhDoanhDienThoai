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
    public class MuaHangDAO : DBConnection
    {
        public MuaHangDAO() : base() { }
        public DataTable HienThiHangSanPham()
        {
            string sql = "select * from HANGSX";
            return executeDisplayQuery(sql);
        }
        public DataTable HienThiTenSanPham(string maHang)
        {
            string sql = "select TenSP from SANPHAM where MaHangSX  = '" + maHang + "'";
            return executeDisplayQuery(sql);
        }
        public DataTable LoadSanPham(string tenSP)
        {
            string sql = "select MaSP,TenSP,DonGiaBan,RAM,BoNho,KichThuoc,MauSac from SANPHAM where TenSP = '" + tenSP + "'";
            return executeDisplayQuery(sql);
        }
        public void ThemDonHang(DonHang dh)
        {
            const string sql = "THEMDONHANG @NgayBan,@TaiKhoan,@TongTien";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@NgayBan", SqlDbType.Date);
            sqlParameters[0].Value = Convert.ToDateTime(dh.NgayBan);
            sqlParameters[1] = new SqlParameter("TaiKhoan", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(dh.TaiKhoan);
            sqlParameters[2] = new SqlParameter("@TongTien", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(dh.TongTien);

            executeInsertQuery(sql, sqlParameters);
        }
    }
}
