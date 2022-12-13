using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class HangSX
    {
        private string TenHang, DiaChi;
        private int MaHang;
        public HangSX(string TenHang,string DiaChi)
        {
            this.TenHang = TenHang;
            this.DiaChi = DiaChi;
        }
        public HangSX(int MaHang,string TenHang, string DiaChi)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.DiaChi = DiaChi;
        }

        public int MaHang1 { get => MaHang; set => MaHang = value; }
        public string TenHang1 { get => TenHang; set => TenHang = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    }
}
