namespace HMS_NHOM25
{
    partial class TTCNBacSi
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
            this.palAddBS = new System.Windows.Forms.Panel();
            this.labAddBS = new System.Windows.Forms.Label();
            this.ptbBS = new System.Windows.Forms.PictureBox();
            this.grbInforBS = new System.Windows.Forms.GroupBox();
            this.cobDiaChiBS = new System.Windows.Forms.ComboBox();
            this.cobChuyenMonBS = new System.Windows.Forms.ComboBox();
            this.cobSexBS = new System.Windows.Forms.ComboBox();
            this.DOBBS = new System.Windows.Forms.DateTimePicker();
            this.txtSDTBS = new System.Windows.Forms.TextBox();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.labChuyenMonBS = new System.Windows.Forms.Label();
            this.labBangCapBS = new System.Windows.Forms.Label();
            this.labSDTBS = new System.Windows.Forms.Label();
            this.labDiaChiBS = new System.Windows.Forms.Label();
            this.labSexBS = new System.Windows.Forms.Label();
            this.labNgaySinhBS = new System.Windows.Forms.Label();
            this.labTenBS = new System.Windows.Forms.Label();
            this.labMaBS = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSaveTTCN = new System.Windows.Forms.Button();
            this.palAddBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).BeginInit();
            this.grbInforBS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbBS);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(-5, -4);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(1096, 132);
            this.palAddBS.TabIndex = 6;
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(377, 32);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(426, 55);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Thông tin cá nhân";
            // 
            // ptbBS
            // 
            this.ptbBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbBS.Image = global::HMS_NHOM25.Properties.Resources.user2;
            this.ptbBS.Location = new System.Drawing.Point(292, 27);
            this.ptbBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbBS.Name = "ptbBS";
            this.ptbBS.Size = new System.Drawing.Size(79, 60);
            this.ptbBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBS.TabIndex = 3;
            this.ptbBS.TabStop = false;
            // 
            // grbInforBS
            // 
            this.grbInforBS.Controls.Add(this.cobDiaChiBS);
            this.grbInforBS.Controls.Add(this.cobSexBS);
            this.grbInforBS.Controls.Add(this.DOBBS);
            this.grbInforBS.Controls.Add(this.txtSDTBS);
            this.grbInforBS.Controls.Add(this.txtTenBS);
            this.grbInforBS.Controls.Add(this.labSDTBS);
            this.grbInforBS.Controls.Add(this.labDiaChiBS);
            this.grbInforBS.Controls.Add(this.labSexBS);
            this.grbInforBS.Controls.Add(this.labNgaySinhBS);
            this.grbInforBS.Controls.Add(this.labTenBS);
            this.grbInforBS.ForeColor = System.Drawing.Color.Red;
            this.grbInforBS.Location = new System.Drawing.Point(51, 161);
            this.grbInforBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforBS.Name = "grbInforBS";
            this.grbInforBS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforBS.Size = new System.Drawing.Size(965, 291);
            this.grbInforBS.TabIndex = 7;
            this.grbInforBS.TabStop = false;
            this.grbInforBS.Text = "Thông tin cá nhân";
            // 
            // cobDiaChiBS
            // 
            this.cobDiaChiBS.FormattingEnabled = true;
            this.cobDiaChiBS.Items.AddRange(new object[] {
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
            this.cobDiaChiBS.Location = new System.Drawing.Point(637, 136);
            this.cobDiaChiBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiBS.Name = "cobDiaChiBS";
            this.cobDiaChiBS.Size = new System.Drawing.Size(273, 28);
            this.cobDiaChiBS.TabIndex = 19;
            // 
            // cobChuyenMonBS
            // 
            this.cobChuyenMonBS.FormattingEnabled = true;
            this.cobChuyenMonBS.Items.AddRange(new object[] {
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
            this.cobChuyenMonBS.Location = new System.Drawing.Point(637, 36);
            this.cobChuyenMonBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobChuyenMonBS.Name = "cobChuyenMonBS";
            this.cobChuyenMonBS.Size = new System.Drawing.Size(273, 28);
            this.cobChuyenMonBS.TabIndex = 18;
            // 
            // cobSexBS
            // 
            this.cobSexBS.FormattingEnabled = true;
            this.cobSexBS.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobSexBS.Location = new System.Drawing.Point(637, 58);
            this.cobSexBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSexBS.Name = "cobSexBS";
            this.cobSexBS.Size = new System.Drawing.Size(273, 28);
            this.cobSexBS.TabIndex = 15;
            // 
            // DOBBS
            // 
            this.DOBBS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBBS.Location = new System.Drawing.Point(161, 138);
            this.DOBBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBBS.Name = "DOBBS";
            this.DOBBS.Size = new System.Drawing.Size(273, 26);
            this.DOBBS.TabIndex = 13;
            // 
            // txtSDTBS
            // 
            this.txtSDTBS.Location = new System.Drawing.Point(161, 217);
            this.txtSDTBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTBS.Name = "txtSDTBS";
            this.txtSDTBS.Size = new System.Drawing.Size(273, 26);
            this.txtSDTBS.TabIndex = 12;
            // 
            // txtTenBS
            // 
            this.txtTenBS.Location = new System.Drawing.Point(161, 60);
            this.txtTenBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(273, 26);
            this.txtTenBS.TabIndex = 10;
            // 
            // txtMaBS
            // 
            this.txtMaBS.Location = new System.Drawing.Point(161, 44);
            this.txtMaBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.ReadOnly = true;
            this.txtMaBS.Size = new System.Drawing.Size(273, 26);
            this.txtMaBS.TabIndex = 9;
            // 
            // labChuyenMonBS
            // 
            this.labChuyenMonBS.AutoSize = true;
            this.labChuyenMonBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labChuyenMonBS.Location = new System.Drawing.Point(529, 44);
            this.labChuyenMonBS.Name = "labChuyenMonBS";
            this.labChuyenMonBS.Size = new System.Drawing.Size(98, 20);
            this.labChuyenMonBS.TabIndex = 7;
            this.labChuyenMonBS.Text = "Chuyên môn";
            // 
            // labBangCapBS
            // 
            this.labBangCapBS.AutoSize = true;
            this.labBangCapBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labBangCapBS.Location = new System.Drawing.Point(54, 122);
            this.labBangCapBS.Name = "labBangCapBS";
            this.labBangCapBS.Size = new System.Drawing.Size(77, 20);
            this.labBangCapBS.TabIndex = 6;
            this.labBangCapBS.Text = "Bằng cấp";
            // 
            // labSDTBS
            // 
            this.labSDTBS.AutoSize = true;
            this.labSDTBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTBS.Location = new System.Drawing.Point(68, 223);
            this.labSDTBS.Name = "labSDTBS";
            this.labSDTBS.Size = new System.Drawing.Size(41, 20);
            this.labSDTBS.TabIndex = 5;
            this.labSDTBS.Text = "SĐT";
            // 
            // labDiaChiBS
            // 
            this.labDiaChiBS.AutoSize = true;
            this.labDiaChiBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiBS.Location = new System.Drawing.Point(551, 144);
            this.labDiaChiBS.Name = "labDiaChiBS";
            this.labDiaChiBS.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiBS.TabIndex = 4;
            this.labDiaChiBS.Text = "Địa chỉ";
            // 
            // labSexBS
            // 
            this.labSexBS.AutoSize = true;
            this.labSexBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexBS.Location = new System.Drawing.Point(551, 66);
            this.labSexBS.Name = "labSexBS";
            this.labSexBS.Size = new System.Drawing.Size(67, 20);
            this.labSexBS.TabIndex = 3;
            this.labSexBS.Text = "Giới tính";
            // 
            // labNgaySinhBS
            // 
            this.labNgaySinhBS.AutoSize = true;
            this.labNgaySinhBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhBS.Location = new System.Drawing.Point(68, 144);
            this.labNgaySinhBS.Name = "labNgaySinhBS";
            this.labNgaySinhBS.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinhBS.TabIndex = 2;
            this.labNgaySinhBS.Text = "Ngày sinh";
            // 
            // labTenBS
            // 
            this.labTenBS.AutoSize = true;
            this.labTenBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBS.Location = new System.Drawing.Point(68, 66);
            this.labTenBS.Name = "labTenBS";
            this.labTenBS.Size = new System.Drawing.Size(77, 20);
            this.labTenBS.TabIndex = 1;
            this.labTenBS.Text = "Họ và tên";
            // 
            // labMaBS
            // 
            this.labMaBS.AutoSize = true;
            this.labMaBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBS.Location = new System.Drawing.Point(54, 50);
            this.labMaBS.Name = "labMaBS";
            this.labMaBS.Size = new System.Drawing.Size(76, 20);
            this.labMaBS.TabIndex = 0;
            this.labMaBS.Text = "Mã bác sĩ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.txtMaBS);
            this.groupBox1.Controls.Add(this.cobChuyenMonBS);
            this.groupBox1.Controls.Add(this.labMaBS);
            this.groupBox1.Controls.Add(this.labChuyenMonBS);
            this.groupBox1.Controls.Add(this.labBangCapBS);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(51, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 244);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nghề nghiệp";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(159, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 90);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // btnSaveTTCN
            // 
            this.btnSaveTTCN.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveTTCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTTCN.Location = new System.Drawing.Point(452, 792);
            this.btnSaveTTCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveTTCN.Name = "btnSaveTTCN";
            this.btnSaveTTCN.Size = new System.Drawing.Size(154, 39);
            this.btnSaveTTCN.TabIndex = 10;
            this.btnSaveTTCN.Text = "Lưu thông tin";
            this.btnSaveTTCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTTCN.UseVisualStyleBackColor = true;
            // 
            // TTCNBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 874);
            this.Controls.Add(this.btnSaveTTCN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbInforBS);
            this.Controls.Add(this.palAddBS);
            this.Name = "TTCNBacSi";
            this.Text = "TTCNBacSi";
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).EndInit();
            this.grbInforBS.ResumeLayout(false);
            this.grbInforBS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.PictureBox ptbBS;
        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.GroupBox grbInforBS;
        private System.Windows.Forms.ComboBox cobDiaChiBS;
        private System.Windows.Forms.ComboBox cobChuyenMonBS;
        private System.Windows.Forms.ComboBox cobSexBS;
        private System.Windows.Forms.DateTimePicker DOBBS;
        private System.Windows.Forms.TextBox txtSDTBS;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label labChuyenMonBS;
        private System.Windows.Forms.Label labBangCapBS;
        private System.Windows.Forms.Label labSDTBS;
        private System.Windows.Forms.Label labDiaChiBS;
        private System.Windows.Forms.Label labSexBS;
        private System.Windows.Forms.Label labNgaySinhBS;
        private System.Windows.Forms.Label labTenBS;
        private System.Windows.Forms.Label labMaBS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSaveTTCN;
    }
}