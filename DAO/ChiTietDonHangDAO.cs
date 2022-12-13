using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietDonHangDAO : DBConnection
    {
        public ChiTietDonHangDAO() : base() { }
        public DataTable HienThi(string maDH)
        {
            string sql = "XEMCHITIETDONHANG '" + maDH + "'";     
            return executeDisplayQuery(sql);
        }
        //public DataTable loadSanPham()
        //{
        //    string sql = "select MaSP from SANPHAM";
        //    return executeDisplayQuery(sql);
        //}
        //public DataTable loadTenSanPham(string str)
        //{
        //    string sql = "select TenSP,DonGiaBan from SANPHAM WHERE MaSP = '" + str + "'";
        //    return executeDisplayQuery(sql);
        //}
        public void ThemCTDH(ChiTietDonHang ctdh)
        {

            string sql = "THEM_CHITIETDONHANG @MaDH, @MaSP, @SoLuong,@DonGia,@ThanhTien";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@MaDH", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(ctdh.MaDonHang);
            sqlParameters[1] = new SqlParameter("@MaSP", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(ctdh.MaSanPham1);
            sqlParameters[2] = new SqlParameter("@SoLuong", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(ctdh.SoLuong);
            sqlParameters[3] = new SqlParameter("@DonGia", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(ctdh.DonGia);
            sqlParameters[4] = new SqlParameter("@ThanhTien", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(ctdh.ThanhTien);

            executeInsertQuery(sql, sqlParameters);
        }
        public void CapNhatCTDH(ChiTietDonHang ctdh)
        {

            string sql = "CAPNHAT_CHITIETDONHANG @MaCTDH,@MaDH, @MaSP, @SoLuong,@DonGia,@ThanhTien";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@MaCTDH", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(ctdh.MaCTDH);
            sqlParameters[1] = new SqlParameter("@MaDH", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(ctdh.MaDonHang);
            sqlParameters[2] = new SqlParameter("@MaSP", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(ctdh.MaSanPham1);
            sqlParameters[3] = new SqlParameter("@SoLuong", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(ctdh.SoLuong);
            sqlParameters[4] = new SqlParameter("@DonGia", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(ctdh.DonGia);
            sqlParameters[5] = new SqlParameter("@ThanhTien", SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToInt32(ctdh.ThanhTien);

            executeUpdateOrDeleteQuery(sql, sqlParameters);

        }
        public void XoaCTDH(string maCTDH)
        {
            const string sql = "XOA_CHITIETDONHANG @MaCTDH";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaCTDH", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(maCTDH);

            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }

    }
}
