using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonHang
    {
        private int maDonHang, soLuong, donGia, thanhTien;
        private string maSanPham, maCTDH;
        public ChiTietDonHang(string maCTDH,int maDonHang, int soLuong, int donGia, int thanhTien, string maSanPham)
        {
            this.MaCTDH = maCTDH;
            this.MaDonHang = maDonHang;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
            this.maSanPham = maSanPham;
        }
        public ChiTietDonHang( int maDonHang, int soLuong, int donGia, int thanhTien, string maSanPham)
        {
         
            this.MaDonHang = maDonHang;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
            this.maSanPham = maSanPham;
        }

        public int MaDonHang { get => maDonHang; set => maDonHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string MaSanPham1 { get => maSanPham; set => maSanPham = value; }
        public string MaCTDH { get => maCTDH; set => maCTDH = value; }
    }
}
