namespace HMS_NHOM25
{
    partial class ChiTietDonThuoc
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
            this.cmbTenThuoc = new System.Windows.Forms.ComboBox();
            this.labVND = new System.Windows.Forms.Label();
            this.labTienThuoc = new System.Windows.Forms.Label();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.labLieuDung = new System.Windows.Forms.Label();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.labSoLuongThuoc = new System.Windows.Forms.Label();
            this.txtSoLuongThuoc = new System.Windows.Forms.TextBox();
            this.labTenThuoc = new System.Windows.Forms.Label();
            this.txtTimKiemTenThuoc = new System.Windows.Forms.TextBox();
            this.labTimKiemDT = new System.Windows.Forms.Label();
            this.labTKTenThuoc = new System.Windows.Forms.Label();
            this.dgvInforDonThuoc = new System.Windows.Forms.DataGridView();
            this.btnCapNhatCTDonThuoc = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnThoatAddDonThuoc = new System.Windows.Forms.Button();
            this.btnSaveInfoDonThuoc = new System.Windows.Forms.Button();
            this.grbInfoDonThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDonThuoc)).BeginInit();
            this.SuspendLayout();
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
            this.grbInfoDonThuoc.Location = new System.Drawing.Point(35, 24);
            this.grbInfoDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Name = "grbInfoDonThuoc";
            this.grbInfoDonThuoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Size = new System.Drawing.Size(887, 134);
            this.grbInfoDonThuoc.TabIndex = 23;
            this.grbInfoDonThuoc.TabStop = false;
            this.grbInfoDonThuoc.Text = "Chi tiết kê thuốc ";
            // 
            // cmbTenThuoc
            // 
            this.cmbTenThuoc.FormattingEnabled = true;
            this.cmbTenThuoc.Location = new System.Drawing.Point(187, 32);
            this.cmbTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTenThuoc.Name = "cmbTenThuoc";
            this.cmbTenThuoc.Size = new System.Drawing.Size(219, 28);
            this.cmbTenThuoc.TabIndex = 36;
            // 
            // labVND
            // 
            this.labVND.AutoSize = true;
            this.labVND.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labVND.Location = new System.Drawing.Point(803, 37);
            this.labVND.Name = "labVND";
            this.labVND.Size = new System.Drawing.Size(53, 20);
            this.labVND.TabIndex = 35;
            this.labVND.Text = "(VNĐ)";
            // 
            // labTienThuoc
            // 
            this.labTienThuoc.AutoSize = true;
            this.labTienThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTienThuoc.Location = new System.Drawing.Point(461, 37);
            this.labTienThuoc.Name = "labTienThuoc";
            this.labTienThuoc.Size = new System.Drawing.Size(64, 20);
            this.labTienThuoc.TabIndex = 33;
            this.labTienThuoc.Text = "Giá tiền";
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.Location = new System.Drawing.Point(571, 30);
            this.txtTienThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.Size = new System.Drawing.Size(218, 26);
            this.txtTienThuoc.TabIndex = 34;
            // 
            // labLieuDung
            // 
            this.labLieuDung.AutoSize = true;
            this.labLieuDung.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labLieuDung.Location = new System.Drawing.Point(461, 87);
            this.labLieuDung.Name = "labLieuDung";
            this.labLieuDung.Size = new System.Drawing.Size(79, 20);
            this.labLieuDung.TabIndex = 31;
            this.labLieuDung.Text = "Liều dùng";
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Location = new System.Drawing.Point(571, 81);
            this.txtLieuDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(218, 26);
            this.txtLieuDung.TabIndex = 32;
            // 
            // labSoLuongThuoc
            // 
            this.labSoLuongThuoc.AutoSize = true;
            this.labSoLuongThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSoLuongThuoc.Location = new System.Drawing.Point(37, 87);
            this.labSoLuongThuoc.Name = "labSoLuongThuoc";
            this.labSoLuongThuoc.Size = new System.Drawing.Size(72, 20);
            this.labSoLuongThuoc.TabIndex = 29;
            this.labSoLuongThuoc.Text = "Số lượng";
            // 
            // txtSoLuongThuoc
            // 
            this.txtSoLuongThuoc.Location = new System.Drawing.Point(187, 80);
            this.txtSoLuongThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongThuoc.Name = "txtSoLuongThuoc";
            this.txtSoLuongThuoc.Size = new System.Drawing.Size(219, 26);
            this.txtSoLuongThuoc.TabIndex = 30;
            // 
            // labTenThuoc
            // 
            this.labTenThuoc.AutoSize = true;
            this.labTenThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenThuoc.Location = new System.Drawing.Point(37, 33);
            this.labTenThuoc.Name = "labTenThuoc";
            this.labTenThuoc.Size = new System.Drawing.Size(80, 20);
            this.labTenThuoc.TabIndex = 23;
            this.labTenThuoc.Text = "Tên thuốc";
            // 
            // txtTimKiemTenThuoc
            // 
            this.txtTimKiemTenThuoc.Location = new System.Drawing.Point(222, 208);
            this.txtTimKiemTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemTenThuoc.Name = "txtTimKiemTenThuoc";
            this.txtTimKiemTenThuoc.Size = new System.Drawing.Size(218, 26);
            this.txtTimKiemTenThuoc.TabIndex = 38;
            // 
            // labTimKiemDT
            // 
            this.labTimKiemDT.AutoSize = true;
            this.labTimKiemDT.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemDT.Location = new System.Drawing.Point(47, 178);
            this.labTimKiemDT.Name = "labTimKiemDT";
            this.labTimKiemDT.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemDT.TabIndex = 37;
            this.labTimKiemDT.Text = "Tìm kiếm";
            // 
            // labTKTenThuoc
            // 
            this.labTKTenThuoc.AutoSize = true;
            this.labTKTenThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTKTenThuoc.Location = new System.Drawing.Point(70, 214);
            this.labTKTenThuoc.Name = "labTKTenThuoc";
            this.labTKTenThuoc.Size = new System.Drawing.Size(80, 20);
            this.labTKTenThuoc.TabIndex = 37;
            this.labTKTenThuoc.Text = "Tên thuốc";
            // 
            // dgvInforDonThuoc
            // 
            this.dgvInforDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforDonThuoc.Location = new System.Drawing.Point(35, 269);
            this.dgvInforDonThuoc.Name = "dgvInforDonThuoc";
            this.dgvInforDonThuoc.RowHeadersWidth = 62;
            this.dgvInforDonThuoc.RowTemplate.Height = 28;
            this.dgvInforDonThuoc.Size = new System.Drawing.Size(887, 257);
            this.dgvInforDonThuoc.TabIndex = 42;
            // 
            // btnCapNhatCTDonThuoc
            // 
            this.btnCapNhatCTDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnCapNhatCTDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatCTDonThuoc.Location = new System.Drawing.Point(654, 195);
            this.btnCapNhatCTDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatCTDonThuoc.Name = "btnCapNhatCTDonThuoc";
            this.btnCapNhatCTDonThuoc.Size = new System.Drawing.Size(114, 39);
            this.btnCapNhatCTDonThuoc.TabIndex = 41;
            this.btnCapNhatCTDonThuoc.Text = "Cập nhật";
            this.btnCapNhatCTDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatCTDonThuoc.UseVisualStyleBackColor = true;
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.ForeColor = System.Drawing.Color.Black;
            this.btnXoaThuoc.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaThuoc.Location = new System.Drawing.Point(820, 195);
            this.btnXoaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(102, 39);
            this.btnXoaThuoc.TabIndex = 45;
            this.btnXoaThuoc.Text = "Xóa";
            this.btnXoaThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaThuoc.UseVisualStyleBackColor = true;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.ForeColor = System.Drawing.Color.Black;
            this.btnThemThuoc.Image = global::HMS_NHOM25.Properties.Resources.plus;
            this.btnThemThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemThuoc.Location = new System.Drawing.Point(492, 195);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(99, 39);
            this.btnThemThuoc.TabIndex = 44;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            // 
            // btnThoatAddDonThuoc
            // 
            this.btnThoatAddDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.cancel;
            this.btnThoatAddDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddDonThuoc.Location = new System.Drawing.Point(578, 549);
            this.btnThoatAddDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddDonThuoc.Name = "btnThoatAddDonThuoc";
            this.btnThoatAddDonThuoc.Size = new System.Drawing.Size(141, 39);
            this.btnThoatAddDonThuoc.TabIndex = 47;
            this.btnThoatAddDonThuoc.Text = "Thoát";
            this.btnThoatAddDonThuoc.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfoDonThuoc
            // 
            this.btnSaveInfoDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveInfoDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInfoDonThuoc.Location = new System.Drawing.Point(244, 549);
            this.btnSaveInfoDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfoDonThuoc.Name = "btnSaveInfoDonThuoc";
            this.btnSaveInfoDonThuoc.Size = new System.Drawing.Size(154, 39);
            this.btnSaveInfoDonThuoc.TabIndex = 46;
            this.btnSaveInfoDonThuoc.Text = "Lưu thông tin";
            this.btnSaveInfoDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInfoDonThuoc.UseVisualStyleBackColor = true;
            // 
            // ChiTietDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 611);
            this.Controls.Add(this.btnThoatAddDonThuoc);
            this.Controls.Add(this.btnSaveInfoDonThuoc);
            this.Controls.Add(this.btnXoaThuoc);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.dgvInforDonThuoc);
            this.Controls.Add(this.labTKTenThuoc);
            this.Controls.Add(this.btnCapNhatCTDonThuoc);
            this.Controls.Add(this.grbInfoDonThuoc);
            this.Controls.Add(this.txtTimKiemTenThuoc);
            this.Controls.Add(this.labTimKiemDT);
            this.Name = "ChiTietDonThuoc";
            this.Text = "ChiTietDonThuoc";
            this.grbInfoDonThuoc.ResumeLayout(false);
            this.grbInfoDonThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfoDonThuoc;
        private System.Windows.Forms.ComboBox cmbTenThuoc;
        private System.Windows.Forms.Label labVND;
        private System.Windows.Forms.Label labTienThuoc;
        private System.Windows.Forms.TextBox txtTienThuoc;
        private System.Windows.Forms.Label labLieuDung;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.Label labSoLuongThuoc;
        private System.Windows.Forms.TextBox txtSoLuongThuoc;
        private System.Windows.Forms.Label labTenThuoc;
        private System.Windows.Forms.Button btnCapNhatCTDonThuoc;
        private System.Windows.Forms.TextBox txtTimKiemTenThuoc;
        private System.Windows.Forms.Label labTimKiemDT;
        private System.Windows.Forms.Label labTKTenThuoc;
        private System.Windows.Forms.DataGridView dgvInforDonThuoc;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Button btnThoatAddDonThuoc;
        private System.Windows.Forms.Button btnSaveInfoDonThuoc;
    }
}