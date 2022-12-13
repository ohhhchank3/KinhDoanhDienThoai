using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MuaHangBUS
    {
        MuaHangDAO mhDAO;
        public MuaHangBUS()
        {
            mhDAO = new MuaHangDAO();
        }
        public DataTable loadHangSX()
        {
            return mhDAO.HienThiHangSanPham();
        }
        public DataTable loadTenSP(string maHang)
        {
            return mhDAO.HienThiTenSanPham(maHang);
        }
        public DataTable loadSP(string tenSP)
        {
            return mhDAO.LoadSanPham(tenSP);
        }
    }
}
