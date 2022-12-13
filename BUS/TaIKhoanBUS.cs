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
    public class TaIKhoanBUS
    {
        TaiKhoanDAO tkDAO;
        public TaIKhoanBUS()
        {
           tkDAO = new TaiKhoanDAO();
        }
        public DataTable HienThi(string str)
        {
            return tkDAO.HienThi(str);
        }
        public void CapNhatTaiKhoan(TaiKhoan tk)
        {
            tkDAO.CapNhat(tk);
        }
        public void CapNhatMatKhau(TaiKhoan tk)
        {
            tkDAO.CapNhatMatKhau(tk);
        }
    }
}
