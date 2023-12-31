namespace HMS_NHOM25
{
    partial class Admin
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
            this.grbInforQTV.Location = new System.Drawing.Point(31, 18);
            this.grbInforQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforQTV.Name = "grbInforQTV";
            this.grbInforQTV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforQTV.Size = new System.Drawing.Size(904, 166);
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
            this.cobTrangThaiQTV.Location = new System.Drawing.Point(130, 114);
            this.cobTrangThaiQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobTrangThaiQTV.Name = "cobTrangThaiQTV";
            this.cobTrangThaiQTV.Size = new System.Drawing.Size(164, 24);
            this.cobTrangThaiQTV.TabIndex = 17;
            // 
            // cobDiaChiQTV
            // 
            this.cobDiaChiQTV.FormattingEnabled = true;
            this.cobDiaChiQTV.Items.AddRange(new object[] {
            "Đống Đa, Hà Nội",
            "Hai Bà Trưng, Hà Nội",
            "Phù Cừ, Hưng Yên"});
            this.cobDiaChiQTV.Location = new System.Drawing.Point(400, 75);
            this.cobDiaChiQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDiaChiQTV.Name = "cobDiaChiQTV";
            this.cobDiaChiQTV.Size = new System.Drawing.Size(160, 24);
            this.cobDiaChiQTV.TabIndex = 16;
            // 
            // cobGioiTinhQTV
            // 
            this.cobGioiTinhQTV.FormattingEnabled = true;
            this.cobGioiTinhQTV.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhQTV.Location = new System.Drawing.Point(400, 38);
            this.cobGioiTinhQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobGioiTinhQTV.Name = "cobGioiTinhQTV";
            this.cobGioiTinhQTV.Size = new System.Drawing.Size(160, 24);
            this.cobGioiTinhQTV.TabIndex = 15;
            // 
            // DOBQTV
            // 
            this.DOBQTV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBQTV.Location = new System.Drawing.Point(692, 40);
            this.DOBQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOBQTV.Name = "DOBQTV";
            this.DOBQTV.Size = new System.Drawing.Size(162, 22);
            this.DOBQTV.TabIndex = 13;
            // 
            // txtSDTQTV
            // 
            this.txtSDTQTV.Location = new System.Drawing.Point(693, 77);
            this.txtSDTQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTQTV.Name = "txtSDTQTV";
            this.txtSDTQTV.Size = new System.Drawing.Size(160, 22);
            this.txtSDTQTV.TabIndex = 12;
            // 
            // txtTenQTV
            // 
            this.txtTenQTV.Location = new System.Drawing.Point(130, 77);
            this.txtTenQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenQTV.Name = "txtTenQTV";
            this.txtTenQTV.Size = new System.Drawing.Size(164, 22);
            this.txtTenQTV.TabIndex = 10;
            // 
            // txtMaQTV
            // 
            this.txtMaQTV.Location = new System.Drawing.Point(130, 38);
            this.txtMaQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaQTV.Name = "txtMaQTV";
            this.txtMaQTV.Size = new System.Drawing.Size(164, 22);
            this.txtMaQTV.TabIndex = 9;
            // 
            // labTrangThaiQTV
            // 
            this.labTrangThaiQTV.AutoSize = true;
            this.labTrangThaiQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTrangThaiQTV.Location = new System.Drawing.Point(33, 121);
            this.labTrangThaiQTV.Name = "labTrangThaiQTV";
            this.labTrangThaiQTV.Size = new System.Drawing.Size(67, 16);
            this.labTrangThaiQTV.TabIndex = 8;
            this.labTrangThaiQTV.Text = "Trạng thái";
            // 
            // labSDTQTV
            // 
            this.labSDTQTV.AutoSize = true;
            this.labSDTQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTQTV.Location = new System.Drawing.Point(609, 82);
            this.labSDTQTV.Name = "labSDTQTV";
            this.labSDTQTV.Size = new System.Drawing.Size(34, 16);
            this.labSDTQTV.TabIndex = 5;
            this.labSDTQTV.Text = "SĐT";
            // 
            // labDiaChiQTV
            // 
            this.labDiaChiQTV.AutoSize = true;
            this.labDiaChiQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChiQTV.Location = new System.Drawing.Point(332, 82);
            this.labDiaChiQTV.Name = "labDiaChiQTV";
            this.labDiaChiQTV.Size = new System.Drawing.Size(47, 16);
            this.labDiaChiQTV.TabIndex = 4;
            this.labDiaChiQTV.Text = "Địa chỉ";
            // 
            // labSexQTV
            // 
            this.labSexQTV.AutoSize = true;
            this.labSexQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSexQTV.Location = new System.Drawing.Point(332, 40);
            this.labSexQTV.Name = "labSexQTV";
            this.labSexQTV.Size = new System.Drawing.Size(54, 16);
            this.labSexQTV.TabIndex = 3;
            this.labSexQTV.Text = "Giới tính";
            // 
            // labNgaySinhQTV
            // 
            this.labNgaySinhQTV.AutoSize = true;
            this.labNgaySinhQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinhQTV.Location = new System.Drawing.Point(609, 42);
            this.labNgaySinhQTV.Name = "labNgaySinhQTV";
            this.labNgaySinhQTV.Size = new System.Drawing.Size(67, 16);
            this.labNgaySinhQTV.TabIndex = 2;
            this.labNgaySinhQTV.Text = "Ngày sinh";
            // 
            // labTenQTV
            // 
            this.labTenQTV.AutoSize = true;
            this.labTenQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenQTV.Location = new System.Drawing.Point(33, 82);
            this.labTenQTV.Name = "labTenQTV";
            this.labTenQTV.Size = new System.Drawing.Size(64, 16);
            this.labTenQTV.TabIndex = 1;
            this.labTenQTV.Text = "Họ và tên";
            // 
            // labMaQTV
            // 
            this.labMaQTV.AutoSize = true;
            this.labMaQTV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaQTV.Location = new System.Drawing.Point(33, 40);
            this.labMaQTV.Name = "labMaQTV";
            this.labMaQTV.Size = new System.Drawing.Size(72, 16);
            this.labMaQTV.TabIndex = 0;
            this.labMaQTV.Text = "Mã quản lý";
            // 
            // labTimKiemQTV
            // 
            this.labTimKiemQTV.AutoSize = true;
            this.labTimKiemQTV.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemQTV.Location = new System.Drawing.Point(41, 195);
            this.labTimKiemQTV.Name = "labTimKiemQTV";
            this.labTimKiemQTV.Size = new System.Drawing.Size(62, 16);
            this.labTimKiemQTV.TabIndex = 1;
            this.labTimKiemQTV.Text = "Tìm kiếm";
            // 
            // labTenQTVTimKiem
            // 
            this.labTenQTVTimKiem.AutoSize = true;
            this.labTenQTVTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenQTVTimKiem.Location = new System.Drawing.Point(60, 222);
            this.labTenQTVTimKiem.Name = "labTenQTVTimKiem";
            this.labTenQTVTimKiem.Size = new System.Drawing.Size(77, 16);
            this.labTenQTVTimKiem.TabIndex = 18;
            this.labTenQTVTimKiem.Text = "Tên quản lý";
            // 
            // txtTimKiemQTV
            // 
            this.txtTimKiemQTV.Location = new System.Drawing.Point(161, 217);
            this.txtTimKiemQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemQTV.Name = "txtTimKiemQTV";
            this.txtTimKiemQTV.Size = new System.Drawing.Size(164, 22);
            this.txtTimKiemQTV.TabIndex = 18;
            // 
            // dgvInfoQTV
            // 
            this.dgvInfoQTV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoQTV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoQTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoQTV.Location = new System.Drawing.Point(31, 263);
            this.dgvInfoQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoQTV.Name = "dgvInfoQTV";
            this.dgvInfoQTV.RowHeadersWidth = 62;
            this.dgvInfoQTV.RowTemplate.Height = 28;
            this.dgvInfoQTV.Size = new System.Drawing.Size(908, 363);
            this.dgvInfoQTV.TabIndex = 23;
            // 
            // btnSuaQTV
            // 
            this.btnSuaQTV.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaQTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaQTV.Location = new System.Drawing.Point(462, 206);
            this.btnSuaQTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaQTV.Name = "btnSuaQTV";
            this.btnSuaQTV.Size = new System.Drawing.Size(111, 31);
            this.btnSuaQTV.TabIndex = 22;
            this.btnSuaQTV.Text = "Cập nhật";
            this.btnSuaQTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaQTV.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 681);
            this.Controls.Add(this.dgvInfoQTV);
            this.Controls.Add(this.btnSuaQTV);
            this.Controls.Add(this.txtTimKiemQTV);
            this.Controls.Add(this.labTenQTVTimKiem);
            this.Controls.Add(this.labTimKiemQTV);
            this.Controls.Add(this.grbInforQTV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "Admin";
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
    }
}