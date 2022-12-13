using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietSanPhamBUS
    {
        ChiTietSanPhamDAO ctspDAO;
        public ChiTietSanPhamBUS()
        {
            ctspDAO = new ChiTietSanPhamDAO();
        }
        public DataTable LoadSP(string str)
        {
            return ctspDAO.LoadSP(str);
        }
        public DataTable TimSP(string maSP)
        {
            return ctspDAO.TimSP(maSP);
        }
        public DataTable TimMaDH(DateTime ngaymua, string taikhoan)
        {
            return ctspDAO.TimMaDH(ngaymua, taikhoan);
        }
        public void MuaHang(ChiTietSanPham ctsp)
        {
            ctspDAO.MuaHang(ctsp);
        }
        public void TaoDonHangMoi(ChiTietSanPham ctsp)
        {
            ctspDAO.ThemDonHang(ctsp);
        }
        public DataTable loadMaDH(string str)
        {
            return ctspDAO.loadMaDH(str);
        }
    }
}
