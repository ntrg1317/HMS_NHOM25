namespace HMS_NHOM25
{
    partial class HoaDon
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
            this.grbTTBenhNhan = new System.Windows.Forms.GroupBox();
            this.dateNgayVao = new System.Windows.Forms.DateTimePicker();
            this.labNgayVao = new System.Windows.Forms.Label();
            this.cbbDiaChi = new System.Windows.Forms.ComboBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.labGioiTinh = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.labNgaySinh = new System.Windows.Forms.Label();
            this.labMaBN = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labMaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dateNgayTT = new System.Windows.Forms.DateTimePicker();
            this.labHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.labNgayTT = new System.Windows.Forms.Label();
            this.labHoaDon = new System.Windows.Forms.Label();
            this.grbBangChiPhi = new System.Windows.Forms.GroupBox();
            this.dgvBangChiPhi = new System.Windows.Forms.DataGridView();
            this.grbThanhToan = new System.Windows.Forms.GroupBox();
            this.labDaTT = new System.Windows.Forms.Label();
            this.txtDaTT = new System.Windows.Forms.TextBox();
            this.labConLai = new System.Windows.Forms.Label();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.labVND = new System.Windows.Forms.Label();
            this.labTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.labInHoaDon = new System.Windows.Forms.Button();
            this.grbTTBenhNhan.SuspendLayout();
            this.grbBangChiPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChiPhi)).BeginInit();
            this.grbThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTBenhNhan
            // 
            this.grbTTBenhNhan.Controls.Add(this.dateNgayVao);
            this.grbTTBenhNhan.Controls.Add(this.labNgayVao);
            this.grbTTBenhNhan.Controls.Add(this.cbbDiaChi);
            this.grbTTBenhNhan.Controls.Add(this.cbbGioiTinh);
            this.grbTTBenhNhan.Controls.Add(this.labGioiTinh);
            this.grbTTBenhNhan.Controls.Add(this.dateNgaySinh);
            this.grbTTBenhNhan.Controls.Add(this.labNgaySinh);
            this.grbTTBenhNhan.Controls.Add(this.labMaBN);
            this.grbTTBenhNhan.Controls.Add(this.txtMaBN);
            this.grbTTBenhNhan.Controls.Add(this.labDiaChi);
            this.grbTTBenhNhan.Controls.Add(this.labMaHD);
            this.grbTTBenhNhan.Controls.Add(this.txtMaHD);
            this.grbTTBenhNhan.Controls.Add(this.dateNgayTT);
            this.grbTTBenhNhan.Controls.Add(this.labHoTen);
            this.grbTTBenhNhan.Controls.Add(this.txtHoTen);
            this.grbTTBenhNhan.Controls.Add(this.labNgayTT);
            this.grbTTBenhNhan.ForeColor = System.Drawing.Color.Red;
            this.grbTTBenhNhan.Location = new System.Drawing.Point(28, 78);
            this.grbTTBenhNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTBenhNhan.Name = "grbTTBenhNhan";
            this.grbTTBenhNhan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTBenhNhan.Size = new System.Drawing.Size(1037, 195);
            this.grbTTBenhNhan.TabIndex = 41;
            this.grbTTBenhNhan.TabStop = false;
            this.grbTTBenhNhan.Text = "Thông tin bệnh nhân";
            this.grbTTBenhNhan.Enter += new System.EventHandler(this.grbTTBenhNhan_Enter);
            // 
            // dateNgayVao
            // 
            this.dateNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayVao.Location = new System.Drawing.Point(826, 95);
            this.dateNgayVao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayVao.Name = "dateNgayVao";
            this.dateNgayVao.Size = new System.Drawing.Size(167, 26);
            this.dateNgayVao.TabIndex = 49;
            // 
            // labNgayVao
            // 
            this.labNgayVao.AutoSize = true;
            this.labNgayVao.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgayVao.Location = new System.Drawing.Point(726, 99);
            this.labNgayVao.Name = "labNgayVao";
            this.labNgayVao.Size = new System.Drawing.Size(74, 20);
            this.labNgayVao.TabIndex = 48;
            this.labNgayVao.Text = "Ngày vào";
            // 
            // cbbDiaChi
            // 
            this.cbbDiaChi.FormattingEnabled = true;
            this.cbbDiaChi.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbDiaChi.Location = new System.Drawing.Point(826, 149);
            this.cbbDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDiaChi.Name = "cbbDiaChi";
            this.cbbDiaChi.Size = new System.Drawing.Size(167, 28);
            this.cbbDiaChi.TabIndex = 47;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(503, 151);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(167, 28);
            this.cbbGioiTinh.TabIndex = 46;
            // 
            // labGioiTinh
            // 
            this.labGioiTinh.AutoSize = true;
            this.labGioiTinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labGioiTinh.Location = new System.Drawing.Point(366, 151);
            this.labGioiTinh.Name = "labGioiTinh";
            this.labGioiTinh.Size = new System.Drawing.Size(67, 20);
            this.labGioiTinh.TabIndex = 45;
            this.labGioiTinh.Text = "Giới tính";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(137, 142);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(164, 26);
            this.dateNgaySinh.TabIndex = 44;
            // 
            // labNgaySinh
            // 
            this.labNgaySinh.AutoSize = true;
            this.labNgaySinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinh.Location = new System.Drawing.Point(34, 149);
            this.labNgaySinh.Name = "labNgaySinh";
            this.labNgaySinh.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinh.TabIndex = 43;
            this.labNgaySinh.Text = "Ngày sinh";
            // 
            // labMaBN
            // 
            this.labMaBN.AutoSize = true;
            this.labMaBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBN.Location = new System.Drawing.Point(366, 99);
            this.labMaBN.Name = "labMaBN";
            this.labMaBN.Size = new System.Drawing.Size(111, 20);
            this.labMaBN.TabIndex = 41;
            this.labMaBN.Text = "Mã bệnh nhân";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(503, 95);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(167, 26);
            this.txtMaBN.TabIndex = 42;
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDiaChi.Location = new System.Drawing.Point(726, 149);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(57, 20);
            this.labDiaChi.TabIndex = 39;
            this.labDiaChi.Text = "Địa chỉ";
            // 
            // labMaHD
            // 
            this.labMaHD.AutoSize = true;
            this.labMaHD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaHD.Location = new System.Drawing.Point(34, 52);
            this.labMaHD.Name = "labMaHD";
            this.labMaHD.Size = new System.Drawing.Size(93, 20);
            this.labMaHD.TabIndex = 37;
            this.labMaHD.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(134, 46);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(167, 26);
            this.txtMaHD.TabIndex = 38;
            // 
            // dateNgayTT
            // 
            this.dateNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTT.Location = new System.Drawing.Point(503, 46);
            this.dateNgayTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayTT.Name = "dateNgayTT";
            this.dateNgayTT.Size = new System.Drawing.Size(164, 26);
            this.dateNgayTT.TabIndex = 36;
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labHoTen.Location = new System.Drawing.Point(34, 99);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(57, 20);
            this.labHoTen.TabIndex = 33;
            this.labHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(134, 92);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(167, 26);
            this.txtHoTen.TabIndex = 34;
            // 
            // labNgayTT
            // 
            this.labNgayTT.AutoSize = true;
            this.labNgayTT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgayTT.Location = new System.Drawing.Point(366, 52);
            this.labNgayTT.Name = "labNgayTT";
            this.labNgayTT.Size = new System.Drawing.Size(126, 20);
            this.labNgayTT.TabIndex = 29;
            this.labNgayTT.Text = "Ngày thanh toán";
            // 
            // labHoaDon
            // 
            this.labHoaDon.AutoSize = true;
            this.labHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHoaDon.Location = new System.Drawing.Point(459, 11);
            this.labHoaDon.Name = "labHoaDon";
            this.labHoaDon.Size = new System.Drawing.Size(193, 52);
            this.labHoaDon.TabIndex = 37;
            this.labHoaDon.Text = "Hóa đơn";
            // 
            // grbBangChiPhi
            // 
            this.grbBangChiPhi.Controls.Add(this.dgvBangChiPhi);
            this.grbBangChiPhi.ForeColor = System.Drawing.Color.Red;
            this.grbBangChiPhi.Location = new System.Drawing.Point(28, 278);
            this.grbBangChiPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbBangChiPhi.Name = "grbBangChiPhi";
            this.grbBangChiPhi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbBangChiPhi.Size = new System.Drawing.Size(1037, 205);
            this.grbBangChiPhi.TabIndex = 47;
            this.grbBangChiPhi.TabStop = false;
            this.grbBangChiPhi.Text = "Bảng chi phí";
            // 
            // dgvBangChiPhi
            // 
            this.dgvBangChiPhi.AllowUserToAddRows = false;
            this.dgvBangChiPhi.AllowUserToDeleteRows = false;
            this.dgvBangChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangChiPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangChiPhi.Location = new System.Drawing.Point(3, 21);
            this.dgvBangChiPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBangChiPhi.Name = "dgvBangChiPhi";
            this.dgvBangChiPhi.ReadOnly = true;
            this.dgvBangChiPhi.RowHeadersWidth = 51;
            this.dgvBangChiPhi.RowTemplate.Height = 24;
            this.dgvBangChiPhi.Size = new System.Drawing.Size(1031, 182);
            this.dgvBangChiPhi.TabIndex = 0;
            // 
            // grbThanhToan
            // 
            this.grbThanhToan.Controls.Add(this.labDaTT);
            this.grbThanhToan.Controls.Add(this.txtDaTT);
            this.grbThanhToan.Controls.Add(this.labConLai);
            this.grbThanhToan.Controls.Add(this.txtConLai);
            this.grbThanhToan.Controls.Add(this.labVND);
            this.grbThanhToan.Controls.Add(this.labTongTien);
            this.grbThanhToan.Controls.Add(this.txtTongTien);
            this.grbThanhToan.ForeColor = System.Drawing.Color.Red;
            this.grbThanhToan.Location = new System.Drawing.Point(32, 488);
            this.grbThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThanhToan.Name = "grbThanhToan";
            this.grbThanhToan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThanhToan.Size = new System.Drawing.Size(1037, 142);
            this.grbThanhToan.TabIndex = 48;
            this.grbThanhToan.TabStop = false;
            this.grbThanhToan.Text = "Thanh toán";
            this.grbThanhToan.Enter += new System.EventHandler(this.grbInfoHoaDon_Enter);
            // 
            // labDaTT
            // 
            this.labDaTT.AutoSize = true;
            this.labDaTT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labDaTT.Location = new System.Drawing.Point(97, 84);
            this.labDaTT.Name = "labDaTT";
            this.labDaTT.Size = new System.Drawing.Size(111, 20);
            this.labDaTT.TabIndex = 38;
            this.labDaTT.Text = "Đã thanh toán";
            // 
            // txtDaTT
            // 
            this.txtDaTT.Location = new System.Drawing.Point(222, 84);
            this.txtDaTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDaTT.Name = "txtDaTT";
            this.txtDaTT.Size = new System.Drawing.Size(167, 26);
            this.txtDaTT.TabIndex = 39;
            // 
            // labConLai
            // 
            this.labConLai.AutoSize = true;
            this.labConLai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labConLai.Location = new System.Drawing.Point(646, 36);
            this.labConLai.Name = "labConLai";
            this.labConLai.Size = new System.Drawing.Size(57, 20);
            this.labConLai.TabIndex = 36;
            this.labConLai.Text = "Còn lại";
            // 
            // txtConLai
            // 
            this.txtConLai.Location = new System.Drawing.Point(746, 30);
            this.txtConLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(167, 26);
            this.txtConLai.TabIndex = 37;
            // 
            // labVND
            // 
            this.labVND.AutoSize = true;
            this.labVND.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labVND.Location = new System.Drawing.Point(415, 41);
            this.labVND.Name = "labVND";
            this.labVND.Size = new System.Drawing.Size(53, 20);
            this.labVND.TabIndex = 35;
            this.labVND.Text = "(VNĐ)";
            // 
            // labTongTien
            // 
            this.labTongTien.AutoSize = true;
            this.labTongTien.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTongTien.Location = new System.Drawing.Point(96, 39);
            this.labTongTien.Name = "labTongTien";
            this.labTongTien.Size = new System.Drawing.Size(75, 20);
            this.labTongTien.TabIndex = 33;
            this.labTongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(220, 39);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(167, 26);
            this.txtTongTien.TabIndex = 34;
            // 
            // labInHoaDon
            // 
            this.labInHoaDon.Image = global::HMS_NHOM25.Properties.Resources.printer__2_;
            this.labInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labInHoaDon.Location = new System.Drawing.Point(854, 635);
            this.labInHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labInHoaDon.Name = "labInHoaDon";
            this.labInHoaDon.Size = new System.Drawing.Size(114, 39);
            this.labInHoaDon.TabIndex = 49;
            this.labInHoaDon.Text = "In hóa đơn";
            this.labInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labInHoaDon.UseVisualStyleBackColor = true;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 688);
            this.Controls.Add(this.labInHoaDon);
            this.Controls.Add(this.grbThanhToan);
            this.Controls.Add(this.grbBangChiPhi);
            this.Controls.Add(this.labHoaDon);
            this.Controls.Add(this.grbTTBenhNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HoaDon";
            this.Text = "Hóa đơn";
            this.grbTTBenhNhan.ResumeLayout(false);
            this.grbTTBenhNhan.PerformLayout();
            this.grbBangChiPhi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChiPhi)).EndInit();
            this.grbThanhToan.ResumeLayout(false);
            this.grbThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbTTBenhNhan;
        private System.Windows.Forms.DateTimePicker dateNgayTT;
        private System.Windows.Forms.Label labNgayTT;
        private System.Windows.Forms.Label labHoaDon;
        private System.Windows.Forms.Label labMaBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label labNgaySinh;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label labGioiTinh;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cbbDiaChi;
        private System.Windows.Forms.DateTimePicker dateNgayVao;
        private System.Windows.Forms.Label labNgayVao;
        private System.Windows.Forms.GroupBox grbBangChiPhi;
        private System.Windows.Forms.DataGridView dgvBangChiPhi;
        private System.Windows.Forms.GroupBox grbThanhToan;
        private System.Windows.Forms.Label labVND;
        private System.Windows.Forms.Label labTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label labDaTT;
        private System.Windows.Forms.TextBox txtDaTT;
        private System.Windows.Forms.Label labConLai;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.Button labInHoaDon;
    }
}