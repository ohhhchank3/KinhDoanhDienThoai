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
    public partial class frm_KhachHang : Form
    {
        TaiKhoan tk;

        public frm_KhachHang()
        {
            InitializeComponent();
        }
        public void XemKhachHang()
        {
            KhachHangBUS khBUS = new KhachHangBUS();
            DataTable dt = new DataTable();
            dt = khBUS.HienThi();
            dgv_KhachHang.DataSource = dt;
            dgv_KhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgv_KhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgv_KhachHang.Columns[2].HeaderText = "CMND";
            dgv_KhachHang.Columns[3].HeaderText = "Ngày sinh";
            dgv_KhachHang.Columns[4].HeaderText = "Giới tính";
            dgv_KhachHang.Columns[5].HeaderText = "Số điện thoại";
            dgv_KhachHang.Columns[6].HeaderText = "Địa chỉ";
            dgv_KhachHang.Columns[7].HeaderText = "Email";
            dgv_KhachHang.Columns[8].HeaderText = "Tài khoản";
            dgv_KhachHang.Columns[9].HeaderText = "Mật khẩu";
            dgv_KhachHang.Columns[10].HeaderText = "Phân loại";

            //dgv_KhachHang.Columns[0].Width = 150;
            dgv_KhachHang.Columns[1].Width = 200;
            //dgv_KhachHang.Columns[2].Width = 250;
            //dgv_KhachHang.Columns[3].Width = 100;
            //dgv_KhachHang.Columns[4].Width = 150;
            //dgv_KhachHang.Columns[5].Width = 150;
            //dgv_KhachHang.Columns[6].Width = 250;
            dgv_KhachHang.Columns[7].Width = 200;
            //dgv_KhachHang.Columns[8].Width = 150;
            //dgv_KhachHang.Columns[9].Width = 150;
            //dgv_KhachHang.Columns[10].Width = 250;
            dgv_KhachHang.AllowUserToAddRows = false;
            dgv_KhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            XemKhachHang();
        }

        private void Reset()
        {
            txt_MaKH.ResetText();
            txt_CMND.ResetText();
            txt_TenKH.ResetText();
            txt_SDT.ResetText();
            txt_TenTK.ResetText();
            txt_DiaChi.ResetText();
            cb_GioiTinh.ResetText();
            dtp_NgaySinh.ResetText();
            txt_Email.ResetText();
            txt_TenTK.Enabled = true;
            txt_MaKH.Enabled = true;
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận cập nhật thông tin khách hàng?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                KhachHangBUS khBUS = new KhachHangBUS();
                if (txt_TenTK.Text == "")
                {
                    MessageBox.Show("Chọn khách hàng muốn cập nhật!");
                }
                else
                {
                    txt_TenTK.Enabled = false;
                    txt_MaKH.Enabled = false;
                    tk = new TaiKhoan(txt_TenTK.Text, txt_CMND.Text, txt_TenKH.Text, txt_SDT.Text, txt_DiaChi.Text, txt_Email.Text, cb_GioiTinh.Text, dtp_NgaySinh.Value);
                    khBUS.SuaKH(tk);
                    Reset();
                    XemKhachHang();
                }
            }    
               
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tài khoản này ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                KhachHangBUS khBUS = new KhachHangBUS();
                if (txt_TenTK.Text == "")
                {
                    MessageBox.Show("Chọn khách hàng muốn xóa!");
                }
                else
                {
                    txt_TenTK.Enabled = false;
                    txt_MaKH.Enabled = false;
                    khBUS.XoaKH(txt_TenTK.Text);
                    Reset();
                    XemKhachHang();
                }
            }    
                
        }
        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgv_KhachHang.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txt_MaKH.Text = row.Cells[0].Value.ToString();
                txt_TenKH.Text = row.Cells[1].Value.ToString();
                txt_CMND.Text = row.Cells[2].Value.ToString();
                dtp_NgaySinh.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                cb_GioiTinh.Text = row.Cells[4].Value.ToString();
                txt_SDT.Text = row.Cells[5].Value.ToString();
                txt_DiaChi.Text = row.Cells[6].Value.ToString();
                txt_Email.Text = row.Cells[7].Value.ToString();
                txt_TenTK.Text = row.Cells[8].Value.ToString();

                //Không cho phép sửa trường MaNV
                txt_MaKH.Enabled = false;
                txt_TenTK.Enabled = false;
            }
        }
    }
}
