namespace HMS_NHOM25
{
    partial class AddPatients
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
            this.components = new System.ComponentModel.Container();
            this.labAddBS = new System.Windows.Forms.Label();
            this.palAddBN = new System.Windows.Forms.Panel();
            this.ptbBS = new System.Windows.Forms.PictureBox();
            this.grbAddInfoBN = new System.Windows.Forms.GroupBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.labMaPhong = new System.Windows.Forms.Label();
            this.txtSDTNguoiThanM = new System.Windows.Forms.TextBox();
            this.labSDTNguoiThan = new System.Windows.Forms.Label();
            this.dateNgayVaoM = new System.Windows.Forms.DateTimePicker();
            this.cobDiaChiBNM = new System.Windows.Forms.ComboBox();
            this.cobTrangThaiBNM = new System.Windows.Forms.ComboBox();
            this.cobSexBNM = new System.Windows.Forms.ComboBox();
            this.DOBBNM = new System.Windows.Forms.DateTimePicker();
            this.txtBenhTrangBNM = new System.Windows.Forms.TextBox();
            this.txtSDTBNM = new System.Windows.Forms.TextBox();
            this.labTrangThaiBNM = new System.Windows.Forms.Label();
            this.labNgayVao = new System.Windows.Forms.Label();
            this.labDiaChiBNM = new System.Windows.Forms.Label();
            this.labBenhTrangBNM = new System.Windows.Forms.Label();
            this.labSDTBNM = new System.Windows.Forms.Label();
            this.txtTenBNM = new System.Windows.Forms.TextBox();
            this.labDOBBNM = new System.Windows.Forms.Label();
            this.labTenBNM = new System.Windows.Forms.Label();
            this.labSexBNM = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbTaiKhoanBSM = new System.Windows.Forms.GroupBox();
            this.txtTenDNBNM = new System.Windows.Forms.TextBox();
            this.txtMatKhauBNM = new System.Windows.Forms.TextBox();
            this.labMKBNM = new System.Windows.Forms.Label();
            this.labTenDNBNM = new System.Windows.Forms.Label();
            this.btnThoatAddBNM = new System.Windows.Forms.Button();
            this.btnSaveInfoBNM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.palAddBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).BeginInit();
            this.grbAddInfoBN.SuspendLayout();
            this.grbTaiKhoanBSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(305, 33);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(242, 32);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Thêm bệnh nhân";
            // 
            // palAddBN
            // 
            this.palAddBN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBN.Controls.Add(this.ptbBS);
            this.palAddBN.Controls.Add(this.labAddBS);
            this.palAddBN.Location = new System.Drawing.Point(-6, 0);
            this.palAddBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBN.Name = "palAddBN";
            this.palAddBN.Size = new System.Drawing.Size(809, 101);
            this.palAddBN.TabIndex = 4;
            // 
            // ptbBS
            // 
            this.ptbBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbBS.Image = global::HMS_NHOM25.Properties.Resources.hospitalisation;
            this.ptbBS.Location = new System.Drawing.Point(240, 22);
            this.ptbBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbBS.Name = "ptbBS";
            this.ptbBS.Size = new System.Drawing.Size(59, 44);
            this.ptbBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBS.TabIndex = 3;
            this.ptbBS.TabStop = false;
            // 
            // grbAddInfoBN
            // 
            this.grbAddInfoBN.Controls.Add(this.txtMaPhong);
            this.grbAddInfoBN.Controls.Add(this.labMaPhong);
            this.grbAddInfoBN.Controls.Add(this.txtSDTNguoiThanM);
            this.grbAddInfoBN.Controls.Add(this.labSDTNguoiThan);
            this.grbAddInfoBN.Controls.Add(this.dateNgayVaoM);
            this.grbAddInfoBN.Controls.Add(this.cobDiaChiBNM);
            this.grbAddInfoBN.Controls.Add(this.cobTrangThaiBNM);
            this.grbAddInfoBN.Controls.Add(this.cobSexBNM);
            this.grbAddInfoBN.Controls.Add(this.DOBBNM);
            this.grbAddInfoBN.Controls.Add(this.txtBenhTrangBNM);
            this.grbAddInfoBN.Controls.Add(this.txtSDTBNM);
            this.grbAddInfoBN.Controls.Add(this.labTrangThaiBNM);
            this.grbAddInfoBN.Controls.Add(this.labNgayVao);
            this.grbAddInfoBN.Controls.Add(this.labDiaChiBNM);
            this.grbAddInfoBN.Controls.Add(this.labBenhTrangBNM);
            this.grbAddInfoBN.Controls.Add(this.labSDTBNM);
            this.grbAddInfoBN.Controls.Add(this.txtTenBNM);
            this.grbAddInfoBN.Controls.Add(this.labDOBBNM);
            this.grbAddInfoBN.Controls.Add(this.labTenBNM);
            this.grbAddInfoBN.Controls.Add(this.labSexBNM);
            this.grbAddInfoBN.ForeColor = System.Drawing.Color.Red;
            this.grbAddInfoBN.Location = new System.Drawing.Point(30, 116);
            this.grbAddInfoBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoBN.Name = "grbAddInfoBN";
            this.grbAddInfoBN.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoBN.Size = new System.Drawing.Size(729, 259);
            this.grbAddInfoBN.TabIndex = 5;
            this.grbAddInfoBN.TabStop = false;
            this.grbAddInfoBN.Text = "Thông tin bệnh nhân mới";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(533, 173);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(154, 26);
            this.txtMaPhong.TabIndex = 20;
            // 
            // labMaPhong
            // 
            this.labMaPhong.AutoSize = true;
            this.labMaPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaPhong.Location = new System.Drawing.Point(384, 179);
            this.labMaPhong.Name = "labMaPhong";
            this.labMaPhong.Size = new System.Drawing.Size(80, 20);
            this.labMaPhong.TabIndex = 19;
            this.labMaPhong.Text = "Mã phòng";
            // 
            // txtSDTNguoiThanM
            // 
            this.txtSDTNguoiThanM.Location = new System.Drawing.Point(172, 220);
            this.txtSDTNguoiThanM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTNguoiThanM.Name = "txtSDTNguoiThanM";
            this.txtSDTNguoiThanM.Size = new System.Drawing.Size(154, 26);
            this.txtSDTNguoiThanM.TabIndex = 18;
            // 
            // labSDTNguoiThan
            // 
            this.labSDTNguoiThan.AutoSize = true;
            this.labSDTNguoiThan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTNguoiThan.Location = new System.Drawing.Point(34, 226);
            this.labSDTNguoiThan.Name = "labSDTNguoiThan";
            this.labSDTNguoiThan.Size = new System.Drawing.Size(120, 20);
            this.labSDTNguoiThan.TabIndex = 17;
            this.labSDTNguoiThan.Text = "SĐT người thân";
            // 
            // dateNgayVaoM
            // 
            this.dateNgayVaoM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayVaoM.Location = new System.Drawing.Point(533, 127);
            this.dateNgayVaoM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayVaoM.Name = "dateNgayVaoM";
            this.dateNgayVaoM.Size = new System.Drawing.Size(152, 26);
            this.dateNgayVaoM.TabIndex = 16;
            // 
            // cobDiaChiBNM
            // 
            this.cobDiaChiBNM.FormattingEnabled = true;
            this.cobDiaChiBNM.Location = new System.Drawing.Point(172, 171);
            this.cobDiaChiBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiBNM.Name = "cobDiaChiBNM";
            this.cobDiaChiBNM.Size = new System.Drawing.Size(152, 28);
            this.cobDiaChiBNM.TabIndex = 15;
            // 
            // cobTrangThaiBNM
            // 
            this.cobTrangThaiBNM.FormattingEnabled = true;
            this.cobTrangThaiBNM.Location = new System.Drawing.Point(532, 218);
            this.cobTrangThaiBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobTrangThaiBNM.Name = "cobTrangThaiBNM";
            this.cobTrangThaiBNM.Size = new System.Drawing.Size(153, 28);
            this.cobTrangThaiBNM.TabIndex = 14;
            // 
            // cobSexBNM
            // 
            this.cobSexBNM.FormattingEnabled = true;
            this.cobSexBNM.Location = new System.Drawing.Point(171, 80);
            this.cobSexBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSexBNM.Name = "cobSexBNM";
            this.cobSexBNM.Size = new System.Drawing.Size(152, 28);
            this.cobSexBNM.TabIndex = 13;
            // 
            // DOBBNM
            // 
            this.DOBBNM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBBNM.Location = new System.Drawing.Point(171, 126);
            this.DOBBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBBNM.Name = "DOBBNM";
            this.DOBBNM.Size = new System.Drawing.Size(152, 26);
            this.DOBBNM.TabIndex = 12;
            // 
            // txtBenhTrangBNM
            // 
            this.txtBenhTrangBNM.Location = new System.Drawing.Point(533, 82);
            this.txtBenhTrangBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBenhTrangBNM.Name = "txtBenhTrangBNM";
            this.txtBenhTrangBNM.Size = new System.Drawing.Size(154, 26);
            this.txtBenhTrangBNM.TabIndex = 10;
            // 
            // txtSDTBNM
            // 
            this.txtSDTBNM.Location = new System.Drawing.Point(532, 39);
            this.txtSDTBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTBNM.Name = "txtSDTBNM";
            this.txtSDTBNM.Size = new System.Drawing.Size(154, 26);
            this.txtSDTBNM.TabIndex = 9;
            // 
            // labTrangThaiBNM
            // 
            this.labTrangThaiBNM.AutoSize = true;
            this.labTrangThaiBNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTrangThaiBNM.Location = new System.Drawing.Point(384, 226);
            this.labTrangThaiBNM.Name = "labTrangThaiBNM";
            this.labTrangThaiBNM.Size = new System.Drawing.Size(80, 20);
            this.labTrangThaiBNM.TabIndex = 8;
            this.labTrangThaiBNM.Text = "Trạng thái";
            // 
            // labNgayVao
            // 
            this.labNgayVao.AutoSize = true;
            this.labNgayVao.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgayVao.Location = new System.Drawing.Point(384, 132);
            this.labNgayVao.Name = "labNgayVao";
            this.labNgayVao.Size = new System.Drawing.Size(74, 20);
            this.labNgayVao.TabIndex = 7;
            this.labNgayVao.Text = "Ngày vào";
            // 
            // labDiaChiBNM
            // 
            this.labDiaChiBNM.AutoSize = true;
            this.labDiaChiBNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiBNM.Location = new System.Drawing.Point(34, 179);
            this.labDiaChiBNM.Name = "labDiaChiBNM";
            this.labDiaChiBNM.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiBNM.TabIndex = 6;
            this.labDiaChiBNM.Text = "Địa chỉ";
            // 
            // labBenhTrangBNM
            // 
            this.labBenhTrangBNM.AutoSize = true;
            this.labBenhTrangBNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labBenhTrangBNM.Location = new System.Drawing.Point(384, 88);
            this.labBenhTrangBNM.Name = "labBenhTrangBNM";
            this.labBenhTrangBNM.Size = new System.Drawing.Size(88, 20);
            this.labBenhTrangBNM.TabIndex = 5;
            this.labBenhTrangBNM.Text = "Bệnh trạng";
            // 
            // labSDTBNM
            // 
            this.labSDTBNM.AutoSize = true;
            this.labSDTBNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTBNM.Location = new System.Drawing.Point(384, 42);
            this.labSDTBNM.Name = "labSDTBNM";
            this.labSDTBNM.Size = new System.Drawing.Size(41, 20);
            this.labSDTBNM.TabIndex = 4;
            this.labSDTBNM.Text = "SĐT";
            // 
            // txtTenBNM
            // 
            this.txtTenBNM.Location = new System.Drawing.Point(171, 36);
            this.txtTenBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenBNM.Name = "txtTenBNM";
            this.txtTenBNM.Size = new System.Drawing.Size(154, 26);
            this.txtTenBNM.TabIndex = 3;
            // 
            // labDOBBNM
            // 
            this.labDOBBNM.AutoSize = true;
            this.labDOBBNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDOBBNM.Location = new System.Drawing.Point(34, 132);
            this.labDOBBNM.Name = "labDOBBNM";
            this.labDOBBNM.Size = new System.Drawing.Size(78, 20);
            this.labDOBBNM.TabIndex = 2;
            this.labDOBBNM.Text = "Ngày sinh";
            // 
            // labTenBNM
            // 
            this.labTenBNM.AutoSize = true;
            this.labTenBNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBNM.Location = new System.Drawing.Point(34, 42);
            this.labTenBNM.Name = "labTenBNM";
            this.labTenBNM.Size = new System.Drawing.Size(77, 20);
            this.labTenBNM.TabIndex = 1;
            this.labTenBNM.Text = "Họ và tên";
            // 
            // labSexBNM
            // 
            this.labSexBNM.AutoSize = true;
            this.labSexBNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexBNM.Location = new System.Drawing.Point(34, 88);
            this.labSexBNM.Name = "labSexBNM";
            this.labSexBNM.Size = new System.Drawing.Size(67, 20);
            this.labSexBNM.TabIndex = 0;
            this.labSexBNM.Text = "Giới tính";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbTaiKhoanBSM
            // 
            this.grbTaiKhoanBSM.Controls.Add(this.txtTenDNBNM);
            this.grbTaiKhoanBSM.Controls.Add(this.txtMatKhauBNM);
            this.grbTaiKhoanBSM.Controls.Add(this.labMKBNM);
            this.grbTaiKhoanBSM.Controls.Add(this.labTenDNBNM);
            this.grbTaiKhoanBSM.ForeColor = System.Drawing.Color.Red;
            this.grbTaiKhoanBSM.Location = new System.Drawing.Point(30, 394);
            this.grbTaiKhoanBSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoanBSM.Name = "grbTaiKhoanBSM";
            this.grbTaiKhoanBSM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoanBSM.Size = new System.Drawing.Size(729, 86);
            this.grbTaiKhoanBSM.TabIndex = 7;
            this.grbTaiKhoanBSM.TabStop = false;
            this.grbTaiKhoanBSM.Text = "Tài khoản bệnh nhân mới";
            // 
            // txtTenDNBNM
            // 
            this.txtTenDNBNM.Location = new System.Drawing.Point(172, 34);
            this.txtTenDNBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDNBNM.Name = "txtTenDNBNM";
            this.txtTenDNBNM.Size = new System.Drawing.Size(154, 26);
            this.txtTenDNBNM.TabIndex = 16;
            // 
            // txtMatKhauBNM
            // 
            this.txtMatKhauBNM.Location = new System.Drawing.Point(534, 34);
            this.txtMatKhauBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauBNM.Name = "txtMatKhauBNM";
            this.txtMatKhauBNM.Size = new System.Drawing.Size(154, 26);
            this.txtMatKhauBNM.TabIndex = 17;
            // 
            // labMKBNM
            // 
            this.labMKBNM.AutoSize = true;
            this.labMKBNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMKBNM.Location = new System.Drawing.Point(384, 37);
            this.labMKBNM.Name = "labMKBNM";
            this.labMKBNM.Size = new System.Drawing.Size(75, 20);
            this.labMKBNM.TabIndex = 3;
            this.labMKBNM.Text = "Mật khẩu";
            // 
            // labTenDNBNM
            // 
            this.labTenDNBNM.AutoSize = true;
            this.labTenDNBNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenDNBNM.Location = new System.Drawing.Point(34, 40);
            this.labTenDNBNM.Name = "labTenDNBNM";
            this.labTenDNBNM.Size = new System.Drawing.Size(116, 20);
            this.labTenDNBNM.TabIndex = 2;
            this.labTenDNBNM.Text = "Tên đăng nhập";
            // 
            // btnThoatAddBNM
            // 
            this.btnThoatAddBNM.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnThoatAddBNM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddBNM.Location = new System.Drawing.Point(418, 510);
            this.btnThoatAddBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddBNM.Name = "btnThoatAddBNM";
            this.btnThoatAddBNM.Size = new System.Drawing.Size(141, 39);
            this.btnThoatAddBNM.TabIndex = 9;
            this.btnThoatAddBNM.Text = "Thoát";
            this.btnThoatAddBNM.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfoBNM
            // 
            this.btnSaveInfoBNM.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveInfoBNM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInfoBNM.Location = new System.Drawing.Point(202, 510);
            this.btnSaveInfoBNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfoBNM.Name = "btnSaveInfoBNM";
            this.btnSaveInfoBNM.Size = new System.Drawing.Size(154, 39);
            this.btnSaveInfoBNM.TabIndex = 8;
            this.btnSaveInfoBNM.Text = "Lưu thông tin";
            this.btnSaveInfoBNM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInfoBNM.UseVisualStyleBackColor = true;
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
            // AddPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 577);
            this.Controls.Add(this.btnThoatAddBNM);
            this.Controls.Add(this.btnSaveInfoBNM);
            this.Controls.Add(this.grbTaiKhoanBSM);
            this.Controls.Add(this.grbAddInfoBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.palAddBN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPatients";
            this.Load += new System.EventHandler(this.AddPatients_Load);
            this.palAddBN.ResumeLayout(false);
            this.palAddBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).EndInit();
            this.grbAddInfoBN.ResumeLayout(false);
            this.grbAddInfoBN.PerformLayout();
            this.grbTaiKhoanBSM.ResumeLayout(false);
            this.grbTaiKhoanBSM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbBS;
        private System.Windows.Forms.Panel palAddBN;
        private System.Windows.Forms.GroupBox grbAddInfoBN;
        private System.Windows.Forms.Label labSexBNM;
        private System.Windows.Forms.Label labDOBBNM;
        private System.Windows.Forms.Label labTenBNM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTenBNM;
        private System.Windows.Forms.Label labDiaChiBNM;
        private System.Windows.Forms.Label labBenhTrangBNM;
        private System.Windows.Forms.Label labSDTBNM;
        private System.Windows.Forms.Label labTrangThaiBNM;
        private System.Windows.Forms.Label labNgayVao;
        private System.Windows.Forms.ComboBox cobDiaChiBNM;
        private System.Windows.Forms.ComboBox cobTrangThaiBNM;
        private System.Windows.Forms.ComboBox cobSexBNM;
        private System.Windows.Forms.DateTimePicker DOBBNM;
        private System.Windows.Forms.TextBox txtBenhTrangBNM;
        private System.Windows.Forms.TextBox txtSDTBNM;
        private System.Windows.Forms.GroupBox grbTaiKhoanBSM;
        private System.Windows.Forms.Label labTenDNBNM;
        private System.Windows.Forms.TextBox txtTenDNBNM;
        private System.Windows.Forms.TextBox txtMatKhauBNM;
        private System.Windows.Forms.Label labMKBNM;
        private System.Windows.Forms.Button btnSaveInfoBNM;
        private System.Windows.Forms.Button btnThoatAddBNM;
        private System.Windows.Forms.DateTimePicker dateNgayVaoM;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label labMaPhong;
        private System.Windows.Forms.TextBox txtSDTNguoiThanM;
        private System.Windows.Forms.Label labSDTNguoiThan;
    }
}