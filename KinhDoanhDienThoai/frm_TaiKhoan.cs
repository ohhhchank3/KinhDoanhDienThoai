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
    public partial class frm_TaiKhoan : Form
    {
        public frm_TaiKhoan()
        {
            InitializeComponent();
        }
        private void XemTaiKhoan()
        {
            TaIKhoanBUS tk = new TaIKhoanBUS();
            DataTable d1 = new DataTable();
            d1 = tk.HienThi(Bientoancuc.TaiKhoan);

            txt_CMND.Text = d1.Rows[0].ItemArray[4].ToString();
            txt_TenKH.Text = d1.Rows[0].ItemArray[5].ToString(); 
            txt_SDT.Text = d1.Rows[0].ItemArray[6].ToString();
            txt_DiaChi.Text = d1.Rows[0].ItemArray[7].ToString();
            txt_Email.Text=d1.Rows[0].ItemArray[8].ToString();
            cb_GioiTinh.Text = d1.Rows[0].ItemArray[9].ToString();
            dtp_NgaySinh.Value = Convert.ToDateTime(d1.Rows[0].ItemArray[10].ToString());
            txt_MaTK.Text = d1.Rows[0].ItemArray[1].ToString();
            txt_MATKKH.Text = d1.Rows[0].ItemArray[0].ToString();

            txt_TenTKDMK.Text = d1.Rows[0].ItemArray[1].ToString();
        }
        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            XemTaiKhoan();
            txt_MaTK.Enabled = false;
            txt_MATKKH.Enabled = false;
            txt_TenTKDMK.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chỉnh sửa thông tin cá nhân ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TaIKhoanBUS tk = new TaIKhoanBUS();
                TaiKhoan dh = new TaiKhoan(txt_MaTK.Text, txt_TenKH.Text, txt_CMND.Text, cb_GioiTinh.Text, txt_SDT.Text, txt_DiaChi.Text, txt_Email.Text, txt_MATKKH.Text, dtp_NgaySinh.Value);
                tk.CapNhatTaiKhoan(dh);
                XemTaiKhoan();
            }    
               
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TaIKhoanBUS tk = new TaIKhoanBUS();
                TaiKhoan dh = new TaiKhoan(txt_TenTKDMK.Text, txt_MKDMK.Text, txt_NewMK.Text, txt_XNMK.Text);
                tk.CapNhatMatKhau(dh);
                txt_NewMK.ResetText();
                txt_MKDMK.ResetText();
                txt_XNMK.ResetText();
            }    
            
        }
    }
}
