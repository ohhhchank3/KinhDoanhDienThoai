using BUS;
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
    public partial class frm_MuaHang : Form
    {
        public frm_MuaHang()
        {
            InitializeComponent();
        }

        private void btn_ChiTietSP_Click(object sender, EventArgs e)
        {
            if(Bientoancuc.MaSP_CTSP != null)
            {
                frm_ChiTietSanPham frmCTSP = new frm_ChiTietSanPham();
                frmCTSP.ShowDialog();
                Bientoancuc.MaSP_CTSP = null;
            }    
            else
            {
                MessageBox.Show("Chọn sản phẩm muốn xem chi tiết!");
            }    
        }
        private void LoadHangSX()
        {
            HangSXBUS hsxBUS = new HangSXBUS();
            DataTable dt = new DataTable();
            dt = hsxBUS.HienThi();
            cb_HangSP.DisplayMember = "TenHang";
            cb_HangSP.ValueMember = "MaHang";
            cb_HangSP.DataSource = dt;
        }
        private void LoadTenSP(string mahang)
        {
            MuaHangBUS mh = new MuaHangBUS();
            DataTable dt = new DataTable();
            dt = mh.loadTenSP(mahang);
            cb_TenSP.DataSource = dt;
            cb_TenSP.DisplayMember = "TenSP";
        }
        // string sql = "select TenSP,MaSP,DonGiaBan,RAM,BoNho,KichThuoc,MauSac from SANPHAM where TenSP like '%" + str + "%' ";
        private void frm_MuaHang_Load(object sender, EventArgs e)
        {
            LoadHangSX();
            cb_HangSP.SelectedIndex = -1;
        }
        private void XemSanPham(string str)
        {
            MuaHangBUS mhBUS = new MuaHangBUS();
            DataTable dt = new DataTable();
            dt = mhBUS.loadSP(str);
            dgv_SanPham.DataSource = dt;
            dgv_SanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgv_SanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_SanPham.Columns[2].HeaderText = "Đơn giá bán";
            dgv_SanPham.Columns[3].HeaderText = "RAM";
            dgv_SanPham.Columns[4].HeaderText = "Bộ nhớ";
            dgv_SanPham.Columns[5].HeaderText = "Kích Thước";
            dgv_SanPham.Columns[6].HeaderText = "Màu sắc";

            dgv_SanPham.Columns[0].Width = 150;
            dgv_SanPham.Columns[1].Width = 150;
            dgv_SanPham.Columns[2].Width = 150;
            dgv_SanPham.Columns[3].Width = 100;
            dgv_SanPham.Columns[4].Width = 100;
            dgv_SanPham.Columns[5].Width = 150;
            dgv_SanPham.Columns[6].Width = 100;
  
            dgv_SanPham.AllowUserToAddRows = false;
            dgv_SanPham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void cb_HangSP_TextChanged(object sender, EventArgs e)
        {
            if(cb_HangSP.Text != "")
            {
                LoadTenSP(cb_HangSP.SelectedValue.ToString());
                cb_TenSP.SelectedIndex = -1;
            }    
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if(cb_HangSP.Text == "")
            {
                MessageBox.Show("Chọn hãng sản xuất!");
            }    
            else if (cb_TenSP.Text == "")
            {
                MessageBox.Show("Chọn sản phẩm muốn tìm!");
            }
            else
            {
                XemSanPham(cb_TenSP.Text);
            }
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Reset();
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgv_SanPham.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                Bientoancuc.MaSP_CTSP = row.Cells[0].Value.ToString();
            }
        }
    }
}
