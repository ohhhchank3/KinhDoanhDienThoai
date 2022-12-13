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
    public class KhachHangDAO : DBConnection
    {
        public KhachHangDAO() : base() { }
        /*
        public void ThemNV(TaiKhoan kh)
        {
            const string sql = "insert into NHANVIEN(MaNV, CMND, TenNV, GioiTinh, NgaySinh, SDT, DiaChi) values(@MaNV, @CMND, @TenNV, @GioiTinh, @NgaySinh, @SDT, @DiaChi)";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@MaNV", SqlDbType.Char);
            sqlParameters[0].Value = Convert.ToString(nv.MaNV);
            sqlParameters[1] = new SqlParameter("@CMND", SqlDbType.Char);
            sqlParameters[1].Value = Convert.ToString(nv.CMND);
            sqlParameters[2] = new SqlParameter("@TenNV", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(nv.TenNV);
            sqlParameters[3] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(nv.GioiTinh);
            sqlParameters[4] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            sqlParameters[4].Value = Convert.ToString(nv.NgaySinh);
            sqlParameters[5] = new SqlParameter("@SDT", SqlDbType.Char);
            sqlParameters[5].Value = Convert.ToString(nv.SDT);
            sqlParameters[6] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(nv.DiaChi);

            executeInsertQuery(sql, sqlParameters);
        }*/
        public void XoaKH(String tenTK)
        {
            const string sql = "XOATAIKHOAN @TenTaiKhoan";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TenTaiKhoan", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(tenTK);

            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
        public void SuaKH(TaiKhoan kh)
        {
            const string sql = "ChinhSuaTaiKhoan @TaiKhoan, @CMND, @TenKH, @SDT, @DiaChi, @Email, @GioiTinh, @NgaySinh";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@TaiKhoan", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(kh.Tentk);
            sqlParameters[1] = new SqlParameter("@CMND", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(kh.Cmnd);
            sqlParameters[2] = new SqlParameter("@TenKH", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(kh.Hoten);
            sqlParameters[3] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(kh.Gioitinh);
            sqlParameters[4] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            sqlParameters[4].Value = Convert.ToDateTime(kh.Ngaysinh);
            sqlParameters[5] = new SqlParameter("@SDT", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(kh.Sdt);
            sqlParameters[6] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(kh.Diachi);
            sqlParameters[7] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[7].Value = Convert.ToString(kh.Email);

            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
        public DataTable HienThi()
        {
            const string sql = "select * from XEMKHACHHANG";
            return executeDisplayQuery(sql);
        }
    }
}
