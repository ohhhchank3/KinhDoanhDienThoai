using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKeDAO : DBConnection
    {
        public ThongKeDAO() : base() { }
        public DataTable DoanhSo(DateTime ngaybd, DateTime ngaykt)
        {
            string ngayden = ngaybd.ToString("yyyy-MM-dd");
            string ngayket = ngaykt.ToString("yyyy-MM-dd");
            string sql = "ThongKeDoanhSo  '" + ngayden + "','" + ngayket + "'";
            return executeDisplayQuery(sql);
        }
        public DataTable SanPhamHetHang()
        {
            string sql = "ThongKeSanPhamHetHang";
            return executeDisplayQuery(sql);
        }
        public DataTable SanPhamBanChay(DateTime ngaybd, DateTime ngaykt)
        {
            string ngayden = ngaybd.ToString("yyyy-MM-dd");
            string ngayket = ngaykt.ToString("yyyy-MM-dd");
            string sql = "ThongKeSanPhamBanChay '" + ngayden + "','" + ngayket + "'";
            return executeDisplayQuery(sql);
        }
    }
}
