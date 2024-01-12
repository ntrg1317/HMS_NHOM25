namespace HMS_NHOM25
{
    partial class BenhNhan
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
            this.grbInfoBN = new System.Windows.Forms.GroupBox();
            this.cobDiaChiBN = new System.Windows.Forms.ComboBox();
            this.txtSDTNguoiThan = new System.Windows.Forms.TextBox();
            this.cobTrangThaiBN = new System.Windows.Forms.ComboBox();
            this.cobGioiTinhBN = new System.Windows.Forms.ComboBox();
            this.DOBBN = new System.Windows.Forms.DateTimePicker();
            this.txtSDTBN = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.labTrangThaiBN = new System.Windows.Forms.Label();
            this.labSDTNguoiThan = new System.Windows.Forms.Label();
            this.labSDTBN = new System.Windows.Forms.Label();
            this.labDiaChiBN = new System.Windows.Forms.Label();
            this.labSexBN = new System.Windows.Forms.Label();
            this.labNgaySinhBN = new System.Windows.Forms.Label();
            this.labTenBN = new System.Windows.Forms.Label();
            this.labMaBN = new System.Windows.Forms.Label();
            this.labTimKiemBN = new System.Windows.Forms.Label();
            this.labTenBNTimKiem = new System.Windows.Forms.Label();
            this.dgvInfoBN = new System.Windows.Forms.DataGridView();
            this.txtTimKiemBN = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSuaBN = new System.Windows.Forms.Button();
            this.btnXoaBN = new System.Windows.Forms.Button();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.labDS = new System.Windows.Forms.Label();
            this.labAddBS = new System.Windows.Forms.Label();
            this.grbInfoBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoBN)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoBN
            // 
            this.grbInfoBN.Controls.Add(this.cobDiaChiBN);
            this.grbInfoBN.Controls.Add(this.txtSDTNguoiThan);
            this.grbInfoBN.Controls.Add(this.cobTrangThaiBN);
            this.grbInfoBN.Controls.Add(this.cobGioiTinhBN);
            this.grbInfoBN.Controls.Add(this.DOBBN);
            this.grbInfoBN.Controls.Add(this.txtSDTBN);
            this.grbInfoBN.Controls.Add(this.txtTenBN);
            this.grbInfoBN.Controls.Add(this.txtMaBN);
            this.grbInfoBN.Controls.Add(this.labTrangThaiBN);
            this.grbInfoBN.Controls.Add(this.labSDTNguoiThan);
            this.grbInfoBN.Controls.Add(this.labSDTBN);
            this.grbInfoBN.Controls.Add(this.labDiaChiBN);
            this.grbInfoBN.Controls.Add(this.labSexBN);
            this.grbInfoBN.Controls.Add(this.labNgaySinhBN);
            this.grbInfoBN.Controls.Add(this.labTenBN);
            this.grbInfoBN.Controls.Add(this.labMaBN);
            this.grbInfoBN.ForeColor = System.Drawing.Color.Red;
            this.grbInfoBN.Location = new System.Drawing.Point(36, 78);
            this.grbInfoBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoBN.Name = "grbInfoBN";
            this.grbInfoBN.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoBN.Size = new System.Drawing.Size(1022, 232);
            this.grbInfoBN.TabIndex = 0;
            this.grbInfoBN.TabStop = false;
            this.grbInfoBN.Text = "Thông tin bệnh nhân";
            // 
            // cobDiaChiBN
            // 
            this.cobDiaChiBN.FormattingEnabled = true;
            this.cobDiaChiBN.Items.AddRange(new object[] {
            "Yên Bái",
            "Vĩnh Phúc",
            "Vĩnh Long",
            "Tuyên Quang",
            "Trà Vinh",
            "Tiền Giang",
            "Thừa Thiên Huế",
            "Thanh Hóa",
            "Thái Nguyên",
            "Thái Bình",
            "Tây Ninh",
            "Sơn La",
            "Sóc Trăng",
            "Quảng Trị",
            "Quảng Ninh",
            "Quảng Ngãi",
            "Quảng Nam",
            "Quảng Bình",
            "Phú Yên",
            "Phú Thọ",
            "Ninh Thuận",
            "Ninh Bình",
            "Nghệ An",
            "Nam Định",
            "Long An",
            "Lào Cai",
            "Lạng Sơn",
            "Lâm Đồng",
            "Lai Châu",
            "Kon Tum",
            "Kiên Giang",
            "Khánh Hòa",
            "Hưng Yên",
            "Hoà Bình",
            "Hậu Giang",
            "Hải Dương",
            "Hà Tĩnh",
            "Hà Nam",
            "Hà Giang",
            "Gia Lai",
            "Đồng Tháp",
            "Đồng Nai",
            "Điện Biên",
            "Đắk Nông",
            "Đắk Lắk",
            "Cao Bằng",
            "Cà Mau",
            "Bình Thuận",
            "Bình Phước",
            "Bình Dương",
            "Bình Định",
            "Bến Tre",
            "Bắc Ninh",
            "Bạc Liêu",
            "Bắc Kạn",
            "Bắc Giang",
            "Bà Rịa - Vũng Tàu",
            "An Giang",
            "Hồ Chí Minh",
            "Hải Phòng",
            "Hà Nội",
            "Đà Nẵng",
            "Cần Thơ"});
            this.cobDiaChiBN.Location = new System.Drawing.Point(450, 84);
            this.cobDiaChiBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiBN.Name = "cobDiaChiBN";
            this.cobDiaChiBN.Size = new System.Drawing.Size(180, 28);
            this.cobDiaChiBN.TabIndex = 24;
            // 
            // txtSDTNguoiThan
            // 
            this.txtSDTNguoiThan.Location = new System.Drawing.Point(808, 38);
            this.txtSDTNguoiThan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTNguoiThan.Name = "txtSDTNguoiThan";
            this.txtSDTNguoiThan.Size = new System.Drawing.Size(180, 26);
            this.txtSDTNguoiThan.TabIndex = 23;
            // 
            // cobTrangThaiBN
            // 
            this.cobTrangThaiBN.FormattingEnabled = true;
            this.cobTrangThaiBN.Items.AddRange(new object[] {
            "Hoạt động",
            "Ngừng hoạt động"});
            this.cobTrangThaiBN.Location = new System.Drawing.Point(808, 86);
            this.cobTrangThaiBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobTrangThaiBN.Name = "cobTrangThaiBN";
            this.cobTrangThaiBN.Size = new System.Drawing.Size(180, 28);
            this.cobTrangThaiBN.TabIndex = 17;
            // 
            // cobGioiTinhBN
            // 
            this.cobGioiTinhBN.FormattingEnabled = true;
            this.cobGioiTinhBN.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhBN.Location = new System.Drawing.Point(450, 36);
            this.cobGioiTinhBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobGioiTinhBN.Name = "cobGioiTinhBN";
            this.cobGioiTinhBN.Size = new System.Drawing.Size(180, 28);
            this.cobGioiTinhBN.TabIndex = 15;
            // 
            // DOBBN
            // 
            this.DOBBN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBBN.Location = new System.Drawing.Point(145, 132);
            this.DOBBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBBN.Name = "DOBBN";
            this.DOBBN.Size = new System.Drawing.Size(182, 26);
            this.DOBBN.TabIndex = 13;
            // 
            // txtSDTBN
            // 
            this.txtSDTBN.Location = new System.Drawing.Point(450, 132);
            this.txtSDTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTBN.Name = "txtSDTBN";
            this.txtSDTBN.Size = new System.Drawing.Size(180, 26);
            this.txtSDTBN.TabIndex = 12;
            this.txtSDTBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTBN_KeyPress);
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(145, 84);
            this.txtTenBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(184, 26);
            this.txtTenBN.TabIndex = 10;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(145, 35);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(184, 26);
            this.txtMaBN.TabIndex = 9;
            // 
            // labTrangThaiBN
            // 
            this.labTrangThaiBN.AutoSize = true;
            this.labTrangThaiBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTrangThaiBN.Location = new System.Drawing.Point(676, 88);
            this.labTrangThaiBN.Name = "labTrangThaiBN";
            this.labTrangThaiBN.Size = new System.Drawing.Size(80, 20);
            this.labTrangThaiBN.TabIndex = 8;
            this.labTrangThaiBN.Text = "Trạng thái";
            // 
            // labSDTNguoiThan
            // 
            this.labSDTNguoiThan.AutoSize = true;
            this.labSDTNguoiThan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTNguoiThan.Location = new System.Drawing.Point(676, 40);
            this.labSDTNguoiThan.Name = "labSDTNguoiThan";
            this.labSDTNguoiThan.Size = new System.Drawing.Size(122, 20);
            this.labSDTNguoiThan.TabIndex = 7;
            this.labSDTNguoiThan.Text = "SĐT Người thân";
            // 
            // labSDTBN
            // 
            this.labSDTBN.AutoSize = true;
            this.labSDTBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTBN.Location = new System.Drawing.Point(374, 139);
            this.labSDTBN.Name = "labSDTBN";
            this.labSDTBN.Size = new System.Drawing.Size(41, 20);
            this.labSDTBN.TabIndex = 5;
            this.labSDTBN.Text = "SĐT";
            // 
            // labDiaChiBN
            // 
            this.labDiaChiBN.AutoSize = true;
            this.labDiaChiBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiBN.Location = new System.Drawing.Point(374, 90);
            this.labDiaChiBN.Name = "labDiaChiBN";
            this.labDiaChiBN.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiBN.TabIndex = 4;
            this.labDiaChiBN.Text = "Địa chỉ";
            // 
            // labSexBN
            // 
            this.labSexBN.AutoSize = true;
            this.labSexBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexBN.Location = new System.Drawing.Point(374, 38);
            this.labSexBN.Name = "labSexBN";
            this.labSexBN.Size = new System.Drawing.Size(67, 20);
            this.labSexBN.TabIndex = 3;
            this.labSexBN.Text = "Giới tính";
            // 
            // labNgaySinhBN
            // 
            this.labNgaySinhBN.AutoSize = true;
            this.labNgaySinhBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhBN.Location = new System.Drawing.Point(22, 139);
            this.labNgaySinhBN.Name = "labNgaySinhBN";
            this.labNgaySinhBN.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinhBN.TabIndex = 2;
            this.labNgaySinhBN.Text = "Ngày sinh";
            // 
            // labTenBN
            // 
            this.labTenBN.AutoSize = true;
            this.labTenBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBN.Location = new System.Drawing.Point(22, 90);
            this.labTenBN.Name = "labTenBN";
            this.labTenBN.Size = new System.Drawing.Size(77, 20);
            this.labTenBN.TabIndex = 1;
            this.labTenBN.Text = "Họ và tên";
            // 
            // labMaBN
            // 
            this.labMaBN.AutoSize = true;
            this.labMaBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBN.Location = new System.Drawing.Point(22, 38);
            this.labMaBN.Name = "labMaBN";
            this.labMaBN.Size = new System.Drawing.Size(111, 20);
            this.labMaBN.TabIndex = 0;
            this.labMaBN.Text = "Mã bệnh nhân";
            // 
            // labTimKiemBN
            // 
            this.labTimKiemBN.AutoSize = true;
            this.labTimKiemBN.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemBN.Location = new System.Drawing.Point(44, 326);
            this.labTimKiemBN.Name = "labTimKiemBN";
            this.labTimKiemBN.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemBN.TabIndex = 1;
            this.labTimKiemBN.Text = "Tìm kiếm";
            // 
            // labTenBNTimKiem
            // 
            this.labTenBNTimKiem.AutoSize = true;
            this.labTenBNTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBNTimKiem.Location = new System.Drawing.Point(58, 361);
            this.labTenBNTimKiem.Name = "labTenBNTimKiem";
            this.labTenBNTimKiem.Size = new System.Drawing.Size(116, 20);
            this.labTenBNTimKiem.TabIndex = 18;
            this.labTenBNTimKiem.Text = "Tên bệnh nhân";
            // 
            // dgvInfoBN
            // 
            this.dgvInfoBN.AllowUserToAddRows = false;
            this.dgvInfoBN.AllowUserToDeleteRows = false;
            this.dgvInfoBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoBN.Location = new System.Drawing.Point(36, 409);
            this.dgvInfoBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoBN.Name = "dgvInfoBN";
            this.dgvInfoBN.ReadOnly = true;
            this.dgvInfoBN.RowHeadersWidth = 62;
            this.dgvInfoBN.RowTemplate.Height = 28;
            this.dgvInfoBN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoBN.Size = new System.Drawing.Size(1022, 508);
            this.dgvInfoBN.TabIndex = 23;
            this.dgvInfoBN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoBN_CellClick);
            // 
            // txtTimKiemBN
            // 
            this.txtTimKiemBN.Location = new System.Drawing.Point(179, 355);
            this.txtTimKiemBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemBN.Name = "txtTimKiemBN";
            this.txtTimKiemBN.Size = new System.Drawing.Size(184, 26);
            this.txtTimKiemBN.TabIndex = 18;
            this.txtTimKiemBN.TextChanged += new System.EventHandler(this.txtTimKiemBN_TextChanged);
            // 
            // btnSuaBN
            // 
            this.btnSuaBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaBN.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBN.Location = new System.Drawing.Point(672, 349);
            this.btnSuaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaBN.Name = "btnSuaBN";
            this.btnSuaBN.Size = new System.Drawing.Size(116, 39);
            this.btnSuaBN.TabIndex = 22;
            this.btnSuaBN.Text = "Cập nhật";
            this.btnSuaBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBN.UseVisualStyleBackColor = true;
            this.btnSuaBN.Click += new System.EventHandler(this.btnSuaBN_Click);
            // 
            // btnXoaBN
            // 
            this.btnXoaBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaBN.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBN.Location = new System.Drawing.Point(903, 350);
            this.btnXoaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaBN.Name = "btnXoaBN";
            this.btnXoaBN.Size = new System.Drawing.Size(96, 39);
            this.btnXoaBN.TabIndex = 21;
            this.btnXoaBN.Text = "Xóa";
            this.btnXoaBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBN.UseVisualStyleBackColor = true;
            this.btnXoaBN.Click += new System.EventHandler(this.btnXoaBN_Click);
            // 
            // btnThemBN
            // 
            this.btnThemBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemBN.Image = global::HMS_NHOM25.Properties.Resources.add_user__1_;
            this.btnThemBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBN.Location = new System.Drawing.Point(434, 349);
            this.btnThemBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(124, 39);
            this.btnThemBN.TabIndex = 20;
            this.btnThemBN.Text = "Thêm BN";
            this.btnThemBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemBN.UseVisualStyleBackColor = true;
            this.btnThemBN.Click += new System.EventHandler(this.btnThemBN_Click);
            // 
            // labDS
            // 
            this.labDS.AutoSize = true;
            this.labDS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labDS.Location = new System.Drawing.Point(390, 32);
            this.labDS.Name = "labDS";
            this.labDS.Size = new System.Drawing.Size(310, 32);
            this.labDS.TabIndex = 25;
            this.labDS.Text = "Danh sách bệnh nhân";
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(429, 22);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(246, 32);
            this.labAddBS.TabIndex = 25;
            this.labAddBS.Text = "Danh sách bác sĩ";
            // 
            // BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1091, 930);
            this.Controls.Add(this.labAddBS);
            this.Controls.Add(this.dgvInfoBN);
            this.Controls.Add(this.btnSuaBN);
            this.Controls.Add(this.btnXoaBN);
            this.Controls.Add(this.btnThemBN);
            this.Controls.Add(this.txtTimKiemBN);
            this.Controls.Add(this.labTenBNTimKiem);
            this.Controls.Add(this.labTimKiemBN);
            this.Controls.Add(this.grbInfoBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BenhNhan";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            this.grbInfoBN.ResumeLayout(false);
            this.grbInfoBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfoBN;
        private System.Windows.Forms.Label labMaBN;
        private System.Windows.Forms.Label labNgaySinhBN;
        private System.Windows.Forms.Label labTenBN;
        private System.Windows.Forms.Label labSexBN;
        private System.Windows.Forms.Label labTrangThaiBN;
        private System.Windows.Forms.Label labSDTNguoiThan;
        private System.Windows.Forms.Label labSDTBN;
        private System.Windows.Forms.Label labDiaChiBN;
        private System.Windows.Forms.TextBox txtSDTBN;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.DateTimePicker DOBBN;
        private System.Windows.Forms.ComboBox cobGioiTinhBN;
        private System.Windows.Forms.ComboBox cobTrangThaiBN;
        private System.Windows.Forms.Label labTimKiemBN;
        private System.Windows.Forms.Label labTenBNTimKiem;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.Button btnXoaBN;
        private System.Windows.Forms.Button btnSuaBN;
        private System.Windows.Forms.DataGridView dgvInfoBN;
        private System.Windows.Forms.TextBox txtSDTNguoiThan;
        private System.Windows.Forms.TextBox txtTimKiemBN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cobDiaChiBN;
        private System.Windows.Forms.Label labDS;
        private System.Windows.Forms.Label labAddBS;
    }
}