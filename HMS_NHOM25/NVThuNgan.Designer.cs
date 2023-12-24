namespace HMS_NHOM25
{
    partial class NVThuNgan
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
            this.grbInforNVTN = new System.Windows.Forms.GroupBox();
            this.cobTrangThaiNVTN = new System.Windows.Forms.ComboBox();
            this.cobDiaChiNVTN = new System.Windows.Forms.ComboBox();
            this.cobGioiTinhNVTN = new System.Windows.Forms.ComboBox();
            this.DOBNVTN = new System.Windows.Forms.DateTimePicker();
            this.txtSDTNVTN = new System.Windows.Forms.TextBox();
            this.txtTenNVTN = new System.Windows.Forms.TextBox();
            this.txtMaNVTN = new System.Windows.Forms.TextBox();
            this.labTrangThaiNVTN = new System.Windows.Forms.Label();
            this.labSDTNVTN = new System.Windows.Forms.Label();
            this.labDiaChiNVTN = new System.Windows.Forms.Label();
            this.labSexNVTN = new System.Windows.Forms.Label();
            this.labNgaySinhNVTN = new System.Windows.Forms.Label();
            this.labTenNVTN = new System.Windows.Forms.Label();
            this.labMaNVTN = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labTimKiemNVTN = new System.Windows.Forms.Label();
            this.labTenNVTNTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiemNVTN = new System.Windows.Forms.TextBox();
            this.dgvInfoNVTN = new System.Windows.Forms.DataGridView();
            this.btnSuaNVTN = new System.Windows.Forms.Button();
            this.btnXoaNVTN = new System.Windows.Forms.Button();
            this.btnThemNVTN = new System.Windows.Forms.Button();
            this.btnTimKiemNVTN = new System.Windows.Forms.Button();
            this.grbInforNVTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoNVTN)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInforNVTN
            // 
            this.grbInforNVTN.Controls.Add(this.cobTrangThaiNVTN);
            this.grbInforNVTN.Controls.Add(this.cobDiaChiNVTN);
            this.grbInforNVTN.Controls.Add(this.cobGioiTinhNVTN);
            this.grbInforNVTN.Controls.Add(this.DOBNVTN);
            this.grbInforNVTN.Controls.Add(this.txtSDTNVTN);
            this.grbInforNVTN.Controls.Add(this.txtTenNVTN);
            this.grbInforNVTN.Controls.Add(this.txtMaNVTN);
            this.grbInforNVTN.Controls.Add(this.labTrangThaiNVTN);
            this.grbInforNVTN.Controls.Add(this.labSDTNVTN);
            this.grbInforNVTN.Controls.Add(this.labDiaChiNVTN);
            this.grbInforNVTN.Controls.Add(this.labSexNVTN);
            this.grbInforNVTN.Controls.Add(this.labNgaySinhNVTN);
            this.grbInforNVTN.Controls.Add(this.labTenNVTN);
            this.grbInforNVTN.Controls.Add(this.labMaNVTN);
            this.grbInforNVTN.ForeColor = System.Drawing.Color.Red;
            this.grbInforNVTN.Location = new System.Drawing.Point(35, 22);
            this.grbInforNVTN.Name = "grbInforNVTN";
            this.grbInforNVTN.Size = new System.Drawing.Size(1017, 207);
            this.grbInforNVTN.TabIndex = 0;
            this.grbInforNVTN.TabStop = false;
            this.grbInforNVTN.Text = "Thông tin nhân viên thu ngân";
            this.grbInforNVTN.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cobTrangThaiNVTN
            // 
            this.cobTrangThaiNVTN.FormattingEnabled = true;
            this.cobTrangThaiNVTN.Items.AddRange(new object[] {
            "Hoạt Động",
            "Ngừng hoạt động"});
            this.cobTrangThaiNVTN.Location = new System.Drawing.Point(146, 143);
            this.cobTrangThaiNVTN.Name = "cobTrangThaiNVTN";
            this.cobTrangThaiNVTN.Size = new System.Drawing.Size(184, 28);
            this.cobTrangThaiNVTN.TabIndex = 17;
            // 
            // cobDiaChiNVTN
            // 
            this.cobDiaChiNVTN.FormattingEnabled = true;
            this.cobDiaChiNVTN.Items.AddRange(new object[] {
            "Đống Đa, Hà Nội",
            "Hai Bà Trưng, Hà Nội",
            "Phù Cừ, Hưng Yên"});
            this.cobDiaChiNVTN.Location = new System.Drawing.Point(450, 94);
            this.cobDiaChiNVTN.Name = "cobDiaChiNVTN";
            this.cobDiaChiNVTN.Size = new System.Drawing.Size(180, 28);
            this.cobDiaChiNVTN.TabIndex = 16;
            // 
            // cobGioiTinhNVTN
            // 
            this.cobGioiTinhNVTN.FormattingEnabled = true;
            this.cobGioiTinhNVTN.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhNVTN.Location = new System.Drawing.Point(450, 48);
            this.cobGioiTinhNVTN.Name = "cobGioiTinhNVTN";
            this.cobGioiTinhNVTN.Size = new System.Drawing.Size(180, 28);
            this.cobGioiTinhNVTN.TabIndex = 15;
            this.cobGioiTinhNVTN.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DOBNVTN
            // 
            this.DOBNVTN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBNVTN.Location = new System.Drawing.Point(778, 50);
            this.DOBNVTN.Name = "DOBNVTN";
            this.DOBNVTN.Size = new System.Drawing.Size(182, 26);
            this.DOBNVTN.TabIndex = 13;
            // 
            // txtSDTNVTN
            // 
            this.txtSDTNVTN.Location = new System.Drawing.Point(780, 96);
            this.txtSDTNVTN.Name = "txtSDTNVTN";
            this.txtSDTNVTN.Size = new System.Drawing.Size(180, 26);
            this.txtSDTNVTN.TabIndex = 12;
            // 
            // txtTenNVTN
            // 
            this.txtTenNVTN.Location = new System.Drawing.Point(146, 96);
            this.txtTenNVTN.Name = "txtTenNVTN";
            this.txtTenNVTN.Size = new System.Drawing.Size(184, 26);
            this.txtTenNVTN.TabIndex = 10;
            // 
            // txtMaNVTN
            // 
            this.txtMaNVTN.Location = new System.Drawing.Point(146, 47);
            this.txtMaNVTN.Name = "txtMaNVTN";
            this.txtMaNVTN.Size = new System.Drawing.Size(184, 26);
            this.txtMaNVTN.TabIndex = 9;
            // 
            // labTrangThaiNVTN
            // 
            this.labTrangThaiNVTN.AutoSize = true;
            this.labTrangThaiNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTrangThaiNVTN.Location = new System.Drawing.Point(37, 151);
            this.labTrangThaiNVTN.Name = "labTrangThaiNVTN";
            this.labTrangThaiNVTN.Size = new System.Drawing.Size(80, 20);
            this.labTrangThaiNVTN.TabIndex = 8;
            this.labTrangThaiNVTN.Text = "Trạng thái";
            this.labTrangThaiNVTN.Click += new System.EventHandler(this.label9_Click);
            // 
            // labSDTNVTN
            // 
            this.labSDTNVTN.AutoSize = true;
            this.labSDTNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTNVTN.Location = new System.Drawing.Point(685, 102);
            this.labSDTNVTN.Name = "labSDTNVTN";
            this.labSDTNVTN.Size = new System.Drawing.Size(41, 20);
            this.labSDTNVTN.TabIndex = 5;
            this.labSDTNVTN.Text = "SĐT";
            // 
            // labDiaChiNVTN
            // 
            this.labDiaChiNVTN.AutoSize = true;
            this.labDiaChiNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiNVTN.Location = new System.Drawing.Point(373, 102);
            this.labDiaChiNVTN.Name = "labDiaChiNVTN";
            this.labDiaChiNVTN.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiNVTN.TabIndex = 4;
            this.labDiaChiNVTN.Text = "Địa chỉ";
            // 
            // labSexNVTN
            // 
            this.labSexNVTN.AutoSize = true;
            this.labSexNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexNVTN.Location = new System.Drawing.Point(373, 50);
            this.labSexNVTN.Name = "labSexNVTN";
            this.labSexNVTN.Size = new System.Drawing.Size(67, 20);
            this.labSexNVTN.TabIndex = 3;
            this.labSexNVTN.Text = "Giới tính";
            // 
            // labNgaySinhNVTN
            // 
            this.labNgaySinhNVTN.AutoSize = true;
            this.labNgaySinhNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhNVTN.Location = new System.Drawing.Point(685, 52);
            this.labNgaySinhNVTN.Name = "labNgaySinhNVTN";
            this.labNgaySinhNVTN.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinhNVTN.TabIndex = 2;
            this.labNgaySinhNVTN.Text = "Ngày sinh";
            // 
            // labTenNVTN
            // 
            this.labTenNVTN.AutoSize = true;
            this.labTenNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenNVTN.Location = new System.Drawing.Point(37, 102);
            this.labTenNVTN.Name = "labTenNVTN";
            this.labTenNVTN.Size = new System.Drawing.Size(77, 20);
            this.labTenNVTN.TabIndex = 1;
            this.labTenNVTN.Text = "Họ và tên";
            this.labTenNVTN.Click += new System.EventHandler(this.label2_Click);
            // 
            // labMaNVTN
            // 
            this.labMaNVTN.AutoSize = true;
            this.labMaNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaNVTN.Location = new System.Drawing.Point(37, 50);
            this.labMaNVTN.Name = "labMaNVTN";
            this.labMaNVTN.Size = new System.Drawing.Size(103, 20);
            this.labMaNVTN.TabIndex = 0;
            this.labMaNVTN.Text = "Mã nhân viên";
            // 
            // labTimKiemNVTN
            // 
            this.labTimKiemNVTN.AutoSize = true;
            this.labTimKiemNVTN.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemNVTN.Location = new System.Drawing.Point(46, 244);
            this.labTimKiemNVTN.Name = "labTimKiemNVTN";
            this.labTimKiemNVTN.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemNVTN.TabIndex = 1;
            this.labTimKiemNVTN.Text = "Tìm kiếm";
            // 
            // labTenNVTNTimKiem
            // 
            this.labTenNVTNTimKiem.AutoSize = true;
            this.labTenNVTNTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenNVTNTimKiem.Location = new System.Drawing.Point(67, 277);
            this.labTenNVTNTimKiem.Name = "labTenNVTNTimKiem";
            this.labTenNVTNTimKiem.Size = new System.Drawing.Size(110, 20);
            this.labTenNVTNTimKiem.TabIndex = 18;
            this.labTenNVTNTimKiem.Text = "Tên Nhân viên";
            this.labTenNVTNTimKiem.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtTimKiemNVTN
            // 
            this.txtTimKiemNVTN.Location = new System.Drawing.Point(181, 271);
            this.txtTimKiemNVTN.Name = "txtTimKiemNVTN";
            this.txtTimKiemNVTN.Size = new System.Drawing.Size(184, 26);
            this.txtTimKiemNVTN.TabIndex = 18;
            // 
            // dgvInfoNVTN
            // 
            this.dgvInfoNVTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoNVTN.Location = new System.Drawing.Point(35, 329);
            this.dgvInfoNVTN.Name = "dgvInfoNVTN";
            this.dgvInfoNVTN.RowHeadersWidth = 62;
            this.dgvInfoNVTN.RowTemplate.Height = 28;
            this.dgvInfoNVTN.Size = new System.Drawing.Size(1021, 259);
            this.dgvInfoNVTN.TabIndex = 23;
            // 
            // btnSuaNVTN
            // 
            this.btnSuaNVTN.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaNVTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNVTN.Location = new System.Drawing.Point(756, 265);
            this.btnSuaNVTN.Name = "btnSuaNVTN";
            this.btnSuaNVTN.Size = new System.Drawing.Size(120, 39);
            this.btnSuaNVTN.TabIndex = 22;
            this.btnSuaNVTN.Text = "Cập nhật";
            this.btnSuaNVTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNVTN.UseVisualStyleBackColor = true;
            // 
            // btnXoaNVTN
            // 
            this.btnXoaNVTN.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaNVTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNVTN.Location = new System.Drawing.Point(932, 265);
            this.btnXoaNVTN.Name = "btnXoaNVTN";
            this.btnXoaNVTN.Size = new System.Drawing.Size(96, 39);
            this.btnXoaNVTN.TabIndex = 21;
            this.btnXoaNVTN.Text = "Xóa";
            this.btnXoaNVTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNVTN.UseVisualStyleBackColor = true;
            // 
            // btnThemNVTN
            // 
            this.btnThemNVTN.Image = global::HMS_NHOM25.Properties.Resources.add_user__1_;
            this.btnThemNVTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNVTN.Location = new System.Drawing.Point(588, 265);
            this.btnThemNVTN.Name = "btnThemNVTN";
            this.btnThemNVTN.Size = new System.Drawing.Size(102, 39);
            this.btnThemNVTN.TabIndex = 20;
            this.btnThemNVTN.Text = "Thêm";
            this.btnThemNVTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNVTN.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemNVTN
            // 
            this.btnTimKiemNVTN.Image = global::HMS_NHOM25.Properties.Resources.find__1_;
            this.btnTimKiemNVTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemNVTN.Location = new System.Drawing.Point(412, 265);
            this.btnTimKiemNVTN.Name = "btnTimKiemNVTN";
            this.btnTimKiemNVTN.Size = new System.Drawing.Size(109, 39);
            this.btnTimKiemNVTN.TabIndex = 19;
            this.btnTimKiemNVTN.Text = "Tìm kiếm";
            this.btnTimKiemNVTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemNVTN.UseVisualStyleBackColor = true;
            // 
            // NVThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 612);
            this.Controls.Add(this.dgvInfoNVTN);
            this.Controls.Add(this.btnSuaNVTN);
            this.Controls.Add(this.btnXoaNVTN);
            this.Controls.Add(this.btnThemNVTN);
            this.Controls.Add(this.btnTimKiemNVTN);
            this.Controls.Add(this.txtTimKiemNVTN);
            this.Controls.Add(this.labTenNVTNTimKiem);
            this.Controls.Add(this.labTimKiemNVTN);
            this.Controls.Add(this.grbInforNVTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NVThuNgan";
            this.Text = "NVThuNgan";
            this.Load += new System.EventHandler(this.Danh_sách_bác_sĩ_Load);
            this.grbInforNVTN.ResumeLayout(false);
            this.grbInforNVTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoNVTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInforNVTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labMaNVTN;
        private System.Windows.Forms.Label labNgaySinhNVTN;
        private System.Windows.Forms.Label labTenNVTN;
        private System.Windows.Forms.Label labSexNVTN;
        private System.Windows.Forms.Label labTrangThaiNVTN;
        private System.Windows.Forms.Label labSDTNVTN;
        private System.Windows.Forms.Label labDiaChiNVTN;
        private System.Windows.Forms.TextBox txtSDTNVTN;
        private System.Windows.Forms.TextBox txtTenNVTN;
        private System.Windows.Forms.TextBox txtMaNVTN;
        private System.Windows.Forms.DateTimePicker DOBNVTN;
        private System.Windows.Forms.ComboBox cobGioiTinhNVTN;
        private System.Windows.Forms.ComboBox cobDiaChiNVTN;
        private System.Windows.Forms.ComboBox cobTrangThaiNVTN;
        private System.Windows.Forms.Label labTimKiemNVTN;
        private System.Windows.Forms.Label labTenNVTNTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemNVTN;
        private System.Windows.Forms.Button btnTimKiemNVTN;
        private System.Windows.Forms.Button btnThemNVTN;
        private System.Windows.Forms.Button btnXoaNVTN;
        private System.Windows.Forms.Button btnSuaNVTN;
        private System.Windows.Forms.DataGridView dgvInfoNVTN;
    }
}