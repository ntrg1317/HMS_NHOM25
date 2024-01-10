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
            this.labDSDT = new System.Windows.Forms.Label();
            this.grbInfoDonThuoc = new System.Windows.Forms.GroupBox();
            this.dateNgayKeDon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrangThaiTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labMaDT = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.labMaBN = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.btnChiTietDonThuoc = new System.Windows.Forms.Button();
            this.btnXoaDonThuoc = new System.Windows.Forms.Button();
            this.btnThemDonThuoc = new System.Windows.Forms.Button();
            this.dgvDSDonThuoc = new System.Windows.Forms.DataGridView();
            this.labAddBS = new System.Windows.Forms.Label();
            this.grbInfoDonThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // labTimKiemDT
            // 
            this.labTimKiemDT.AutoSize = true;
            this.labTimKiemDT.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemDT.Location = new System.Drawing.Point(35, 258);
            this.labTimKiemDT.Name = "labTimKiemDT";
            this.labTimKiemDT.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemDT.TabIndex = 1;
            this.labTimKiemDT.Text = "Tìm kiếm";
            // 
            // labTenBNTimKiem
            // 
            this.labTenBNTimKiem.AutoSize = true;
            this.labTenBNTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBNTimKiem.Location = new System.Drawing.Point(100, 306);
            this.labTenBNTimKiem.Name = "labTenBNTimKiem";
            this.labTenBNTimKiem.Size = new System.Drawing.Size(121, 20);
            this.labTenBNTimKiem.TabIndex = 18;
            this.labTenBNTimKiem.Text = "SĐT bệnh nhân";
            // 
            // txtTimKiemSDTBN
            // 
            this.txtTimKiemSDTBN.Location = new System.Drawing.Point(252, 302);
            this.txtTimKiemSDTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemSDTBN.Name = "txtTimKiemSDTBN";
            this.txtTimKiemSDTBN.Size = new System.Drawing.Size(218, 26);
            this.txtTimKiemSDTBN.TabIndex = 18;
            this.txtTimKiemSDTBN.TextChanged += new System.EventHandler(this.txtTimKiemSDTBN_TextChanged);
            this.txtTimKiemSDTBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiemSDTBN_KeyPress);
            // 
            // labDSDT
            // 
            this.labDSDT.AutoSize = true;
            this.labDSDT.ForeColor = System.Drawing.Color.Red;
            this.labDSDT.Location = new System.Drawing.Point(35, 369);
            this.labDSDT.Name = "labDSDT";
            this.labDSDT.Size = new System.Drawing.Size(161, 20);
            this.labDSDT.TabIndex = 21;
            this.labDSDT.Text = "Danh sách đơn thuốc";
            // 
            // grbInfoDonThuoc
            // 
            this.grbInfoDonThuoc.Controls.Add(this.dateNgayKeDon);
            this.grbInfoDonThuoc.Controls.Add(this.label2);
            this.grbInfoDonThuoc.Controls.Add(this.txtTrangThaiTT);
            this.grbInfoDonThuoc.Controls.Add(this.label1);
            this.grbInfoDonThuoc.Controls.Add(this.labMaDT);
            this.grbInfoDonThuoc.Controls.Add(this.txtMaDT);
            this.grbInfoDonThuoc.Controls.Add(this.labMaBN);
            this.grbInfoDonThuoc.Controls.Add(this.txtMaBN);
            this.grbInfoDonThuoc.ForeColor = System.Drawing.Color.Red;
            this.grbInfoDonThuoc.Location = new System.Drawing.Point(28, 88);
            this.grbInfoDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Name = "grbInfoDonThuoc";
            this.grbInfoDonThuoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Size = new System.Drawing.Size(1027, 150);
            this.grbInfoDonThuoc.TabIndex = 22;
            this.grbInfoDonThuoc.TabStop = false;
            this.grbInfoDonThuoc.Text = "Thông tin đơn thuốc";
            // 
            // dateNgayKeDon
            // 
            this.dateNgayKeDon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayKeDon.Location = new System.Drawing.Point(716, 102);
            this.dateNgayKeDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayKeDon.Name = "dateNgayKeDon";
            this.dateNgayKeDon.Size = new System.Drawing.Size(216, 26);
            this.dateNgayKeDon.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(544, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ngày kê đơn";
            // 
            // txtTrangThaiTT
            // 
            this.txtTrangThaiTT.Location = new System.Drawing.Point(224, 100);
            this.txtTrangThaiTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrangThaiTT.Name = "txtTrangThaiTT";
            this.txtTrangThaiTT.ReadOnly = true;
            this.txtTrangThaiTT.Size = new System.Drawing.Size(218, 26);
            this.txtTrangThaiTT.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(72, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Trạng thái TT";
            // 
            // labMaDT
            // 
            this.labMaDT.AutoSize = true;
            this.labMaDT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaDT.Location = new System.Drawing.Point(544, 52);
            this.labMaDT.Name = "labMaDT";
            this.labMaDT.Size = new System.Drawing.Size(106, 20);
            this.labMaDT.TabIndex = 31;
            this.labMaDT.Text = "Mã đơn thuốc";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(714, 48);
            this.txtMaDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.ReadOnly = true;
            this.txtMaDT.Size = new System.Drawing.Size(218, 26);
            this.txtMaDT.TabIndex = 32;
            // 
            // labMaBN
            // 
            this.labMaBN.AutoSize = true;
            this.labMaBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBN.Location = new System.Drawing.Point(70, 58);
            this.labMaBN.Name = "labMaBN";
            this.labMaBN.Size = new System.Drawing.Size(111, 20);
            this.labMaBN.TabIndex = 29;
            this.labMaBN.Text = "Mã bệnh nhân";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(222, 50);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(218, 26);
            this.txtMaBN.TabIndex = 30;
            // 
            // btnChiTietDonThuoc
            // 
            this.btnChiTietDonThuoc.Enabled = false;
            this.btnChiTietDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.pills;
            this.btnChiTietDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietDonThuoc.Location = new System.Drawing.Point(742, 295);
            this.btnChiTietDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChiTietDonThuoc.Name = "btnChiTietDonThuoc";
            this.btnChiTietDonThuoc.Size = new System.Drawing.Size(108, 39);
            this.btnChiTietDonThuoc.TabIndex = 25;
            this.btnChiTietDonThuoc.Text = "Chi tiết";
            this.btnChiTietDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChiTietDonThuoc.UseVisualStyleBackColor = true;
            this.btnChiTietDonThuoc.Click += new System.EventHandler(this.btnCapNhatDonThuoc_Click);
            // 
            // btnXoaDonThuoc
            // 
            this.btnXoaDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDonThuoc.Location = new System.Drawing.Point(928, 295);
            this.btnXoaDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDonThuoc.Name = "btnXoaDonThuoc";
            this.btnXoaDonThuoc.Size = new System.Drawing.Size(96, 39);
            this.btnXoaDonThuoc.TabIndex = 24;
            this.btnXoaDonThuoc.Text = "Xóa";
            this.btnXoaDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDonThuoc.UseVisualStyleBackColor = true;
            this.btnXoaDonThuoc.Click += new System.EventHandler(this.btnXoaDonThuoc_Click);
            // 
            // btnThemDonThuoc
            // 
            this.btnThemDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.plus;
            this.btnThemDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDonThuoc.Location = new System.Drawing.Point(565, 295);
            this.btnThemDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDonThuoc.Name = "btnThemDonThuoc";
            this.btnThemDonThuoc.Size = new System.Drawing.Size(99, 39);
            this.btnThemDonThuoc.TabIndex = 23;
            this.btnThemDonThuoc.Text = "Thêm";
            this.btnThemDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDonThuoc.UseVisualStyleBackColor = true;
            this.btnThemDonThuoc.Click += new System.EventHandler(this.btnThemDonThuoc_Click);
            // 
            // dgvDSDonThuoc
            // 
            this.dgvDSDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDonThuoc.Location = new System.Drawing.Point(28, 408);
            this.dgvDSDonThuoc.Name = "dgvDSDonThuoc";
            this.dgvDSDonThuoc.RowHeadersWidth = 62;
            this.dgvDSDonThuoc.RowTemplate.Height = 28;
            this.dgvDSDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDonThuoc.Size = new System.Drawing.Size(1027, 479);
            this.dgvDSDonThuoc.TabIndex = 26;
            this.dgvDSDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDonThuoc_CellClick);
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(378, 29);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(300, 32);
            this.labAddBS.TabIndex = 27;
            this.labAddBS.Text = "Danh sách đơn thuốc";
            // 
            // DonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 930);
            this.Controls.Add(this.labAddBS);
            this.Controls.Add(this.dgvDSDonThuoc);
            this.Controls.Add(this.btnChiTietDonThuoc);
            this.Controls.Add(this.btnXoaDonThuoc);
            this.Controls.Add(this.btnThemDonThuoc);
            this.Controls.Add(this.grbInfoDonThuoc);
            this.Controls.Add(this.labDSDT);
            this.Controls.Add(this.txtTimKiemSDTBN);
            this.Controls.Add(this.labTenBNTimKiem);
            this.Controls.Add(this.labTimKiemDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DonThuoc";
            this.Text = "DonThuoc";
            this.Load += new System.EventHandler(this.DonThuoc_Load);
            this.grbInfoDonThuoc.ResumeLayout(false);
            this.grbInfoDonThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labTimKiemDT;
        private System.Windows.Forms.Label labTenBNTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSDTBN;
        private System.Windows.Forms.Label labDSDT;
        private System.Windows.Forms.GroupBox grbInfoDonThuoc;
        private System.Windows.Forms.Label labMaDT;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label labMaBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Button btnChiTietDonThuoc;
        private System.Windows.Forms.Button btnXoaDonThuoc;
        private System.Windows.Forms.Button btnThemDonThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrangThaiTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgayKeDon;
        private System.Windows.Forms.DataGridView dgvDSDonThuoc;
        private System.Windows.Forms.Label labAddBS;
    }
}