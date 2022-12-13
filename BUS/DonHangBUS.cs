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
    public class DonHangBUS
    {
        DonHangDAO dhDAO;
        public DonHangBUS()
        {
           dhDAO = new DonHangDAO();
           
        }
        public DataTable HienThi(string phanloai,string taikhoan)
        {
            return dhDAO.HienThi(phanloai, taikhoan); 
        }
        public void ThemDonHang(DonHang dh)
        {
            dhDAO.ThemDonHang(dh);
        }
        public void CapNhatDonHang(DonHang dh)
        {
            dhDAO.CapNhatDonHang(dh);
        }
        public void XoaDonHang(string str)
        {
            dhDAO.XoaDonHang(str);
        }  
    }
}
