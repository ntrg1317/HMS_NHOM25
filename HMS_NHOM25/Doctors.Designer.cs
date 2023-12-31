namespace HMS_NHOM25
{
    partial class Doctors
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
            this.txtDiaChiBS = new System.Windows.Forms.TextBox();
            this.cobChuyenMonBS = new System.Windows.Forms.ComboBox();
            this.cobTrangThaiBS = new System.Windows.Forms.ComboBox();
            this.cobSexBS = new System.Windows.Forms.ComboBox();
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
            this.grbInforBS.Controls.Add(this.txtDiaChiBS);
            this.grbInforBS.Controls.Add(this.cobChuyenMonBS);
            this.grbInforBS.Controls.Add(this.cobTrangThaiBS);
            this.grbInforBS.Controls.Add(this.cobSexBS);
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
            this.grbInforBS.Location = new System.Drawing.Point(31, 18);
            this.grbInforBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforBS.Name = "grbInforBS";
            this.grbInforBS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforBS.Size = new System.Drawing.Size(904, 166);
            this.grbInforBS.TabIndex = 0;
            this.grbInforBS.TabStop = false;
            this.grbInforBS.Text = "Thông tin bác sĩ";
            // 
            // txtDiaChiBS
            // 
            this.txtDiaChiBS.Location = new System.Drawing.Point(400, 79);
            this.txtDiaChiBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiBS.Name = "txtDiaChiBS";
            this.txtDiaChiBS.Size = new System.Drawing.Size(180, 22);
            this.txtDiaChiBS.TabIndex = 19;
            // 
            // cobChuyenMonBS
            // 
            this.cobChuyenMonBS.FormattingEnabled = true;
            this.cobChuyenMonBS.Items.AddRange(new object[] {
            "Sản",
            "Tim Mạch",
            "Răng - Hàm - Mặt",
            "Da liễu"});
            this.cobChuyenMonBS.Location = new System.Drawing.Point(702, 75);
            this.cobChuyenMonBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobChuyenMonBS.Name = "cobChuyenMonBS";
            this.cobChuyenMonBS.Size = new System.Drawing.Size(164, 24);
            this.cobChuyenMonBS.TabIndex = 18;
            // 
            // cobTrangThaiBS
            // 
            this.cobTrangThaiBS.FormattingEnabled = true;
            this.cobTrangThaiBS.Items.AddRange(new object[] {
            "Hoạt Động",
            "Ngừng hoạt động"});
            this.cobTrangThaiBS.Location = new System.Drawing.Point(702, 118);
            this.cobTrangThaiBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobTrangThaiBS.Name = "cobTrangThaiBS";
            this.cobTrangThaiBS.Size = new System.Drawing.Size(164, 24);
            this.cobTrangThaiBS.TabIndex = 17;
            // 
            // cobSexBS
            // 
            this.cobSexBS.FormattingEnabled = true;
            this.cobSexBS.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobSexBS.Location = new System.Drawing.Point(400, 40);
            this.cobSexBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSexBS.Name = "cobSexBS";
            this.cobSexBS.Size = new System.Drawing.Size(180, 24);
            this.cobSexBS.TabIndex = 15;
            // 
            // DOBBS
            // 
            this.DOBBS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBBS.Location = new System.Drawing.Point(116, 120);
            this.DOBBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBBS.Name = "DOBBS";
            this.DOBBS.Size = new System.Drawing.Size(162, 22);
            this.DOBBS.TabIndex = 13;
            // 
            // txtSDTBS
            // 
            this.txtSDTBS.Location = new System.Drawing.Point(400, 120);
            this.txtSDTBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTBS.Name = "txtSDTBS";
            this.txtSDTBS.Size = new System.Drawing.Size(180, 22);
            this.txtSDTBS.TabIndex = 12;
            // 
            // txtBangCapBS
            // 
            this.txtBangCapBS.Location = new System.Drawing.Point(702, 40);
            this.txtBangCapBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBangCapBS.Name = "txtBangCapBS";
            this.txtBangCapBS.Size = new System.Drawing.Size(164, 22);
            this.txtBangCapBS.TabIndex = 11;
            // 
            // txtTenBS
            // 
            this.txtTenBS.Location = new System.Drawing.Point(116, 77);
            this.txtTenBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(164, 22);
            this.txtTenBS.TabIndex = 10;
            // 
            // txtMaBS
            // 
            this.txtMaBS.Location = new System.Drawing.Point(116, 38);
            this.txtMaBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(164, 22);
            this.txtMaBS.TabIndex = 9;
            // 
            // labTrangThaiBS
            // 
            this.labTrangThaiBS.AutoSize = true;
            this.labTrangThaiBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTrangThaiBS.Location = new System.Drawing.Point(606, 126);
            this.labTrangThaiBS.Name = "labTrangThaiBS";
            this.labTrangThaiBS.Size = new System.Drawing.Size(67, 16);
            this.labTrangThaiBS.TabIndex = 8;
            this.labTrangThaiBS.Text = "Trạng thái";
            // 
            // labChuyenMonBS
            // 
            this.labChuyenMonBS.AutoSize = true;
            this.labChuyenMonBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labChuyenMonBS.Location = new System.Drawing.Point(606, 82);
            this.labChuyenMonBS.Name = "labChuyenMonBS";
            this.labChuyenMonBS.Size = new System.Drawing.Size(81, 16);
            this.labChuyenMonBS.TabIndex = 7;
            this.labChuyenMonBS.Text = "Chuyên môn";
            // 
            // labBangCapBS
            // 
            this.labBangCapBS.AutoSize = true;
            this.labBangCapBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labBangCapBS.Location = new System.Drawing.Point(606, 40);
            this.labBangCapBS.Name = "labBangCapBS";
            this.labBangCapBS.Size = new System.Drawing.Size(65, 16);
            this.labBangCapBS.TabIndex = 6;
            this.labBangCapBS.Text = "Bằng cấp";
            // 
            // labSDTBS
            // 
            this.labSDTBS.AutoSize = true;
            this.labSDTBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTBS.Location = new System.Drawing.Point(332, 126);
            this.labSDTBS.Name = "labSDTBS";
            this.labSDTBS.Size = new System.Drawing.Size(34, 16);
            this.labSDTBS.TabIndex = 5;
            this.labSDTBS.Text = "SĐT";
            // 
            // labDiaChiBS
            // 
            this.labDiaChiBS.AutoSize = true;
            this.labDiaChiBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiBS.Location = new System.Drawing.Point(332, 82);
            this.labDiaChiBS.Name = "labDiaChiBS";
            this.labDiaChiBS.Size = new System.Drawing.Size(47, 16);
            this.labDiaChiBS.TabIndex = 4;
            this.labDiaChiBS.Text = "Địa chỉ";
            // 
            // labSexBS
            // 
            this.labSexBS.AutoSize = true;
            this.labSexBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexBS.Location = new System.Drawing.Point(332, 40);
            this.labSexBS.Name = "labSexBS";
            this.labSexBS.Size = new System.Drawing.Size(54, 16);
            this.labSexBS.TabIndex = 3;
            this.labSexBS.Text = "Giới tính";
            // 
            // labNgaySinhBS
            // 
            this.labNgaySinhBS.AutoSize = true;
            this.labNgaySinhBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhBS.Location = new System.Drawing.Point(33, 126);
            this.labNgaySinhBS.Name = "labNgaySinhBS";
            this.labNgaySinhBS.Size = new System.Drawing.Size(67, 16);
            this.labNgaySinhBS.TabIndex = 2;
            this.labNgaySinhBS.Text = "Ngày sinh";
            // 
            // labTenBS
            // 
            this.labTenBS.AutoSize = true;
            this.labTenBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBS.Location = new System.Drawing.Point(33, 82);
            this.labTenBS.Name = "labTenBS";
            this.labTenBS.Size = new System.Drawing.Size(64, 16);
            this.labTenBS.TabIndex = 1;
            this.labTenBS.Text = "Họ và tên";
            // 
            // labMaBS
            // 
            this.labMaBS.AutoSize = true;
            this.labMaBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBS.Location = new System.Drawing.Point(33, 40);
            this.labMaBS.Name = "labMaBS";
            this.labMaBS.Size = new System.Drawing.Size(67, 16);
            this.labMaBS.TabIndex = 0;
            this.labMaBS.Text = "Mã bác sĩ";
            // 
            // labTimKiemBS
            // 
            this.labTimKiemBS.AutoSize = true;
            this.labTimKiemBS.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemBS.Location = new System.Drawing.Point(41, 195);
            this.labTimKiemBS.Name = "labTimKiemBS";
            this.labTimKiemBS.Size = new System.Drawing.Size(62, 16);
            this.labTimKiemBS.TabIndex = 1;
            this.labTimKiemBS.Text = "Tìm kiếm";
            // 
            // labTenBSTimKiem
            // 
            this.labTenBSTimKiem.AutoSize = true;
            this.labTenBSTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBSTimKiem.Location = new System.Drawing.Point(60, 222);
            this.labTenBSTimKiem.Name = "labTenBSTimKiem";
            this.labTenBSTimKiem.Size = new System.Drawing.Size(72, 16);
            this.labTenBSTimKiem.TabIndex = 18;
            this.labTenBSTimKiem.Text = "Tên bác sĩ";
            // 
            // txtTimKiemBS
            // 
            this.txtTimKiemBS.Location = new System.Drawing.Point(147, 217);
            this.txtTimKiemBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemBS.Name = "txtTimKiemBS";
            this.txtTimKiemBS.Size = new System.Drawing.Size(164, 22);
            this.txtTimKiemBS.TabIndex = 18;
            this.txtTimKiemBS.TextChanged += new System.EventHandler(this.txtTimKiemBS_TextChanged);
            // 
            // dgvInfoBS
            // 
            this.dgvInfoBS.AllowUserToAddRows = false;
            this.dgvInfoBS.AllowUserToDeleteRows = false;
            this.dgvInfoBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoBS.Location = new System.Drawing.Point(31, 263);
            this.dgvInfoBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoBS.Name = "dgvInfoBS";
            this.dgvInfoBS.ReadOnly = true;
            this.dgvInfoBS.RowHeadersWidth = 62;
            this.dgvInfoBS.RowTemplate.Height = 28;
            this.dgvInfoBS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoBS.Size = new System.Drawing.Size(904, 396);
            this.dgvInfoBS.TabIndex = 23;
            this.dgvInfoBS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoBS_CellClick);
            // 
            // btnSuaBS
            // 
            this.btnSuaBS.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBS.Location = new System.Drawing.Point(682, 212);
            this.btnSuaBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaBS.Name = "btnSuaBS";
            this.btnSuaBS.Size = new System.Drawing.Size(101, 31);
            this.btnSuaBS.TabIndex = 22;
            this.btnSuaBS.Text = "Cập nhật";
            this.btnSuaBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBS.UseVisualStyleBackColor = true;
            this.btnSuaBS.Click += new System.EventHandler(this.btnSuaBS_Click);
            // 
            // btnXoaBS
            // 
            this.btnXoaBS.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBS.Location = new System.Drawing.Point(850, 212);
            this.btnXoaBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaBS.Name = "btnXoaBS";
            this.btnXoaBS.Size = new System.Drawing.Size(85, 31);
            this.btnXoaBS.TabIndex = 21;
            this.btnXoaBS.Text = "Xóa";
            this.btnXoaBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBS.UseVisualStyleBackColor = true;
            this.btnXoaBS.Click += new System.EventHandler(this.btnXoaBS_Click);
            // 
            // btnThemBS
            // 
            this.btnThemBS.Image = global::HMS_NHOM25.Properties.Resources.add_user__1_;
            this.btnThemBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBS.Location = new System.Drawing.Point(523, 212);
            this.btnThemBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemBS.Name = "btnThemBS";
            this.btnThemBS.Size = new System.Drawing.Size(88, 31);
            this.btnThemBS.TabIndex = 20;
            this.btnThemBS.Text = "Thêm";
            this.btnThemBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemBS.UseVisualStyleBackColor = true;
            this.btnThemBS.Click += new System.EventHandler(this.btnThemBS_Click);
            // 
            // btnTimKiemBS
            // 
            this.btnTimKiemBS.Image = global::HMS_NHOM25.Properties.Resources.find__1_;
            this.btnTimKiemBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemBS.Location = new System.Drawing.Point(366, 212);
            this.btnTimKiemBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemBS.Name = "btnTimKiemBS";
            this.btnTimKiemBS.Size = new System.Drawing.Size(97, 31);
            this.btnTimKiemBS.TabIndex = 19;
            this.btnTimKiemBS.Text = "Tìm kiếm";
            this.btnTimKiemBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemBS.UseVisualStyleBackColor = true;
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 683);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Doctors";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctors_Load);
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
        private System.Windows.Forms.ComboBox cobSexBS;
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
        private System.Windows.Forms.TextBox txtDiaChiBS;
    }
}