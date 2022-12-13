using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap
    {
        private string email, newpassword, retypenewpassword, tenkh, cmnd, gioitinh, TenTaiKhoan, Password, ReTypePassword, DiaChi;
        private DateTime ngaysinh;
        private string sdt;
      
        public  DangNhap(string TenTaiKhoan,string password)
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.Password = password;
        }
        public DangNhap(string email,string newpassword,string retypenewpassword)
        {
            this.email = email;
            this.newpassword = newpassword;
            this.retypenewpassword = retypenewpassword;
        }
        public DangNhap(string tenkh,string cmnd, DateTime ngaysinh, string gioitinh, string sdt, string email, string diaChi1,string tenTaiKhoan1, string password1, string reTypePassword1 )
        {
            this.tenkh = tenkh;
            this.cmnd = cmnd;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.email = email;
            this.DiaChi = diaChi1;
            this.TenTaiKhoan = tenTaiKhoan1;
            this.Password = password1;
            this.ReTypePassword = reTypePassword1;
        }

        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Newpassword { get => newpassword; set => newpassword = value; }
        public string Retypenewpassword { get => retypenewpassword; set => retypenewpassword = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string ReTypePassword1 { get => ReTypePassword; set => ReTypePassword = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
