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
  public class DonHangDAO : DBConnection
    {
        public DonHangDAO() : base() { }
        //private void checkKH(string str,string str2)
        //{
        //    if (str == "KH")
        //    {
        //        string sql = "select * from DONHANG where  TaiKhoan = '" + str + "' ";
        //    }
        //    else
        //    {
        //        string sql = "select * from DONHANG ";
        //    }    
        //}
        public DataTable HienThi(string phanloai,string taikhoan)
        {
            if (phanloai == "KH")
            {
                string sql = "XEMDONHANG_KHACHHANG '" + taikhoan + "'";
                return executeDisplayQuery(sql);
            }
            else
            {
                string sql = "select * from XEMDONHANG";
                return executeDisplayQuery(sql);
            }   
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
        public void CapNhatDonHang(DonHang dh)
        {
            const string sql1 = "SUADONHANG @MaDH,@NgayBan,@TongTien";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaDH", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(dh.MaDonHang);
            sqlParameters[1] = new SqlParameter("@NgayBan", SqlDbType.Date);
            sqlParameters[1].Value = Convert.ToDateTime(dh.NgayBan);
          //  sqlParameters[2] = new SqlParameter("TaiKhoan", SqlDbType.NVarChar);
          //  sqlParameters[2].Value = Convert.ToString(dh.TaiKhoan);
            sqlParameters[2] = new SqlParameter("@TongTien", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(dh.TongTien);

            executeUpdateOrDeleteQuery(sql1, sqlParameters);
        }
        public void XoaDonHang(string str)
        {
            const string sql1 = "XOADONHANG @MaDH";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaDH", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(str);

            executeUpdateOrDeleteQuery(sql1, sqlParameters);
        }
        public DataTable LoadTenKH(string str)
        {
            string sql = "select TenUS from TAIKHOAN WHERE TaiKhoan = '" + str + "'";

            return executeDisplayQuery(sql);
        }

    }
}
