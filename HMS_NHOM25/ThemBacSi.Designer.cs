namespace HMS_NHOM25
{
    partial class ThemBacSi
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
            this.labAddBS = new System.Windows.Forms.Label();
            this.palAddBS = new System.Windows.Forms.Panel();
            this.ptbBS = new System.Windows.Forms.PictureBox();
            this.grbAddInfoBS = new System.Windows.Forms.GroupBox();
            this.cobDiaChiBSM = new System.Windows.Forms.ComboBox();
            this.cobChuyenMonBSM = new System.Windows.Forms.ComboBox();
            this.cobSexBSM = new System.Windows.Forms.ComboBox();
            this.DOBBSM = new System.Windows.Forms.DateTimePicker();
            this.txtBangCapBSM = new System.Windows.Forms.TextBox();
            this.txtSDTBSM = new System.Windows.Forms.TextBox();
            this.labChuyenMonBSM = new System.Windows.Forms.Label();
            this.labDiaChiBSM = new System.Windows.Forms.Label();
            this.labBangCapBSM = new System.Windows.Forms.Label();
            this.labSDTBSM = new System.Windows.Forms.Label();
            this.txtTenBSM = new System.Windows.Forms.TextBox();
            this.labDOBBSM = new System.Windows.Forms.Label();
            this.labTenBSM = new System.Windows.Forms.Label();
            this.labSexBSM = new System.Windows.Forms.Label();
            this.grbTaiKhoanBSM = new System.Windows.Forms.GroupBox();
            this.txtTenDNBSM = new System.Windows.Forms.TextBox();
            this.txtMatKhauBSM = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThoatAddBS = new System.Windows.Forms.Button();
            this.btnSaveInfoBS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.palAddBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).BeginInit();
            this.grbAddInfoBS.SuspendLayout();
            this.grbTaiKhoanBSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(305, 32);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(178, 32);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Thêm bác sĩ";
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbBS);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(-6, 0);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(809, 101);
            this.palAddBS.TabIndex = 4;
            // 
            // ptbBS
            // 
            this.ptbBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbBS.Image = global::HMS_NHOM25.Properties.Resources.doctor;
            this.ptbBS.Location = new System.Drawing.Point(251, 31);
            this.ptbBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbBS.Name = "ptbBS";
            this.ptbBS.Size = new System.Drawing.Size(58, 34);
            this.ptbBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBS.TabIndex = 3;
            this.ptbBS.TabStop = false;
            // 
            // grbAddInfoBS
            // 
            this.grbAddInfoBS.Controls.Add(this.cobDiaChiBSM);
            this.grbAddInfoBS.Controls.Add(this.cobChuyenMonBSM);
            this.grbAddInfoBS.Controls.Add(this.cobSexBSM);
            this.grbAddInfoBS.Controls.Add(this.DOBBSM);
            this.grbAddInfoBS.Controls.Add(this.txtBangCapBSM);
            this.grbAddInfoBS.Controls.Add(this.txtSDTBSM);
            this.grbAddInfoBS.Controls.Add(this.labChuyenMonBSM);
            this.grbAddInfoBS.Controls.Add(this.labDiaChiBSM);
            this.grbAddInfoBS.Controls.Add(this.labBangCapBSM);
            this.grbAddInfoBS.Controls.Add(this.labSDTBSM);
            this.grbAddInfoBS.Controls.Add(this.txtTenBSM);
            this.grbAddInfoBS.Controls.Add(this.labDOBBSM);
            this.grbAddInfoBS.Controls.Add(this.labTenBSM);
            this.grbAddInfoBS.Controls.Add(this.labSexBSM);
            this.grbAddInfoBS.ForeColor = System.Drawing.Color.Red;
            this.grbAddInfoBS.Location = new System.Drawing.Point(30, 116);
            this.grbAddInfoBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoBS.Name = "grbAddInfoBS";
            this.grbAddInfoBS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoBS.Size = new System.Drawing.Size(729, 218);
            this.grbAddInfoBS.TabIndex = 5;
            this.grbAddInfoBS.TabStop = false;
            this.grbAddInfoBS.Text = "Thông tin bác sĩ mới";
            // 
            // cobDiaChiBSM
            // 
            this.cobDiaChiBSM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobDiaChiBSM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobDiaChiBSM.FormattingEnabled = true;
            this.cobDiaChiBSM.Items.AddRange(new object[] {
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
            this.cobDiaChiBSM.Location = new System.Drawing.Point(160, 176);
            this.cobDiaChiBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiBSM.Name = "cobDiaChiBSM";
            this.cobDiaChiBSM.Size = new System.Drawing.Size(152, 28);
            this.cobDiaChiBSM.TabIndex = 17;
            // 
            // cobChuyenMonBSM
            // 
            this.cobChuyenMonBSM.FormattingEnabled = true;
            this.cobChuyenMonBSM.Items.AddRange(new object[] {
            "Khoa Nội tổng quát",
            "Khoa Nhi",
            "Khoa Nha",
            "Khoa Tim mạch",
            "Khoa Hô hấp",
            "Khoa Gan – Tiêu hóa",
            "Khoa Nội thần kinh",
            "Khoa Mắt",
            "Khoa Tai – Mũi – Họng",
            "Khoa Sản phụ khoa",
            "Khoa Chẩn đoán hình ảnh",
            "Khoa Xét nghiệm",
            "Khoa Da liễu",
            "Tiểu phẩu"});
            this.cobChuyenMonBSM.Location = new System.Drawing.Point(532, 128);
            this.cobChuyenMonBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobChuyenMonBSM.Name = "cobChuyenMonBSM";
            this.cobChuyenMonBSM.Size = new System.Drawing.Size(152, 28);
            this.cobChuyenMonBSM.TabIndex = 16;
            // 
            // cobSexBSM
            // 
            this.cobSexBSM.FormattingEnabled = true;
            this.cobSexBSM.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cobSexBSM.Location = new System.Drawing.Point(160, 80);
            this.cobSexBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSexBSM.Name = "cobSexBSM";
            this.cobSexBSM.Size = new System.Drawing.Size(152, 28);
            this.cobSexBSM.TabIndex = 13;
            // 
            // DOBBSM
            // 
            this.DOBBSM.CustomFormat = "yyyy-MM-dd";
            this.DOBBSM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBBSM.Location = new System.Drawing.Point(160, 126);
            this.DOBBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBBSM.Name = "DOBBSM";
            this.DOBBSM.Size = new System.Drawing.Size(152, 26);
            this.DOBBSM.TabIndex = 12;
            this.DOBBSM.Value = new System.DateTime(2023, 12, 31, 21, 31, 58, 0);
            // 
            // txtBangCapBSM
            // 
            this.txtBangCapBSM.Location = new System.Drawing.Point(531, 82);
            this.txtBangCapBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBangCapBSM.Name = "txtBangCapBSM";
            this.txtBangCapBSM.Size = new System.Drawing.Size(154, 26);
            this.txtBangCapBSM.TabIndex = 10;
            // 
            // txtSDTBSM
            // 
            this.txtSDTBSM.Location = new System.Drawing.Point(530, 39);
            this.txtSDTBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTBSM.Name = "txtSDTBSM";
            this.txtSDTBSM.Size = new System.Drawing.Size(154, 26);
            this.txtSDTBSM.TabIndex = 9;
            this.txtSDTBSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTBSM_KeyPress);
            // 
            // labChuyenMonBSM
            // 
            this.labChuyenMonBSM.AutoSize = true;
            this.labChuyenMonBSM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labChuyenMonBSM.Location = new System.Drawing.Point(382, 132);
            this.labChuyenMonBSM.Name = "labChuyenMonBSM";
            this.labChuyenMonBSM.Size = new System.Drawing.Size(98, 20);
            this.labChuyenMonBSM.TabIndex = 7;
            this.labChuyenMonBSM.Text = "Chuyên môn";
            // 
            // labDiaChiBSM
            // 
            this.labDiaChiBSM.AutoSize = true;
            this.labDiaChiBSM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiBSM.Location = new System.Drawing.Point(34, 179);
            this.labDiaChiBSM.Name = "labDiaChiBSM";
            this.labDiaChiBSM.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiBSM.TabIndex = 6;
            this.labDiaChiBSM.Text = "Địa chỉ";
            // 
            // labBangCapBSM
            // 
            this.labBangCapBSM.AutoSize = true;
            this.labBangCapBSM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labBangCapBSM.Location = new System.Drawing.Point(382, 88);
            this.labBangCapBSM.Name = "labBangCapBSM";
            this.labBangCapBSM.Size = new System.Drawing.Size(77, 20);
            this.labBangCapBSM.TabIndex = 5;
            this.labBangCapBSM.Text = "Bằng cấp";
            // 
            // labSDTBSM
            // 
            this.labSDTBSM.AutoSize = true;
            this.labSDTBSM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTBSM.Location = new System.Drawing.Point(382, 42);
            this.labSDTBSM.Name = "labSDTBSM";
            this.labSDTBSM.Size = new System.Drawing.Size(41, 20);
            this.labSDTBSM.TabIndex = 4;
            this.labSDTBSM.Text = "SĐT";
            // 
            // txtTenBSM
            // 
            this.txtTenBSM.Location = new System.Drawing.Point(160, 36);
            this.txtTenBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenBSM.Name = "txtTenBSM";
            this.txtTenBSM.Size = new System.Drawing.Size(154, 26);
            this.txtTenBSM.TabIndex = 3;
            // 
            // labDOBBSM
            // 
            this.labDOBBSM.AutoSize = true;
            this.labDOBBSM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDOBBSM.Location = new System.Drawing.Point(34, 132);
            this.labDOBBSM.Name = "labDOBBSM";
            this.labDOBBSM.Size = new System.Drawing.Size(78, 20);
            this.labDOBBSM.TabIndex = 2;
            this.labDOBBSM.Text = "Ngày sinh";
            // 
            // labTenBSM
            // 
            this.labTenBSM.AutoSize = true;
            this.labTenBSM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBSM.Location = new System.Drawing.Point(34, 42);
            this.labTenBSM.Name = "labTenBSM";
            this.labTenBSM.Size = new System.Drawing.Size(77, 20);
            this.labTenBSM.TabIndex = 1;
            this.labTenBSM.Text = "Họ và tên";
            // 
            // labSexBSM
            // 
            this.labSexBSM.AutoSize = true;
            this.labSexBSM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexBSM.Location = new System.Drawing.Point(34, 88);
            this.labSexBSM.Name = "labSexBSM";
            this.labSexBSM.Size = new System.Drawing.Size(67, 20);
            this.labSexBSM.TabIndex = 0;
            this.labSexBSM.Text = "Giới tính";
            // 
            // grbTaiKhoanBSM
            // 
            this.grbTaiKhoanBSM.Controls.Add(this.txtTenDNBSM);
            this.grbTaiKhoanBSM.Controls.Add(this.txtMatKhauBSM);
            this.grbTaiKhoanBSM.Controls.Add(this.label12);
            this.grbTaiKhoanBSM.Controls.Add(this.label11);
            this.grbTaiKhoanBSM.ForeColor = System.Drawing.Color.Red;
            this.grbTaiKhoanBSM.Location = new System.Drawing.Point(30, 352);
            this.grbTaiKhoanBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoanBSM.Name = "grbTaiKhoanBSM";
            this.grbTaiKhoanBSM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoanBSM.Size = new System.Drawing.Size(729, 86);
            this.grbTaiKhoanBSM.TabIndex = 7;
            this.grbTaiKhoanBSM.TabStop = false;
            this.grbTaiKhoanBSM.Text = "Tài khoản bác sĩ mới";
            // 
            // txtTenDNBSM
            // 
            this.txtTenDNBSM.Location = new System.Drawing.Point(161, 34);
            this.txtTenDNBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDNBSM.Name = "txtTenDNBSM";
            this.txtTenDNBSM.Size = new System.Drawing.Size(154, 26);
            this.txtTenDNBSM.TabIndex = 16;
            // 
            // txtMatKhauBSM
            // 
            this.txtMatKhauBSM.Location = new System.Drawing.Point(532, 34);
            this.txtMatKhauBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauBSM.Name = "txtMatKhauBSM";
            this.txtMatKhauBSM.Size = new System.Drawing.Size(154, 26);
            this.txtMatKhauBSM.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(382, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mật khẩu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(34, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên đăng nhập";
            // 
            // btnThoatAddBS
            // 
            this.btnThoatAddBS.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnThoatAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddBS.Location = new System.Drawing.Point(417, 475);
            this.btnThoatAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddBS.Name = "btnThoatAddBS";
            this.btnThoatAddBS.Size = new System.Drawing.Size(141, 39);
            this.btnThoatAddBS.TabIndex = 9;
            this.btnThoatAddBS.Text = "Thoát";
            this.btnThoatAddBS.UseVisualStyleBackColor = true;
            this.btnThoatAddBS.Click += new System.EventHandler(this.btnThoatAddBS_Click);
            // 
            // btnSaveInfoBS
            // 
            this.btnSaveInfoBS.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveInfoBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInfoBS.Location = new System.Drawing.Point(191, 475);
            this.btnSaveInfoBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfoBS.Name = "btnSaveInfoBS";
            this.btnSaveInfoBS.Size = new System.Drawing.Size(154, 39);
            this.btnSaveInfoBS.TabIndex = 8;
            this.btnSaveInfoBS.Text = "Lưu thông tin";
            this.btnSaveInfoBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInfoBS.UseVisualStyleBackColor = true;
            this.btnSaveInfoBS.Click += new System.EventHandler(this.btnSaveInfoBS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::HMS_NHOM25.Properties.Resources.doctor;
            this.label3.Location = new System.Drawing.Point(151, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 548);
            this.Controls.Add(this.btnThoatAddBS);
            this.Controls.Add(this.btnSaveInfoBS);
            this.Controls.Add(this.grbTaiKhoanBSM);
            this.Controls.Add(this.grbAddInfoBS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.palAddBS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemBacSi";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).EndInit();
            this.grbAddInfoBS.ResumeLayout(false);
            this.grbAddInfoBS.PerformLayout();
            this.grbTaiKhoanBSM.ResumeLayout(false);
            this.grbTaiKhoanBSM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbBS;
        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.GroupBox grbAddInfoBS;
        private System.Windows.Forms.Label labSexBSM;
        private System.Windows.Forms.Label labDOBBSM;
        private System.Windows.Forms.Label labTenBSM;
        private System.Windows.Forms.TextBox txtTenBSM;
        private System.Windows.Forms.Label labDiaChiBSM;
        private System.Windows.Forms.Label labBangCapBSM;
        private System.Windows.Forms.Label labSDTBSM;
        private System.Windows.Forms.Label labChuyenMonBSM;
        private System.Windows.Forms.ComboBox cobSexBSM;
        private System.Windows.Forms.DateTimePicker DOBBSM;
        private System.Windows.Forms.TextBox txtBangCapBSM;
        private System.Windows.Forms.TextBox txtSDTBSM;
        private System.Windows.Forms.GroupBox grbTaiKhoanBSM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenDNBSM;
        private System.Windows.Forms.TextBox txtMatKhauBSM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveInfoBS;
        private System.Windows.Forms.ComboBox cobChuyenMonBSM;
        private System.Windows.Forms.Button btnThoatAddBS;
        private System.Windows.Forms.ComboBox cobDiaChiBSM;
    }
}