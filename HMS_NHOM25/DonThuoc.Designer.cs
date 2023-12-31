namespace HMS_NHOM25
{
    partial class DonThuoc
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labTimKiemDT = new System.Windows.Forms.Label();
            this.labTenBNTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiemSDTBN = new System.Windows.Forms.TextBox();
            this.dgvInfoDSDonThuoc = new System.Windows.Forms.DataGridView();
            this.labDSDT = new System.Windows.Forms.Label();
            this.grbInfoDonThuoc = new System.Windows.Forms.GroupBox();
            this.cmbTenThuoc = new System.Windows.Forms.ComboBox();
            this.labVND = new System.Windows.Forms.Label();
            this.labTienThuoc = new System.Windows.Forms.Label();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.labLieuDung = new System.Windows.Forms.Label();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.labSoLuongThuoc = new System.Windows.Forms.Label();
            this.txtSoLuongThuoc = new System.Windows.Forms.TextBox();
            this.labTenThuoc = new System.Windows.Forms.Label();
            this.btnCapNhatDonThuoc = new System.Windows.Forms.Button();
            this.btnXoaDonThuoc = new System.Windows.Forms.Button();
            this.btnThemDonThuoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDSDonThuoc)).BeginInit();
            this.grbInfoDonThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTimKiemDT
            // 
            this.labTimKiemDT.AutoSize = true;
            this.labTimKiemDT.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemDT.Location = new System.Drawing.Point(35, 218);
            this.labTimKiemDT.Name = "labTimKiemDT";
            this.labTimKiemDT.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemDT.TabIndex = 1;
            this.labTimKiemDT.Text = "Tìm kiếm";
            // 
            // labTenBNTimKiem
            // 
            this.labTenBNTimKiem.AutoSize = true;
            this.labTenBNTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBNTimKiem.Location = new System.Drawing.Point(100, 271);
            this.labTenBNTimKiem.Name = "labTenBNTimKiem";
            this.labTenBNTimKiem.Size = new System.Drawing.Size(121, 20);
            this.labTenBNTimKiem.TabIndex = 18;
            this.labTenBNTimKiem.Text = "SĐT bệnh nhân";
            // 
            // txtTimKiemSDTBN
            // 
            this.txtTimKiemSDTBN.Location = new System.Drawing.Point(252, 265);
            this.txtTimKiemSDTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemSDTBN.Name = "txtTimKiemSDTBN";
            this.txtTimKiemSDTBN.Size = new System.Drawing.Size(218, 26);
            this.txtTimKiemSDTBN.TabIndex = 18;
            this.txtTimKiemSDTBN.TextChanged += new System.EventHandler(this.txtTimKiemSDTBN_TextChanged);
            // 
            // dgvInfoDSDonThuoc
            // 
            this.dgvInfoDSDonThuoc.AllowUserToAddRows = false;
            this.dgvInfoDSDonThuoc.AllowUserToDeleteRows = false;
            this.dgvInfoDSDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoDSDonThuoc.Location = new System.Drawing.Point(27, 378);
            this.dgvInfoDSDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoDSDonThuoc.Name = "dgvInfoDSDonThuoc";
            this.dgvInfoDSDonThuoc.ReadOnly = true;
            this.dgvInfoDSDonThuoc.RowHeadersWidth = 62;
            this.dgvInfoDSDonThuoc.RowTemplate.Height = 28;
            this.dgvInfoDSDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoDSDonThuoc.Size = new System.Drawing.Size(1028, 450);
            this.dgvInfoDSDonThuoc.TabIndex = 20;
            this.dgvInfoDSDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoDSDonThuoc_CellClick);
            // 
            // labDSDT
            // 
            this.labDSDT.AutoSize = true;
            this.labDSDT.ForeColor = System.Drawing.Color.Red;
            this.labDSDT.Location = new System.Drawing.Point(35, 324);
            this.labDSDT.Name = "labDSDT";
            this.labDSDT.Size = new System.Drawing.Size(161, 20);
            this.labDSDT.TabIndex = 21;
            this.labDSDT.Text = "Danh sách đơn thuốc";
            // 
            // grbInfoDonThuoc
            // 
            this.grbInfoDonThuoc.Controls.Add(this.cmbTenThuoc);
            this.grbInfoDonThuoc.Controls.Add(this.labVND);
            this.grbInfoDonThuoc.Controls.Add(this.labTienThuoc);
            this.grbInfoDonThuoc.Controls.Add(this.txtTienThuoc);
            this.grbInfoDonThuoc.Controls.Add(this.labLieuDung);
            this.grbInfoDonThuoc.Controls.Add(this.txtLieuDung);
            this.grbInfoDonThuoc.Controls.Add(this.labSoLuongThuoc);
            this.grbInfoDonThuoc.Controls.Add(this.txtSoLuongThuoc);
            this.grbInfoDonThuoc.Controls.Add(this.labTenThuoc);
            this.grbInfoDonThuoc.ForeColor = System.Drawing.Color.Red;
            this.grbInfoDonThuoc.Location = new System.Drawing.Point(30, 28);
            this.grbInfoDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Name = "grbInfoDonThuoc";
            this.grbInfoDonThuoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Size = new System.Drawing.Size(1027, 162);
            this.grbInfoDonThuoc.TabIndex = 22;
            this.grbInfoDonThuoc.TabStop = false;
            this.grbInfoDonThuoc.Text = "Thông tin đơn thuốc";
            // 
            // cmbTenThuoc
            // 
            this.cmbTenThuoc.FormattingEnabled = true;
            this.cmbTenThuoc.Location = new System.Drawing.Point(218, 49);
            this.cmbTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTenThuoc.Name = "cmbTenThuoc";
            this.cmbTenThuoc.Size = new System.Drawing.Size(219, 28);
            this.cmbTenThuoc.TabIndex = 36;
            // 
            // labVND
            // 
            this.labVND.AutoSize = true;
            this.labVND.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labVND.Location = new System.Drawing.Point(904, 108);
            this.labVND.Name = "labVND";
            this.labVND.Size = new System.Drawing.Size(53, 20);
            this.labVND.TabIndex = 35;
            this.labVND.Text = "(VNĐ)";
            // 
            // labTienThuoc
            // 
            this.labTienThuoc.AutoSize = true;
            this.labTienThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTienThuoc.Location = new System.Drawing.Point(562, 108);
            this.labTienThuoc.Name = "labTienThuoc";
            this.labTienThuoc.Size = new System.Drawing.Size(64, 20);
            this.labTienThuoc.TabIndex = 33;
            this.labTienThuoc.Text = "Giá tiền";
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.Location = new System.Drawing.Point(672, 101);
            this.txtTienThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.Size = new System.Drawing.Size(218, 26);
            this.txtTienThuoc.TabIndex = 34;
            // 
            // labLieuDung
            // 
            this.labLieuDung.AutoSize = true;
            this.labLieuDung.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labLieuDung.Location = new System.Drawing.Point(562, 50);
            this.labLieuDung.Name = "labLieuDung";
            this.labLieuDung.Size = new System.Drawing.Size(79, 20);
            this.labLieuDung.TabIndex = 31;
            this.labLieuDung.Text = "Liều dùng";
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Location = new System.Drawing.Point(672, 44);
            this.txtLieuDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(218, 26);
            this.txtLieuDung.TabIndex = 32;
            // 
            // labSoLuongThuoc
            // 
            this.labSoLuongThuoc.AutoSize = true;
            this.labSoLuongThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSoLuongThuoc.Location = new System.Drawing.Point(68, 108);
            this.labSoLuongThuoc.Name = "labSoLuongThuoc";
            this.labSoLuongThuoc.Size = new System.Drawing.Size(72, 20);
            this.labSoLuongThuoc.TabIndex = 29;
            this.labSoLuongThuoc.Text = "Số lượng";
            // 
            // txtSoLuongThuoc
            // 
            this.txtSoLuongThuoc.Location = new System.Drawing.Point(220, 101);
            this.txtSoLuongThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongThuoc.Name = "txtSoLuongThuoc";
            this.txtSoLuongThuoc.Size = new System.Drawing.Size(218, 26);
            this.txtSoLuongThuoc.TabIndex = 30;
            // 
            // labTenThuoc
            // 
            this.labTenThuoc.AutoSize = true;
            this.labTenThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenThuoc.Location = new System.Drawing.Point(68, 50);
            this.labTenThuoc.Name = "labTenThuoc";
            this.labTenThuoc.Size = new System.Drawing.Size(80, 20);
            this.labTenThuoc.TabIndex = 23;
            this.labTenThuoc.Text = "Tên thuốc";
            // 
            // btnCapNhatDonThuoc
            // 
            this.btnCapNhatDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnCapNhatDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatDonThuoc.Location = new System.Drawing.Point(743, 259);
            this.btnCapNhatDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatDonThuoc.Name = "btnCapNhatDonThuoc";
            this.btnCapNhatDonThuoc.Size = new System.Drawing.Size(114, 39);
            this.btnCapNhatDonThuoc.TabIndex = 25;
            this.btnCapNhatDonThuoc.Text = "Cập nhật";
            this.btnCapNhatDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatDonThuoc.UseVisualStyleBackColor = true;
            // 
            // btnXoaDonThuoc
            // 
            this.btnXoaDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDonThuoc.Location = new System.Drawing.Point(928, 259);
            this.btnXoaDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDonThuoc.Name = "btnXoaDonThuoc";
            this.btnXoaDonThuoc.Size = new System.Drawing.Size(96, 39);
            this.btnXoaDonThuoc.TabIndex = 24;
            this.btnXoaDonThuoc.Text = "Xóa";
            this.btnXoaDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDonThuoc.UseVisualStyleBackColor = true;
            // 
            // btnThemDonThuoc
            // 
            this.btnThemDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.plus;
            this.btnThemDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDonThuoc.Location = new System.Drawing.Point(565, 259);
            this.btnThemDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDonThuoc.Name = "btnThemDonThuoc";
            this.btnThemDonThuoc.Size = new System.Drawing.Size(99, 39);
            this.btnThemDonThuoc.TabIndex = 23;
            this.btnThemDonThuoc.Text = "Thêm";
            this.btnThemDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDonThuoc.UseVisualStyleBackColor = true;
            // 
            // DonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 854);
            this.Controls.Add(this.btnCapNhatDonThuoc);
            this.Controls.Add(this.btnXoaDonThuoc);
            this.Controls.Add(this.btnThemDonThuoc);
            this.Controls.Add(this.grbInfoDonThuoc);
            this.Controls.Add(this.labDSDT);
            this.Controls.Add(this.dgvInfoDSDonThuoc);
            this.Controls.Add(this.txtTimKiemSDTBN);
            this.Controls.Add(this.labTenBNTimKiem);
            this.Controls.Add(this.labTimKiemDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DonThuoc";
            this.Text = "DonThuoc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDSDonThuoc)).EndInit();
            this.grbInfoDonThuoc.ResumeLayout(false);
            this.grbInfoDonThuoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labTimKiemDT;
        private System.Windows.Forms.Label labTenBNTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSDTBN;
        private System.Windows.Forms.DataGridView dgvInfoDSDonThuoc;
        private System.Windows.Forms.Label labDSDT;
        private System.Windows.Forms.GroupBox grbInfoDonThuoc;
        private System.Windows.Forms.Label labTienThuoc;
        private System.Windows.Forms.TextBox txtTienThuoc;
        private System.Windows.Forms.Label labLieuDung;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.Label labSoLuongThuoc;
        private System.Windows.Forms.TextBox txtSoLuongThuoc;
        private System.Windows.Forms.Label labTenThuoc;
        private System.Windows.Forms.Label labVND;
        private System.Windows.Forms.Button btnCapNhatDonThuoc;
        private System.Windows.Forms.Button btnXoaDonThuoc;
        private System.Windows.Forms.Button btnThemDonThuoc;
        private System.Windows.Forms.ComboBox cmbTenThuoc;
    }
}