using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string maKhachHang, tenKhachHang, gioiTinh, diaChi, sdt, email;
        private DateTime ngaySinh;
        public KhachHang(string maKhachHang, string tenKhachHang, string gioiTinh, string diaChi, string sdt, string email, DateTime ngaySinh)
        {
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.Email = email;
            this.NgaySinh = ngaySinh;
        }

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
