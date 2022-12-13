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
    public partial class frm_DangNhap : Form
    {
        DangNhapBUS dnBUS;
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HienThiMK.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }
        // xử lý
        private void lb_QuenMatKhau_Click(object sender, EventArgs e)
        {
            gb_QuenMatKhau.Visible = true;
        }
        // xử lý
        private void lb_DangKy_Click(object sender, EventArgs e)
        {
            gb_DangKy.Visible = true;
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            gb_QuenMatKhau.Visible = false;
            gb_DangKy.Visible = false;
        }

        private void pb_ThoatQuenMK_Click(object sender, EventArgs e)
        {
            gb_QuenMatKhau.Visible = false;
        }

        private void pb_ThoatDangKy_Click(object sender, EventArgs e)
        {
            gb_DangKy.Visible = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dnBUS = new DangNhapBUS();
            //Bientoancuc.TaiKhoan = txtDangNhap.Text;
            DangNhap dn = new DangNhap(txtDangNhap.Text,txtMatKhau.Text);
            DataTable dt= new DataTable();
            dt =  dnBUS.DangNhap(dn);
           
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                txtMatKhau.ResetText();
            }
            else
            {
                //HienThiPhieuHoaDon();
                string s1 = dt.Rows[0].ItemArray[3].ToString();
                Bientoancuc.LoaiTK = s1.Trim();
                Bientoancuc.TaiKhoan = dt.Rows[0].ItemArray[1].ToString();
                if (s1.Trim() == "KH")
                {
                    Bientoancuc.boolCheck = 1;
                    User f = new User();
                    f.ShowDialog();
                }
                else if (s1.Trim() == "ADMIN")
                {
                    Bientoancuc.boolCheck = 1;
                    Admin f = new Admin();
                    f.ShowDialog();    
                }
                txtDangNhap.ResetText();
                txtMatKhau.ResetText();
            }
            

        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đổi mật khẩu ", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                dnBUS = new DangNhapBUS();
                DangNhap dn = new DangNhap(txt_EmailQMK.Text, txt_MatKhauMoiQMK.Text, txt_XacNhanQMK.Text);
                dnBUS.QuenMatKhau(dn);
                txt_MatKhauMoiQMK.ResetText();
                txt_XacNhanQMK.ResetText();
            }    
          
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            dnBUS = new DangNhapBUS();
            if (MessageBox.Show("Xác nhận đăng ký ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (txt_MatKhauDK.Text != txt_XacNhanMK.Text)
                {
                    MessageBox.Show("Nhập sai xác nhận mật khẩu!");
                    txt_XacNhanMK.ResetText();
                    txt_XacNhanMK.Focus();
                }
                else
                {
                    DangNhap dn = new DangNhap(txt_TenKH.Text, txt_CMND.Text, dtp_NgaySinh.Value, cb_GioiTinh.Text, txt_SDT.Text, txt_EmailDK.Text, txt_DiaChi.Text, txt_TenTK.Text, txt_MatKhauDK.Text, txt_XacNhanMK.Text);
                    dnBUS.DANGKYTAIKHOAN(dn);
                    txt_TenKH.ResetText();
                    txt_CMND.ResetText();
                    dtp_NgaySinh.ResetText();
                    cb_GioiTinh.ResetText();
                    txt_SDT.ResetText();
                    txt_EmailDK.ResetText();
                    txt_DiaChi.ResetText();
                    txt_TenTK.ResetText();
                    txt_MatKhauDK.ResetText();
                    txt_XacNhanMK.ResetText();
                }
            }    
                
        }
    }
}
