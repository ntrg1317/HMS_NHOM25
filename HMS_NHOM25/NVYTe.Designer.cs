using System;

namespace HMS_NHOM25
{
    partial class NVYTe
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
            this.cobTrangThaiNVYTe = new System.Windows.Forms.ComboBox();
            this.cobDiaChiNVYTe = new System.Windows.Forms.ComboBox();
            this.cobGioiTinhNVYTe = new System.Windows.Forms.ComboBox();
            this.DOBNVYTe = new System.Windows.Forms.DateTimePicker();
            this.txtSDTNVYTe = new System.Windows.Forms.TextBox();
            this.txtTenNVYTe = new System.Windows.Forms.TextBox();
            this.txtMaNVYTe = new System.Windows.Forms.TextBox();
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
            this.txtTimKiemNVYTe = new System.Windows.Forms.TextBox();
            this.dgvInfoNVYTe = new System.Windows.Forms.DataGridView();
            this.btnSuaNVYTe = new System.Windows.Forms.Button();
            this.btnXoaNVYTe = new System.Windows.Forms.Button();
            this.btnThemNVYTe = new System.Windows.Forms.Button();
            this.grbInforNVYTe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoNVYTe)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInforNVYTe
            // 
            this.grbInforNVYTe.Controls.Add(this.cobTrangThaiNVYTe);
            this.grbInforNVYTe.Controls.Add(this.cobDiaChiNVYTe);
            this.grbInforNVYTe.Controls.Add(this.cobGioiTinhNVYTe);
            this.grbInforNVYTe.Controls.Add(this.DOBNVYTe);
            this.grbInforNVYTe.Controls.Add(this.txtSDTNVYTe);
            this.grbInforNVYTe.Controls.Add(this.txtTenNVYTe);
            this.grbInforNVYTe.Controls.Add(this.txtMaNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labTrangThaiNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labSDTNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labDiaChiNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labSexNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labNgaySinhNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labTenNVYTe);
            this.grbInforNVYTe.Controls.Add(this.labMaNVYTe);
            this.grbInforNVYTe.ForeColor = System.Drawing.Color.Red;
            this.grbInforNVYTe.Location = new System.Drawing.Point(35, 22);
            this.grbInforNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforNVYTe.Name = "grbInforNVYTe";
            this.grbInforNVYTe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforNVYTe.Size = new System.Drawing.Size(1017, 208);
            this.grbInforNVYTe.TabIndex = 0;
            this.grbInforNVYTe.TabStop = false;
            this.grbInforNVYTe.Text = "Thông tin nhân viên y tế";
            // 
            // cobTrangThaiNVYTe
            // 
            this.cobTrangThaiNVYTe.FormattingEnabled = true;
            this.cobTrangThaiNVYTe.Items.AddRange(new object[] {
            "Hoạt Động",
            "Ngừng hoạt động"});
            this.cobTrangThaiNVYTe.Location = new System.Drawing.Point(146, 142);
            this.cobTrangThaiNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobTrangThaiNVYTe.Name = "cobTrangThaiNVYTe";
            this.cobTrangThaiNVYTe.Size = new System.Drawing.Size(184, 28);
            this.cobTrangThaiNVYTe.TabIndex = 17;
            // 
            // cobDiaChiNVYTe
            // 
            this.cobDiaChiNVYTe.FormattingEnabled = true;
            this.cobDiaChiNVYTe.Items.AddRange(new object[] {
            "Đống Đa, Hà Nội",
            "Hai Bà Trưng, Hà Nội",
            "Phù Cừ, Hưng Yên"});
            this.cobDiaChiNVYTe.Location = new System.Drawing.Point(450, 94);
            this.cobDiaChiNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiNVYTe.Name = "cobDiaChiNVYTe";
            this.cobDiaChiNVYTe.Size = new System.Drawing.Size(180, 28);
            this.cobDiaChiNVYTe.TabIndex = 16;
            // 
            // cobGioiTinhNVYTe
            // 
            this.cobGioiTinhNVYTe.FormattingEnabled = true;
            this.cobGioiTinhNVYTe.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhNVYTe.Location = new System.Drawing.Point(450, 48);
            this.cobGioiTinhNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobGioiTinhNVYTe.Name = "cobGioiTinhNVYTe";
            this.cobGioiTinhNVYTe.Size = new System.Drawing.Size(180, 28);
            this.cobGioiTinhNVYTe.TabIndex = 15;
            // 
            // DOBNVYTe
            // 
            this.DOBNVYTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBNVYTe.Location = new System.Drawing.Point(778, 50);
            this.DOBNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBNVYTe.Name = "DOBNVYTe";
            this.DOBNVYTe.Size = new System.Drawing.Size(182, 26);
            this.DOBNVYTe.TabIndex = 13;
            // 
            // txtSDTNVYTe
            // 
            this.txtSDTNVYTe.Location = new System.Drawing.Point(780, 96);
            this.txtSDTNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTNVYTe.Name = "txtSDTNVYTe";
            this.txtSDTNVYTe.Size = new System.Drawing.Size(180, 26);
            this.txtSDTNVYTe.TabIndex = 12;
            // 
            // txtTenNVYTe
            // 
            this.txtTenNVYTe.Location = new System.Drawing.Point(146, 96);
            this.txtTenNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNVYTe.Name = "txtTenNVYTe";
            this.txtTenNVYTe.Size = new System.Drawing.Size(184, 26);
            this.txtTenNVYTe.TabIndex = 10;
            // 
            // txtMaNVYTe
            // 
            this.txtMaNVYTe.Location = new System.Drawing.Point(146, 48);
            this.txtMaNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNVYTe.Name = "txtMaNVYTe";
            this.txtMaNVYTe.Size = new System.Drawing.Size(184, 26);
            this.txtMaNVYTe.TabIndex = 9;
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
            this.labTimKiemNVYTe.Location = new System.Drawing.Point(46, 244);
            this.labTimKiemNVYTe.Name = "labTimKiemNVYTe";
            this.labTimKiemNVYTe.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemNVYTe.TabIndex = 1;
            this.labTimKiemNVYTe.Text = "Tìm kiếm";
            // 
            // labTenNVYTeTimKiem
            // 
            this.labTenNVYTeTimKiem.AutoSize = true;
            this.labTenNVYTeTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenNVYTeTimKiem.Location = new System.Drawing.Point(68, 278);
            this.labTenNVYTeTimKiem.Name = "labTenNVYTeTimKiem";
            this.labTenNVYTeTimKiem.Size = new System.Drawing.Size(108, 20);
            this.labTenNVYTeTimKiem.TabIndex = 18;
            this.labTenNVYTeTimKiem.Text = "Tên nhân viên";
            // 
            // txtTimKiemNVYTe
            // 
            this.txtTimKiemNVYTe.Location = new System.Drawing.Point(181, 271);
            this.txtTimKiemNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemNVYTe.Name = "txtTimKiemNVYTe";
            this.txtTimKiemNVYTe.Size = new System.Drawing.Size(184, 26);
            this.txtTimKiemNVYTe.TabIndex = 18;
            // 
            // dgvInfoNVYTe
            // 
            this.dgvInfoNVYTe.AllowUserToAddRows = false;
            this.dgvInfoNVYTe.AllowUserToDeleteRows = false;
            this.dgvInfoNVYTe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoNVYTe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoNVYTe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoNVYTe.Location = new System.Drawing.Point(35, 329);
            this.dgvInfoNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoNVYTe.Name = "dgvInfoNVYTe";
            this.dgvInfoNVYTe.ReadOnly = true;
            this.dgvInfoNVYTe.RowHeadersWidth = 62;
            this.dgvInfoNVYTe.RowTemplate.Height = 28;
            this.dgvInfoNVYTe.Size = new System.Drawing.Size(1022, 509);
            this.dgvInfoNVYTe.TabIndex = 23;
            // 
            // btnSuaNVYTe
            // 
            this.btnSuaNVYTe.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaNVYTe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNVYTe.Location = new System.Drawing.Point(678, 269);
            this.btnSuaNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaNVYTe.Name = "btnSuaNVYTe";
            this.btnSuaNVYTe.Size = new System.Drawing.Size(120, 39);
            this.btnSuaNVYTe.TabIndex = 22;
            this.btnSuaNVYTe.Text = "Cập nhật";
            this.btnSuaNVYTe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNVYTe.UseVisualStyleBackColor = true;
            // 
            // btnXoaNVYTe
            // 
            this.btnXoaNVYTe.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaNVYTe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNVYTe.Location = new System.Drawing.Point(899, 269);
            this.btnXoaNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaNVYTe.Name = "btnXoaNVYTe";
            this.btnXoaNVYTe.Size = new System.Drawing.Size(96, 39);
            this.btnXoaNVYTe.TabIndex = 21;
            this.btnXoaNVYTe.Text = "Xóa";
            this.btnXoaNVYTe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNVYTe.UseVisualStyleBackColor = true;
            // 
            // btnThemNVYTe
            // 
            this.btnThemNVYTe.Image = global::HMS_NHOM25.Properties.Resources.add_user__1_;
            this.btnThemNVYTe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNVYTe.Location = new System.Drawing.Point(485, 269);
            this.btnThemNVYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNVYTe.Name = "btnThemNVYTe";
            this.btnThemNVYTe.Size = new System.Drawing.Size(99, 39);
            this.btnThemNVYTe.TabIndex = 20;
            this.btnThemNVYTe.Text = "Thêm";
            this.btnThemNVYTe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNVYTe.UseVisualStyleBackColor = true;
            this.btnThemNVYTe.Click += new System.EventHandler(this.btnThemNVYTe_Click);
            // 
            // NVYTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 851);
            this.Controls.Add(this.dgvInfoNVYTe);
            this.Controls.Add(this.btnSuaNVYTe);
            this.Controls.Add(this.btnXoaNVYTe);
            this.Controls.Add(this.btnThemNVYTe);
            this.Controls.Add(this.txtTimKiemNVYTe);
            this.Controls.Add(this.labTenNVYTeTimKiem);
            this.Controls.Add(this.labTimKiemNVYTe);
            this.Controls.Add(this.grbInforNVYTe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NVYTe";
            this.Text = "NVYTe";
            this.Load += new System.EventHandler(this.NVYTe_Load);
            this.grbInforNVYTe.ResumeLayout(false);
            this.grbInforNVYTe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoNVYTe)).EndInit();
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
        private System.Windows.Forms.TextBox txtSDTNVYTe;
        private System.Windows.Forms.TextBox txtTenNVYTe;
        private System.Windows.Forms.TextBox txtMaNVYTe;
        private System.Windows.Forms.DateTimePicker DOBNVYTe;
        private System.Windows.Forms.ComboBox cobGioiTinhNVYTe;
        private System.Windows.Forms.ComboBox cobDiaChiNVYTe;
        private System.Windows.Forms.ComboBox cobTrangThaiNVYTe;
        private System.Windows.Forms.Label labTimKiemNVYTe;
        private System.Windows.Forms.Label labTenNVYTeTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemNVYTe;
        private System.Windows.Forms.Button btnThemNVYTe;
        private System.Windows.Forms.Button btnXoaNVYTe;
        private System.Windows.Forms.Button btnSuaNVYTe;
        private System.Windows.Forms.DataGridView dgvInfoNVYTe;
    }
}