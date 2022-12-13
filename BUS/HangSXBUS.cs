using DAO;
using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HangSXBUS
    {
        HangSXDAO sxDAO;
        public HangSXBUS()
        {
           sxDAO = new HangSXDAO();
        }
        public DataTable HienThi()
        {
            return sxDAO.HienThi();
        }  
        public void ThemHangSX(HangSX sx)
        {
            sxDAO.ThemHangSX(sx);
        }
        public void CapNhatHangSX(HangSX sx)
        {
            sxDAO.CapNhatHangSX(sx);
        }
        public void XoaHangSX(string str)
        {
            sxDAO.XoaHangSX(str);
        }    
    }
}
