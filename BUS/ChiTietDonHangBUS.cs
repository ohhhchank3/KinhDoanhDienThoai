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
    public class ChiTietDonHangBUS
    {
        ChiTietDonHangDAO ctdhDAO;
        public ChiTietDonHangBUS()
        {
           ctdhDAO = new ChiTietDonHangDAO();
        }
        public  DataTable DuLieu(string maDH)
        {
            return  ctdhDAO.HienThi(maDH);
        }  
        //public DataTable LoadSanPham()
        //{
        //    return ctdhDAO.loadSanPham();
        //}
        //public DataTable LoadTenSanPham(string str)
        //{
        //    return ctdhDAO.loadTenSanPham(str);
        //}
        public void ThemCTDH(ChiTietDonHang ct)
        {
            ctdhDAO.ThemCTDH(ct);   
        }    
        public void SuaCTDH(ChiTietDonHang ct)
        {
            ctdhDAO.CapNhatCTDH(ct);
        }
        public void XoaCTDH(string maCTDH)
        {
            ctdhDAO.XoaCTDH(maCTDH); 
        }    
    }
}
