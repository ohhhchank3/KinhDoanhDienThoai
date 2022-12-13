namespace KinhDoanhDienThoai
{
    partial class frm_ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Tong = new System.Windows.Forms.TextBox();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.cb_DanhMuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.chart_ThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Tong);
            this.groupBox1.Controls.Add(this.dtp_NgayKetThuc);
            this.groupBox1.Controls.Add(this.dtp_NgayBatDau);
            this.groupBox1.Controls.Add(this.cb_DanhMuc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txt_Tong
            // 
            this.txt_Tong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong.Location = new System.Drawing.Point(613, 40);
            this.txt_Tong.Name = "txt_Tong";
            this.txt_Tong.Size = new System.Drawing.Size(299, 34);
            this.txt_Tong.TabIndex = 42;
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKetThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(145, 122);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(299, 34);
            this.dtp_NgayKetThuc.TabIndex = 41;
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(145, 82);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(299, 34);
            this.dtp_NgayBatDau.TabIndex = 40;
            // 
            // cb_DanhMuc
            // 
            this.cb_DanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DanhMuc.FormattingEnabled = true;
            this.cb_DanhMuc.Items.AddRange(new object[] {
            "Doanh số",
            "Sản phẩm bán chạy",
            "Sản phẩm hết hàng"});
            this.cb_DanhMuc.Location = new System.Drawing.Point(145, 40);
            this.cb_DanhMuc.Name = "cb_DanhMuc";
            this.cb_DanhMuc.Size = new System.Drawing.Size(299, 36);
            this.cb_DanhMuc.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Danh mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_HienThi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.Image = global::KinhDoanhDienThoai.Properties.Resources.chart_histogram1;
            this.btn_HienThi.Location = new System.Drawing.Point(977, 28);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(179, 60);
            this.btn_HienThi.TabIndex = 10;
            this.btn_HienThi.Text = "Hiển thị";
            this.btn_HienThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HienThi.UseVisualStyleBackColor = false;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1837, 609);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart_ThongKe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(697, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 609);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_ThongKe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 609);
            this.panel2.TabIndex = 0;
            // 
            // dgv_ThongKe
            // 
            this.dgv_ThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongKe.Location = new System.Drawing.Point(0, 0);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.RowHeadersWidth = 51;
            this.dgv_ThongKe.RowTemplate.Height = 24;
            this.dgv_ThongKe.Size = new System.Drawing.Size(603, 609);
            this.dgv_ThongKe.TabIndex = 2;
            // 
            // chart_ThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ThongKe.ChartAreas.Add(chartArea1);
            this.chart_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_ThongKe.Legends.Add(legend1);
            this.chart_ThongKe.Location = new System.Drawing.Point(0, 0);
            this.chart_ThongKe.Name = "chart_ThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            this.chart_ThongKe.Series.Add(series1);
            this.chart_ThongKe.Size = new System.Drawing.Size(1140, 609);
            this.chart_ThongKe.TabIndex = 0;
            this.chart_ThongKe.Text = "chart1";
            this.chart_ThongKe.Click += new System.EventHandler(this.chart_ThongKe_Click);
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 859);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ThongKe";
            this.Text = "frm_ThongKe";
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_DanhMuc;
        private System.Windows.Forms.DateTimePicker dtp_NgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtp_NgayBatDau;
        private System.Windows.Forms.TextBox txt_Tong;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_ThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ThongKe;
    }
}