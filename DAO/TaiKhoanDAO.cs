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
    public class TaiKhoanDAO : DBConnection
    {
        public TaiKhoanDAO() : base() { }
        public DataTable HienThi(string str)
        {
             string sql = "select * from TAIKHOAN where TaiKhoan='"+str.ToString()+"'";
             return executeDisplayQuery(sql);
        }
        public void CapNhat(TaiKhoan tk)
        {

          const  string sql = "CHINHSUATAIKHOAN @TaiKhoan,@CMND,@TenUS,@SDT,@DiaChi,@Email,@GioiTinh,@NgaySinh";

            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@TaiKhoan", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(tk.MaTK);
            sqlParameters[1] = new SqlParameter("@CMND", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(tk.Cmnd);
            sqlParameters[2] = new SqlParameter("@TenUS", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(tk.Hoten);
            sqlParameters[3] = new SqlParameter("@SDT", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(tk.Sdt);
            sqlParameters[4] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(tk.Diachi);
            sqlParameters[5] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(tk.Email);
            sqlParameters[6] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(tk.Gioitinh);
            sqlParameters[7] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            sqlParameters[7].Value = Convert.ToDateTime(tk.Ngaysinh);

            executeUpdateOrDeleteQuery(sql, sqlParameters);

        }
        public void CapNhatMatKhau(TaiKhoan tk)
        {
            const string sql = "DOIMATKHAU_TK @TaiKhoan,@MatKhau,@MatKhauNew,@MatKhauNew_ReType";

            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@TaiKhoan", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(tk.Tentk);
            sqlParameters[1] = new SqlParameter("@MatKhau", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(tk.Matkhau);
            sqlParameters[2] = new SqlParameter("@MatKhauNew", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(tk.Matkhaumoi);
            sqlParameters[3] = new SqlParameter("@MatKhauNew_ReType", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(tk.Xacnhanmatkhau);
            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
    }
}
