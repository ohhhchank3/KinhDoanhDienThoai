using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietSanPham
    {
        private string masanpham, tensanpham, hangsx, mausac, boxuly, hedieuhanh, nhacungcap, tgbaohanh, ghichu, hinhanh;
        private int ram, bonho;
        private float camtruoc, camsau;
        private int soluong,dongia,thanhtien;
        private DateTime ngayban;
        private string madonhang, maCTDH;
        private string tongtien, taikhoan;

       public ChiTietSanPham(string madonhang,string masanpham,int soluong,int thanhtien,int dongia)
        {
            this.madonhang = madonhang;
            this.masanpham = masanpham;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
            this.dongia = dongia;
        }
       public ChiTietSanPham(DateTime ngayban,string taikhoan, int thanhtien)
        {
            this.ngayban = ngayban;
            this.taikhoan = taikhoan;
            this.thanhtien = thanhtien;
        }
        public ChiTietSanPham(string madonhang,DateTime ngayban,string taikhoan,string tongtien)
        {
            this.madonhang = madonhang;
            this.ngayban = ngayban;
            this.taikhoan = taikhoan;
            this.tongtien = tongtien;
        }
        public float Camtruoc { get => camtruoc; set => camtruoc = value; }
        public float Camsau { get => camsau; set => camsau = value; }
        public int Ram { get => ram; set => ram = value; }
        public int Bonho { get => bonho; set => bonho = value; }
        public string Masanpham { get => masanpham; set => masanpham = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public string Hangsx { get => hangsx; set => hangsx = value; }
        public string Mausac { get => mausac; set => mausac = value; }
        public string Boxuly { get => boxuly; set => boxuly = value; }
        public string Hedieuhanh { get => hedieuhanh; set => hedieuhanh = value; }
        public string Nhacungcap { get => nhacungcap; set => nhacungcap = value; }
        public string Tgbaohanh { get => tgbaohanh; set => tgbaohanh = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public DateTime Ngayban { get => ngayban; set => ngayban = value; }
        public string Madonhang { get => madonhang; set => madonhang = value; }
        public string MaCTDH { get => maCTDH; set => maCTDH = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
    }
}