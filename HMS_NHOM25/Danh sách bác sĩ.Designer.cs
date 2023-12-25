namespace HMS_NHOM25
{
    partial class Danh_sách_bác_sĩ
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
            this.grbInforBS = new System.Windows.Forms.GroupBox();
            this.cobChuyenMonBS = new System.Windows.Forms.ComboBox();
            this.cobTrangThaiBS = new System.Windows.Forms.ComboBox();
            this.cobDiaChiBS = new System.Windows.Forms.ComboBox();
            this.cobGioiTinhBS = new System.Windows.Forms.ComboBox();
            this.DOBBS = new System.Windows.Forms.DateTimePicker();
            this.txtSDTBS = new System.Windows.Forms.TextBox();
            this.txtBangCapBS = new System.Windows.Forms.TextBox();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.labTrangThaiBS = new System.Windows.Forms.Label();
            this.labChuyenMonBS = new System.Windows.Forms.Label();
            this.labBangCapBS = new System.Windows.Forms.Label();
            this.labSDTBS = new System.Windows.Forms.Label();
            this.labDiaChiBS = new System.Windows.Forms.Label();
            this.labSexBS = new System.Windows.Forms.Label();
            this.labNgaySinhBS = new System.Windows.Forms.Label();
            this.labTenBS = new System.Windows.Forms.Label();
            this.labMaBS = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labTimKiemBS = new System.Windows.Forms.Label();
            this.labTenBSTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiemBS = new System.Windows.Forms.TextBox();
            this.dgvInfoBS = new System.Windows.Forms.DataGridView();
            this.btnSuaBS = new System.Windows.Forms.Button();
            this.btnXoaBS = new System.Windows.Forms.Button();
            this.btnThemBS = new System.Windows.Forms.Button();
            this.btnTimKiemBS = new System.Windows.Forms.Button();
            this.grbInforBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoBS)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInforBS
            // 
            this.grbInforBS.Controls.Add(this.cobChuyenMonBS);
            this.grbInforBS.Controls.Add(this.cobTrangThaiBS);
            this.grbInforBS.Controls.Add(this.cobDiaChiBS);
            this.grbInforBS.Controls.Add(this.cobGioiTinhBS);
            this.grbInforBS.Controls.Add(this.DOBBS);
            this.grbInforBS.Controls.Add(this.txtSDTBS);
            this.grbInforBS.Controls.Add(this.txtBangCapBS);
            this.grbInforBS.Controls.Add(this.txtTenBS);
            this.grbInforBS.Controls.Add(this.txtMaBS);
            this.grbInforBS.Controls.Add(this.labTrangThaiBS);
            this.grbInforBS.Controls.Add(this.labChuyenMonBS);
            this.grbInforBS.Controls.Add(this.labBangCapBS);
            this.grbInforBS.Controls.Add(this.labSDTBS);
            this.grbInforBS.Controls.Add(this.labDiaChiBS);
            this.grbInforBS.Controls.Add(this.labSexBS);
            this.grbInforBS.Controls.Add(this.labNgaySinhBS);
            this.grbInforBS.Controls.Add(this.labTenBS);
            this.grbInforBS.Controls.Add(this.labMaBS);
            this.grbInforBS.ForeColor = System.Drawing.Color.Red;
            this.grbInforBS.Location = new System.Drawing.Point(35, 22);
            this.grbInforBS.Name = "grbInforBS";
            this.grbInforBS.Size = new System.Drawing.Size(1017, 207);
            this.grbInforBS.TabIndex = 0;
            this.grbInforBS.TabStop = false;
            this.grbInforBS.Text = "Thông tin bác sĩ";
            this.grbInforBS.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cobChuyenMonBS
            // 
            this.cobChuyenMonBS.FormattingEnabled = true;
            this.cobChuyenMonBS.Items.AddRange(new object[] {
            "Sản",
            "Tim Mạch",
            "Răng - Hàm - Mặt",
            "Da liễu"});
            this.cobChuyenMonBS.Location = new System.Drawing.Point(790, 94);
            this.cobChuyenMonBS.Name = "cobChuyenMonBS";
            this.cobChuyenMonBS.Size = new System.Drawing.Size(180, 28);
            this.cobChuyenMonBS.TabIndex = 18;
            // 
            // cobTrangThaiBS
            // 
            this.cobTrangThaiBS.FormattingEnabled = true;
            this.cobTrangThaiBS.Items.AddRange(new object[] {
            "Hoạt Động",
            "Ngừng hoạt động"});
            this.cobTrangThaiBS.Location = new System.Drawing.Point(790, 148);
            this.cobTrangThaiBS.Name = "cobTrangThaiBS";
            this.cobTrangThaiBS.Size = new System.Drawing.Size(184, 28);
            this.cobTrangThaiBS.TabIndex = 17;
            // 
            // cobDiaChiBS
            // 
            this.cobDiaChiBS.FormattingEnabled = true;
            this.cobDiaChiBS.Items.AddRange(new object[] {
            "Đống Đa, Hà Nội",
            "Hai Bà Trưng, Hà Nội",
            "Phù Cừ, Hưng Yên"});
            this.cobDiaChiBS.Location = new System.Drawing.Point(450, 94);
            this.cobDiaChiBS.Name = "cobDiaChiBS";
            this.cobDiaChiBS.Size = new System.Drawing.Size(180, 28);
            this.cobDiaChiBS.TabIndex = 16;
            // 
            // cobGioiTinhBS
            // 
            this.cobGioiTinhBS.FormattingEnabled = true;
            this.cobGioiTinhBS.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhBS.Location = new System.Drawing.Point(450, 48);
            this.cobGioiTinhBS.Name = "cobGioiTinhBS";
            this.cobGioiTinhBS.Size = new System.Drawing.Size(180, 28);
            this.cobGioiTinhBS.TabIndex = 15;
            this.cobGioiTinhBS.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DOBBS
            // 
            this.DOBBS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBBS.Location = new System.Drawing.Point(130, 150);
            this.DOBBS.Name = "DOBBS";
            this.DOBBS.Size = new System.Drawing.Size(182, 26);
            this.DOBBS.TabIndex = 13;
            // 
            // txtSDTBS
            // 
            this.txtSDTBS.Location = new System.Drawing.Point(450, 150);
            this.txtSDTBS.Name = "txtSDTBS";
            this.txtSDTBS.Size = new System.Drawing.Size(180, 26);
            this.txtSDTBS.TabIndex = 12;
            // 
            // txtBangCapBS
            // 
            this.txtBangCapBS.Location = new System.Drawing.Point(790, 50);
            this.txtBangCapBS.Name = "txtBangCapBS";
            this.txtBangCapBS.Size = new System.Drawing.Size(184, 26);
            this.txtBangCapBS.TabIndex = 11;
            // 
            // txtTenBS
            // 
            this.txtTenBS.Location = new System.Drawing.Point(130, 96);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(184, 26);
            this.txtTenBS.TabIndex = 10;
            // 
            // txtMaBS
            // 
            this.txtMaBS.Location = new System.Drawing.Point(130, 47);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(184, 26);
            this.txtMaBS.TabIndex = 9;
            // 
            // labTrangThaiBS
            // 
            this.labTrangThaiBS.AutoSize = true;
            this.labTrangThaiBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTrangThaiBS.Location = new System.Drawing.Point(682, 158);
            this.labTrangThaiBS.Name = "labTrangThaiBS";
            this.labTrangThaiBS.Size = new System.Drawing.Size(80, 20);
            this.labTrangThaiBS.TabIndex = 8;
            this.labTrangThaiBS.Text = "Trạng thái";
            this.labTrangThaiBS.Click += new System.EventHandler(this.label9_Click);
            // 
            // labChuyenMonBS
            // 
            this.labChuyenMonBS.AutoSize = true;
            this.labChuyenMonBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labChuyenMonBS.Location = new System.Drawing.Point(682, 102);
            this.labChuyenMonBS.Name = "labChuyenMonBS";
            this.labChuyenMonBS.Size = new System.Drawing.Size(98, 20);
            this.labChuyenMonBS.TabIndex = 7;
            this.labChuyenMonBS.Text = "Chuyên môn";
            // 
            // labBangCapBS
            // 
            this.labBangCapBS.AutoSize = true;
            this.labBangCapBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labBangCapBS.Location = new System.Drawing.Point(682, 50);
            this.labBangCapBS.Name = "labBangCapBS";
            this.labBangCapBS.Size = new System.Drawing.Size(77, 20);
            this.labBangCapBS.TabIndex = 6;
            this.labBangCapBS.Text = "Bằng cấp";
            this.labBangCapBS.Click += new System.EventHandler(this.label7_Click);
            // 
            // labSDTBS
            // 
            this.labSDTBS.AutoSize = true;
            this.labSDTBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTBS.Location = new System.Drawing.Point(373, 158);
            this.labSDTBS.Name = "labSDTBS";
            this.labSDTBS.Size = new System.Drawing.Size(41, 20);
            this.labSDTBS.TabIndex = 5;
            this.labSDTBS.Text = "SĐT";
            // 
            // labDiaChiBS
            // 
            this.labDiaChiBS.AutoSize = true;
            this.labDiaChiBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiBS.Location = new System.Drawing.Point(373, 102);
            this.labDiaChiBS.Name = "labDiaChiBS";
            this.labDiaChiBS.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiBS.TabIndex = 4;
            this.labDiaChiBS.Text = "Địa chỉ";
            // 
            // labSexBS
            // 
            this.labSexBS.AutoSize = true;
            this.labSexBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexBS.Location = new System.Drawing.Point(373, 50);
            this.labSexBS.Name = "labSexBS";
            this.labSexBS.Size = new System.Drawing.Size(67, 20);
            this.labSexBS.TabIndex = 3;
            this.labSexBS.Text = "Giới tính";
            // 
            // labNgaySinhBS
            // 
            this.labNgaySinhBS.AutoSize = true;
            this.labNgaySinhBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhBS.Location = new System.Drawing.Point(37, 158);
            this.labNgaySinhBS.Name = "labNgaySinhBS";
            this.labNgaySinhBS.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinhBS.TabIndex = 2;
            this.labNgaySinhBS.Text = "Ngày sinh";
            // 
            // labTenBS
            // 
            this.labTenBS.AutoSize = true;
            this.labTenBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBS.Location = new System.Drawing.Point(37, 102);
            this.labTenBS.Name = "labTenBS";
            this.labTenBS.Size = new System.Drawing.Size(77, 20);
            this.labTenBS.TabIndex = 1;
            this.labTenBS.Text = "Họ và tên";
            this.labTenBS.Click += new System.EventHandler(this.label2_Click);
            // 
            // labMaBS
            // 
            this.labMaBS.AutoSize = true;
            this.labMaBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBS.Location = new System.Drawing.Point(37, 50);
            this.labMaBS.Name = "labMaBS";
            this.labMaBS.Size = new System.Drawing.Size(76, 20);
            this.labMaBS.TabIndex = 0;
            this.labMaBS.Text = "Mã bác sĩ";
            // 
            // labTimKiemBS
            // 
            this.labTimKiemBS.AutoSize = true;
            this.labTimKiemBS.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemBS.Location = new System.Drawing.Point(46, 244);
            this.labTimKiemBS.Name = "labTimKiemBS";
            this.labTimKiemBS.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemBS.TabIndex = 1;
            this.labTimKiemBS.Text = "Tìm kiếm";
            // 
            // labTenBSTimKiem
            // 
            this.labTenBSTimKiem.AutoSize = true;
            this.labTenBSTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBSTimKiem.Location = new System.Drawing.Point(67, 277);
            this.labTenBSTimKiem.Name = "labTenBSTimKiem";
            this.labTenBSTimKiem.Size = new System.Drawing.Size(81, 20);
            this.labTenBSTimKiem.TabIndex = 18;
            this.labTenBSTimKiem.Text = "Tên bác sĩ";
            this.labTenBSTimKiem.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtTimKiemBS
            // 
            this.txtTimKiemBS.Location = new System.Drawing.Point(165, 271);
            this.txtTimKiemBS.Name = "txtTimKiemBS";
            this.txtTimKiemBS.Size = new System.Drawing.Size(184, 26);
            this.txtTimKiemBS.TabIndex = 18;
            // 
            // dgvInfoBS
            // 
            this.dgvInfoBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoBS.Location = new System.Drawing.Point(35, 329);
            this.dgvInfoBS.Name = "dgvInfoBS";
            this.dgvInfoBS.RowHeadersWidth = 62;
            this.dgvInfoBS.RowTemplate.Height = 28;
            this.dgvInfoBS.Size = new System.Drawing.Size(1021, 259);
            this.dgvInfoBS.TabIndex = 23;
            // 
            // btnSuaBS
            // 
            this.btnSuaBS.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBS.Location = new System.Drawing.Point(758, 265);
            this.btnSuaBS.Name = "btnSuaBS";
            this.btnSuaBS.Size = new System.Drawing.Size(114, 39);
            this.btnSuaBS.TabIndex = 22;
            this.btnSuaBS.Text = "Cập nhật";
            this.btnSuaBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBS.UseVisualStyleBackColor = true;
            // 
            // btnXoaBS
            // 
            this.btnXoaBS.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBS.Location = new System.Drawing.Point(932, 265);
            this.btnXoaBS.Name = "btnXoaBS";
            this.btnXoaBS.Size = new System.Drawing.Size(96, 39);
            this.btnXoaBS.TabIndex = 21;
            this.btnXoaBS.Text = "Xóa";
            this.btnXoaBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBS.UseVisualStyleBackColor = true;
            // 
            // btnThemBS
            // 
            this.btnThemBS.Image = global::HMS_NHOM25.Properties.Resources.add_user__1_;
            this.btnThemBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBS.Location = new System.Drawing.Point(598, 265);
            this.btnThemBS.Name = "btnThemBS";
            this.btnThemBS.Size = new System.Drawing.Size(99, 39);
            this.btnThemBS.TabIndex = 20;
            this.btnThemBS.Text = "Thêm";
            this.btnThemBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemBS.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemBS
            // 
            this.btnTimKiemBS.Image = global::HMS_NHOM25.Properties.Resources.find__1_;
            this.btnTimKiemBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemBS.Location = new System.Drawing.Point(412, 265);
            this.btnTimKiemBS.Name = "btnTimKiemBS";
            this.btnTimKiemBS.Size = new System.Drawing.Size(109, 39);
            this.btnTimKiemBS.TabIndex = 19;
            this.btnTimKiemBS.Text = "Tìm kiếm";
            this.btnTimKiemBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemBS.UseVisualStyleBackColor = true;
            // 
            // Danh_sách_bác_sĩ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 612);
            this.Controls.Add(this.dgvInfoBS);
            this.Controls.Add(this.btnSuaBS);
            this.Controls.Add(this.btnXoaBS);
            this.Controls.Add(this.btnThemBS);
            this.Controls.Add(this.btnTimKiemBS);
            this.Controls.Add(this.txtTimKiemBS);
            this.Controls.Add(this.labTenBSTimKiem);
            this.Controls.Add(this.labTimKiemBS);
            this.Controls.Add(this.grbInforBS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Danh_sách_bác_sĩ_Load);
            this.grbInforBS.ResumeLayout(false);
            this.grbInforBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInforBS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labMaBS;
        private System.Windows.Forms.Label labNgaySinhBS;
        private System.Windows.Forms.Label labTenBS;
        private System.Windows.Forms.Label labSexBS;
        private System.Windows.Forms.Label labTrangThaiBS;
        private System.Windows.Forms.Label labChuyenMonBS;
        private System.Windows.Forms.Label labBangCapBS;
        private System.Windows.Forms.Label labSDTBS;
        private System.Windows.Forms.Label labDiaChiBS;
        private System.Windows.Forms.TextBox txtSDTBS;
        private System.Windows.Forms.TextBox txtBangCapBS;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.DateTimePicker DOBBS;
        private System.Windows.Forms.ComboBox cobGioiTinhBS;
        private System.Windows.Forms.ComboBox cobDiaChiBS;
        private System.Windows.Forms.ComboBox cobTrangThaiBS;
        private System.Windows.Forms.Label labTimKiemBS;
        private System.Windows.Forms.Label labTenBSTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemBS;
        private System.Windows.Forms.Button btnTimKiemBS;
        private System.Windows.Forms.Button btnThemBS;
        private System.Windows.Forms.Button btnXoaBS;
        private System.Windows.Forms.Button btnSuaBS;
        private System.Windows.Forms.DataGridView dgvInfoBS;
        private System.Windows.Forms.ComboBox cobChuyenMonBS;
    }
}