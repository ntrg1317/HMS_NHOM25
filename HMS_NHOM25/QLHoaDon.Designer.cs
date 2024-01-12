namespace HMS_NHOM25
{
    partial class QLHoaDon
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
            this.dgvTimBN = new System.Windows.Forms.DataGridView();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.txtTimKiemSDTBN = new System.Windows.Forms.TextBox();
            this.labTenBNTimKiem = new System.Windows.Forms.Label();
            this.ptbYTe = new System.Windows.Forms.PictureBox();
            this.palAddBS = new System.Windows.Forms.Panel();
            this.labHoaDon = new System.Windows.Forms.Label();
            this.labVND = new System.Windows.Forms.Label();
            this.labTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.grbThanhToan = new System.Windows.Forms.GroupBox();
            this.dateNgayTT = new System.Windows.Forms.DateTimePicker();
            this.labNgayTT = new System.Windows.Forms.Label();
            this.labChiTietHD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSHoaDonBN = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaoHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).BeginInit();
            this.palAddBS.SuspendLayout();
            this.grbThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDonBN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimBN
            // 
            this.dgvTimBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimBN.Location = new System.Drawing.Point(19, 103);
            this.dgvTimBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTimBN.Name = "dgvTimBN";
            this.dgvTimBN.RowHeadersWidth = 62;
            this.dgvTimBN.RowTemplate.Height = 28;
            this.dgvTimBN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimBN.Size = new System.Drawing.Size(912, 118);
            this.dgvTimBN.TabIndex = 69;
            this.dgvTimBN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimBN_CellClick);
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.AllowUserToAddRows = false;
            this.dgvChiTietHD.AllowUserToDeleteRows = false;
            this.dgvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Location = new System.Drawing.Point(20, 483);
            this.dgvChiTietHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.ReadOnly = true;
            this.dgvChiTietHD.RowHeadersWidth = 62;
            this.dgvChiTietHD.RowTemplate.Height = 28;
            this.dgvChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHD.Size = new System.Drawing.Size(912, 141);
            this.dgvChiTietHD.TabIndex = 67;
            // 
            // txtTimKiemSDTBN
            // 
            this.txtTimKiemSDTBN.Location = new System.Drawing.Point(226, 64);
            this.txtTimKiemSDTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemSDTBN.Name = "txtTimKiemSDTBN";
            this.txtTimKiemSDTBN.Size = new System.Drawing.Size(160, 22);
            this.txtTimKiemSDTBN.TabIndex = 55;
            this.txtTimKiemSDTBN.TextChanged += new System.EventHandler(this.txtTimKiemSDTBN_TextChanged);
            this.txtTimKiemSDTBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiemSDTBN_KeyPress);
            // 
            // labTenBNTimKiem
            // 
            this.labTenBNTimKiem.AutoSize = true;
            this.labTenBNTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBNTimKiem.Location = new System.Drawing.Point(103, 69);
            this.labTenBNTimKiem.Name = "labTenBNTimKiem";
            this.labTenBNTimKiem.Size = new System.Drawing.Size(99, 16);
            this.labTenBNTimKiem.TabIndex = 54;
            this.labTenBNTimKiem.Text = "SĐT bệnh nhân";
            // 
            // ptbYTe
            // 
            this.ptbYTe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbYTe.Image = global::HMS_NHOM25.Properties.Resources.receipt;
            this.ptbYTe.Location = new System.Drawing.Point(292, 27);
            this.ptbYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbYTe.Name = "ptbYTe";
            this.ptbYTe.Size = new System.Drawing.Size(77, 33);
            this.ptbYTe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbYTe.TabIndex = 3;
            this.ptbYTe.TabStop = false;
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.labHoaDon);
            this.palAddBS.Controls.Add(this.ptbYTe);
            this.palAddBS.Location = new System.Drawing.Point(-14, -18);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(978, 64);
            this.palAddBS.TabIndex = 65;
            // 
            // labHoaDon
            // 
            this.labHoaDon.AutoSize = true;
            this.labHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHoaDon.Location = new System.Drawing.Point(375, 28);
            this.labHoaDon.Name = "labHoaDon";
            this.labHoaDon.Size = new System.Drawing.Size(249, 36);
            this.labHoaDon.TabIndex = 37;
            this.labHoaDon.Text = "Quản lý hóa đơn";
            // 
            // labVND
            // 
            this.labVND.AutoSize = true;
            this.labVND.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labVND.Location = new System.Drawing.Point(762, 23);
            this.labVND.Name = "labVND";
            this.labVND.Size = new System.Drawing.Size(43, 16);
            this.labVND.TabIndex = 35;
            this.labVND.Text = "(VNĐ)";
            // 
            // labTongTien
            // 
            this.labTongTien.AutoSize = true;
            this.labTongTien.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTongTien.Location = new System.Drawing.Point(532, 26);
            this.labTongTien.Name = "labTongTien";
            this.labTongTien.Size = new System.Drawing.Size(63, 16);
            this.labTongTien.TabIndex = 33;
            this.labTongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(612, 21);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(149, 22);
            this.txtTongTien.TabIndex = 34;
            // 
            // grbThanhToan
            // 
            this.grbThanhToan.Controls.Add(this.labVND);
            this.grbThanhToan.Controls.Add(this.labTongTien);
            this.grbThanhToan.Controls.Add(this.txtTongTien);
            this.grbThanhToan.Controls.Add(this.dateNgayTT);
            this.grbThanhToan.Controls.Add(this.labNgayTT);
            this.grbThanhToan.ForeColor = System.Drawing.Color.Red;
            this.grbThanhToan.Location = new System.Drawing.Point(19, 393);
            this.grbThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThanhToan.Name = "grbThanhToan";
            this.grbThanhToan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThanhToan.Size = new System.Drawing.Size(912, 55);
            this.grbThanhToan.TabIndex = 61;
            this.grbThanhToan.TabStop = false;
            this.grbThanhToan.Text = "Thông tin hóa đơn";
            // 
            // dateNgayTT
            // 
            this.dateNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTT.Location = new System.Drawing.Point(242, 21);
            this.dateNgayTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayTT.Name = "dateNgayTT";
            this.dateNgayTT.Size = new System.Drawing.Size(146, 22);
            this.dateNgayTT.TabIndex = 36;
            // 
            // labNgayTT
            // 
            this.labNgayTT.AutoSize = true;
            this.labNgayTT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgayTT.Location = new System.Drawing.Point(101, 26);
            this.labNgayTT.Name = "labNgayTT";
            this.labNgayTT.Size = new System.Drawing.Size(104, 16);
            this.labNgayTT.TabIndex = 29;
            this.labNgayTT.Text = "Ngày thanh toán";
            // 
            // labChiTietHD
            // 
            this.labChiTietHD.AutoSize = true;
            this.labChiTietHD.ForeColor = System.Drawing.Color.Red;
            this.labChiTietHD.Location = new System.Drawing.Point(17, 458);
            this.labChiTietHD.Name = "labChiTietHD";
            this.labChiTietHD.Size = new System.Drawing.Size(98, 16);
            this.labChiTietHD.TabIndex = 68;
            this.labChiTietHD.Text = "Chi tiết hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(455, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã BN";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(534, 64);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(149, 22);
            this.txtMaBN.TabIndex = 57;
            this.txtMaBN.TextChanged += new System.EventHandler(this.txtMaBN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tìm kiếm";
            // 
            // dgvDSHoaDonBN
            // 
            this.dgvDSHoaDonBN.AllowUserToAddRows = false;
            this.dgvDSHoaDonBN.AllowUserToDeleteRows = false;
            this.dgvDSHoaDonBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoaDonBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDonBN.Location = new System.Drawing.Point(20, 258);
            this.dgvDSHoaDonBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSHoaDonBN.Name = "dgvDSHoaDonBN";
            this.dgvDSHoaDonBN.ReadOnly = true;
            this.dgvDSHoaDonBN.RowHeadersWidth = 62;
            this.dgvDSHoaDonBN.RowTemplate.Height = 28;
            this.dgvDSHoaDonBN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHoaDonBN.Size = new System.Drawing.Size(912, 122);
            this.dgvDSHoaDonBN.TabIndex = 71;
            this.dgvDSHoaDonBN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHoaDonBN_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(17, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Danh sách hóa đơn của bệnh nhân";
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Image = global::HMS_NHOM25.Properties.Resources.plus;
            this.btnTaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHD.Location = new System.Drawing.Point(766, 59);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(126, 31);
            this.btnTaoHD.TabIndex = 73;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(950, 630);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.dgvDSHoaDonBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTimBN);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.dgvChiTietHD);
            this.Controls.Add(this.txtTimKiemSDTBN);
            this.Controls.Add(this.labTenBNTimKiem);
            this.Controls.Add(this.palAddBS);
            this.Controls.Add(this.grbThanhToan);
            this.Controls.Add(this.labChiTietHD);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLHoaDon";
            this.Text = "QLHoaDon";
            this.Load += new System.EventHandler(this.QLHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).EndInit();
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            this.grbThanhToan.ResumeLayout(false);
            this.grbThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDonBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimBN;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.TextBox txtTimKiemSDTBN;
        private System.Windows.Forms.Label labTenBNTimKiem;
        private System.Windows.Forms.PictureBox ptbYTe;
        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.Label labHoaDon;
        private System.Windows.Forms.Label labVND;
        private System.Windows.Forms.Label labTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.GroupBox grbThanhToan;
        private System.Windows.Forms.DateTimePicker dateNgayTT;
        private System.Windows.Forms.Label labNgayTT;
        private System.Windows.Forms.Label labChiTietHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSHoaDonBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaoHD;
    }
}