using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
       SanPhamDAO spDAO;
        public SanPhamBUS()
        {
            spDAO = new SanPhamDAO();
        }
        public DataTable HienThiDanhSach()
        {
            return spDAO.HienThi();
        }
        public void ThemSanPham(SanPham sp)
        {
            spDAO.ThemSanPham(sp);
        }
        public void CapNhatSanPham(SanPham sp)
        {
            spDAO.CapNhatSanPham(sp);
        }
        public void XoaSanPham(string str)
        {
            spDAO.XoaSanPham(str);
        }
    }
}
