using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHang
    {
        private int maDonHang, tongTien;
        private DateTime ngayBan;
        private string taiKhoan;
        public DonHang(int maDonHang, int tongTien, DateTime ngayBan, string taiKhoan)
        {
            this.maDonHang = maDonHang;
            this.tongTien = tongTien;
            this.ngayBan = ngayBan;
            this.taiKhoan = taiKhoan;
        }
        public DonHang(int maDonHang, int tongTien, DateTime ngayBan)
        {
            this.maDonHang = maDonHang;
            this.tongTien = tongTien;
            this.ngayBan = ngayBan;
        }
        public DonHang(int tongTien, DateTime ngayBan, string taiKhoan)
        {
         
            this.tongTien = tongTien;
            this.ngayBan = ngayBan;
            this.taiKhoan = taiKhoan;
        }
        public int MaDonHang { get => maDonHang; set => maDonHang = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
    }
}
