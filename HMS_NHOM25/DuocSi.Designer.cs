using System;

namespace HMS_NHOM25
{
    partial class DuocSi
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
            this.grbInforNVYTe = new System.Windows.Forms.GroupBox();
            this.cobDiaChiDS = new System.Windows.Forms.ComboBox();
            this.cobTrangThaiDS = new System.Windows.Forms.ComboBox();
            this.cobGioiTinhDS = new System.Windows.Forms.ComboBox();
            this.DOBDS = new System.Windows.Forms.DateTimePicker();
            this.txtSDTDS = new System.Windows.Forms.TextBox();
            this.txtTenDS = new System.Windows.Forms.TextBox();
            this.txtMaDS = new System.Windows.Forms.TextBox();
            this.labTrangThaiNVYTe = new System.Windows.Forms.Label();
            this.labSDTNVYTe = new System.Windows.Forms.Label();
            this.labDiaChiNVYTe = new System.Windows.Forms.Label();
            this.labSexNVYTe = new System.Windows.Forms.Label();
            this.labNgaySinhNVYTe = new System.Windows.Forms.Label();
            this.labTenNVYTe = new System.Windows.Forms.Label();
            this.labMaNVYTe = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labTimKiemNVYTe = new System.Windows.Forms.Label();
            this.labTenNVYTeTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiemDS = new System.Windows.Forms.TextBox();
            this.dgvInfoDS = new System.Windows.Forms.DataGridView();
            this.labAddBS = new System.Windows.Forms.Label();
            this.btnSuaDS = new System.Windows.Forms.Button();
            this.btnXoaDS = new System.Windows.Forms.Button();
            this.btnThemDSi = new System.Windows.Forms.Button();
            this.grbInforNVYTe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInforNVYTe
            // 
            this.grbInforNVYTe.Controls.Add(this.cobDiaChiDS);
            this.grbInforNVYTe.Controls.Add(this.cobTrangThaiDS);
            this.grbInforNVYTe.Controls.Add(this.cobGioiTinhDS);
            this.grbInforNVYTe.Controls.Add(this.DOBDS);
            this.grbInforNVYTe.Controls.Add(this.txtSDTDS);
            this.grbInforNVYTe.Controls.Add(this.txtTenDS);
            this.grbInforNVYTe.Controls.Add(this.txtMaDS);
            this.grbInforNVYTe.Controls.Add(this.labTrangThaiNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labSDTNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labDiaChiNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labSexNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labNgaySinhNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labTenNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labMaNVYTe);
            this.grbInforNVYTe.ForeColor = System.Drawing.Color.Red;
            this.grbInforNVYTe.Location = new System.Drawing.Point(35, 71);
            this.grbInforNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforNVYTe.Name = "grbInforNVYTe";
            this.grbInforNVYTe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforNVYTe.Size = new System.Drawing.Size(1017, 208);
            this.grbInforNVYTe.TabIndex = 0;
            this.grbInforNVYTe.TabStop = false;
            this.grbInforNVYTe.Text = "Thông tin dược sĩ";
            // 
            // cobDiaChiDS
            // 
            this.cobDiaChiDS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobDiaChiDS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobDiaChiDS.FormattingEnabled = true;
            this.cobDiaChiDS.Items.AddRange(new object[] {
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
            this.cobDiaChiDS.Location = new System.Drawing.Point(450, 96);
            this.cobDiaChiDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiDS.Name = "cobDiaChiDS";
            this.cobDiaChiDS.Size = new System.Drawing.Size(180, 28);
            this.cobDiaChiDS.TabIndex = 18;
            // 
            // cobTrangThaiDS
            // 
            this.cobTrangThaiDS.FormattingEnabled = true;
            this.cobTrangThaiDS.Items.AddRange(new object[] {
            "Hoạt Động",
            "Ngừng hoạt động"});
            this.cobTrangThaiDS.Location = new System.Drawing.Point(146, 142);
            this.cobTrangThaiDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobTrangThaiDS.Name = "cobTrangThaiDS";
            this.cobTrangThaiDS.Size = new System.Drawing.Size(184, 28);
            this.cobTrangThaiDS.TabIndex = 17;
            // 
            // cobGioiTinhDS
            // 
            this.cobGioiTinhDS.FormattingEnabled = true;
            this.cobGioiTinhDS.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhDS.Location = new System.Drawing.Point(450, 48);
            this.cobGioiTinhDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobGioiTinhDS.Name = "cobGioiTinhDS";
            this.cobGioiTinhDS.Size = new System.Drawing.Size(180, 28);
            this.cobGioiTinhDS.TabIndex = 15;
            // 
            // DOBDS
            // 
            this.DOBDS.CustomFormat = "yyyy-MM-dd";
            this.DOBDS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBDS.Location = new System.Drawing.Point(778, 50);
            this.DOBDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBDS.Name = "DOBDS";
            this.DOBDS.Size = new System.Drawing.Size(182, 26);
            this.DOBDS.TabIndex = 13;
            // 
            // txtSDTDS
            // 
            this.txtSDTDS.Location = new System.Drawing.Point(780, 96);
            this.txtSDTDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTDS.Name = "txtSDTDS";
            this.txtSDTDS.Size = new System.Drawing.Size(180, 26);
            this.txtSDTDS.TabIndex = 12;
            this.txtSDTDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTDS_KeyPress);
            // 
            // txtTenDS
            // 
            this.txtTenDS.Location = new System.Drawing.Point(146, 96);
            this.txtTenDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDS.Name = "txtTenDS";
            this.txtTenDS.Size = new System.Drawing.Size(184, 26);
            this.txtTenDS.TabIndex = 10;
            // 
            // txtMaDS
            // 
            this.txtMaDS.Location = new System.Drawing.Point(146, 48);
            this.txtMaDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDS.Name = "txtMaDS";
            this.txtMaDS.Size = new System.Drawing.Size(184, 26);
            this.txtMaDS.TabIndex = 9;
            // 
            // labTrangThaiNVYTe
            // 
            this.labTrangThaiNVYTe.AutoSize = true;
            this.labTrangThaiNVYTe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTrangThaiNVYTe.Location = new System.Drawing.Point(37, 151);
            this.labTrangThaiNVYTe.Name = "labTrangThaiNVYTe";
            this.labTrangThaiNVYTe.Size = new System.Drawing.Size(80, 20);
            this.labTrangThaiNVYTe.TabIndex = 8;
            this.labTrangThaiNVYTe.Text = "Trạng thái";
            // 
            // labSDTNVYTe
            // 
            this.labSDTNVYTe.AutoSize = true;
            this.labSDTNVYTe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTNVYTe.Location = new System.Drawing.Point(685, 102);
            this.labSDTNVYTe.Name = "labSDTNVYTe";
            this.labSDTNVYTe.Size = new System.Drawing.Size(41, 20);
            this.labSDTNVYTe.TabIndex = 5;
            this.labSDTNVYTe.Text = "SĐT";
            // 
            // labDiaChiNVYTe
            // 
            this.labDiaChiNVYTe.AutoSize = true;
            this.labDiaChiNVYTe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiNVYTe.Location = new System.Drawing.Point(374, 102);
            this.labDiaChiNVYTe.Name = "labDiaChiNVYTe";
            this.labDiaChiNVYTe.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiNVYTe.TabIndex = 4;
            this.labDiaChiNVYTe.Text = "Địa chỉ";
            // 
            // labSexNVYTe
            // 
            this.labSexNVYTe.AutoSize = true;
            this.labSexNVYTe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexNVYTe.Location = new System.Drawing.Point(374, 50);
            this.labSexNVYTe.Name = "labSexNVYTe";
            this.labSexNVYTe.Size = new System.Drawing.Size(67, 20);
            this.labSexNVYTe.TabIndex = 3;
            this.labSexNVYTe.Text = "Giới tính";
            // 
            // labNgaySinhNVYTe
            // 
            this.labNgaySinhNVYTe.AutoSize = true;
            this.labNgaySinhNVYTe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhNVYTe.Location = new System.Drawing.Point(685, 52);
            this.labNgaySinhNVYTe.Name = "labNgaySinhNVYTe";
            this.labNgaySinhNVYTe.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinhNVYTe.TabIndex = 2;
            this.labNgaySinhNVYTe.Text = "Ngày sinh";
            // 
            // labTenNVYTe
            // 
            this.labTenNVYTe.AutoSize = true;
            this.labTenNVYTe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenNVYTe.Location = new System.Drawing.Point(37, 102);
            this.labTenNVYTe.Name = "labTenNVYTe";
            this.labTenNVYTe.Size = new System.Drawing.Size(77, 20);
            this.labTenNVYTe.TabIndex = 1;
            this.labTenNVYTe.Text = "Họ và tên";
            // 
            // labMaNVYTe
            // 
            this.labMaNVYTe.AutoSize = true;
            this.labMaNVYTe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaNVYTe.Location = new System.Drawing.Point(37, 50);
            this.labMaNVYTe.Name = "labMaNVYTe";
            this.labMaNVYTe.Size = new System.Drawing.Size(103, 20);
            this.labMaNVYTe.TabIndex = 0;
            this.labMaNVYTe.Text = "Mã nhân viên";
            // 
            // labTimKiemNVYTe
            // 
            this.labTimKiemNVYTe.AutoSize = true;
            this.labTimKiemNVYTe.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemNVYTe.Location = new System.Drawing.Point(46, 292);
            this.labTimKiemNVYTe.Name = "labTimKiemNVYTe";
            this.labTimKiemNVYTe.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemNVYTe.TabIndex = 1;
            this.labTimKiemNVYTe.Text = "Tìm kiếm";
            // 
            // labTenNVYTeTimKiem
            // 
            this.labTenNVYTeTimKiem.AutoSize = true;
            this.labTenNVYTeTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenNVYTeTimKiem.Location = new System.Drawing.Point(68, 328);
            this.labTenNVYTeTimKiem.Name = "labTenNVYTeTimKiem";
            this.labTenNVYTeTimKiem.Size = new System.Drawing.Size(108, 20);
            this.labTenNVYTeTimKiem.TabIndex = 18;
            this.labTenNVYTeTimKiem.Text = "Tên nhân viên";
            // 
            // txtTimKiemDS
            // 
            this.txtTimKiemDS.Location = new System.Drawing.Point(181, 320);
            this.txtTimKiemDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemDS.Name = "txtTimKiemDS";
            this.txtTimKiemDS.Size = new System.Drawing.Size(184, 26);
            this.txtTimKiemDS.TabIndex = 18;
            this.txtTimKiemDS.TextChanged += new System.EventHandler(this.txtTimKiemNVYTe_TextChanged);
            // 
            // dgvInfoDS
            // 
            this.dgvInfoDS.AllowUserToAddRows = false;
            this.dgvInfoDS.AllowUserToDeleteRows = false;
            this.dgvInfoDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoDS.Location = new System.Drawing.Point(35, 375);
            this.dgvInfoDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoDS.Name = "dgvInfoDS";
            this.dgvInfoDS.ReadOnly = true;
            this.dgvInfoDS.RowHeadersWidth = 62;
            this.dgvInfoDS.RowTemplate.Height = 28;
            this.dgvInfoDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoDS.Size = new System.Drawing.Size(1022, 392);
            this.dgvInfoDS.TabIndex = 23;
            this.dgvInfoDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoNVYTe_CellClick);
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(407, 24);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(263, 32);
            this.labAddBS.TabIndex = 24;
            this.labAddBS.Text = "Danh sách dược sĩ";
            // 
            // btnSuaDS
            // 
            this.btnSuaDS.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDS.Location = new System.Drawing.Point(678, 318);
            this.btnSuaDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaDS.Name = "btnSuaDS";
            this.btnSuaDS.Size = new System.Drawing.Size(120, 39);
            this.btnSuaDS.TabIndex = 22;
            this.btnSuaDS.Text = "Cập nhật";
            this.btnSuaDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDS.UseVisualStyleBackColor = true;
            this.btnSuaDS.Click += new System.EventHandler(this.btnSuaDS_Click);
            // 
            // btnXoaDS
            // 
            this.btnXoaDS.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDS.Location = new System.Drawing.Point(899, 318);
            this.btnXoaDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDS.Name = "btnXoaDS";
            this.btnXoaDS.Size = new System.Drawing.Size(96, 39);
            this.btnXoaDS.TabIndex = 21;
            this.btnXoaDS.Text = "Xóa";
            this.btnXoaDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDS.UseVisualStyleBackColor = true;
            this.btnXoaDS.Click += new System.EventHandler(this.btnXoaDS_Click);
            // 
            // btnThemDSi
            // 
            this.btnThemDSi.Image = global::HMS_NHOM25.Properties.Resources.add_user__1_;
            this.btnThemDSi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDSi.Location = new System.Drawing.Point(485, 318);
            this.btnThemDSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDSi.Name = "btnThemDSi";
            this.btnThemDSi.Size = new System.Drawing.Size(99, 39);
            this.btnThemDSi.TabIndex = 20;
            this.btnThemDSi.Text = "Thêm";
            this.btnThemDSi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDSi.UseVisualStyleBackColor = true;
            this.btnThemDSi.Click += new System.EventHandler(this.btnThemDSi_Click);
            // 
            // DuocSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1091, 780);
            this.Controls.Add(this.labAddBS);
            this.Controls.Add(this.dgvInfoDS);
            this.Controls.Add(this.btnSuaDS);
            this.Controls.Add(this.btnXoaDS);
            this.Controls.Add(this.btnThemDSi);
            this.Controls.Add(this.txtTimKiemDS);
            this.Controls.Add(this.labTenNVYTeTimKiem);
            this.Controls.Add(this.labTimKiemNVYTe);
            this.Controls.Add(this.grbInforNVYTe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DuocSi";
            this.Text = "NVYTe";
            this.Load += new System.EventHandler(this.DS_Load);
            this.grbInforNVYTe.ResumeLayout(false);
            this.grbInforNVYTe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInforNVYTe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labMaNVYTe;
        private System.Windows.Forms.Label labNgaySinhNVYTe;
        private System.Windows.Forms.Label labTenNVYTe;
        private System.Windows.Forms.Label labSexNVYTe;
        private System.Windows.Forms.Label labTrangThaiNVYTe;
        private System.Windows.Forms.Label labSDTNVYTe;
        private System.Windows.Forms.Label labDiaChiNVYTe;
        private System.Windows.Forms.TextBox txtSDTDS;
        private System.Windows.Forms.TextBox txtTenDS;
        private System.Windows.Forms.TextBox txtMaDS;
        private System.Windows.Forms.DateTimePicker DOBDS;
        private System.Windows.Forms.ComboBox cobGioiTinhDS;
        private System.Windows.Forms.ComboBox cobTrangThaiDS;
        private System.Windows.Forms.Label labTimKiemNVYTe;
        private System.Windows.Forms.Label labTenNVYTeTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemDS;
        private System.Windows.Forms.Button btnThemDSi;
        private System.Windows.Forms.Button btnXoaDS;
        private System.Windows.Forms.Button btnSuaDS;
        private System.Windows.Forms.DataGridView dgvInfoDS;
        private System.Windows.Forms.ComboBox cobDiaChiDS;
        private System.Windows.Forms.Label labAddBS;
    }
}