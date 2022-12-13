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
    public class KhachHangBUS
    {
        private KhachHangDAO khDAO;
        public KhachHangBUS()
        {
            khDAO = new KhachHangDAO();
        }
        public void XoaKH(String MaKH)
        {
            khDAO.XoaKH(MaKH);
        }
        public void SuaKH(TaiKhoan kh)
        {
            khDAO.SuaKH(kh);
        }
        public DataTable HienThi()
        {
            return khDAO.HienThi();
        }  
    }
}
