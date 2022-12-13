using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        private string maSanPham, tenSanPham, mauSac, boXuLy, heDieuHanh, nhaCungCap, thoiHanBH, ghiChu, hinhAnh;
        private int soLuong, donGiaNhap, donGiaBan, boNho, ram, maHangSX;
        private float kichThuoc, camTruoc, camSau;
        private DateTime namSX;
        public SanPham(string maSanPham, string tenSanPham, string mauSac, string boXuLy, string heDieuHanh, string nhaCungCap, string thoiHanBH, string ghiChu, string hinhAnh, int soLuong, int donGiaNhap, int donGiaBan, int boNho, int ram, int maHangSX, float kichThuoc, float camTruoc, float camSau, DateTime namSX)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.MauSac = mauSac;
            this.BoXuLy = boXuLy;
            this.HeDieuHanh = heDieuHanh;
            this.NhaCungCap = nhaCungCap;
            this.ThoiHanBH = thoiHanBH;
            this.GhiChu = ghiChu;
            this.HinhAnh = hinhAnh;
            this.SoLuong = soLuong;
            this.DonGiaNhap = donGiaNhap;
            this.DonGiaBan = donGiaBan;
            this.BoNho = boNho;
            this.Ram = ram;
            this.MaHangSX = maHangSX;
            this.KichThuoc = kichThuoc;
            this.CamTruoc = camTruoc;
            this.CamSau = camSau;
            this.NamSX = namSX;
        }

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }
        public string BoXuLy { get => boXuLy; set => boXuLy = value; }
        public string HeDieuHanh { get => heDieuHanh; set => heDieuHanh = value; }
        public string NhaCungCap { get => nhaCungCap; set => nhaCungCap = value; }
        public string ThoiHanBH { get => thoiHanBH; set => thoiHanBH = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public int DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public int BoNho { get => boNho; set => boNho = value; }
        public int Ram { get => ram; set => ram = value; }
        public int MaHangSX { get => maHangSX; set => maHangSX = value; }
        public float KichThuoc { get => kichThuoc; set => kichThuoc = value; }
        public float CamTruoc { get => camTruoc; set => camTruoc = value; }
        public float CamSau { get => camSau; set => camSau = value; }
        public DateTime NamSX { get => namSX; set => namSX = value; }
    }
}
