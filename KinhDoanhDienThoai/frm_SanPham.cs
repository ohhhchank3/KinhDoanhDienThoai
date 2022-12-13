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
    public partial class frm_SanPham : Form
    {
        string filepath = null;
        public frm_SanPham()
        {
            InitializeComponent();
        }
        private void XemSanPham()
        {
            SanPhamBUS spBUS = new SanPhamBUS();
            DataTable dt = new DataTable();
            dt = spBUS.HienThiDanhSach();
            dgv_SanPham.DataSource = dt;
            dgv_SanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgv_SanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_SanPham.Columns[2].HeaderText = "Mã nhà sản xuất"; 
            dgv_SanPham.Columns[3].HeaderText = "Tên nhà sản xuất";
            dgv_SanPham.Columns[4].HeaderText = "Số Lượng";
            dgv_SanPham.Columns[5].HeaderText = "Đơn giá nhập";
            dgv_SanPham.Columns[6].HeaderText = "Đơn giá bán";
            dgv_SanPham.Columns[7].HeaderText = "Màu sắc";
            dgv_SanPham.Columns[8].HeaderText = "Kích Thước";
            dgv_SanPham.Columns[9].HeaderText = "Bộ nhớ";
            dgv_SanPham.Columns[10].HeaderText = "Bộ xử lý";
            dgv_SanPham.Columns[11].HeaderText = "RAM";
            dgv_SanPham.Columns[12].HeaderText = "Hệ điều hành";
            dgv_SanPham.Columns[13].HeaderText = "Cam trước";
            dgv_SanPham.Columns[14].HeaderText = "Cam sau";
            dgv_SanPham.Columns[15].HeaderText = "Năm sản xuất";
            dgv_SanPham.Columns[16].HeaderText = "Nhà cung cấp ";
            dgv_SanPham.Columns[17].HeaderText = "Tg bảo hành";
            dgv_SanPham.Columns[18].HeaderText = "Ghi chú";
            dgv_SanPham.Columns[19].HeaderText = "Hình ảnh";

            dgv_SanPham.Columns[0].Width = 100;
            dgv_SanPham.Columns[1].Width = 150;
            dgv_SanPham.Columns[2].Width = 100;
            dgv_SanPham.Columns[3].Width = 100;
            dgv_SanPham.Columns[4].Width = 100;
            dgv_SanPham.Columns[5].Width = 100;
            dgv_SanPham.Columns[6].Width = 100;
            dgv_SanPham.Columns[7].Width = 100;
            dgv_SanPham.Columns[8].Width = 70;
            dgv_SanPham.Columns[9].Width = 70;
            dgv_SanPham.Columns[10].Width = 200;
            dgv_SanPham.Columns[11].Width = 70;
            dgv_SanPham.Columns[12].Width = 100;
            dgv_SanPham.Columns[13].Width = 70;
            dgv_SanPham.Columns[14].Width = 70;
            dgv_SanPham.Columns[15].Width = 100;
            dgv_SanPham.Columns[16].Width = 150;
            dgv_SanPham.Columns[17].Width = 100;
            dgv_SanPham.Columns[18].Width = 100;
            dgv_SanPham.Columns[19].Width = 100;

            dgv_SanPham.AllowUserToAddRows = false;
            dgv_SanPham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadComboBoxHangSX()
        {
            HangSXBUS hsxBUS = new HangSXBUS();
            DataTable dt = new DataTable();
            dt = hsxBUS.HienThi();
            cb_HangSX.DisplayMember = "TenHang";
            cb_HangSX.ValueMember = "MaHang";
            cb_HangSX.DataSource = dt;
        }
        private void Reset()
        {
            txt_MaSanPham.ResetText();
            txt_TenSP.ResetText();
            cb_HangSX.ResetText();
            txt_SoLuong.ResetText();
            txt_DonGiaBan.ResetText();
            txt_DonGiaNhap.ResetText();
            txt_MauSac.ResetText();
            txt_BoNho.ResetText();
            txt_BoXuLy.ResetText();
            txt_RAM.ResetText();
            txt_HeDieuHanh.ResetText();
            txt_NhaCungCap.ResetText();
            txt_kichthuoc.ResetText();
            txt_CamTruoc.ResetText();
            txt_CamSau.ResetText();
            dtp_NamSX.ResetText();
            txt_ThoiHanBH.ResetText();
            txt_GhiChu.ResetText();
            txt_HinhAnh.ResetText();
            pbChonAnh.Image = null;
            txt_MaSanPham.Focus();
        }
        private bool CheckNhapSP()
        {
            if (txt_MaSanPham.Text == "")
            {
                MessageBox.Show("Nhập mã sản phẩm!");
                return false;
            }
            else if (txt_TenSP.Text == "")
            {
                MessageBox.Show("Nhập tên sản phẩm!");
                return false;
            }
            else if (cb_HangSX.Text == "")
            {
                MessageBox.Show("Chọn hãng sản xuất sản phẩm!");
                return false;
            }
            else if (txt_SoLuong.Text == "")
            {
                MessageBox.Show("Nhập số lượng sản phẩm!");
                return false;
            }
            else if (txt_DonGiaNhap.Text == "")
            {
                MessageBox.Show("Nhập đơn giá nhập sản phẩm!");
                return false;
            }
            else if (txt_DonGiaBan.Text == "")
            {
                MessageBox.Show("Nhập đơn giá bán sản phẩm!");
                return false;
            }
            else if (txt_MauSac.Text == "")
            {
                MessageBox.Show("Nhập màu sắc sản phẩm!");
                return false;
            }
            else if (txt_BoNho.Text == "")
            {
                MessageBox.Show("Nhập bộ nhớ sản phẩm!");
                return false;
            }
            else if (txt_BoXuLy.Text == "")
            {
                MessageBox.Show("Nhập bộ xử lý sản phẩm!");
                return false;
            }
            else if (txt_RAM.Text == "")
            {
                MessageBox.Show("Nhập RAM sản phẩm!");
                return false;
            }
            else if (txt_HeDieuHanh.Text == "")
            {
                MessageBox.Show("Nhập hệ điều hành sản phẩm!");
                return false;
            }
            else if (txt_NhaCungCap.Text == "")
            {
                MessageBox.Show("Nhập nhà cung cấp sản phẩm!");
                return false;
            }
            else if (txt_kichthuoc.Text == "")
            {
                MessageBox.Show("Nhập kích thước sản phẩm!");
                return false;
            }
            else if (txt_CamTruoc.Text == "")
            {
                MessageBox.Show("Nhập cam trước sản phẩm!");
                return false;
            }
            else if (txt_CamSau.Text == "")
            {
                MessageBox.Show("Nhập cam sau sản phẩm!");
                return false;
            }
            else if (txt_ThoiHanBH.Text == "")
            {
                MessageBox.Show("Nhập thời gian bảo hành sản phẩm!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Reset();
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgv_SanPham.Rows[e.RowIndex];
                
                //Đưa dữ liệu vào textbox
                txt_MaSanPham.Text = row.Cells[0].Value.ToString();
                txt_TenSP.Text = row.Cells[1].Value.ToString();
                cb_HangSX.Text = row.Cells[3].Value.ToString();
                txt_SoLuong.Text = row.Cells[4].Value.ToString();
                txt_DonGiaNhap.Text=row.Cells[5].Value.ToString();
                txt_DonGiaBan.Text = row.Cells[6].Value.ToString();
                txt_MauSac.Text = row.Cells[7].Value.ToString();
                float kichthuoc = Convert.ToSingle(row.Cells[8].Value.ToString());
                txt_kichthuoc.Text = Math.Round(kichthuoc, 2).ToString();
                txt_BoNho.Text = row.Cells[9].Value.ToString();
                txt_BoXuLy.Text = row.Cells[10].Value.ToString();
                txt_RAM.Text = row.Cells[11].Value.ToString();
                txt_HeDieuHanh.Text = row.Cells[12].Value.ToString();
                float camtruoc = Convert.ToSingle(row.Cells[13].Value.ToString());
                float camsau = Convert.ToSingle(row.Cells[14].Value.ToString());
                txt_CamTruoc.Text = Math.Round(camtruoc, 2).ToString();
                txt_CamSau.Text = Math.Round(camsau, 2).ToString();
                dtp_NamSX.Value = Convert.ToDateTime(row.Cells[15].Value.ToString());          
                txt_NhaCungCap.Text = row.Cells[16].Value.ToString();          
                txt_ThoiHanBH.Text = row.Cells[17].Value.ToString();
                txt_GhiChu.Text = row.Cells[18].Value.ToString();
                txt_HinhAnh.Text = row.Cells[19].Value.ToString();
                if (txt_HinhAnh.Text != "")
                {
                    pbChonAnh.Image = Image.FromFile(txt_HinhAnh.Text);
                    pbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
                txt_MaSanPham.Enabled = false;
            }
        }

        private void btnChonAnh_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofdImages = new OpenFileDialog();
            ofdImages.Title = "Chọn ảnh minh họa cho sản phẩm";
            // Lưu ảnh trong thư mục KinhDoanhDienThoai\bin\Debug
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            txt_HinhAnh.Text = filepath.Substring(filepath.LastIndexOf("\\") + 1);

            if (txt_HinhAnh.Text != "")
            {
                pbChonAnh.Image = Image.FromFile(txt_HinhAnh.Text);
                pbChonAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            XemSanPham();
            LoadComboBoxHangSX();
            cb_HangSX.SelectedIndex = -1;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm sản phẩm ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                SanPhamBUS spBUS = new SanPhamBUS();
                if (CheckNhapSP())
                {
                    SanPham sp = new SanPham(txt_MaSanPham.Text, txt_TenSP.Text, txt_MauSac.Text, txt_BoXuLy.Text, txt_HeDieuHanh.Text, txt_NhaCungCap.Text, txt_ThoiHanBH.Text, txt_GhiChu.Text, txt_HinhAnh.Text, Convert.ToInt32(txt_SoLuong.Text),
                    Convert.ToInt32(txt_DonGiaNhap.Text), Convert.ToInt32(txt_DonGiaBan.Text), Convert.ToInt32(txt_BoNho.Text), Convert.ToInt32(txt_RAM.Text), Convert.ToInt32(cb_HangSX.SelectedValue), Convert.ToSingle(txt_kichthuoc.Text), Convert.ToSingle(txt_CamTruoc.Text),
                    Convert.ToSingle(txt_CamSau.Text), dtp_NamSX.Value);
                    spBUS.ThemSanPham(sp);
                    Reset();
                    XemSanPham();
                }
            }   
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa sản phẩm", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                SanPhamBUS spBUS = new SanPhamBUS();
                if (CheckNhapSP())
                {
                    SanPham sp = new SanPham(txt_MaSanPham.Text, txt_TenSP.Text, txt_MauSac.Text, txt_BoXuLy.Text, txt_HeDieuHanh.Text, txt_NhaCungCap.Text, txt_ThoiHanBH.Text, txt_GhiChu.Text, txt_HinhAnh.Text, Convert.ToInt32(txt_SoLuong.Text),
                    Convert.ToInt32(txt_DonGiaNhap.Text), Convert.ToInt32(txt_DonGiaBan.Text), Convert.ToInt32(txt_BoNho.Text), Convert.ToInt32(txt_RAM.Text), Convert.ToInt32(cb_HangSX.SelectedValue), Convert.ToSingle(txt_kichthuoc.Text), Convert.ToSingle(txt_CamTruoc.Text),
                    Convert.ToSingle(txt_CamSau.Text), dtp_NamSX.Value);
                    spBUS.CapNhatSanPham(sp);
                    Reset();
                    XemSanPham();
                }
            }    
                
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                SanPhamBUS spBUS = new SanPhamBUS();
                if (txt_MaSanPham.Text != "")
                {
                    spBUS.XoaSanPham(txt_MaSanPham.Text);
                    Reset();
                    XemSanPham();
                }
                else
                {
                    MessageBox.Show("Chọn sản phẩm muốn xóa!");
                }
            }
                
        }
    }
}
