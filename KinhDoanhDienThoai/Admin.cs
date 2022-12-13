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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void EditButtonColor(Button btn, String topname)
        {
            btn_Home.Visible = true;
            btn_DonHang.BackColor = Color.FromArgb(102, 165, 173);
            btn_SanPham.BackColor = Color.FromArgb(102, 165, 173);
            btn_HangSX.BackColor = Color.FromArgb(102, 165, 173);
            btn_KhachHang.BackColor = Color.FromArgb(102, 165, 173);
            btn_ThongKe.BackColor = Color.FromArgb(102, 165, 173);
            btn_TaiKhoan.BackColor = Color.FromArgb(102, 165, 173);

            if (topname == "TRANG CHỦ")
            {
                btn.BackColor = Color.FromArgb(102, 165, 173);
                pnl_Top.BackColor = Color.FromArgb(102, 165, 173);
            }
            else
            {
                btn.BackColor = Color.FromArgb(196, 223, 230);
                pnl_Top.BackColor = Color.FromArgb(196, 223, 230);
            }
            lb_TopName.Text = topname;
        }
        void AddForm(Form f)
        {
            this.pnl_Main.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(f);
            f.Show();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            btn_Home.Visible = false;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_Home, "TRANG CHỦ");
            btn_Home.Visible = false;
            this.pnl_Main.Controls.Clear();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_SanPham, "SẢN PHẨM");
            frm_SanPham frmSP = new frm_SanPham();
            AddForm(frmSP);
        }
        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_KhachHang, "KHÁCH HÀNG");
            frm_KhachHang frmKH = new frm_KhachHang();
            AddForm(frmKH);
        }
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_ThongKe, "THỐNG KÊ");
            frm_ThongKe frmTK = new frm_ThongKe();
            AddForm(frmTK);
        }
        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_TaiKhoan, "TÀI KHOẢN");
            frm_TaiKhoan frmTK = new frm_TaiKhoan();
            AddForm(frmTK);
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_Thoat, "THOÁT");
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btn_HangSX_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_HangSX, "HÃNG SẢN XUẤT");
            frm_HangSanXuat frmHSX = new frm_HangSanXuat();
            AddForm(frmHSX);
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_DonHang, "ĐƠN HÀNG");
            frm_DonHang frmDH = new frm_DonHang();
            AddForm(frmDH);
        }
    }
}
