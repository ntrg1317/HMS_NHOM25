namespace HMS_NHOM25
{
    partial class DSHoaDon
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
            this.grbInfoHoaDon = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labVND = new System.Windows.Forms.Label();
            this.labTienThuoc = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.labSoLuongThuoc = new System.Windows.Forms.Label();
            this.labDSDT = new System.Windows.Forms.Label();
            this.dgvInfoDSHoaDon = new System.Windows.Forms.DataGridView();
            this.txtTimKiemSDTBN = new System.Windows.Forms.TextBox();
            this.labTenBNTimKiem = new System.Windows.Forms.Label();
            this.labTimKiemDT = new System.Windows.Forms.Label();
            this.btnCapNhatDonThuoc = new System.Windows.Forms.Button();
            this.btnXoaDonThuoc = new System.Windows.Forms.Button();
            this.btnThemDonThuoc = new System.Windows.Forms.Button();
            this.btnTimKiemSDTBN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbInfoHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoHoaDon
            // 
            this.grbInfoHoaDon.Controls.Add(this.dateTimePicker1);
            this.grbInfoHoaDon.Controls.Add(this.labVND);
            this.grbInfoHoaDon.Controls.Add(this.labTienThuoc);
            this.grbInfoHoaDon.Controls.Add(this.txtTongTien);
            this.grbInfoHoaDon.Controls.Add(this.labSoLuongThuoc);
            this.grbInfoHoaDon.ForeColor = System.Drawing.Color.Red;
            this.grbInfoHoaDon.Location = new System.Drawing.Point(23, 21);
            this.grbInfoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoHoaDon.Name = "grbInfoHoaDon";
            this.grbInfoHoaDon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoHoaDon.Size = new System.Drawing.Size(922, 81);
            this.grbInfoHoaDon.TabIndex = 32;
            this.grbInfoHoaDon.TabStop = false;
            this.grbInfoHoaDon.Text = "Thông tin hóa đơn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 22);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // labVND
            // 
            this.labVND.AutoSize = true;
            this.labVND.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labVND.Location = new System.Drawing.Point(806, 38);
            this.labVND.Name = "labVND";
            this.labVND.Size = new System.Drawing.Size(43, 16);
            this.labVND.TabIndex = 35;
            this.labVND.Text = "(VNĐ)";
            // 
            // labTienThuoc
            // 
            this.labTienThuoc.AutoSize = true;
            this.labTienThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTienThuoc.Location = new System.Drawing.Point(544, 41);
            this.labTienThuoc.Name = "labTienThuoc";
            this.labTienThuoc.Size = new System.Drawing.Size(63, 16);
            this.labTienThuoc.TabIndex = 33;
            this.labTienThuoc.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(633, 36);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(149, 22);
            this.txtTongTien.TabIndex = 34;
            // 
            // labSoLuongThuoc
            // 
            this.labSoLuongThuoc.AutoSize = true;
            this.labSoLuongThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSoLuongThuoc.Location = new System.Drawing.Point(42, 41);
            this.labSoLuongThuoc.Name = "labSoLuongThuoc";
            this.labSoLuongThuoc.Size = new System.Drawing.Size(104, 16);
            this.labSoLuongThuoc.TabIndex = 29;
            this.labSoLuongThuoc.Text = "Ngày thanh toán";
            // 
            // labDSDT
            // 
            this.labDSDT.AutoSize = true;
            this.labDSDT.ForeColor = System.Drawing.Color.Red;
            this.labDSDT.Location = new System.Drawing.Point(20, 194);
            this.labDSDT.Name = "labDSDT";
            this.labDSDT.Size = new System.Drawing.Size(123, 16);
            this.labDSDT.TabIndex = 31;
            this.labDSDT.Text = "Danh sách hóa đơn";
            // 
            // dgvInfoDSHoaDon
            // 
            this.dgvInfoDSHoaDon.AllowUserToAddRows = false;
            this.dgvInfoDSHoaDon.AllowUserToDeleteRows = false;
            this.dgvInfoDSHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoDSHoaDon.Location = new System.Drawing.Point(23, 233);
            this.dgvInfoDSHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoDSHoaDon.Name = "dgvInfoDSHoaDon";
            this.dgvInfoDSHoaDon.ReadOnly = true;
            this.dgvInfoDSHoaDon.RowHeadersWidth = 62;
            this.dgvInfoDSHoaDon.RowTemplate.Height = 28;
            this.dgvInfoDSHoaDon.Size = new System.Drawing.Size(922, 427);
            this.dgvInfoDSHoaDon.TabIndex = 30;
            // 
            // txtTimKiemSDTBN
            // 
            this.txtTimKiemSDTBN.Location = new System.Drawing.Point(187, 150);
            this.txtTimKiemSDTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemSDTBN.Name = "txtTimKiemSDTBN";
            this.txtTimKiemSDTBN.Size = new System.Drawing.Size(146, 22);
            this.txtTimKiemSDTBN.TabIndex = 27;
            // 
            // labTenBNTimKiem
            // 
            this.labTenBNTimKiem.AutoSize = true;
            this.labTenBNTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBNTimKiem.Location = new System.Drawing.Point(65, 154);
            this.labTenBNTimKiem.Name = "labTenBNTimKiem";
            this.labTenBNTimKiem.Size = new System.Drawing.Size(99, 16);
            this.labTenBNTimKiem.TabIndex = 28;
            this.labTenBNTimKiem.Text = "SĐT bệnh nhân";
            // 
            // labTimKiemDT
            // 
            this.labTimKiemDT.AutoSize = true;
            this.labTimKiemDT.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemDT.Location = new System.Drawing.Point(-95, 86);
            this.labTimKiemDT.Name = "labTimKiemDT";
            this.labTimKiemDT.Size = new System.Drawing.Size(62, 16);
            this.labTimKiemDT.TabIndex = 26;
            this.labTimKiemDT.Text = "Tìm kiếm";
            // 
            // btnCapNhatDonThuoc
            // 
            this.btnCapNhatDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnCapNhatDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatDonThuoc.Location = new System.Drawing.Point(704, 145);
            this.btnCapNhatDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatDonThuoc.Name = "btnCapNhatDonThuoc";
            this.btnCapNhatDonThuoc.Size = new System.Drawing.Size(101, 31);
            this.btnCapNhatDonThuoc.TabIndex = 35;
            this.btnCapNhatDonThuoc.Text = "Cập nhật";
            this.btnCapNhatDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatDonThuoc.UseVisualStyleBackColor = true;
            // 
            // btnXoaDonThuoc
            // 
            this.btnXoaDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDonThuoc.Location = new System.Drawing.Point(860, 145);
            this.btnXoaDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDonThuoc.Name = "btnXoaDonThuoc";
            this.btnXoaDonThuoc.Size = new System.Drawing.Size(85, 31);
            this.btnXoaDonThuoc.TabIndex = 34;
            this.btnXoaDonThuoc.Text = "Xóa";
            this.btnXoaDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDonThuoc.UseVisualStyleBackColor = true;
            // 
            // btnThemDonThuoc
            // 
            this.btnThemDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.plus;
            this.btnThemDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDonThuoc.Location = new System.Drawing.Point(559, 145);
            this.btnThemDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDonThuoc.Name = "btnThemDonThuoc";
            this.btnThemDonThuoc.Size = new System.Drawing.Size(88, 31);
            this.btnThemDonThuoc.TabIndex = 33;
            this.btnThemDonThuoc.Text = "Thêm";
            this.btnThemDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDonThuoc.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemSDTBN
            // 
            this.btnTimKiemSDTBN.Image = global::HMS_NHOM25.Properties.Resources.find__1_;
            this.btnTimKiemSDTBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemSDTBN.Location = new System.Drawing.Point(400, 147);
            this.btnTimKiemSDTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemSDTBN.Name = "btnTimKiemSDTBN";
            this.btnTimKiemSDTBN.Size = new System.Drawing.Size(97, 31);
            this.btnTimKiemSDTBN.TabIndex = 29;
            this.btnTimKiemSDTBN.Text = "Tìm kiếm";
            this.btnTimKiemSDTBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemSDTBN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tìm kiếm";
            // 
            // DSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapNhatDonThuoc);
            this.Controls.Add(this.btnXoaDonThuoc);
            this.Controls.Add(this.btnThemDonThuoc);
            this.Controls.Add(this.grbInfoHoaDon);
            this.Controls.Add(this.labDSDT);
            this.Controls.Add(this.dgvInfoDSHoaDon);
            this.Controls.Add(this.btnTimKiemSDTBN);
            this.Controls.Add(this.txtTimKiemSDTBN);
            this.Controls.Add(this.labTenBNTimKiem);
            this.Controls.Add(this.labTimKiemDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DSHoaDon";
            this.Text = "DSHoaDon";
            this.Load += new System.EventHandler(this.DSHoaDon_Load);
            this.grbInfoHoaDon.ResumeLayout(false);
            this.grbInfoHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhatDonThuoc;
        private System.Windows.Forms.Button btnXoaDonThuoc;
        private System.Windows.Forms.Button btnThemDonThuoc;
        private System.Windows.Forms.GroupBox grbInfoHoaDon;
        private System.Windows.Forms.Label labVND;
        private System.Windows.Forms.Label labTienThuoc;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label labSoLuongThuoc;
        private System.Windows.Forms.Label labDSDT;
        private System.Windows.Forms.DataGridView dgvInfoDSHoaDon;
        private System.Windows.Forms.Button btnTimKiemSDTBN;
        private System.Windows.Forms.TextBox txtTimKiemSDTBN;
        private System.Windows.Forms.Label labTenBNTimKiem;
        private System.Windows.Forms.Label labTimKiemDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}