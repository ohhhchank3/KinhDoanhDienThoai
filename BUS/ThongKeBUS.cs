using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class ThongKeBUS
    {
        private ThongKeDAO tkDAO;
        public ThongKeBUS()
        {
            tkDAO = new ThongKeDAO();
        }
        public DataTable DoanhSo(DateTime ngaybd, DateTime ngaykt)
        {
            return tkDAO.DoanhSo(ngaybd, ngaykt);
        }
        public DataTable SanPhamHetHang()
        {
            return tkDAO.SanPhamHetHang();
        }
        public DataTable SanPhamBanChay(DateTime ngaybd, DateTime ngaykt)
        {
            return tkDAO.SanPhamBanChay(ngaybd, ngaykt);
        }
    }
}
