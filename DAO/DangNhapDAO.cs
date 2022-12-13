using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class DangNhapDAO : DBConnection
    {
         public DangNhapDAO() : base() { }
        public DataTable HienThi(DangNhap dn)
        {
            string sql = "select * from DANGNHAP(@TaiKhoan,@MatKhau)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TaiKhoan", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(dn.TenTaiKhoan1);
            sqlParameters[1] = new SqlParameter("@MatKhau", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(dn.Password1);

            return executeSearchQuery(sql, sqlParameters);
        }
        public void QuenMatKhau(DangNhap dn)
        {
            const string sql = "QuenMatKhau @Email,@MatKhau,@MatKhau_ReType";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@Email", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(dn.Email);
            sqlParameters[1] = new SqlParameter("@MatKhau", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(dn.Newpassword);
            sqlParameters[2] = new SqlParameter("@MatKhau_ReType", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(dn.Retypenewpassword);

            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
        public void DangKyTaiKhoan(DangNhap dn)
        {
            string s1 = "KH";
            const string sql = "DANGKYTAIKHOAN @TaiKhoan,@MatKhau,@PhanLoai,@CMND,@TenUS,@SDT,@DiaChi,@Email,@GioiTinh,@NgaySinh";
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("TaiKhoan", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(dn.TenTaiKhoan1);
            sqlParameters[1] = new SqlParameter("@MatKhau", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(dn.Password1);
            sqlParameters[2] = new SqlParameter("PhanLoai", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(s1);
            sqlParameters[3] = new SqlParameter("CMND", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(dn.Cmnd);
            sqlParameters[4] = new SqlParameter("@TenUS", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(dn.Tenkh);
            sqlParameters[5] = new SqlParameter("@SDT",SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(dn.Sdt);
            sqlParameters[6] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(dn.DiaChi1);
            sqlParameters[7] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[7].Value = Convert.ToString(dn.Email);
            sqlParameters[8] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(dn.Gioitinh);
            sqlParameters[9] = new SqlParameter("NgaySinh", SqlDbType.Date);
            sqlParameters[9].Value = Convert.ToDateTime(dn.Ngaysinh);

            executeInsertQuery(sql, sqlParameters);
        }
    }
}
