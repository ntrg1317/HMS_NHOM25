namespace HMS_NHOM25
{
    partial class AddNVYTe
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
            this.palAddBS = new System.Windows.Forms.Panel();
            this.ptbYTe = new System.Windows.Forms.PictureBox();
            this.grbAddInfoNVYTeM = new System.Windows.Forms.GroupBox();
            this.cobDiaChiNVYTeM = new System.Windows.Forms.ComboBox();
            this.cobSexNVYTeM = new System.Windows.Forms.ComboBox();
            this.DOBNVYTeM = new System.Windows.Forms.DateTimePicker();
            this.txtSDTNVYTeM = new System.Windows.Forms.TextBox();
            this.labDiaChiNVYTeM = new System.Windows.Forms.Label();
            this.labSDTNVYTeM = new System.Windows.Forms.Label();
            this.txtTenNVYTeM = new System.Windows.Forms.TextBox();
            this.labDOBNVYTeM = new System.Windows.Forms.Label();
            this.labTenNVYTeM = new System.Windows.Forms.Label();
            this.labSexNVYTeM = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbTaiKhoanNVYTeM = new System.Windows.Forms.GroupBox();
            this.txtTenDNNVYTeM = new System.Windows.Forms.TextBox();
            this.txtMatKhauNVYTeM = new System.Windows.Forms.TextBox();
            this.labMatKhauNVYTeM = new System.Windows.Forms.Label();
            this.labTenDNNVYTe = new System.Windows.Forms.Label();
            this.btnThoatAddNVYTeM = new System.Windows.Forms.Button();
            this.btnSaveInfoNVYTeM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.palAddBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).BeginInit();
            this.grbAddInfoNVYTeM.SuspendLayout();
            this.grbTaiKhoanNVYTeM.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(252, 26);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(251, 29);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Thêm Nhân viên y tế";
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbYTe);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(-5, 0);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(719, 81);
            this.palAddBS.TabIndex = 4;
            // 
            // ptbYTe
            // 
            this.ptbYTe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbYTe.Image = global::HMS_NHOM25.Properties.Resources.nurse;
            this.ptbYTe.Location = new System.Drawing.Point(188, 26);
            this.ptbYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbYTe.Name = "ptbYTe";
            this.ptbYTe.Size = new System.Drawing.Size(69, 26);
            this.ptbYTe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbYTe.TabIndex = 3;
            this.ptbYTe.TabStop = false;
            // 
            // grbAddInfoNVYTeM
            // 
            this.grbAddInfoNVYTeM.Controls.Add(this.cobDiaChiNVYTeM);
            this.grbAddInfoNVYTeM.Controls.Add(this.cobSexNVYTeM);
            this.grbAddInfoNVYTeM.Controls.Add(this.DOBNVYTeM);
            this.grbAddInfoNVYTeM.Controls.Add(this.txtSDTNVYTeM);
            this.grbAddInfoNVYTeM.Controls.Add(this.labDiaChiNVYTeM);
            this.grbAddInfoNVYTeM.Controls.Add(this.labSDTNVYTeM);
            this.grbAddInfoNVYTeM.Controls.Add(this.txtTenNVYTeM);
            this.grbAddInfoNVYTeM.Controls.Add(this.labDOBNVYTeM);
            this.grbAddInfoNVYTeM.Controls.Add(this.labTenNVYTeM);
            this.grbAddInfoNVYTeM.Controls.Add(this.labSexNVYTeM);
            this.grbAddInfoNVYTeM.ForeColor = System.Drawing.Color.Red;
            this.grbAddInfoNVYTeM.Location = new System.Drawing.Point(27, 93);
            this.grbAddInfoNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoNVYTeM.Name = "grbAddInfoNVYTeM";
            this.grbAddInfoNVYTeM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoNVYTeM.Size = new System.Drawing.Size(648, 155);
            this.grbAddInfoNVYTeM.TabIndex = 5;
            this.grbAddInfoNVYTeM.TabStop = false;
            this.grbAddInfoNVYTeM.Text = "Thông tin nhân viên y tế mới";
            // 
            // cobDiaChiNVYTeM
            // 
            this.cobDiaChiNVYTeM.FormattingEnabled = true;
            this.cobDiaChiNVYTeM.Location = new System.Drawing.Point(471, 64);
            this.cobDiaChiNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiNVYTeM.Name = "cobDiaChiNVYTeM";
            this.cobDiaChiNVYTeM.Size = new System.Drawing.Size(136, 24);
            this.cobDiaChiNVYTeM.TabIndex = 15;
            // 
            // cobSexNVYTeM
            // 
            this.cobSexNVYTeM.FormattingEnabled = true;
            this.cobSexNVYTeM.Location = new System.Drawing.Point(142, 64);
            this.cobSexNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobSexNVYTeM.Name = "cobSexNVYTeM";
            this.cobSexNVYTeM.Size = new System.Drawing.Size(136, 24);
            this.cobSexNVYTeM.TabIndex = 13;
            // 
            // DOBNVYTeM
            // 
            this.DOBNVYTeM.CustomFormat = "yyyy-MM-dd";
            this.DOBNVYTeM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBNVYTeM.Location = new System.Drawing.Point(142, 101);
            this.DOBNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBNVYTeM.Name = "DOBNVYTeM";
            this.DOBNVYTeM.Size = new System.Drawing.Size(136, 22);
            this.DOBNVYTeM.TabIndex = 12;
            // 
            // txtSDTNVYTeM
            // 
            this.txtSDTNVYTeM.Location = new System.Drawing.Point(471, 31);
            this.txtSDTNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTNVYTeM.Name = "txtSDTNVYTeM";
            this.txtSDTNVYTeM.Size = new System.Drawing.Size(137, 22);
            this.txtSDTNVYTeM.TabIndex = 9;
            // 
            // labDiaChiNVYTeM
            // 
            this.labDiaChiNVYTeM.AutoSize = true;
            this.labDiaChiNVYTeM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiNVYTeM.Location = new System.Drawing.Point(340, 70);
            this.labDiaChiNVYTeM.Name = "labDiaChiNVYTeM";
            this.labDiaChiNVYTeM.Size = new System.Drawing.Size(47, 16);
            this.labDiaChiNVYTeM.TabIndex = 6;
            this.labDiaChiNVYTeM.Text = "Địa chỉ";
            // 
            // labSDTNVYTeM
            // 
            this.labSDTNVYTeM.AutoSize = true;
            this.labSDTNVYTeM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTNVYTeM.Location = new System.Drawing.Point(340, 34);
            this.labSDTNVYTeM.Name = "labSDTNVYTeM";
            this.labSDTNVYTeM.Size = new System.Drawing.Size(34, 16);
            this.labSDTNVYTeM.TabIndex = 4;
            this.labSDTNVYTeM.Text = "SĐT";
            // 
            // txtTenNVYTeM
            // 
            this.txtTenNVYTeM.Location = new System.Drawing.Point(142, 29);
            this.txtTenNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNVYTeM.Name = "txtTenNVYTeM";
            this.txtTenNVYTeM.Size = new System.Drawing.Size(137, 22);
            this.txtTenNVYTeM.TabIndex = 3;
            // 
            // labDOBNVYTeM
            // 
            this.labDOBNVYTeM.AutoSize = true;
            this.labDOBNVYTeM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDOBNVYTeM.Location = new System.Drawing.Point(30, 106);
            this.labDOBNVYTeM.Name = "labDOBNVYTeM";
            this.labDOBNVYTeM.Size = new System.Drawing.Size(67, 16);
            this.labDOBNVYTeM.TabIndex = 2;
            this.labDOBNVYTeM.Text = "Ngày sinh";
            // 
            // labTenNVYTeM
            // 
            this.labTenNVYTeM.AutoSize = true;
            this.labTenNVYTeM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenNVYTeM.Location = new System.Drawing.Point(30, 34);
            this.labTenNVYTeM.Name = "labTenNVYTeM";
            this.labTenNVYTeM.Size = new System.Drawing.Size(64, 16);
            this.labTenNVYTeM.TabIndex = 1;
            this.labTenNVYTeM.Text = "Họ và tên";
            // 
            // labSexNVYTeM
            // 
            this.labSexNVYTeM.AutoSize = true;
            this.labSexNVYTeM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexNVYTeM.Location = new System.Drawing.Point(30, 70);
            this.labSexNVYTeM.Name = "labSexNVYTeM";
            this.labSexNVYTeM.Size = new System.Drawing.Size(54, 16);
            this.labSexNVYTeM.TabIndex = 0;
            this.labSexNVYTeM.Text = "Giới tính";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbTaiKhoanNVYTeM
            // 
            this.grbTaiKhoanNVYTeM.Controls.Add(this.txtTenDNNVYTeM);
            this.grbTaiKhoanNVYTeM.Controls.Add(this.txtMatKhauNVYTeM);
            this.grbTaiKhoanNVYTeM.Controls.Add(this.labMatKhauNVYTeM);
            this.grbTaiKhoanNVYTeM.Controls.Add(this.labTenDNNVYTe);
            this.grbTaiKhoanNVYTeM.ForeColor = System.Drawing.Color.Red;
            this.grbTaiKhoanNVYTeM.Location = new System.Drawing.Point(27, 282);
            this.grbTaiKhoanNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoanNVYTeM.Name = "grbTaiKhoanNVYTeM";
            this.grbTaiKhoanNVYTeM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoanNVYTeM.Size = new System.Drawing.Size(648, 69);
            this.grbTaiKhoanNVYTeM.TabIndex = 7;
            this.grbTaiKhoanNVYTeM.TabStop = false;
            this.grbTaiKhoanNVYTeM.Text = "Tài khoản nhân viên mới";
            // 
            // txtTenDNNVYTeM
            // 
            this.txtTenDNNVYTeM.Location = new System.Drawing.Point(143, 27);
            this.txtTenDNNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDNNVYTeM.Name = "txtTenDNNVYTeM";
            this.txtTenDNNVYTeM.Size = new System.Drawing.Size(137, 22);
            this.txtTenDNNVYTeM.TabIndex = 16;
            // 
            // txtMatKhauNVYTeM
            // 
            this.txtMatKhauNVYTeM.Location = new System.Drawing.Point(473, 27);
            this.txtMatKhauNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauNVYTeM.Name = "txtMatKhauNVYTeM";
            this.txtMatKhauNVYTeM.Size = new System.Drawing.Size(137, 22);
            this.txtMatKhauNVYTeM.TabIndex = 17;
            // 
            // labMatKhauNVYTeM
            // 
            this.labMatKhauNVYTeM.AutoSize = true;
            this.labMatKhauNVYTeM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMatKhauNVYTeM.Location = new System.Drawing.Point(340, 32);
            this.labMatKhauNVYTeM.Name = "labMatKhauNVYTeM";
            this.labMatKhauNVYTeM.Size = new System.Drawing.Size(61, 16);
            this.labMatKhauNVYTeM.TabIndex = 3;
            this.labMatKhauNVYTeM.Text = "Mật khẩu";
            // 
            // labTenDNNVYTe
            // 
            this.labTenDNNVYTe.AutoSize = true;
            this.labTenDNNVYTe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenDNNVYTe.Location = new System.Drawing.Point(30, 32);
            this.labTenDNNVYTe.Name = "labTenDNNVYTe";
            this.labTenDNNVYTe.Size = new System.Drawing.Size(98, 16);
            this.labTenDNNVYTe.TabIndex = 2;
            this.labTenDNNVYTe.Text = "Tên đăng nhập";
            // 
            // btnThoatAddNVYTeM
            // 
            this.btnThoatAddNVYTeM.Image = global::HMS_NHOM25.Properties.Resources.cancel;
            this.btnThoatAddNVYTeM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddNVYTeM.Location = new System.Drawing.Point(371, 380);
            this.btnThoatAddNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddNVYTeM.Name = "btnThoatAddNVYTeM";
            this.btnThoatAddNVYTeM.Size = new System.Drawing.Size(125, 31);
            this.btnThoatAddNVYTeM.TabIndex = 9;
            this.btnThoatAddNVYTeM.Text = "Thoát";
            this.btnThoatAddNVYTeM.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfoNVYTeM
            // 
            this.btnSaveInfoNVYTeM.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveInfoNVYTeM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInfoNVYTeM.Location = new System.Drawing.Point(170, 380);
            this.btnSaveInfoNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfoNVYTeM.Name = "btnSaveInfoNVYTeM";
            this.btnSaveInfoNVYTeM.Size = new System.Drawing.Size(137, 31);
            this.btnSaveInfoNVYTeM.TabIndex = 8;
            this.btnSaveInfoNVYTeM.Text = "Lưu thông tin";
            this.btnSaveInfoNVYTeM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInfoNVYTeM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::HMS_NHOM25.Properties.Resources.doctor;
            this.label3.Location = new System.Drawing.Point(134, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // AddNVYTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 438);
            this.Controls.Add(this.btnThoatAddNVYTeM);
            this.Controls.Add(this.btnSaveInfoNVYTeM);
            this.Controls.Add(this.grbTaiKhoanNVYTeM);
            this.Controls.Add(this.grbAddInfoNVYTeM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.palAddBS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNVYTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNVYTe";
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).EndInit();
            this.grbAddInfoNVYTeM.ResumeLayout(false);
            this.grbAddInfoNVYTeM.PerformLayout();
            this.grbTaiKhoanNVYTeM.ResumeLayout(false);
            this.grbTaiKhoanNVYTeM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbYTe;
        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.GroupBox grbAddInfoNVYTeM;
        private System.Windows.Forms.Label labSexNVYTeM;
        private System.Windows.Forms.Label labDOBNVYTeM;
        private System.Windows.Forms.Label labTenNVYTeM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTenNVYTeM;
        private System.Windows.Forms.Label labDiaChiNVYTeM;
        private System.Windows.Forms.Label labSDTNVYTeM;
        private System.Windows.Forms.ComboBox cobDiaChiNVYTeM;
        private System.Windows.Forms.ComboBox cobSexNVYTeM;
        private System.Windows.Forms.DateTimePicker DOBNVYTeM;
        private System.Windows.Forms.TextBox txtSDTNVYTeM;
        private System.Windows.Forms.GroupBox grbTaiKhoanNVYTeM;
        private System.Windows.Forms.Label labTenDNNVYTe;
        private System.Windows.Forms.TextBox txtTenDNNVYTeM;
        private System.Windows.Forms.TextBox txtMatKhauNVYTeM;
        private System.Windows.Forms.Label labMatKhauNVYTeM;
        private System.Windows.Forms.Button btnSaveInfoNVYTeM;
        private System.Windows.Forms.Button btnThoatAddNVYTeM;
    }
}