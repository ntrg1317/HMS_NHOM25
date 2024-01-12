namespace HMS_NHOM25
{
    partial class QuanTriVien
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
            this.grbInforQTV = new System.Windows.Forms.GroupBox();
            this.cobTrangThaiQTV = new System.Windows.Forms.ComboBox();
            this.cobDiaChiQTV = new System.Windows.Forms.ComboBox();
            this.cobGioiTinhQTV = new System.Windows.Forms.ComboBox();
            this.DOBQTV = new System.Windows.Forms.DateTimePicker();
            this.txtSDTQTV = new System.Windows.Forms.TextBox();
            this.txtTenQTV = new System.Windows.Forms.TextBox();
            this.txtMaQTV = new System.Windows.Forms.TextBox();
            this.labTrangThaiQTV = new System.Windows.Forms.Label();
            this.labSDTQTV = new System.Windows.Forms.Label();
            this.labDiaChiQTV = new System.Windows.Forms.Label();
            this.labSexQTV = new System.Windows.Forms.Label();
            this.labNgaySinhQTV = new System.Windows.Forms.Label();
            this.labTenQTV = new System.Windows.Forms.Label();
            this.labMaQTV = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labTimKiemQTV = new System.Windows.Forms.Label();
            this.labTenQTVTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiemQTV = new System.Windows.Forms.TextBox();
            this.dgvInfoQTV = new System.Windows.Forms.DataGridView();
            this.btnSuaQTV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbInforQTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoQTV)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInforQTV
            // 
            this.grbInforQTV.Controls.Add(this.cobTrangThaiQTV);
            this.grbInforQTV.Controls.Add(this.cobDiaChiQTV);
            this.grbInforQTV.Controls.Add(this.cobGioiTinhQTV);
            this.grbInforQTV.Controls.Add(this.DOBQTV);
            this.grbInforQTV.Controls.Add(this.txtSDTQTV);
            this.grbInforQTV.Controls.Add(this.txtTenQTV);
            this.grbInforQTV.Controls.Add(this.txtMaQTV);
            this.grbInforQTV.Controls.Add(this.labTrangThaiQTV);
            this.grbInforQTV.Controls.Add(this.labSDTQTV);
            this.grbInforQTV.Controls.Add(this.labDiaChiQTV);
            this.grbInforQTV.Controls.Add(this.labSexQTV);
            this.grbInforQTV.Controls.Add(this.labNgaySinhQTV);
            this.grbInforQTV.Controls.Add(this.labTenQTV);
            this.grbInforQTV.Controls.Add(this.labMaQTV);
            this.grbInforQTV.ForeColor = System.Drawing.Color.Red;
            this.grbInforQTV.Location = new System.Drawing.Point(35, 67);
            this.grbInforQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforQTV.Name = "grbInforQTV";
            this.grbInforQTV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforQTV.Size = new System.Drawing.Size(1017, 208);
            this.grbInforQTV.TabIndex = 0;
            this.grbInforQTV.TabStop = false;
            this.grbInforQTV.Text = "Thông tin quản trị viên";
            // 
            // cobTrangThaiQTV
            // 
            this.cobTrangThaiQTV.FormattingEnabled = true;
            this.cobTrangThaiQTV.Items.AddRange(new object[] {
            "Hoạt Động",
            "Ngừng hoạt động"});
            this.cobTrangThaiQTV.Location = new System.Drawing.Point(146, 142);
            this.cobTrangThaiQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobTrangThaiQTV.Name = "cobTrangThaiQTV";
            this.cobTrangThaiQTV.Size = new System.Drawing.Size(184, 28);
            this.cobTrangThaiQTV.TabIndex = 17;
            // 
            // cobDiaChiQTV
            // 
            this.cobDiaChiQTV.FormattingEnabled = true;
            this.cobDiaChiQTV.Items.AddRange(new object[] {
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
            this.cobDiaChiQTV.Location = new System.Drawing.Point(450, 94);
            this.cobDiaChiQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiQTV.Name = "cobDiaChiQTV";
            this.cobDiaChiQTV.Size = new System.Drawing.Size(180, 28);
            this.cobDiaChiQTV.TabIndex = 16;
            // 
            // cobGioiTinhQTV
            // 
            this.cobGioiTinhQTV.FormattingEnabled = true;
            this.cobGioiTinhQTV.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhQTV.Location = new System.Drawing.Point(450, 48);
            this.cobGioiTinhQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobGioiTinhQTV.Name = "cobGioiTinhQTV";
            this.cobGioiTinhQTV.Size = new System.Drawing.Size(180, 28);
            this.cobGioiTinhQTV.TabIndex = 15;
            // 
            // DOBQTV
            // 
            this.DOBQTV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBQTV.Location = new System.Drawing.Point(778, 50);
            this.DOBQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBQTV.Name = "DOBQTV";
            this.DOBQTV.Size = new System.Drawing.Size(182, 26);
            this.DOBQTV.TabIndex = 13;
            // 
            // txtSDTQTV
            // 
            this.txtSDTQTV.Location = new System.Drawing.Point(780, 96);
            this.txtSDTQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTQTV.Name = "txtSDTQTV";
            this.txtSDTQTV.Size = new System.Drawing.Size(180, 26);
            this.txtSDTQTV.TabIndex = 12;
            this.txtSDTQTV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTQTV_KeyPress);
            // 
            // txtTenQTV
            // 
            this.txtTenQTV.Location = new System.Drawing.Point(146, 96);
            this.txtTenQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenQTV.Name = "txtTenQTV";
            this.txtTenQTV.Size = new System.Drawing.Size(184, 26);
            this.txtTenQTV.TabIndex = 10;
            // 
            // txtMaQTV
            // 
            this.txtMaQTV.Location = new System.Drawing.Point(146, 48);
            this.txtMaQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaQTV.Name = "txtMaQTV";
            this.txtMaQTV.ReadOnly = true;
            this.txtMaQTV.Size = new System.Drawing.Size(184, 26);
            this.txtMaQTV.TabIndex = 9;
            // 
            // labTrangThaiQTV
            // 
            this.labTrangThaiQTV.AutoSize = true;
            this.labTrangThaiQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTrangThaiQTV.Location = new System.Drawing.Point(37, 151);
            this.labTrangThaiQTV.Name = "labTrangThaiQTV";
            this.labTrangThaiQTV.Size = new System.Drawing.Size(80, 20);
            this.labTrangThaiQTV.TabIndex = 8;
            this.labTrangThaiQTV.Text = "Trạng thái";
            // 
            // labSDTQTV
            // 
            this.labSDTQTV.AutoSize = true;
            this.labSDTQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTQTV.Location = new System.Drawing.Point(685, 102);
            this.labSDTQTV.Name = "labSDTQTV";
            this.labSDTQTV.Size = new System.Drawing.Size(41, 20);
            this.labSDTQTV.TabIndex = 5;
            this.labSDTQTV.Text = "SĐT";
            // 
            // labDiaChiQTV
            // 
            this.labDiaChiQTV.AutoSize = true;
            this.labDiaChiQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiQTV.Location = new System.Drawing.Point(374, 102);
            this.labDiaChiQTV.Name = "labDiaChiQTV";
            this.labDiaChiQTV.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiQTV.TabIndex = 4;
            this.labDiaChiQTV.Text = "Địa chỉ";
            // 
            // labSexQTV
            // 
            this.labSexQTV.AutoSize = true;
            this.labSexQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexQTV.Location = new System.Drawing.Point(374, 50);
            this.labSexQTV.Name = "labSexQTV";
            this.labSexQTV.Size = new System.Drawing.Size(67, 20);
            this.labSexQTV.TabIndex = 3;
            this.labSexQTV.Text = "Giới tính";
            // 
            // labNgaySinhQTV
            // 
            this.labNgaySinhQTV.AutoSize = true;
            this.labNgaySinhQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhQTV.Location = new System.Drawing.Point(685, 52);
            this.labNgaySinhQTV.Name = "labNgaySinhQTV";
            this.labNgaySinhQTV.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinhQTV.TabIndex = 2;
            this.labNgaySinhQTV.Text = "Ngày sinh";
            // 
            // labTenQTV
            // 
            this.labTenQTV.AutoSize = true;
            this.labTenQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenQTV.Location = new System.Drawing.Point(37, 102);
            this.labTenQTV.Name = "labTenQTV";
            this.labTenQTV.Size = new System.Drawing.Size(77, 20);
            this.labTenQTV.TabIndex = 1;
            this.labTenQTV.Text = "Họ và tên";
            // 
            // labMaQTV
            // 
            this.labMaQTV.AutoSize = true;
            this.labMaQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaQTV.Location = new System.Drawing.Point(37, 50);
            this.labMaQTV.Name = "labMaQTV";
            this.labMaQTV.Size = new System.Drawing.Size(85, 20);
            this.labMaQTV.TabIndex = 0;
            this.labMaQTV.Text = "Mã quản lý";
            // 
            // labTimKiemQTV
            // 
            this.labTimKiemQTV.AutoSize = true;
            this.labTimKiemQTV.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemQTV.Location = new System.Drawing.Point(46, 289);
            this.labTimKiemQTV.Name = "labTimKiemQTV";
            this.labTimKiemQTV.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemQTV.TabIndex = 1;
            this.labTimKiemQTV.Text = "Tìm kiếm";
            // 
            // labTenQTVTimKiem
            // 
            this.labTenQTVTimKiem.AutoSize = true;
            this.labTenQTVTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenQTVTimKiem.Location = new System.Drawing.Point(68, 323);
            this.labTenQTVTimKiem.Name = "labTenQTVTimKiem";
            this.labTenQTVTimKiem.Size = new System.Drawing.Size(90, 20);
            this.labTenQTVTimKiem.TabIndex = 18;
            this.labTenQTVTimKiem.Text = "Tên quản lý";
            // 
            // txtTimKiemQTV
            // 
            this.txtTimKiemQTV.Location = new System.Drawing.Point(181, 316);
            this.txtTimKiemQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemQTV.Name = "txtTimKiemQTV";
            this.txtTimKiemQTV.Size = new System.Drawing.Size(184, 26);
            this.txtTimKiemQTV.TabIndex = 18;
            this.txtTimKiemQTV.TextChanged += new System.EventHandler(this.txtTimKiemQTV_TextChanged);
            // 
            // dgvInfoQTV
            // 
            this.dgvInfoQTV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoQTV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoQTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoQTV.Location = new System.Drawing.Point(35, 358);
            this.dgvInfoQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoQTV.Name = "dgvInfoQTV";
            this.dgvInfoQTV.RowHeadersWidth = 62;
            this.dgvInfoQTV.RowTemplate.Height = 28;
            this.dgvInfoQTV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoQTV.Size = new System.Drawing.Size(1019, 409);
            this.dgvInfoQTV.TabIndex = 23;
            this.dgvInfoQTV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoQTV_CellClick);
            // 
            // btnSuaQTV
            // 
            this.btnSuaQTV.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaQTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaQTV.Location = new System.Drawing.Point(520, 303);
            this.btnSuaQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaQTV.Name = "btnSuaQTV";
            this.btnSuaQTV.Size = new System.Drawing.Size(125, 39);
            this.btnSuaQTV.TabIndex = 22;
            this.btnSuaQTV.Text = "Cập nhật";
            this.btnSuaQTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaQTV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản trị viên";
            // 
            // QuanTriVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1091, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInfoQTV);
            this.Controls.Add(this.btnSuaQTV);
            this.Controls.Add(this.txtTimKiemQTV);
            this.Controls.Add(this.labTenQTVTimKiem);
            this.Controls.Add(this.labTimKiemQTV);
            this.Controls.Add(this.grbInforQTV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanTriVien";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.grbInforQTV.ResumeLayout(false);
            this.grbInforQTV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoQTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInforQTV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labMaQTV;
        private System.Windows.Forms.Label labNgaySinhQTV;
        private System.Windows.Forms.Label labTenQTV;
        private System.Windows.Forms.Label labSexQTV;
        private System.Windows.Forms.Label labTrangThaiQTV;
        private System.Windows.Forms.Label labSDTQTV;
        private System.Windows.Forms.Label labDiaChiQTV;
        private System.Windows.Forms.TextBox txtSDTQTV;
        private System.Windows.Forms.TextBox txtTenQTV;
        private System.Windows.Forms.TextBox txtMaQTV;
        private System.Windows.Forms.DateTimePicker DOBQTV;
        private System.Windows.Forms.ComboBox cobGioiTinhQTV;
        private System.Windows.Forms.ComboBox cobDiaChiQTV;
        private System.Windows.Forms.ComboBox cobTrangThaiQTV;
        private System.Windows.Forms.Label labTimKiemQTV;
        private System.Windows.Forms.Label labTenQTVTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemQTV;
        private System.Windows.Forms.Button btnSuaQTV;
        private System.Windows.Forms.DataGridView dgvInfoQTV;
        private System.Windows.Forms.Label label1;
    }
}