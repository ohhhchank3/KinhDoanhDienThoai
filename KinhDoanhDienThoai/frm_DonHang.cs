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
    public partial class frm_DonHang : Form
    {
        public frm_DonHang()
        {
            InitializeComponent();
        }

        private void btn_ChiTietDH_Click(object sender, EventArgs e)
        {
            Bientoancuc.boolCheck = 0;
            if(txt_MaDonHang.Text != "")
            {
                Bientoancuc.masodonhang = txt_MaDonHang.Text;
                frm_ChiTietDonHang frmCTDH = new frm_ChiTietDonHang();
                frmCTDH.ShowDialog();
                LoadDH();
            }    
            else
            {
                MessageBox.Show("Chọn đơn hàng muốn xem chi tiết!");
            }    
        }
        private void XemDonHang()
        {
            DonHangBUS dhBUS = new DonHangBUS();
            DataTable dt = new DataTable();
            dt = dhBUS.HienThi(Bientoancuc.LoaiTK, Bientoancuc.TaiKhoan);
            //Bientoancuc.masodonhang = dt.Rows[0].ItemArray[0].ToString();
            dgv_DonHang.DataSource = dt;
            dgv_DonHang.Columns[0].HeaderText = "Mã đơn hàng";
            dgv_DonHang.Columns[1].HeaderText = "Ngày bán";
            dgv_DonHang.Columns[2].HeaderText = "Tài khoản";
            dgv_DonHang.Columns[3].HeaderText = "Tên khách hàng";
            dgv_DonHang.Columns[4].HeaderText = "Tổng tiền";

            dgv_DonHang.Columns[0].Width = 100;
            dgv_DonHang.Columns[1].Width = 100;
            dgv_DonHang.Columns[2].Width = 100;
            dgv_DonHang.Columns[3].Width = 150;
            dgv_DonHang.Columns[4].Width = 150;

            dgv_DonHang.AllowUserToAddRows = false;
            dgv_DonHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public bool CheckPhanLoai()
        {
            if(Bientoancuc.LoaiTK == "KH")
            {
                
                return true;
            }
            return false;
           
           
        }
        public void CheckPL()
        {
            if(CheckPhanLoai()==true)
            {
                btn_Them.Visible = false;
                btn_Xoa.Visible = false;
                // btn_Sua.Visible = false;
                txt_TenTK.Enabled = false;
                dtp_NgayMua.Enabled = false;
                //  btn_ChiTietDH.Enabled = false;
                txt_TongTien.Enabled = false;
            }    
        }
        private void frm_DonHang_Load(object sender, EventArgs e)
        {
            txt_TongTien.Enabled = true;
            XemDonHang();
            CheckPL();
            txt_MaDonHang.Enabled = false;
            txt_TenKH.Enabled = false;
            txt_TongTien.Enabled = false;
            txt_TenTK.Enabled = false;
            btn_Them.Visible = false;
        }
        public void LoadDH()
        {
            XemDonHang();
            CheckPL();
            txt_MaDonHang.Enabled = false;
            txt_TenKH.Enabled = false;
            txt_TongTien.Enabled = false;
        }
        private void Reset()
        {
            txt_MaDonHang.ResetText();
            txt_TenTK.ResetText();
            txt_TenKH.ResetText();
            txt_TongTien.Text = "0";
            dtp_NgayMua.ResetText();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận Thêm đơn hàng  ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DonHangBUS dhBUS = new DonHangBUS();
                if (txt_TenTK.Text != "")
                {
                    DonHang dh = new DonHang(Convert.ToInt32(txt_TongTien.Text), dtp_NgayMua.Value, txt_TenTK.Text.ToString());
                    dhBUS.ThemDonHang(dh);
                    Reset();
                    XemDonHang();
                }
                else
                {
                    txt_TenTK.Focus();
                    MessageBox.Show("Nhập tài khoản khách hàng!");
                }
            }    
                
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string s1 = dtp_NgayMua.Value.ToString("yyyy-MM-dd");
            string s2 = DateTime.Now.ToString("yyyy-MM-dd");
            DonHangBUS sp = new DonHangBUS();
            bool check = CheckPhanLoai();
            if(check == true)
            {
                Bientoancuc.boolCheck = 1;
                DateTime d1 = Convert.ToDateTime(s1);
                DateTime d2 = Convert.ToDateTime(s2);
              //  btn_ChiTietDH.Enabled = false;
                int result = DateTime.Compare(d1, d2);
                if(result == 0)
                {
                   // btn_ChiTietDH.Enabled = true;
                    if (txt_MaDonHang.Text != "")
                    {
                        if (txt_TongTien.Text == "")
                        {
                            txt_TongTien.Text = "0";
                        }

                        if (txt_MaDonHang.Text != "")
                        {
                            Bientoancuc.masodonhang = txt_MaDonHang.Text;
                            frm_ChiTietDonHang frmCTDH = new frm_ChiTietDonHang();
                            frmCTDH.ShowDialog();
                            LoadDH();
                        }
                        else
                        {
                            MessageBox.Show("Chọn đơn hàng muốn xem chi tiết!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chọn đơn hàng muốn cập nhật!");
                    }
                } 
                else
                {
                    Bientoancuc.boolCheck = 0;
                    MessageBox.Show("Không thể chỉnh sửa");
                }    
               
            }   
            else
            {
                Bientoancuc.boolCheck = 1;
                if (txt_MaDonHang.Text != "")
                {
                    if (txt_TongTien.Text == "")
                    {
                        txt_TongTien.Text = "0";
                    }
                    if (txt_MaDonHang.Text != "")
                    {
                        Bientoancuc.masodonhang = txt_MaDonHang.Text;
                        frm_ChiTietDonHang frmCTDH = new frm_ChiTietDonHang();
                        frmCTDH.ShowDialog();
                        LoadDH();
                    }
                    else
                    {
                        MessageBox.Show("Chọn đơn hàng muốn xem chi tiết!");
                    }
                }
                else
                {
                    MessageBox.Show("Chọn đơn hàng muốn cập nhật!");
                }
            }    
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa đơn hàng ", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                DonHangBUS sp = new DonHangBUS();
                if (txt_MaDonHang.Text != "")
                {
                    sp.XoaDonHang(txt_MaDonHang.Text);
                    Reset();
                    XemDonHang();
                }
                else
                {
                    MessageBox.Show("Chọn đơn hàng muốn xóa!");
                }
            }   
            
        }
        private void dgv_DonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgv_DonHang.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txt_MaDonHang.Text = dgv_DonHang.CurrentRow.Cells[0].Value.ToString();
                //Bientoancuc.masodonhang = txt_MaDonHang.Text;
                dtp_NgayMua.Value = Convert.ToDateTime(dgv_DonHang.CurrentRow.Cells[1].Value.ToString());
                txt_TenTK.Text = dgv_DonHang.CurrentRow.Cells[2].Value.ToString();
                txt_TenKH.Text = dgv_DonHang.CurrentRow.Cells[3].Value.ToString();
                txt_TongTien.Text = dgv_DonHang.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
