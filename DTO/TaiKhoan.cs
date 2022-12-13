using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string maTK, hoten, cmnd, gioitinh, sdt, diachi, email, maUS;
        private DateTime ngaysinh;
        private string tentk, matkhau, matkhaumoi, xacnhanmatkhau;
        public TaiKhoan(string maTK, string hoten, string cmnd, string gioitinh, string sdt, string diachi, string email,string maUS,DateTime ngaysinh)
        {
            this.MaTK = maTK;
            this.Hoten = hoten;
            this.Cmnd = cmnd;   
            this.Gioitinh = gioitinh;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.Email = email;
            this.MaUS = maUS;
            this.Ngaysinh = ngaysinh;
        }

        public TaiKhoan(string tenTK, string Cmnd, string tenKH, string sdt, string diachi, string email, string gioitinh, DateTime ngaysinh)
        {
            this.Tentk = tenTK;
            this.Cmnd = Cmnd;
            this.Hoten = tenKH;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.Email = email;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
        }
        public TaiKhoan(string tentk,string matkhau,string matkhaumoi,string xacnhanmatkhau)
        {
            this.Tentk = tentk;
            this.Matkhau=matkhau;
            this.Matkhaumoi = matkhaumoi;
            this.Xacnhanmatkhau = xacnhanmatkhau;
        }

        public string Tentk { get => tentk; set => tentk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Matkhaumoi { get => matkhaumoi; set => matkhaumoi = value; }
        public string Xacnhanmatkhau { get => xacnhanmatkhau; set => xacnhanmatkhau = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string MaTK { get => maTK; set => maTK = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string MaUS { get => maUS; set => maUS = value; }
    }
}
