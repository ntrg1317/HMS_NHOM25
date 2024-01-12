namespace HMS_NHOM25
{
    partial class ChiTietPhong
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
            this.grbInfoDonThuoc = new System.Windows.Forms.GroupBox();
            this.dateNgayVao = new System.Windows.Forms.DateTimePicker();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.labLieuDung = new System.Windows.Forms.Label();
            this.labNgayVao = new System.Windows.Forms.Label();
            this.labSoLuongThuoc = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.txtBenhTrang = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.labTenThuoc = new System.Windows.Forms.Label();
            this.txtTimKiemTenThuoc = new System.Windows.Forms.TextBox();
            this.labTimKiemDT = new System.Windows.Forms.Label();
            this.labTKTenThuoc = new System.Windows.Forms.Label();
            this.dgvCTPhong = new System.Windows.Forms.DataGridView();
            this.labCTPhong = new System.Windows.Forms.Label();
            this.labTenPhong = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoatAddDonThuoc = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.btnThemBN_Phong = new System.Windows.Forms.Button();
            this.btnCapNhatCTDonThuoc = new System.Windows.Forms.Button();
            this.grbInfoDonThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoDonThuoc
            // 
            this.grbInfoDonThuoc.Controls.Add(this.dateNgayVao);
            this.grbInfoDonThuoc.Controls.Add(this.btnLamMoi);
            this.grbInfoDonThuoc.Controls.Add(this.labLieuDung);
            this.grbInfoDonThuoc.Controls.Add(this.labNgayVao);
            this.grbInfoDonThuoc.Controls.Add(this.labSoLuongThuoc);
            this.grbInfoDonThuoc.Controls.Add(this.txtMaBN);
            this.grbInfoDonThuoc.Controls.Add(this.txtBenhTrang);
            this.grbInfoDonThuoc.Controls.Add(this.txtTenBN);
            this.grbInfoDonThuoc.Controls.Add(this.labTenThuoc);
            this.grbInfoDonThuoc.ForeColor = System.Drawing.Color.Red;
            this.grbInfoDonThuoc.Location = new System.Drawing.Point(33, 158);
            this.grbInfoDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Name = "grbInfoDonThuoc";
            this.grbInfoDonThuoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Size = new System.Drawing.Size(888, 259);
            this.grbInfoDonThuoc.TabIndex = 23;
            this.grbInfoDonThuoc.TabStop = false;
            this.grbInfoDonThuoc.Text = "Thông Tin Bệnh Nhân";
            // 
            // dateNgayVao
            // 
            this.dateNgayVao.CustomFormat = "yyyy-MM-dd";
            this.dateNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayVao.Location = new System.Drawing.Point(187, 98);
            this.dateNgayVao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayVao.Name = "dateNgayVao";
            this.dateNgayVao.Size = new System.Drawing.Size(220, 26);
            this.dateNgayVao.TabIndex = 56;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = global::HMS_NHOM25.Properties.Resources.refresh;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(398, 198);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(99, 39);
            this.btnLamMoi.TabIndex = 55;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // labLieuDung
            // 
            this.labLieuDung.AutoSize = true;
            this.labLieuDung.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labLieuDung.Location = new System.Drawing.Point(498, 100);
            this.labLieuDung.Name = "labLieuDung";
            this.labLieuDung.Size = new System.Drawing.Size(92, 20);
            this.labLieuDung.TabIndex = 31;
            this.labLieuDung.Text = "Bệnh Trạng";
            // 
            // labNgayVao
            // 
            this.labNgayVao.AutoSize = true;
            this.labNgayVao.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgayVao.Location = new System.Drawing.Point(65, 100);
            this.labNgayVao.Name = "labNgayVao";
            this.labNgayVao.Size = new System.Drawing.Size(78, 20);
            this.labNgayVao.TabIndex = 29;
            this.labNgayVao.Text = "Ngày Vào";
            // 
            // labSoLuongThuoc
            // 
            this.labSoLuongThuoc.AutoSize = true;
            this.labSoLuongThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSoLuongThuoc.Location = new System.Drawing.Point(498, 40);
            this.labSoLuongThuoc.Name = "labSoLuongThuoc";
            this.labSoLuongThuoc.Size = new System.Drawing.Size(62, 20);
            this.labSoLuongThuoc.TabIndex = 29;
            this.labSoLuongThuoc.Text = "Tên BN";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(187, 32);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(219, 26);
            this.txtMaBN.TabIndex = 30;
            // 
            // txtBenhTrang
            // 
            this.txtBenhTrang.Location = new System.Drawing.Point(610, 96);
            this.txtBenhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBenhTrang.Name = "txtBenhTrang";
            this.txtBenhTrang.Size = new System.Drawing.Size(219, 26);
            this.txtBenhTrang.TabIndex = 30;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(610, 34);
            this.txtTenBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(219, 26);
            this.txtTenBN.TabIndex = 30;
            // 
            // labTenThuoc
            // 
            this.labTenThuoc.AutoSize = true;
            this.labTenThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenThuoc.Location = new System.Drawing.Point(65, 40);
            this.labTenThuoc.Name = "labTenThuoc";
            this.labTenThuoc.Size = new System.Drawing.Size(57, 20);
            this.labTenThuoc.TabIndex = 23;
            this.labTenThuoc.Text = "Mã BN";
            // 
            // txtTimKiemTenThuoc
            // 
            this.txtTimKiemTenThuoc.Location = new System.Drawing.Point(222, 442);
            this.txtTimKiemTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemTenThuoc.Name = "txtTimKiemTenThuoc";
            this.txtTimKiemTenThuoc.Size = new System.Drawing.Size(218, 26);
            this.txtTimKiemTenThuoc.TabIndex = 38;
            // 
            // labTimKiemDT
            // 
            this.labTimKiemDT.AutoSize = true;
            this.labTimKiemDT.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemDT.Location = new System.Drawing.Point(32, 418);
            this.labTimKiemDT.Name = "labTimKiemDT";
            this.labTimKiemDT.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemDT.TabIndex = 37;
            this.labTimKiemDT.Text = "Tìm kiếm";
            // 
            // labTKTenThuoc
            // 
            this.labTKTenThuoc.AutoSize = true;
            this.labTKTenThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTKTenThuoc.Location = new System.Drawing.Point(100, 446);
            this.labTKTenThuoc.Name = "labTKTenThuoc";
            this.labTKTenThuoc.Size = new System.Drawing.Size(62, 20);
            this.labTKTenThuoc.TabIndex = 37;
            this.labTKTenThuoc.Text = "Tên BN";
            // 
            // dgvCTPhong
            // 
            this.dgvCTPhong.AllowUserToDeleteRows = false;
            this.dgvCTPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhong.Location = new System.Drawing.Point(35, 494);
            this.dgvCTPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTPhong.Name = "dgvCTPhong";
            this.dgvCTPhong.ReadOnly = true;
            this.dgvCTPhong.RowHeadersWidth = 62;
            this.dgvCTPhong.RowTemplate.Height = 28;
            this.dgvCTPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPhong.Size = new System.Drawing.Size(886, 258);
            this.dgvCTPhong.TabIndex = 42;
            this.dgvCTPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhong_CellClick);
            // 
            // labCTPhong
            // 
            this.labCTPhong.AutoSize = true;
            this.labCTPhong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labCTPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCTPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labCTPhong.Location = new System.Drawing.Point(384, 11);
            this.labCTPhong.Name = "labCTPhong";
            this.labCTPhong.Size = new System.Drawing.Size(204, 32);
            this.labCTPhong.TabIndex = 48;
            this.labCTPhong.Text = "Chi tiết phòng";
            // 
            // labTenPhong
            // 
            this.labTenPhong.AutoSize = true;
            this.labTenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenPhong.Location = new System.Drawing.Point(531, 85);
            this.labTenPhong.Name = "labTenPhong";
            this.labTenPhong.Size = new System.Drawing.Size(86, 20);
            this.labTenPhong.TabIndex = 49;
            this.labTenPhong.Text = "Tên Phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(644, 79);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(219, 26);
            this.txtTenPhong.TabIndex = 50;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(220, 79);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(219, 26);
            this.txtMaPhong.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(98, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mã Phòng";
            // 
            // btnThoatAddDonThuoc
            // 
            this.btnThoatAddDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.cancel;
            this.btnThoatAddDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddDonThuoc.Location = new System.Drawing.Point(389, 779);
            this.btnThoatAddDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddDonThuoc.Name = "btnThoatAddDonThuoc";
            this.btnThoatAddDonThuoc.Size = new System.Drawing.Size(141, 39);
            this.btnThoatAddDonThuoc.TabIndex = 47;
            this.btnThoatAddDonThuoc.Text = "Thoát";
            this.btnThoatAddDonThuoc.UseVisualStyleBackColor = true;
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.ForeColor = System.Drawing.Color.Black;
            this.btnXoaThuoc.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaThuoc.Location = new System.Drawing.Point(819, 438);
            this.btnXoaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(102, 39);
            this.btnXoaThuoc.TabIndex = 45;
            this.btnXoaThuoc.Text = "Xóa";
            this.btnXoaThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaThuoc.UseVisualStyleBackColor = true;
            // 
            // btnThemBN_Phong
            // 
            this.btnThemBN_Phong.ForeColor = System.Drawing.Color.Black;
            this.btnThemBN_Phong.Image = global::HMS_NHOM25.Properties.Resources.plus;
            this.btnThemBN_Phong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBN_Phong.Location = new System.Drawing.Point(482, 438);
            this.btnThemBN_Phong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemBN_Phong.Name = "btnThemBN_Phong";
            this.btnThemBN_Phong.Size = new System.Drawing.Size(99, 39);
            this.btnThemBN_Phong.TabIndex = 44;
            this.btnThemBN_Phong.Text = "Thêm";
            this.btnThemBN_Phong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemBN_Phong.UseVisualStyleBackColor = true;
            this.btnThemBN_Phong.Click += new System.EventHandler(this.btnThemBN_Phong_Click);
            // 
            // btnCapNhatCTDonThuoc
            // 
            this.btnCapNhatCTDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnCapNhatCTDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatCTDonThuoc.Location = new System.Drawing.Point(644, 438);
            this.btnCapNhatCTDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatCTDonThuoc.Name = "btnCapNhatCTDonThuoc";
            this.btnCapNhatCTDonThuoc.Size = new System.Drawing.Size(114, 39);
            this.btnCapNhatCTDonThuoc.TabIndex = 41;
            this.btnCapNhatCTDonThuoc.Text = "Cập nhật";
            this.btnCapNhatCTDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatCTDonThuoc.UseVisualStyleBackColor = true;
            this.btnCapNhatCTDonThuoc.Click += new System.EventHandler(this.btnCapNhatCTDonThuoc_Click);
            // 
            // ChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(955, 832);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.labTenPhong);
            this.Controls.Add(this.labCTPhong);
            this.Controls.Add(this.btnThoatAddDonThuoc);
            this.Controls.Add(this.btnXoaThuoc);
            this.Controls.Add(this.btnThemBN_Phong);
            this.Controls.Add(this.dgvCTPhong);
            this.Controls.Add(this.labTKTenThuoc);
            this.Controls.Add(this.btnCapNhatCTDonThuoc);
            this.Controls.Add(this.grbInfoDonThuoc);
            this.Controls.Add(this.txtTimKiemTenThuoc);
            this.Controls.Add(this.labTimKiemDT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChiTietPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietDonThuoc";
            this.Load += new System.EventHandler(this.ChiTietPhong_Load);
            this.grbInfoDonThuoc.ResumeLayout(false);
            this.grbInfoDonThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfoDonThuoc;
        private System.Windows.Forms.Label labLieuDung;
        private System.Windows.Forms.Label labSoLuongThuoc;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label labTenThuoc;
        private System.Windows.Forms.Button btnCapNhatCTDonThuoc;
        private System.Windows.Forms.TextBox txtTimKiemTenThuoc;
        private System.Windows.Forms.Label labTimKiemDT;
        private System.Windows.Forms.Label labTKTenThuoc;
        private System.Windows.Forms.DataGridView dgvCTPhong;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Button btnThemBN_Phong;
        private System.Windows.Forms.Button btnThoatAddDonThuoc;
        private System.Windows.Forms.Label labNgayVao;
        private System.Windows.Forms.Label labCTPhong;
        private System.Windows.Forms.Label labTenPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.DateTimePicker dateNgayVao;
        private System.Windows.Forms.TextBox txtBenhTrang;
    }
}