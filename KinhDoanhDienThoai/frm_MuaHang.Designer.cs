namespace KinhDoanhDienThoai
{
    partial class frm_MuaHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_TenSP = new System.Windows.Forms.ComboBox();
            this.cb_HangSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.btn_ChiTietSP = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_TenSP);
            this.groupBox1.Controls.Add(this.cb_HangSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 133);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sản phẩm";
            // 
            // cb_TenSP
            // 
            this.cb_TenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenSP.FormattingEnabled = true;
            this.cb_TenSP.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_TenSP.Location = new System.Drawing.Point(224, 79);
            this.cb_TenSP.Name = "cb_TenSP";
            this.cb_TenSP.Size = new System.Drawing.Size(310, 36);
            this.cb_TenSP.TabIndex = 22;
            // 
            // cb_HangSP
            // 
            this.cb_HangSP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_HangSP.FormattingEnabled = true;
            this.cb_HangSP.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_HangSP.Location = new System.Drawing.Point(224, 32);
            this.cb_HangSP.Name = "cb_HangSP";
            this.cb_HangSP.Size = new System.Drawing.Size(310, 36);
            this.cb_HangSP.TabIndex = 21;
            this.cb_HangSP.TextChanged += new System.EventHandler(this.cb_HangSP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hãng sản phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_SanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1754, 572);
            this.panel1.TabIndex = 12;
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SanPham.Location = new System.Drawing.Point(0, 0);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.RowTemplate.Height = 24;
            this.dgv_SanPham.Size = new System.Drawing.Size(1754, 572);
            this.dgv_SanPham.TabIndex = 2;
            this.dgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellClick);
            // 
            // btn_ChiTietSP
            // 
            this.btn_ChiTietSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_ChiTietSP.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTietSP.Image = global::KinhDoanhDienThoai.Properties.Resources.mobile_notch;
            this.btn_ChiTietSP.Location = new System.Drawing.Point(811, 49);
            this.btn_ChiTietSP.Name = "btn_ChiTietSP";
            this.btn_ChiTietSP.Size = new System.Drawing.Size(272, 60);
            this.btn_ChiTietSP.TabIndex = 13;
            this.btn_ChiTietSP.Text = "Chi tiết sản phẩm";
            this.btn_ChiTietSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChiTietSP.UseVisualStyleBackColor = false;
            this.btn_ChiTietSP.Click += new System.EventHandler(this.btn_ChiTietSP_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = global::KinhDoanhDienThoai.Properties.Resources.search;
            this.btn_TimKiem.Location = new System.Drawing.Point(601, 49);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(178, 60);
            this.btn_TimKiem.TabIndex = 11;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // frm_MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 753);
            this.Controls.Add(this.btn_ChiTietSP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_MuaHang";
            this.Text = "frm_MuaHang";
            this.Load += new System.EventHandler(this.frm_MuaHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_HangSP;
        private System.Windows.Forms.ComboBox cb_TenSP;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.Button btn_ChiTietSP;
    }
}