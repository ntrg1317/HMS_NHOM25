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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.richTxtLieuDung = new System.Windows.Forms.RichTextBox();
            this.richTxtLoiDan = new System.Windows.Forms.RichTextBox();
            this.cmbTenThuoc = new System.Windows.Forms.ComboBox();
            this.labLieuDung = new System.Windows.Forms.Label();
            this.labelMota = new System.Windows.Forms.Label();
            this.labSoLuongThuoc = new System.Windows.Forms.Label();
            this.txtSoLuongThuoc = new System.Windows.Forms.TextBox();
            this.labTenThuoc = new System.Windows.Forms.Label();
            this.txtTimKiemTenThuoc = new System.Windows.Forms.TextBox();
            this.labTimKiemDT = new System.Windows.Forms.Label();
            this.labTKTenThuoc = new System.Windows.Forms.Label();
            this.dgvInforDonThuoc = new System.Windows.Forms.DataGridView();
            this.labAddBS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrangThaiTT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoatAddDonThuoc = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnCapNhatCTDonThuoc = new System.Windows.Forms.Button();
            this.grbInfoDonThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoDonThuoc
            // 
            this.grbInfoDonThuoc.Controls.Add(this.btnLamMoi);
            this.grbInfoDonThuoc.Controls.Add(this.richTxtLieuDung);
            this.grbInfoDonThuoc.Controls.Add(this.richTxtLoiDan);
            this.grbInfoDonThuoc.Controls.Add(this.cmbTenThuoc);
            this.grbInfoDonThuoc.Controls.Add(this.labLieuDung);
            this.grbInfoDonThuoc.Controls.Add(this.labelMota);
            this.grbInfoDonThuoc.Controls.Add(this.labSoLuongThuoc);
            this.grbInfoDonThuoc.Controls.Add(this.txtSoLuongThuoc);
            this.grbInfoDonThuoc.Controls.Add(this.labTenThuoc);
            this.grbInfoDonThuoc.ForeColor = System.Drawing.Color.Red;
            this.grbInfoDonThuoc.Location = new System.Drawing.Point(33, 157);
            this.grbInfoDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Name = "grbInfoDonThuoc";
            this.grbInfoDonThuoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Size = new System.Drawing.Size(888, 259);
            this.grbInfoDonThuoc.TabIndex = 23;
            this.grbInfoDonThuoc.TabStop = false;
            this.grbInfoDonThuoc.Text = "Chi tiết kê thuốc ";
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
            // richTxtLieuDung
            // 
            this.richTxtLieuDung.Location = new System.Drawing.Point(610, 100);
            this.richTxtLieuDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTxtLieuDung.Name = "richTxtLieuDung";
            this.richTxtLieuDung.Size = new System.Drawing.Size(219, 60);
            this.richTxtLieuDung.TabIndex = 49;
            this.richTxtLieuDung.Text = "";
            // 
            // richTxtLoiDan
            // 
            this.richTxtLoiDan.Location = new System.Drawing.Point(187, 100);
            this.richTxtLoiDan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTxtLoiDan.Name = "richTxtLoiDan";
            this.richTxtLoiDan.Size = new System.Drawing.Size(219, 60);
            this.richTxtLoiDan.TabIndex = 48;
            this.richTxtLoiDan.Text = "";
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
            // labLieuDung
            // 
            this.labLieuDung.AutoSize = true;
            this.labLieuDung.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labLieuDung.Location = new System.Drawing.Point(498, 100);
            this.labLieuDung.Name = "labLieuDung";
            this.labLieuDung.Size = new System.Drawing.Size(79, 20);
            this.labLieuDung.TabIndex = 31;
            this.labLieuDung.Text = "Liều dùng";
            // 
            // labelMota
            // 
            this.labelMota.AutoSize = true;
            this.labelMota.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelMota.Location = new System.Drawing.Point(65, 100);
            this.labelMota.Name = "labelMota";
            this.labelMota.Size = new System.Drawing.Size(61, 20);
            this.labelMota.TabIndex = 29;
            this.labelMota.Text = "Lời dặn";
            // 
            // labSoLuongThuoc
            // 
            this.labSoLuongThuoc.AutoSize = true;
            this.labSoLuongThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSoLuongThuoc.Location = new System.Drawing.Point(498, 40);
            this.labSoLuongThuoc.Name = "labSoLuongThuoc";
            this.labSoLuongThuoc.Size = new System.Drawing.Size(72, 20);
            this.labSoLuongThuoc.TabIndex = 29;
            this.labSoLuongThuoc.Text = "Số lượng";
            // 
            // txtSoLuongThuoc
            // 
            this.txtSoLuongThuoc.Location = new System.Drawing.Point(610, 34);
            this.txtSoLuongThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongThuoc.Name = "txtSoLuongThuoc";
            this.txtSoLuongThuoc.Size = new System.Drawing.Size(219, 26);
            this.txtSoLuongThuoc.TabIndex = 30;
            this.txtSoLuongThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongThuoc_KeyPress);
            // 
            // labTenThuoc
            // 
            this.labTenThuoc.AutoSize = true;
            this.labTenThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenThuoc.Location = new System.Drawing.Point(65, 40);
            this.labTenThuoc.Name = "labTenThuoc";
            this.labTenThuoc.Size = new System.Drawing.Size(80, 20);
            this.labTenThuoc.TabIndex = 23;
            this.labTenThuoc.Text = "Tên thuốc";
            // 
            // txtTimKiemTenThuoc
            // 
            this.txtTimKiemTenThuoc.Location = new System.Drawing.Point(222, 443);
            this.txtTimKiemTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemTenThuoc.Name = "txtTimKiemTenThuoc";
            this.txtTimKiemTenThuoc.Size = new System.Drawing.Size(218, 26);
            this.txtTimKiemTenThuoc.TabIndex = 38;
            this.txtTimKiemTenThuoc.TextChanged += new System.EventHandler(this.txtTimKiemTenThuoc_TextChanged);
            // 
            // labTimKiemDT
            // 
            this.labTimKiemDT.AutoSize = true;
            this.labTimKiemDT.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemDT.Location = new System.Drawing.Point(31, 418);
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
            this.labTKTenThuoc.Size = new System.Drawing.Size(80, 20);
            this.labTKTenThuoc.TabIndex = 37;
            this.labTKTenThuoc.Text = "Tên thuốc";
            // 
            // dgvInforDonThuoc
            // 
            this.dgvInforDonThuoc.AllowUserToDeleteRows = false;
            this.dgvInforDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInforDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforDonThuoc.Location = new System.Drawing.Point(35, 494);
            this.dgvInforDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInforDonThuoc.Name = "dgvInforDonThuoc";
            this.dgvInforDonThuoc.ReadOnly = true;
            this.dgvInforDonThuoc.RowHeadersWidth = 62;
            this.dgvInforDonThuoc.RowTemplate.Height = 28;
            this.dgvInforDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInforDonThuoc.Size = new System.Drawing.Size(886, 258);
            this.dgvInforDonThuoc.TabIndex = 42;
            this.dgvInforDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInforDonThuoc_CellClick);
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(350, 9);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(253, 32);
            this.labAddBS.TabIndex = 48;
            this.labAddBS.Text = "Chi tiết đơn thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(531, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã đơn thuốc";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(643, 61);
            this.txtMaDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.ReadOnly = true;
            this.txtMaDT.Size = new System.Drawing.Size(219, 26);
            this.txtMaDT.TabIndex = 50;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(220, 61);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(219, 26);
            this.txtMaBN.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(98, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // txtTrangThaiTT
            // 
            this.txtTrangThaiTT.Location = new System.Drawing.Point(220, 108);
            this.txtTrangThaiTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrangThaiTT.Name = "txtTrangThaiTT";
            this.txtTrangThaiTT.ReadOnly = true;
            this.txtTrangThaiTT.Size = new System.Drawing.Size(218, 26);
            this.txtTrangThaiTT.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(98, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Trạng thái TT";
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
            this.btnThoatAddDonThuoc.Click += new System.EventHandler(this.btnThoatAddDonThuoc_Click);
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.Enabled = false;
            this.btnXoaThuoc.ForeColor = System.Drawing.Color.Black;
            this.btnXoaThuoc.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaThuoc.Location = new System.Drawing.Point(819, 437);
            this.btnXoaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(102, 39);
            this.btnXoaThuoc.TabIndex = 45;
            this.btnXoaThuoc.Text = "Xóa";
            this.btnXoaThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaThuoc.UseVisualStyleBackColor = true;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Enabled = false;
            this.btnThemThuoc.ForeColor = System.Drawing.Color.Black;
            this.btnThemThuoc.Image = global::HMS_NHOM25.Properties.Resources.plus;
            this.btnThemThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemThuoc.Location = new System.Drawing.Point(481, 437);
            this.btnThemThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(99, 39);
            this.btnThemThuoc.TabIndex = 44;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // btnCapNhatCTDonThuoc
            // 
            this.btnCapNhatCTDonThuoc.Enabled = false;
            this.btnCapNhatCTDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnCapNhatCTDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatCTDonThuoc.Location = new System.Drawing.Point(643, 437);
            this.btnCapNhatCTDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatCTDonThuoc.Name = "btnCapNhatCTDonThuoc";
            this.btnCapNhatCTDonThuoc.Size = new System.Drawing.Size(114, 39);
            this.btnCapNhatCTDonThuoc.TabIndex = 41;
            this.btnCapNhatCTDonThuoc.Text = "Cập nhật";
            this.btnCapNhatCTDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatCTDonThuoc.UseVisualStyleBackColor = true;
            this.btnCapNhatCTDonThuoc.Click += new System.EventHandler(this.btnCapNhatCTDonThuoc_Click);
            // 
            // ChiTietDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(955, 832);
            this.Controls.Add(this.txtTrangThaiTT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labAddBS);
            this.Controls.Add(this.btnThoatAddDonThuoc);
            this.Controls.Add(this.btnXoaThuoc);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.dgvInforDonThuoc);
            this.Controls.Add(this.labTKTenThuoc);
            this.Controls.Add(this.btnCapNhatCTDonThuoc);
            this.Controls.Add(this.grbInfoDonThuoc);
            this.Controls.Add(this.txtTimKiemTenThuoc);
            this.Controls.Add(this.labTimKiemDT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChiTietDonThuoc";
            this.Text = "ChiTietDonThuoc";
            this.Load += new System.EventHandler(this.ChiTietDonThuoc_Load);
            this.grbInfoDonThuoc.ResumeLayout(false);
            this.grbInfoDonThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfoDonThuoc;
        private System.Windows.Forms.ComboBox cmbTenThuoc;
        private System.Windows.Forms.Label labLieuDung;
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
        private System.Windows.Forms.RichTextBox richTxtLoiDan;
        private System.Windows.Forms.Label labelMota;
        private System.Windows.Forms.RichTextBox richTxtLieuDung;
        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrangThaiTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamMoi;
    }
}