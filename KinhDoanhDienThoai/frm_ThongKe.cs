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
    public partial class frm_ThongKe : Form
    {
        ThongKeBUS tkBUS;
        public frm_ThongKe()
        {
            InitializeComponent();
        }
        public void XemDoanhSo()
        {
            tkBUS = new ThongKeBUS();
            DataTable dt = new DataTable();
            dt = tkBUS.DoanhSo(dtp_NgayBatDau.Value, dtp_NgayKetThuc.Value);
            dgv_ThongKe.DataSource = dt;
            dgv_ThongKe.Columns[0].HeaderText = "Ngày bán";
            dgv_ThongKe.Columns[1].HeaderText = "Doanh số";

            dgv_ThongKe.Columns[0].Width = 150;
            dgv_ThongKe.Columns[1].Width = 150;
            dgv_ThongKe.AllowUserToAddRows = false;
            dgv_ThongKe.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void XemSoLuongSP()
        {
            tkBUS = new ThongKeBUS();
            DataTable dt = new DataTable();
            dt = tkBUS.SanPhamHetHang();
            dgv_ThongKe.DataSource = dt;
            dgv_ThongKe.Columns[0].HeaderText = "Mã sản phẩm";
            dgv_ThongKe.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_ThongKe.Columns[2].HeaderText = "Số lượng";

            dgv_ThongKe.Columns[0].Width = 100;
            dgv_ThongKe.Columns[1].Width = 200;
            dgv_ThongKe.Columns[2].Width = 100;
            dgv_ThongKe.AllowUserToAddRows = false;
            dgv_ThongKe.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void XemSanPhamBanChay()
        {
            tkBUS = new ThongKeBUS();
            DataTable dt = new DataTable();
            dt = tkBUS.SanPhamBanChay(dtp_NgayBatDau.Value, dtp_NgayKetThuc.Value);
            dgv_ThongKe.DataSource = dt;
            dgv_ThongKe.Columns[0].HeaderText = "Mã sản phẩm";
            dgv_ThongKe.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_ThongKe.Columns[2].HeaderText = "Số lượng";

            dgv_ThongKe.Columns[0].Width = 200;
            dgv_ThongKe.Columns[1].Width = 200;
            dgv_ThongKe.Columns[2].Width = 100;
            dgv_ThongKe.AllowUserToAddRows = false;
            dgv_ThongKe.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void ChartDoanhSo()
        {
            tkBUS = new ThongKeBUS();
            DateTime ngaybd = new DateTime();
            int ds;
            int count = dgv_ThongKe.RowCount;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    ngaybd = Convert.ToDateTime(dgv_ThongKe.Rows[i].Cells[0].Value.ToString());
                    ds = Convert.ToInt32(dgv_ThongKe.Rows[i].Cells[1].Value.ToString());
                    chart_ThongKe.Series["Salary"].Points.AddXY(ngaybd.Day.ToString() + '-' + ngaybd.Month.ToString() + '-' + ngaybd.Year.ToString(), ds);
                }
                chart_ThongKe.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không có đơn hàng trong khoảng thời gian trên!");
            }
        }
        public void ChartSoLuongSP()
        {
            tkBUS = new ThongKeBUS();
            String tensp;
            int soluong;
            int count = dgv_ThongKe.RowCount;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    tensp = dgv_ThongKe.Rows[i].Cells[1].Value.ToString();
                    soluong = Convert.ToInt32(dgv_ThongKe.Rows[i].Cells[2].Value.ToString());
                    chart_ThongKe.Series["Salary"].Points.AddXY(tensp, soluong);
                }
                chart_ThongKe.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm!");
            }
        }
        public void ChartSPBanChay()
        {
            tkBUS = new ThongKeBUS();
            String tensp;
            int soluong;
            int count = dgv_ThongKe.RowCount;
            if (count != 0)
            {
                for (int i = 0; i < dgv_ThongKe.RowCount; i++)
                {
                    tensp = dgv_ThongKe.Rows[i].Cells[1].Value.ToString();
                    soluong = Convert.ToInt32(dgv_ThongKe.Rows[i].Cells[2].Value);
                    chart_ThongKe.Series["Salary"].Points.AddXY(tensp, soluong);
                }
                //Ẩn đường lưới dọc
                chart_ThongKe.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không có đơn hàng trong khoảng thời gian trên!");
            }
        }
        public void TinhTongDS(TextBox txt)
        {
            int tong = 0;
            for (int i = 0; i < dgv_ThongKe.Rows.Count; i++)
            {
                tong += Convert.ToInt32(dgv_ThongKe.Rows[i].Cells[1].Value);
            }
            txt.Text = tong.ToString();
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            txt_Tong.Text = "0";
            txt_Tong.Enabled = false;
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            chart_ThongKe.Titles.Clear();
            chart_ThongKe.Series["Salary"].Points.Clear();
            if (cb_DanhMuc.Text == "Doanh số")
            {
                XemDoanhSo();
                TinhTongDS(txt_Tong);
                chart_ThongKe.Titles.Add("Salary Chart");
                ChartDoanhSo();
            }
            else if (cb_DanhMuc.Text == "Sản phẩm hết hàng")
            {
                txt_Tong.Text = "0";
                XemSoLuongSP();
                chart_ThongKe.Titles.Add("Quantity of products Chart");
                ChartSoLuongSP();
            }
            else if (cb_DanhMuc.Text == "Sản phẩm bán chạy")
            {
                txt_Tong.Text = "0";
                XemSanPhamBanChay();
                chart_ThongKe.Titles.Add("Products in stock Chart");
                ChartSPBanChay();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ComboBox!");
                cb_DanhMuc.Focus();
            }
        }

        private void chart_ThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btn_HienThi_Click_1(object sender, EventArgs e)
        {
            chart_ThongKe.Titles.Clear();
            chart_ThongKe.Series["Salary"].Points.Clear();
            if (cb_DanhMuc.Text == "Doanh số")
            {
                XemDoanhSo();
                TinhTongDS(txt_Tong);
                chart_ThongKe.Titles.Add("Salary Chart");
                ChartDoanhSo();
            }
            else if (cb_DanhMuc.Text == "Sản phẩm hết hàng")
            {
                txt_Tong.Text = "0";
                XemSoLuongSP();
                chart_ThongKe.Titles.Add("Quantity of products Chart");
                ChartSoLuongSP();
            }
            else if (cb_DanhMuc.Text == "Sản phẩm bán chạy")
            {
                txt_Tong.Text = "0";
                XemSanPhamBanChay();
                chart_ThongKe.Titles.Add("Products in stock Chart");
                ChartSPBanChay();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ComboBox!");
                cb_DanhMuc.Focus();
            }
        }
    }

}
