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
    public  class HangSXDAO : DBConnection
    {
        public HangSXDAO() : base() { }
        public DataTable HienThi()
        {
            string sql = "select * from HANGSX";
            return executeDisplayQuery(sql);
        }
        public void ThemHangSX(HangSX dh)
        {
            const string sql = "THEMHANGSX @TenHang,@DiaChi";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TenHang", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(dh.TenHang1);
            sqlParameters[1] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(dh.DiaChi1);
         

            executeInsertQuery(sql, sqlParameters);
        }
        public void CapNhatHangSX(HangSX dh)
        {
            const string sql = "CAPNHATHANGSX @MaHang,@TenHang,@DiaChi";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaHang", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(dh.MaHang1);
            sqlParameters[1] = new SqlParameter("@TenHang", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(dh.TenHang1);
            sqlParameters[2] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(dh.DiaChi1);

            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
        public void XoaHangSX(string str)
        {
            const string sql = "XOAHANGSX @MaHang";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaHang", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(str);
            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
    }
}
