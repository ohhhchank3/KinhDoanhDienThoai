using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MuaHang
    {
        private string HangSanPham;
        private string TenSanPham;

        private MuaHang(string hangsanpham,string tensanpham)
        {
            this.HangSanPham = hangsanpham;
            this.TenSanPham=tensanpham;
        }
        public string HangSanPham1 { get => HangSanPham; set => HangSanPham = value; }
        public string TenSanPham1 { get => TenSanPham; set => TenSanPham = value; }
    }
}
