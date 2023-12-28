namespace HMS_NHOM25
{
    partial class AddNVTN
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
            this.labAddNVTN = new System.Windows.Forms.Label();
            this.palAddNVTN = new System.Windows.Forms.Panel();
            this.grbAddInfoNVTNM = new System.Windows.Forms.GroupBox();
            this.cobDiaChiNVTNM = new System.Windows.Forms.ComboBox();
            this.cobTrangThaiNVTNM = new System.Windows.Forms.ComboBox();
            this.cobSexNVTNM = new System.Windows.Forms.ComboBox();
            this.DOBNVTNM = new System.Windows.Forms.DateTimePicker();
            this.txtSDTNVTNM = new System.Windows.Forms.TextBox();
            this.labTrangThaiNVTNM = new System.Windows.Forms.Label();
            this.labDiaChiNVTNM = new System.Windows.Forms.Label();
            this.labSDTNVTNM = new System.Windows.Forms.Label();
            this.txtTenNVTNM = new System.Windows.Forms.TextBox();
            this.labDOBNVTNM = new System.Windows.Forms.Label();
            this.labTenNVTNM = new System.Windows.Forms.Label();
            this.labSexNVTNM = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbTaiKhoanNVTNM = new System.Windows.Forms.GroupBox();
            this.txtTenDNNVTNM = new System.Windows.Forms.TextBox();
            this.txtMatKhauNVTNM = new System.Windows.Forms.TextBox();
            this.labMatKhauNVTNM = new System.Windows.Forms.Label();
            this.labTenDNNVTNM = new System.Windows.Forms.Label();
            this.btnThoatAddNVTNM = new System.Windows.Forms.Button();
            this.btnSaveInfoNVTNM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbNVTN = new System.Windows.Forms.PictureBox();
            this.palAddNVTN.SuspendLayout();
            this.grbAddInfoNVTNM.SuspendLayout();
            this.grbTaiKhoanNVTNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNVTN)).BeginInit();
            this.SuspendLayout();
            // 
            // labAddNVTN
            // 
            this.labAddNVTN.AutoSize = true;
            this.labAddNVTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labAddNVTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddNVTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddNVTN.Location = new System.Drawing.Point(271, 32);
            this.labAddNVTN.Name = "labAddNVTN";
            this.labAddNVTN.Size = new System.Drawing.Size(362, 32);
            this.labAddNVTN.TabIndex = 0;
            this.labAddNVTN.Text = "Thêm Nhân viên thu ngân";
            this.labAddNVTN.Click += new System.EventHandler(this.labAddBS_Click);
            // 
            // palAddNVTN
            // 
            this.palAddNVTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddNVTN.Controls.Add(this.ptbNVTN);
            this.palAddNVTN.Controls.Add(this.labAddNVTN);
            this.palAddNVTN.Location = new System.Drawing.Point(-6, 0);
            this.palAddNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddNVTN.Name = "palAddNVTN";
            this.palAddNVTN.Size = new System.Drawing.Size(809, 101);
            this.palAddNVTN.TabIndex = 4;
            // 
            // grbAddInfoNVTNM
            // 
            this.grbAddInfoNVTNM.Controls.Add(this.cobDiaChiNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.cobTrangThaiNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.cobSexNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.DOBNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.txtSDTNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.labTrangThaiNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.labDiaChiNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.labSDTNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.txtTenNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.labDOBNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.labTenNVTNM);
            this.grbAddInfoNVTNM.Controls.Add(this.labSexNVTNM);
            this.grbAddInfoNVTNM.ForeColor = System.Drawing.Color.Red;
            this.grbAddInfoNVTNM.Location = new System.Drawing.Point(30, 116);
            this.grbAddInfoNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoNVTNM.Name = "grbAddInfoNVTNM";
            this.grbAddInfoNVTNM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoNVTNM.Size = new System.Drawing.Size(729, 194);
            this.grbAddInfoNVTNM.TabIndex = 5;
            this.grbAddInfoNVTNM.TabStop = false;
            this.grbAddInfoNVTNM.Text = "Thông tin nhân viên thu ngân mới";
            this.grbAddInfoNVTNM.Enter += new System.EventHandler(this.grbAddInfoBS_Enter);
            // 
            // cobDiaChiNVTNM
            // 
            this.cobDiaChiNVTNM.FormattingEnabled = true;
            this.cobDiaChiNVTNM.Location = new System.Drawing.Point(530, 80);
            this.cobDiaChiNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiNVTNM.Name = "cobDiaChiNVTNM";
            this.cobDiaChiNVTNM.Size = new System.Drawing.Size(152, 28);
            this.cobDiaChiNVTNM.TabIndex = 15;
            // 
            // cobTrangThaiNVTNM
            // 
            this.cobTrangThaiNVTNM.FormattingEnabled = true;
            this.cobTrangThaiNVTNM.Location = new System.Drawing.Point(530, 129);
            this.cobTrangThaiNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobTrangThaiNVTNM.Name = "cobTrangThaiNVTNM";
            this.cobTrangThaiNVTNM.Size = new System.Drawing.Size(152, 28);
            this.cobTrangThaiNVTNM.TabIndex = 14;
            // 
            // cobSexNVTNM
            // 
            this.cobSexNVTNM.FormattingEnabled = true;
            this.cobSexNVTNM.Location = new System.Drawing.Point(160, 80);
            this.cobSexNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSexNVTNM.Name = "cobSexNVTNM";
            this.cobSexNVTNM.Size = new System.Drawing.Size(152, 28);
            this.cobSexNVTNM.TabIndex = 13;
            // 
            // DOBNVTNM
            // 
            this.DOBNVTNM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBNVTNM.Location = new System.Drawing.Point(160, 126);
            this.DOBNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBNVTNM.Name = "DOBNVTNM";
            this.DOBNVTNM.Size = new System.Drawing.Size(152, 26);
            this.DOBNVTNM.TabIndex = 12;
            // 
            // txtSDTNVTNM
            // 
            this.txtSDTNVTNM.Location = new System.Drawing.Point(530, 39);
            this.txtSDTNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTNVTNM.Name = "txtSDTNVTNM";
            this.txtSDTNVTNM.Size = new System.Drawing.Size(154, 26);
            this.txtSDTNVTNM.TabIndex = 9;
            // 
            // labTrangThaiNVTNM
            // 
            this.labTrangThaiNVTNM.AutoSize = true;
            this.labTrangThaiNVTNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTrangThaiNVTNM.Location = new System.Drawing.Point(382, 132);
            this.labTrangThaiNVTNM.Name = "labTrangThaiNVTNM";
            this.labTrangThaiNVTNM.Size = new System.Drawing.Size(80, 20);
            this.labTrangThaiNVTNM.TabIndex = 8;
            this.labTrangThaiNVTNM.Text = "Trạng thái";
            // 
            // labDiaChiNVTNM
            // 
            this.labDiaChiNVTNM.AutoSize = true;
            this.labDiaChiNVTNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiNVTNM.Location = new System.Drawing.Point(382, 88);
            this.labDiaChiNVTNM.Name = "labDiaChiNVTNM";
            this.labDiaChiNVTNM.Size = new System.Drawing.Size(57, 20);
            this.labDiaChiNVTNM.TabIndex = 6;
            this.labDiaChiNVTNM.Text = "Địa chỉ";
            // 
            // labSDTNVTNM
            // 
            this.labSDTNVTNM.AutoSize = true;
            this.labSDTNVTNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTNVTNM.Location = new System.Drawing.Point(382, 42);
            this.labSDTNVTNM.Name = "labSDTNVTNM";
            this.labSDTNVTNM.Size = new System.Drawing.Size(41, 20);
            this.labSDTNVTNM.TabIndex = 4;
            this.labSDTNVTNM.Text = "SĐT";
            // 
            // txtTenNVTNM
            // 
            this.txtTenNVTNM.Location = new System.Drawing.Point(160, 36);
            this.txtTenNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNVTNM.Name = "txtTenNVTNM";
            this.txtTenNVTNM.Size = new System.Drawing.Size(154, 26);
            this.txtTenNVTNM.TabIndex = 3;
            // 
            // labDOBNVTNM
            // 
            this.labDOBNVTNM.AutoSize = true;
            this.labDOBNVTNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDOBNVTNM.Location = new System.Drawing.Point(34, 132);
            this.labDOBNVTNM.Name = "labDOBNVTNM";
            this.labDOBNVTNM.Size = new System.Drawing.Size(78, 20);
            this.labDOBNVTNM.TabIndex = 2;
            this.labDOBNVTNM.Text = "Ngày sinh";
            // 
            // labTenNVTNM
            // 
            this.labTenNVTNM.AutoSize = true;
            this.labTenNVTNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenNVTNM.Location = new System.Drawing.Point(34, 42);
            this.labTenNVTNM.Name = "labTenNVTNM";
            this.labTenNVTNM.Size = new System.Drawing.Size(77, 20);
            this.labTenNVTNM.TabIndex = 1;
            this.labTenNVTNM.Text = "Họ và tên";
            this.labTenNVTNM.Click += new System.EventHandler(this.label4_Click);
            // 
            // labSexNVTNM
            // 
            this.labSexNVTNM.AutoSize = true;
            this.labSexNVTNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexNVTNM.Location = new System.Drawing.Point(34, 88);
            this.labSexNVTNM.Name = "labSexNVTNM";
            this.labSexNVTNM.Size = new System.Drawing.Size(67, 20);
            this.labSexNVTNM.TabIndex = 0;
            this.labSexNVTNM.Text = "Giới tính";
            this.labSexNVTNM.Click += new System.EventHandler(this.label2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbTaiKhoanNVTNM
            // 
            this.grbTaiKhoanNVTNM.Controls.Add(this.txtTenDNNVTNM);
            this.grbTaiKhoanNVTNM.Controls.Add(this.txtMatKhauNVTNM);
            this.grbTaiKhoanNVTNM.Controls.Add(this.labMatKhauNVTNM);
            this.grbTaiKhoanNVTNM.Controls.Add(this.labTenDNNVTNM);
            this.grbTaiKhoanNVTNM.ForeColor = System.Drawing.Color.Red;
            this.grbTaiKhoanNVTNM.Location = new System.Drawing.Point(30, 352);
            this.grbTaiKhoanNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoanNVTNM.Name = "grbTaiKhoanNVTNM";
            this.grbTaiKhoanNVTNM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoanNVTNM.Size = new System.Drawing.Size(729, 86);
            this.grbTaiKhoanNVTNM.TabIndex = 7;
            this.grbTaiKhoanNVTNM.TabStop = false;
            this.grbTaiKhoanNVTNM.Text = "Tài khoản nhân viên mới";
            // 
            // txtTenDNNVTNM
            // 
            this.txtTenDNNVTNM.Location = new System.Drawing.Point(161, 34);
            this.txtTenDNNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDNNVTNM.Name = "txtTenDNNVTNM";
            this.txtTenDNNVTNM.Size = new System.Drawing.Size(154, 26);
            this.txtTenDNNVTNM.TabIndex = 16;
            // 
            // txtMatKhauNVTNM
            // 
            this.txtMatKhauNVTNM.Location = new System.Drawing.Point(532, 34);
            this.txtMatKhauNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauNVTNM.Name = "txtMatKhauNVTNM";
            this.txtMatKhauNVTNM.Size = new System.Drawing.Size(154, 26);
            this.txtMatKhauNVTNM.TabIndex = 17;
            // 
            // labMatKhauNVTNM
            // 
            this.labMatKhauNVTNM.AutoSize = true;
            this.labMatKhauNVTNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMatKhauNVTNM.Location = new System.Drawing.Point(382, 40);
            this.labMatKhauNVTNM.Name = "labMatKhauNVTNM";
            this.labMatKhauNVTNM.Size = new System.Drawing.Size(75, 20);
            this.labMatKhauNVTNM.TabIndex = 3;
            this.labMatKhauNVTNM.Text = "Mật khẩu";
            // 
            // labTenDNNVTNM
            // 
            this.labTenDNNVTNM.AutoSize = true;
            this.labTenDNNVTNM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenDNNVTNM.Location = new System.Drawing.Point(34, 40);
            this.labTenDNNVTNM.Name = "labTenDNNVTNM";
            this.labTenDNNVTNM.Size = new System.Drawing.Size(116, 20);
            this.labTenDNNVTNM.TabIndex = 2;
            this.labTenDNNVTNM.Text = "Tên đăng nhập";
            // 
            // btnThoatAddNVTNM
            // 
            this.btnThoatAddNVTNM.Image = global::HMS_NHOM25.Properties.Resources.cancel;
            this.btnThoatAddNVTNM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddNVTNM.Location = new System.Drawing.Point(417, 475);
            this.btnThoatAddNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddNVTNM.Name = "btnThoatAddNVTNM";
            this.btnThoatAddNVTNM.Size = new System.Drawing.Size(141, 39);
            this.btnThoatAddNVTNM.TabIndex = 9;
            this.btnThoatAddNVTNM.Text = "Thoát";
            this.btnThoatAddNVTNM.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfoNVTNM
            // 
            this.btnSaveInfoNVTNM.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveInfoNVTNM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInfoNVTNM.Location = new System.Drawing.Point(191, 475);
            this.btnSaveInfoNVTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfoNVTNM.Name = "btnSaveInfoNVTNM";
            this.btnSaveInfoNVTNM.Size = new System.Drawing.Size(154, 39);
            this.btnSaveInfoNVTNM.TabIndex = 8;
            this.btnSaveInfoNVTNM.Text = "Lưu thông tin";
            this.btnSaveInfoNVTNM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInfoNVTNM.UseVisualStyleBackColor = true;
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
            // ptbNVTN
            // 
            this.ptbNVTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbNVTN.Image = global::HMS_NHOM25.Properties.Resources.cashier;
            this.ptbNVTN.Location = new System.Drawing.Point(199, 31);
            this.ptbNVTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbNVTN.Name = "ptbNVTN";
            this.ptbNVTN.Size = new System.Drawing.Size(78, 32);
            this.ptbNVTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNVTN.TabIndex = 3;
            this.ptbNVTN.TabStop = false;
            // 
            // AddNVTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 548);
            this.Controls.Add(this.btnThoatAddNVTNM);
            this.Controls.Add(this.btnSaveInfoNVTNM);
            this.Controls.Add(this.grbTaiKhoanNVTNM);
            this.Controls.Add(this.grbAddInfoNVTNM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.palAddNVTN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNVTN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNVTN";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.palAddNVTN.ResumeLayout(false);
            this.palAddNVTN.PerformLayout();
            this.grbAddInfoNVTNM.ResumeLayout(false);
            this.grbAddInfoNVTNM.PerformLayout();
            this.grbTaiKhoanNVTNM.ResumeLayout(false);
            this.grbTaiKhoanNVTNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNVTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAddNVTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbNVTN;
        private System.Windows.Forms.Panel palAddNVTN;
        private System.Windows.Forms.GroupBox grbAddInfoNVTNM;
        private System.Windows.Forms.Label labSexNVTNM;
        private System.Windows.Forms.Label labDOBNVTNM;
        private System.Windows.Forms.Label labTenNVTNM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTenNVTNM;
        private System.Windows.Forms.Label labDiaChiNVTNM;
        private System.Windows.Forms.Label labSDTNVTNM;
        private System.Windows.Forms.Label labTrangThaiNVTNM;
        private System.Windows.Forms.ComboBox cobDiaChiNVTNM;
        private System.Windows.Forms.ComboBox cobTrangThaiNVTNM;
        private System.Windows.Forms.ComboBox cobSexNVTNM;
        private System.Windows.Forms.DateTimePicker DOBNVTNM;
        private System.Windows.Forms.TextBox txtSDTNVTNM;
        private System.Windows.Forms.GroupBox grbTaiKhoanNVTNM;
        private System.Windows.Forms.Label labTenDNNVTNM;
        private System.Windows.Forms.TextBox txtTenDNNVTNM;
        private System.Windows.Forms.TextBox txtMatKhauNVTNM;
        private System.Windows.Forms.Label labMatKhauNVTNM;
        private System.Windows.Forms.Button btnSaveInfoNVTNM;
        private System.Windows.Forms.Button btnThoatAddNVTNM;
    }
}