namespace HMS_NHOM25
{
    partial class TTCNAdmin
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
            this.ptbBS = new System.Windows.Forms.PictureBox();
            this.labAddBS = new System.Windows.Forms.Label();
            this.grbInforQTV = new System.Windows.Forms.GroupBox();
            this.cobDiaChiQTV = new System.Windows.Forms.ComboBox();
            this.cobGioiTinhQTV = new System.Windows.Forms.ComboBox();
            this.DOBQTV = new System.Windows.Forms.DateTimePicker();
            this.txtSDTQTV = new System.Windows.Forms.TextBox();
            this.txtTenQTV = new System.Windows.Forms.TextBox();
            this.txtMaQTV = new System.Windows.Forms.TextBox();
            this.labSDTQTV = new System.Windows.Forms.Label();
            this.labDiaChiQTV = new System.Windows.Forms.Label();
            this.labSexQTV = new System.Windows.Forms.Label();
            this.labNgaySinhQTV = new System.Windows.Forms.Label();
            this.labTenQTV = new System.Windows.Forms.Label();
            this.labMaQTV = new System.Windows.Forms.Label();
            this.btnSaveTTCN = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.palAddBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).BeginInit();
            this.grbInforQTV.SuspendLayout();
            this.SuspendLayout();
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbBS);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(-3, 0);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(1090, 124);
            this.palAddBS.TabIndex = 5;
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
            // grbInforQTV
            // 
            this.grbInforQTV.Controls.Add(this.cobDiaChiQTV);
            this.grbInforQTV.Controls.Add(this.cobGioiTinhQTV);
            this.grbInforQTV.Controls.Add(this.DOBQTV);
            this.grbInforQTV.Controls.Add(this.txtSDTQTV);
            this.grbInforQTV.Controls.Add(this.txtTenQTV);
            this.grbInforQTV.Controls.Add(this.txtMaQTV);
            this.grbInforQTV.Controls.Add(this.labSDTQTV);
            this.grbInforQTV.Controls.Add(this.labDiaChiQTV);
            this.grbInforQTV.Controls.Add(this.labSexQTV);
            this.grbInforQTV.Controls.Add(this.labNgaySinhQTV);
            this.grbInforQTV.Controls.Add(this.labTenQTV);
            this.grbInforQTV.Controls.Add(this.labMaQTV);
            this.grbInforQTV.ForeColor = System.Drawing.Color.Red;
            this.grbInforQTV.Location = new System.Drawing.Point(30, 157);
            this.grbInforQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforQTV.Name = "grbInforQTV";
            this.grbInforQTV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforQTV.Size = new System.Drawing.Size(1009, 277);
            this.grbInforQTV.TabIndex = 6;
            this.grbInforQTV.TabStop = false;
            this.grbInforQTV.Text = "Thông tin cá nhân";
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
            this.cobDiaChiQTV.Location = new System.Drawing.Point(664, 190);
            this.cobDiaChiQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiQTV.Name = "cobDiaChiQTV";
            this.cobDiaChiQTV.Size = new System.Drawing.Size(255, 28);
            this.cobDiaChiQTV.TabIndex = 16;
            // 
            // cobGioiTinhQTV
            // 
            this.cobGioiTinhQTV.FormattingEnabled = true;
            this.cobGioiTinhQTV.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhQTV.Location = new System.Drawing.Point(192, 190);
            this.cobGioiTinhQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobGioiTinhQTV.Name = "cobGioiTinhQTV";
            this.cobGioiTinhQTV.Size = new System.Drawing.Size(253, 28);
            this.cobGioiTinhQTV.TabIndex = 15;
            // 
            // DOBQTV
            // 
            this.DOBQTV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBQTV.Location = new System.Drawing.Point(664, 59);
            this.DOBQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBQTV.Name = "DOBQTV";
            this.DOBQTV.Size = new System.Drawing.Size(255, 26);
            this.DOBQTV.TabIndex = 13;
            // 
            // txtSDTQTV
            // 
            this.txtSDTQTV.Location = new System.Drawing.Point(664, 123);
            this.txtSDTQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTQTV.Name = "txtSDTQTV";
            this.txtSDTQTV.Size = new System.Drawing.Size(255, 26);
            this.txtSDTQTV.TabIndex = 12;
            // 
            // txtTenQTV
            // 
            this.txtTenQTV.Location = new System.Drawing.Point(192, 123);
            this.txtTenQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenQTV.Name = "txtTenQTV";
            this.txtTenQTV.Size = new System.Drawing.Size(253, 26);
            this.txtTenQTV.TabIndex = 10;
            // 
            // txtMaQTV
            // 
            this.txtMaQTV.Location = new System.Drawing.Point(192, 59);
            this.txtMaQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaQTV.Name = "txtMaQTV";
            this.txtMaQTV.ReadOnly = true;
            this.txtMaQTV.Size = new System.Drawing.Size(253, 26);
            this.txtMaQTV.TabIndex = 9;
            // 
            // labSDTQTV
            // 
            this.labSDTQTV.AutoSize = true;
            this.labSDTQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTQTV.Location = new System.Drawing.Point(555, 129);
            this.labSDTQTV.Name = "labSDTQTV";
            this.labSDTQTV.Size = new System.Drawing.Size(41, 20);
            this.labSDTQTV.TabIndex = 5;
            this.labSDTQTV.Text = "SĐT";
            // 
            // labDiaChiQTV
            // 
            this.labDiaChiQTV.AutoSize = true;
            this.labDiaChiQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiQTV.Location = new System.Drawing.Point(555, 198);
            this.labDiaChiQTV.Name = "labDiaChiQTV";
            this.labDiaChiQTV.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiQTV.TabIndex = 4;
            this.labDiaChiQTV.Text = "Địa chỉ";
            // 
            // labSexQTV
            // 
            this.labSexQTV.AutoSize = true;
            this.labSexQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexQTV.Location = new System.Drawing.Point(81, 198);
            this.labSexQTV.Name = "labSexQTV";
            this.labSexQTV.Size = new System.Drawing.Size(67, 20);
            this.labSexQTV.TabIndex = 3;
            this.labSexQTV.Text = "Giới tính";
            // 
            // labNgaySinhQTV
            // 
            this.labNgaySinhQTV.AutoSize = true;
            this.labNgaySinhQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhQTV.Location = new System.Drawing.Point(555, 65);
            this.labNgaySinhQTV.Name = "labNgaySinhQTV";
            this.labNgaySinhQTV.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinhQTV.TabIndex = 2;
            this.labNgaySinhQTV.Text = "Ngày sinh";
            // 
            // labTenQTV
            // 
            this.labTenQTV.AutoSize = true;
            this.labTenQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenQTV.Location = new System.Drawing.Point(81, 129);
            this.labTenQTV.Name = "labTenQTV";
            this.labTenQTV.Size = new System.Drawing.Size(77, 20);
            this.labTenQTV.TabIndex = 1;
            this.labTenQTV.Text = "Họ và tên";
            // 
            // labMaQTV
            // 
            this.labMaQTV.AutoSize = true;
            this.labMaQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaQTV.Location = new System.Drawing.Point(81, 65);
            this.labMaQTV.Name = "labMaQTV";
            this.labMaQTV.Size = new System.Drawing.Size(85, 20);
            this.labMaQTV.TabIndex = 0;
            this.labMaQTV.Text = "Mã quản lý";
            // 
            // btnSaveTTCN
            // 
            this.btnSaveTTCN.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveTTCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTTCN.Location = new System.Drawing.Point(321, 484);
            this.btnSaveTTCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveTTCN.Name = "btnSaveTTCN";
            this.btnSaveTTCN.Size = new System.Drawing.Size(154, 39);
            this.btnSaveTTCN.TabIndex = 9;
            this.btnSaveTTCN.Text = "Lưu thông tin";
            this.btnSaveTTCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTTCN.UseVisualStyleBackColor = true;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Image = global::HMS_NHOM25.Properties.Resources.revision;
            this.btnDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMK.Location = new System.Drawing.Point(589, 484);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(154, 39);
            this.btnDoiMK.TabIndex = 10;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // TTCNAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 874);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnSaveTTCN);
            this.Controls.Add(this.grbInforQTV);
            this.Controls.Add(this.palAddBS);
            this.Name = "TTCNAdmin";
            this.Text = "TTCNAdmin";
            this.Load += new System.EventHandler(this.TTCNAdmin_Load);
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).EndInit();
            this.grbInforQTV.ResumeLayout(false);
            this.grbInforQTV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.PictureBox ptbBS;
        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.GroupBox grbInforQTV;
        private System.Windows.Forms.ComboBox cobDiaChiQTV;
        private System.Windows.Forms.ComboBox cobGioiTinhQTV;
        private System.Windows.Forms.DateTimePicker DOBQTV;
        private System.Windows.Forms.TextBox txtSDTQTV;
        private System.Windows.Forms.TextBox txtTenQTV;
        private System.Windows.Forms.TextBox txtMaQTV;
        private System.Windows.Forms.Label labSDTQTV;
        private System.Windows.Forms.Label labDiaChiQTV;
        private System.Windows.Forms.Label labSexQTV;
        private System.Windows.Forms.Label labNgaySinhQTV;
        private System.Windows.Forms.Label labTenQTV;
        private System.Windows.Forms.Label labMaQTV;
        private System.Windows.Forms.Button btnSaveTTCN;
        private System.Windows.Forms.Button btnDoiMK;
    }
}