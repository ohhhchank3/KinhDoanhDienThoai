using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinhDoanhDienThoai
{
    public partial class frm_ChiTietSanPham : Form
    {
        int maDH;
        public frm_ChiTietSanPham()
        {
            InitializeComponent();
        }
        private void XemCTDH(string maDH)
        {
            ChiTietDonHangBUS ctBUS = new ChiTietDonHangBUS();
            DataTable dt = new DataTable();
            dt = ctBUS.DuLieu(maDH);
            //Bientoancuc.masodonhang = dt.Rows[0].ItemArray[0].ToString();
            dgv_DonMuaHang.DataSource = dt;
            dgv_DonMuaHang.Columns[0].HeaderText = "Mã chi tiết đơn hàng";
            dgv_DonMuaHang.Columns[1].HeaderText = "Mã đơn hàng";
            dgv_DonMuaHang.Columns[2].HeaderText = "Mã sản phẩm";
            dgv_DonMuaHang.Columns[3].HeaderText = "Tên sản phẩm";
            dgv_DonMuaHang.Columns[4].HeaderText = "Số lượng";
            dgv_DonMuaHang.Columns[5].HeaderText = "Đơn giá";
            dgv_DonMuaHang.Columns[6].HeaderText = "Thành tiền";

            dgv_DonMuaHang.Columns[0].Width = 100;
            dgv_DonMuaHang.Columns[1].Width = 100;
            dgv_DonMuaHang.Columns[2].Width = 100;
            dgv_DonMuaHang.Columns[3].Width = 200;
            dgv_DonMuaHang.Columns[4].Width = 70;
            dgv_DonMuaHang.Columns[5].Width = 100;
            dgv_DonMuaHang.Columns[6].Width = 150;
                
            dgv_DonMuaHang.AllowUserToAddRows = false;
            dgv_DonMuaHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadSanPham()
        {
            try
            {
                ChiTietSanPhamBUS ctspBUS = new ChiTietSanPhamBUS();
                DataTable dt = new DataTable();
                if (Bientoancuc.MaSP_CTSP != "")
                {
                    dt = ctspBUS.TimSP(Bientoancuc.MaSP_CTSP);
                }

                txt_MaSanPham.Text = dt.Rows[0].ItemArray[0].ToString();
                txt_TenSP.Text = dt.Rows[0].ItemArray[1].ToString();
                txt_HangSX.Text = dt.Rows[0].ItemArray[3].ToString();
                txt_DonGia.Text = dt.Rows[0].ItemArray[6].ToString();
                txt_MauSac.Text = dt.Rows[0].ItemArray[7].ToString();
                txt_BoNho.Text = dt.Rows[0].ItemArray[9].ToString();
                txt_BoXuLy.Text = dt.Rows[0].ItemArray[10].ToString();
                txt_RAM.Text = dt.Rows[0].ItemArray[11].ToString();
                txt_HeDieuHanh.Text = dt.Rows[0].ItemArray[12].ToString();
                float camtruoc = Convert.ToSingle(dt.Rows[0].ItemArray[13].ToString());
                float camsau = Convert.ToSingle(dt.Rows[0].ItemArray[14].ToString());
                txt_CamTruoc.Text = Math.Round(camtruoc, 2).ToString();
                txt_CamSau.Text = Math.Round(camsau, 2).ToString();
                dtp_NamSX.Value = Convert.ToDateTime(dt.Rows[0].ItemArray[15].ToString());
                txt_NhaCungCap.Text = dt.Rows[0].ItemArray[16].ToString();           
                txt_ThoiHanBH.Text = dt.Rows[0].ItemArray[17].ToString();
                txt_GhiChu.Text = dt.Rows[0].ItemArray[18].ToString();
                string hinhanh = dt.Rows[0].ItemArray[19].ToString();
                if (hinhanh != "")
                {
                    pbChonAnh.Image = Image.FromFile(hinhanh);
                    pbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch { }
        }
        private int LoadMaDH()
        {
            ChiTietSanPhamBUS ctspBUS = new ChiTietSanPhamBUS();
            DataTable dt = new DataTable();
            maDH = -1;
            dt = ctspBUS.TimMaDH(DateTime.Now.Date, Bientoancuc.TaiKhoan);
            if(dt.Rows.Count > 0)
            {
                maDH = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            return maDH;
        }
        private void TaoMaDHNEW()
        {
            ChiTietSanPhamBUS ctspBUS = new ChiTietSanPhamBUS();
            if (LoadMaDH() == -1)
            {
                ChiTietSanPham ct = new ChiTietSanPham(DateTime.Now, Bientoancuc.TaiKhoan, Convert.ToInt32(txt_ThanhTien.Text));
                ctspBUS.TaoDonHangMoi(ct);
                maDH = LoadMaDH();
            }
        }
        private void frm_ChiTietSanPham_Load(object sender, EventArgs e)
        {
            txt_ThanhTien.Text = "0";
            LoadSanPham();
            TaoMaDHNEW();
            txt_MaDH.Text = maDH.ToString();
            XemCTDH(txt_MaDH.Text);
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
           if(txt_SoLuong.Text == "0")
            {
                txt_SoLuong.Text = "";
                MessageBox.Show("Số lượng phải lớn hơn hoặc bằng 1");
            }   
           else
            {
                if (txt_SoLuong.Text != "")
                {
                    try
                    {
                        txt_ThanhTien.Text = Convert.ToString(int.Parse(txt_SoLuong.Text) * int.Parse(txt_DonGia.Text));
                    }
                    catch (Exception) { MessageBox.Show("Vui lòng điền dạng số"); }
                }
            }
            
        }
        private void btn_MuaHang_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận mua hàng?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (txt_SoLuong.Text != "")
                {
                    
                    ChiTietSanPhamBUS ctsp = new ChiTietSanPhamBUS();
                    ChiTietSanPham ct = new ChiTietSanPham(txt_MaDH.Text, Bientoancuc.MaSP_CTSP, int.Parse(txt_SoLuong.Text), int.Parse(txt_ThanhTien.Text), int.Parse(txt_DonGia.Text));
                    ctsp.MuaHang(ct);
                    XemCTDH(txt_MaDH.Text);
                }
                else
                {
                    MessageBox.Show("Nhập số lượng sản phẩm mua!");
                }
            }    
                
        }
    }
}
