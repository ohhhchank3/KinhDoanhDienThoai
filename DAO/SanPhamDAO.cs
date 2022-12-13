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
    public class SanPhamDAO : DBConnection
    {
        public SanPhamDAO() : base() { }
        public DataTable HienThi()
        {
           const string sql = "select * from XEMSANPHAM";


            return executeDisplayQuery(sql);
        }
        public void ThemSanPham(SanPham sp)
        {
           const string sql = "THEMSANPHAM @MaSP,@TenSP,@SoLuong,@DonGiaNhap,@DonGiaBan,@MauSac,@BOXULY,@BoNho,@RAM,@HDH,@NamSX,@MaHangSX,@NhaCC,@KichThuoc,@CAM_TRUOC,@CAM_SAU,@TGBaoHanh,@GhiChu,@HinhAnh";
            SqlParameter[] sqlParameters = new SqlParameter[19];
            sqlParameters[0] = new SqlParameter("@MaSP", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(sp.MaSanPham);
            sqlParameters[1] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(sp.TenSanPham);
            sqlParameters[2] = new SqlParameter("@SoLuong", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(sp.SoLuong);
            sqlParameters[3] = new SqlParameter("@DonGiaNhap", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(sp.DonGiaNhap);
            sqlParameters[4] = new SqlParameter("@DonGiaBan", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(sp.DonGiaBan);
            sqlParameters[5] = new SqlParameter("@MauSac", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(sp.MauSac);
            sqlParameters[6] = new SqlParameter("@BOXULY", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(sp.BoXuLy);
            sqlParameters[7] = new SqlParameter("@BoNho", SqlDbType.Int);
            sqlParameters[7].Value = Convert.ToInt32(sp.BoNho);
            sqlParameters[8] = new SqlParameter("@RAM", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToInt32(sp.Ram);
            sqlParameters[9] = new SqlParameter("@HDH", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(sp.HeDieuHanh);
            sqlParameters[10] = new SqlParameter("@NamSX", SqlDbType.Date);
            sqlParameters[10].Value = Convert.ToDateTime(sp.NamSX);
            sqlParameters[11] = new SqlParameter("@MaHangSX", SqlDbType.Int);
            sqlParameters[11].Value = Convert.ToInt32(sp.MaHangSX);
            sqlParameters[12] = new SqlParameter("@NhaCC", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(sp.NhaCungCap);
            sqlParameters[13] = new SqlParameter("@KichThuoc", SqlDbType.Float);
            sqlParameters[13].Value = Convert.ToSingle(sp.KichThuoc);
            sqlParameters[14] = new SqlParameter("@CAM_TRUOC", SqlDbType.Float);
            sqlParameters[14].Value = Convert.ToSingle(sp.CamTruoc);
            sqlParameters[15] = new SqlParameter("@CAM_SAU", SqlDbType.Float);
            sqlParameters[15].Value = Convert.ToSingle(sp.CamSau);
            sqlParameters[16] = new SqlParameter("@TGBaoHanh", SqlDbType.NVarChar);
            sqlParameters[16].Value = Convert.ToString(sp.ThoiHanBH);
            sqlParameters[17] = new SqlParameter("@GhiChu", SqlDbType.NVarChar);
            sqlParameters[17].Value = Convert.ToString(sp.GhiChu);
            sqlParameters[18] = new SqlParameter("@HinhAnh", SqlDbType.NVarChar);
            sqlParameters[18].Value = Convert.ToString(sp.HinhAnh);
           executeInsertQuery(sql, sqlParameters);
        }
        public void CapNhatSanPham(SanPham sp)
        {
            string sql = "CAPNHAT_SANPHAM @MaSP,@TenSP,@SoLuong,@DonGiaNhap,@DonGiaBan,@MauSac,@BOXULY,@BoNho,@RAM,@HDH,@NamSX,@MaHangSX,@NhaCC,@KichThuoc,@CAM_TRUOC,@CAM_SAU,@TGBaoHanh,@GhiChu,@HinhAnh";
            SqlParameter[] sqlParameters = new SqlParameter[19];
            sqlParameters[0] = new SqlParameter("@MaSP", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(sp.MaSanPham);
            sqlParameters[1] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(sp.TenSanPham);
            sqlParameters[2] = new SqlParameter("@SoLuong", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(sp.SoLuong);
            sqlParameters[3] = new SqlParameter("@DonGiaNhap", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(sp.DonGiaNhap);
            sqlParameters[4] = new SqlParameter("@DonGiaBan", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(sp.DonGiaBan);
            sqlParameters[5] = new SqlParameter("@MauSac", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(sp.MauSac);
            sqlParameters[6] = new SqlParameter("@BOXULY", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(sp.BoXuLy);
            sqlParameters[7] = new SqlParameter("@BoNho", SqlDbType.Int);
            sqlParameters[7].Value = Convert.ToInt32(sp.BoNho);
            sqlParameters[8] = new SqlParameter("@RAM", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToInt32(sp.Ram);
            sqlParameters[9] = new SqlParameter("@HDH", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(sp.HeDieuHanh);
            sqlParameters[10] = new SqlParameter("@NamSX", SqlDbType.Date);
            sqlParameters[10].Value = Convert.ToDateTime(sp.NamSX);
            sqlParameters[11] = new SqlParameter("@MaHangSX", SqlDbType.Int);
            sqlParameters[11].Value = Convert.ToInt32(sp.MaHangSX);
            sqlParameters[12] = new SqlParameter("@NhaCC", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(sp.NhaCungCap);
            sqlParameters[13] = new SqlParameter("@KichThuoc", SqlDbType.Float);
            sqlParameters[13].Value = Convert.ToSingle(sp.KichThuoc);
            sqlParameters[14] = new SqlParameter("@CAM_TRUOC", SqlDbType.Float);
            sqlParameters[14].Value = Convert.ToSingle(sp.CamTruoc);
            sqlParameters[15] = new SqlParameter("@CAM_SAU", SqlDbType.Float);
            sqlParameters[15].Value = Convert.ToSingle(sp.CamSau);
            sqlParameters[16] = new SqlParameter("@TGBaoHanh", SqlDbType.NVarChar);
            sqlParameters[16].Value = Convert.ToString(sp.ThoiHanBH);
            sqlParameters[17] = new SqlParameter("@GhiChu", SqlDbType.NVarChar);
            sqlParameters[17].Value = Convert.ToString(sp.GhiChu);
            sqlParameters[18] = new SqlParameter("@HinhAnh", SqlDbType.NVarChar);
            sqlParameters[18].Value = Convert.ToString(sp.HinhAnh);

            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
        public void XoaSanPham(string str)
        {
            const string sql = "XOASANPHAM @MaSP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSP", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(str);

            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }

    }
}
