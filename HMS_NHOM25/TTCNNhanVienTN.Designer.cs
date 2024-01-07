namespace HMS_NHOM25
{
    partial class TTCNNhanVienTN
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
            this.grbInforNVTN = new System.Windows.Forms.GroupBox();
            this.cobDiaChiNVTN = new System.Windows.Forms.ComboBox();
            this.cobGioiTinhNVTN = new System.Windows.Forms.ComboBox();
            this.DOBNVTN = new System.Windows.Forms.DateTimePicker();
            this.txtSDTNVTN = new System.Windows.Forms.TextBox();
            this.txtTenNVTN = new System.Windows.Forms.TextBox();
            this.txtMaNVTN = new System.Windows.Forms.TextBox();
            this.labSDTNVTN = new System.Windows.Forms.Label();
            this.labDiaChiNVTN = new System.Windows.Forms.Label();
            this.labSexNVTN = new System.Windows.Forms.Label();
            this.labNgaySinhNVTN = new System.Windows.Forms.Label();
            this.labTenNVTN = new System.Windows.Forms.Label();
            this.labMaNVTN = new System.Windows.Forms.Label();
            this.btnSaveTTCN = new System.Windows.Forms.Button();
            this.palAddBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).BeginInit();
            this.grbInforNVTN.SuspendLayout();
            this.SuspendLayout();
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbBS);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(-5, 0);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(1107, 124);
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
            // grbInforNVTN
            // 
            this.grbInforNVTN.Controls.Add(this.cobDiaChiNVTN);
            this.grbInforNVTN.Controls.Add(this.cobGioiTinhNVTN);
            this.grbInforNVTN.Controls.Add(this.DOBNVTN);
            this.grbInforNVTN.Controls.Add(this.txtSDTNVTN);
            this.grbInforNVTN.Controls.Add(this.txtTenNVTN);
            this.grbInforNVTN.Controls.Add(this.txtMaNVTN);
            this.grbInforNVTN.Controls.Add(this.labSDTNVTN);
            this.grbInforNVTN.Controls.Add(this.labDiaChiNVTN);
            this.grbInforNVTN.Controls.Add(this.labSexNVTN);
            this.grbInforNVTN.Controls.Add(this.labNgaySinhNVTN);
            this.grbInforNVTN.Controls.Add(this.labTenNVTN);
            this.grbInforNVTN.Controls.Add(this.labMaNVTN);
            this.grbInforNVTN.ForeColor = System.Drawing.Color.Red;
            this.grbInforNVTN.Location = new System.Drawing.Point(41, 172);
            this.grbInforNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforNVTN.Name = "grbInforNVTN";
            this.grbInforNVTN.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforNVTN.Size = new System.Drawing.Size(975, 314);
            this.grbInforNVTN.TabIndex = 7;
            this.grbInforNVTN.TabStop = false;
            this.grbInforNVTN.Text = "Thông tin cá nhân";
            // 
            // cobDiaChiNVTN
            // 
            this.cobDiaChiNVTN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobDiaChiNVTN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobDiaChiNVTN.FormattingEnabled = true;
            this.cobDiaChiNVTN.Items.AddRange(new object[] {
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
            this.cobDiaChiNVTN.Location = new System.Drawing.Point(643, 143);
            this.cobDiaChiNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiNVTN.Name = "cobDiaChiNVTN";
            this.cobDiaChiNVTN.Size = new System.Drawing.Size(253, 28);
            this.cobDiaChiNVTN.TabIndex = 18;
            // 
            // cobGioiTinhNVTN
            // 
            this.cobGioiTinhNVTN.FormattingEnabled = true;
            this.cobGioiTinhNVTN.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhNVTN.Location = new System.Drawing.Point(645, 70);
            this.cobGioiTinhNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobGioiTinhNVTN.Name = "cobGioiTinhNVTN";
            this.cobGioiTinhNVTN.Size = new System.Drawing.Size(253, 28);
            this.cobGioiTinhNVTN.TabIndex = 15;
            // 
            // DOBNVTN
            // 
            this.DOBNVTN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBNVTN.Location = new System.Drawing.Point(193, 221);
            this.DOBNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBNVTN.Name = "DOBNVTN";
            this.DOBNVTN.Size = new System.Drawing.Size(255, 26);
            this.DOBNVTN.TabIndex = 13;
            // 
            // txtSDTNVTN
            // 
            this.txtSDTNVTN.Location = new System.Drawing.Point(645, 223);
            this.txtSDTNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTNVTN.Name = "txtSDTNVTN";
            this.txtSDTNVTN.Size = new System.Drawing.Size(251, 26);
            this.txtSDTNVTN.TabIndex = 12;
            // 
            // txtTenNVTN
            // 
            this.txtTenNVTN.Location = new System.Drawing.Point(193, 145);
            this.txtTenNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNVTN.Name = "txtTenNVTN";
            this.txtTenNVTN.Size = new System.Drawing.Size(253, 26);
            this.txtTenNVTN.TabIndex = 10;
            // 
            // txtMaNVTN
            // 
            this.txtMaNVTN.Location = new System.Drawing.Point(193, 68);
            this.txtMaNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNVTN.Name = "txtMaNVTN";
            this.txtMaNVTN.ReadOnly = true;
            this.txtMaNVTN.Size = new System.Drawing.Size(253, 26);
            this.txtMaNVTN.TabIndex = 9;
            // 
            // labSDTNVTN
            // 
            this.labSDTNVTN.AutoSize = true;
            this.labSDTNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTNVTN.Location = new System.Drawing.Point(561, 226);
            this.labSDTNVTN.Name = "labSDTNVTN";
            this.labSDTNVTN.Size = new System.Drawing.Size(41, 20);
            this.labSDTNVTN.TabIndex = 5;
            this.labSDTNVTN.Text = "SĐT";
            // 
            // labDiaChiNVTN
            // 
            this.labDiaChiNVTN.AutoSize = true;
            this.labDiaChiNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiNVTN.Location = new System.Drawing.Point(557, 149);
            this.labDiaChiNVTN.Name = "labDiaChiNVTN";
            this.labDiaChiNVTN.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiNVTN.TabIndex = 4;
            this.labDiaChiNVTN.Text = "Địa chỉ";
            // 
            // labSexNVTN
            // 
            this.labSexNVTN.AutoSize = true;
            this.labSexNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexNVTN.Location = new System.Drawing.Point(557, 73);
            this.labSexNVTN.Name = "labSexNVTN";
            this.labSexNVTN.Size = new System.Drawing.Size(67, 20);
            this.labSexNVTN.TabIndex = 3;
            this.labSexNVTN.Text = "Giới tính";
            // 
            // labNgaySinhNVTN
            // 
            this.labNgaySinhNVTN.AutoSize = true;
            this.labNgaySinhNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhNVTN.Location = new System.Drawing.Point(76, 226);
            this.labNgaySinhNVTN.Name = "labNgaySinhNVTN";
            this.labNgaySinhNVTN.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinhNVTN.TabIndex = 2;
            this.labNgaySinhNVTN.Text = "Ngày sinh";
            // 
            // labTenNVTN
            // 
            this.labTenNVTN.AutoSize = true;
            this.labTenNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenNVTN.Location = new System.Drawing.Point(74, 151);
            this.labTenNVTN.Name = "labTenNVTN";
            this.labTenNVTN.Size = new System.Drawing.Size(77, 20);
            this.labTenNVTN.TabIndex = 1;
            this.labTenNVTN.Text = "Họ và tên";
            // 
            // labMaNVTN
            // 
            this.labMaNVTN.AutoSize = true;
            this.labMaNVTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaNVTN.Location = new System.Drawing.Point(74, 70);
            this.labMaNVTN.Name = "labMaNVTN";
            this.labMaNVTN.Size = new System.Drawing.Size(103, 20);
            this.labMaNVTN.TabIndex = 0;
            this.labMaNVTN.Text = "Mã nhân viên";
            // 
            // btnSaveTTCN
            // 
            this.btnSaveTTCN.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveTTCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTTCN.Location = new System.Drawing.Point(446, 537);
            this.btnSaveTTCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveTTCN.Name = "btnSaveTTCN";
            this.btnSaveTTCN.Size = new System.Drawing.Size(154, 39);
            this.btnSaveTTCN.TabIndex = 10;
            this.btnSaveTTCN.Text = "Lưu thông tin";
            this.btnSaveTTCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTTCN.UseVisualStyleBackColor = true;
            // 
            // TTCNNhanVienTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 874);
            this.Controls.Add(this.btnSaveTTCN);
            this.Controls.Add(this.grbInforNVTN);
            this.Controls.Add(this.palAddBS);
            this.Name = "TTCNNhanVienTN";
            this.Text = "TTCNNhanVienTN";
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).EndInit();
            this.grbInforNVTN.ResumeLayout(false);
            this.grbInforNVTN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.PictureBox ptbBS;
        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.GroupBox grbInforNVTN;
        private System.Windows.Forms.ComboBox cobDiaChiNVTN;
        private System.Windows.Forms.ComboBox cobGioiTinhNVTN;
        private System.Windows.Forms.DateTimePicker DOBNVTN;
        private System.Windows.Forms.TextBox txtSDTNVTN;
        private System.Windows.Forms.TextBox txtTenNVTN;
        private System.Windows.Forms.TextBox txtMaNVTN;
        private System.Windows.Forms.Label labSDTNVTN;
        private System.Windows.Forms.Label labDiaChiNVTN;
        private System.Windows.Forms.Label labSexNVTN;
        private System.Windows.Forms.Label labNgaySinhNVTN;
        private System.Windows.Forms.Label labTenNVTN;
        private System.Windows.Forms.Label labMaNVTN;
        private System.Windows.Forms.Button btnSaveTTCN;
    }
}