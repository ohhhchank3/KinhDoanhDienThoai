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
    public partial class frm_ChiTietDonHang : Form
    {
        public frm_ChiTietDonHang()
        {
            InitializeComponent();
        }
        private void check()
        {
            if(Bientoancuc.boolCheck == 0)
            {
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }    
        }
        private void frm_ChiTietDonHang_Load(object sender, EventArgs e)
        {
            txt_MaDonHang.Text = Bientoancuc.masodonhang;
            XemCTDH();
            if(dgv_ChiTietDonHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm trong đơn hàng!");
                this.Close();
            }
            check();
            txt_MaCTDH.Enabled = false;
            txt_MaDonHang.Enabled = false;
            txt_MaSP.Enabled = false;
            txt_TenSanPham.Enabled = false;
            txt_DonGia.Enabled = false;
            txt_ThanhTien.Enabled = false;
        }  
        private void XemCTDH()
        {
            ChiTietDonHangBUS ctBUS = new ChiTietDonHangBUS();  
            DataTable dt = new DataTable();
            dt = ctBUS.DuLieu(Bientoancuc.masodonhang);
            //Bientoancuc.masodonhang = dt.Rows[0].ItemArray[0].ToString();
            dgv_ChiTietDonHang.DataSource = dt;
            dgv_ChiTietDonHang.Columns[0].HeaderText = "Mã chi tiết đơn hàng";
            dgv_ChiTietDonHang.Columns[1].HeaderText = "Mã đơn hàng";
            dgv_ChiTietDonHang.Columns[2].HeaderText = "Mã sản phẩm";
            dgv_ChiTietDonHang.Columns[3].HeaderText = "Tên sản phẩm";
            dgv_ChiTietDonHang.Columns[4].HeaderText = "Số lượng";
            dgv_ChiTietDonHang.Columns[5].HeaderText = "Đơn giá";
            dgv_ChiTietDonHang.Columns[6].HeaderText = "Thành tiền";


            dgv_ChiTietDonHang.Columns[0].Width = 100;
            dgv_ChiTietDonHang.Columns[1].Width = 100;
            dgv_ChiTietDonHang.Columns[2].Width = 100;
            dgv_ChiTietDonHang.Columns[3].Width = 150;
            dgv_ChiTietDonHang.Columns[4].Width = 70;
            dgv_ChiTietDonHang.Columns[5].Width = 100;
            dgv_ChiTietDonHang.Columns[6].Width = 100;

            dgv_ChiTietDonHang.AllowUserToAddRows = false;
            dgv_ChiTietDonHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void Reset()
        {
            txt_MaCTDH.ResetText();
            txt_MaSP.ResetText();
            txt_TenSanPham.ResetText();
            txt_SoLuong.Text = "0";
            txt_DonGia.Text = "0";
            txt_ThanhTien.Text = "0";
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cập nhật chi tiết đơn hàng", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ChiTietDonHangBUS ctdhBUS = new ChiTietDonHangBUS();
                if (txt_MaCTDH.Text != "")
                {
                    ChiTietDonHang ctdh = new ChiTietDonHang(txt_MaCTDH.Text, Convert.ToInt32(txt_MaDonHang.Text), Convert.ToInt32(txt_SoLuong.Text), Convert.ToInt32(txt_DonGia.Text), Convert.ToInt32(txt_ThanhTien.Text), txt_MaSP.Text);
                    ctdhBUS.SuaCTDH(ctdh);
                    Reset();
                    XemCTDH();
                }
                else
                {
                    MessageBox.Show("Chọn chi tiết đơn hàng muốn sửa!");
                }
            }    
        
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa chi tiết đơn hàng ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ChiTietDonHangBUS ctdhBUS = new ChiTietDonHangBUS();
                if (txt_MaCTDH.Text != "")
                {
                    ctdhBUS.XoaCTDH(txt_MaCTDH.Text);
                    Reset();
                    XemCTDH();
                }
                else
                {
                    MessageBox.Show("Chọn chi tiết đơn hàng muốn xóa!");
                }
            }    
                
        }
        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoLuong.Text != " " && txt_DonGia.Text != " ")
                {
                    txt_ThanhTien.Text = Convert.ToString(int.Parse(txt_SoLuong.Text) * int.Parse(txt_DonGia.Text));
                }
            }
            catch { }
        }
        private void dgv_ChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgv_ChiTietDonHang.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txt_MaCTDH.Text = dgv_ChiTietDonHang.CurrentRow.Cells[0].Value.ToString();
                txt_MaDonHang.Text = dgv_ChiTietDonHang.CurrentRow.Cells[1].Value.ToString();
                txt_MaSP.Text = dgv_ChiTietDonHang.CurrentRow.Cells[2].Value.ToString();
                txt_TenSanPham.Text = dgv_ChiTietDonHang.CurrentRow.Cells[3].Value.ToString();
                txt_SoLuong.Text = dgv_ChiTietDonHang.CurrentRow.Cells[4].Value.ToString();
                txt_DonGia.Text = dgv_ChiTietDonHang.CurrentRow.Cells[5].Value.ToString();
                txt_ThanhTien.Text = dgv_ChiTietDonHang.CurrentRow.Cells[6].Value.ToString();
            }
        }
    }
}
