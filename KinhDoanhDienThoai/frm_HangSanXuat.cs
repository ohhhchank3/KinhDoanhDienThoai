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
    public partial class frm_HangSanXuat : Form
    {
        public frm_HangSanXuat()
        {
            InitializeComponent();
        }
        private void XemHangSanXuat()
        {
            HangSXBUS dhBUS = new HangSXBUS();  
            DataTable dt = new DataTable();
            dt = dhBUS.HienThi();
            Bientoancuc.masodonhang = dt.Rows[0].ItemArray[0].ToString();
            dgv_HangSX.DataSource = dt;
            dgv_HangSX.Columns[0].HeaderText = "Mã hãng sản xuất";
            dgv_HangSX.Columns[1].HeaderText = "Tên hãng";
            dgv_HangSX.Columns[2].HeaderText = "Địa chỉ hãng";
        
            dgv_HangSX.Columns[0].Width = 200;
            dgv_HangSX.Columns[1].Width = 200;
            dgv_HangSX.Columns[2].Width = 250;
            dgv_HangSX.AllowUserToAddRows = false;
            dgv_HangSX.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void frm_HangSanXuat_Load(object sender, EventArgs e)
        {
            XemHangSanXuat();
            txt_MaHangSX.Enabled = false;
        }
        private bool CheckNhapThongTin()
        {
            if (txt_TenHangSX.Text == "")
            {
                MessageBox.Show("Nhập tên hãng sản xuất!");
                return false;
            }
            if (txt_ViTri.Text == "")
            {
                MessageBox.Show("Nhập vị trí hãng sản xuất!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Reset()
        {
            txt_MaHangSX.ResetText();
            txt_TenHangSX.ResetText();
            txt_ViTri.ResetText();
        }
        private void dgv_HangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHangSX.Text = dgv_HangSX.CurrentRow.Cells[0].Value.ToString();
            txt_TenHangSX.Text = dgv_HangSX.CurrentRow.Cells[1].Value.ToString();
            txt_ViTri.Text = dgv_HangSX.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm hãng sản xuất ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                HangSXBUS hsxBUS = new HangSXBUS();
                if (CheckNhapThongTin())
                {
                    HangSX hsx = new HangSX(txt_TenHangSX.Text, txt_ViTri.Text);
                    hsxBUS.ThemHangSX(hsx);
                    Reset();
                    XemHangSanXuat();
                }
            }    
               
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa hãng sản xuất ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                HangSXBUS sx = new HangSXBUS();
                if (txt_MaHangSX.Text == "")
                {
                    MessageBox.Show("Chọn hãng sản xuất muốn cập nhật!");
                }
                else
                {
                    HangSX dt = new HangSX(Convert.ToInt32(txt_MaHangSX.Text), txt_TenHangSX.Text, txt_ViTri.Text);
                    sx.CapNhatHangSX(dt);
                    Reset();
                    XemHangSanXuat();
                }
            }    
                
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hãng sản xuất", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                HangSXBUS sx = new HangSXBUS();
                if (txt_MaHangSX.Text == "")
                {
                    MessageBox.Show("Chọn hãng sản xuất muốn xóa!");
                }
                else
                {
                    sx.XoaHangSX(txt_MaHangSX.Text);
                    Reset();
                    XemHangSanXuat();
                }
            }   
        }
    }
}
