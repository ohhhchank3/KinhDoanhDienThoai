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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        private void EditButtonColor(Button btn, String topname)
        {
            btn_Home.Visible = true;
            btn_DonHang.BackColor = Color.FromArgb(102, 165, 173);
            btn_MuaHang.BackColor = Color.FromArgb(102, 165, 173);
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

        private void User_Load(object sender, EventArgs e)
        {
            btn_Home.Visible = false;
        }

        private void btn_MuaHang_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_MuaHang, "MUA HÀNG");
            frm_MuaHang frmMH = new frm_MuaHang();
            AddForm(frmMH);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_Home, "TRANG CHỦ");
            btn_Home.Visible = false;
            this.pnl_Main.Controls.Clear();
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_DonHang, "ĐƠN HÀNG");
            frm_DonHang frmDH = new frm_DonHang();
            AddForm(frmDH);
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
    }
}
