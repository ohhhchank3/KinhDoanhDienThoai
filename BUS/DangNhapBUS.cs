using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public  class DangNhapBUS
    {
        DangNhapDAO dnDAO;
        public DangNhapBUS()
        {
           dnDAO = new DangNhapDAO();
        }
        public DataTable DangNhap(DangNhap dn)
        {
            return dnDAO.HienThi(dn);
        }
        public void QuenMatKhau(DangNhap dn)
        {
            dnDAO.QuenMatKhau(dn);
        }
        public void DANGKYTAIKHOAN(DangNhap dn)
        {
            dnDAO.DangKyTaiKhoan(dn);
        }
    }
}
