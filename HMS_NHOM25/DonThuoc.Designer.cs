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
            this.txtTrangThaiTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labMaDT = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.labMaBN = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.btnCapNhatDonThuoc = new System.Windows.Forms.Button();
            this.btnXoaDonThuoc = new System.Windows.Forms.Button();
            this.btnThemDonThuoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateNgayKeDon = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDSDonThuoc)).BeginInit();
            this.grbInfoDonThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTimKiemDT
            // 
            this.labTimKiemDT.AutoSize = true;
            this.labTimKiemDT.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemDT.Location = new System.Drawing.Point(35, 204);
            this.labTimKiemDT.Name = "labTimKiemDT";
            this.labTimKiemDT.Size = new System.Drawing.Size(71, 20);
            this.labTimKiemDT.TabIndex = 1;
            this.labTimKiemDT.Text = "Tìm kiếm";
            // 
            // labTenBNTimKiem
            // 
            this.labTenBNTimKiem.AutoSize = true;
            this.labTenBNTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBNTimKiem.Location = new System.Drawing.Point(100, 253);
            this.labTenBNTimKiem.Name = "labTenBNTimKiem";
            this.labTenBNTimKiem.Size = new System.Drawing.Size(121, 20);
            this.labTenBNTimKiem.TabIndex = 18;
            this.labTenBNTimKiem.Text = "SĐT bệnh nhân";
            // 
            // txtTimKiemSDTBN
            // 
            this.txtTimKiemSDTBN.Location = new System.Drawing.Point(252, 247);
            this.txtTimKiemSDTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemSDTBN.Name = "txtTimKiemSDTBN";
            this.txtTimKiemSDTBN.Size = new System.Drawing.Size(218, 26);
            this.txtTimKiemSDTBN.TabIndex = 18;
            this.txtTimKiemSDTBN.TextChanged += new System.EventHandler(this.txtTimKiemSDTBN_TextChanged);
            this.txtTimKiemSDTBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiemSDTBN_KeyPress);
            // 
            // dgvInfoDSDonThuoc
            // 
            this.dgvInfoDSDonThuoc.AllowUserToAddRows = false;
            this.dgvInfoDSDonThuoc.AllowUserToDeleteRows = false;
            this.dgvInfoDSDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoDSDonThuoc.Location = new System.Drawing.Point(27, 366);
            this.dgvInfoDSDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoDSDonThuoc.Name = "dgvInfoDSDonThuoc";
            this.dgvInfoDSDonThuoc.ReadOnly = true;
            this.dgvInfoDSDonThuoc.RowHeadersWidth = 62;
            this.dgvInfoDSDonThuoc.RowTemplate.Height = 28;
            this.dgvInfoDSDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoDSDonThuoc.Size = new System.Drawing.Size(1028, 447);
            this.dgvInfoDSDonThuoc.TabIndex = 20;
            this.dgvInfoDSDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoDSDonThuoc_CellClick);
            // 
            // labDSDT
            // 
            this.labDSDT.AutoSize = true;
            this.labDSDT.ForeColor = System.Drawing.Color.Red;
            this.labDSDT.Location = new System.Drawing.Point(35, 315);
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
            this.grbInfoDonThuoc.Location = new System.Drawing.Point(28, 34);
            this.grbInfoDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Name = "grbInfoDonThuoc";
            this.grbInfoDonThuoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDonThuoc.Size = new System.Drawing.Size(1027, 150);
            this.grbInfoDonThuoc.TabIndex = 22;
            this.grbInfoDonThuoc.TabStop = false;
            this.grbInfoDonThuoc.Text = "Thông tin đơn thuốc";
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
            this.labMaDT.Location = new System.Drawing.Point(545, 53);
            this.labMaDT.Name = "labMaDT";
            this.labMaDT.Size = new System.Drawing.Size(106, 20);
            this.labMaDT.TabIndex = 31;
            this.labMaDT.Text = "Mã đơn thuốc";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(714, 47);
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
            this.labMaBN.Location = new System.Drawing.Point(70, 57);
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
            // btnCapNhatDonThuoc
            // 
            this.btnCapNhatDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.pills;
            this.btnCapNhatDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatDonThuoc.Location = new System.Drawing.Point(742, 241);
            this.btnCapNhatDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatDonThuoc.Name = "btnCapNhatDonThuoc";
            this.btnCapNhatDonThuoc.Size = new System.Drawing.Size(108, 39);
            this.btnCapNhatDonThuoc.TabIndex = 25;
            this.btnCapNhatDonThuoc.Text = "Chi tiết";
            this.btnCapNhatDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatDonThuoc.UseVisualStyleBackColor = true;
            this.btnCapNhatDonThuoc.Click += new System.EventHandler(this.btnCapNhatDonThuoc_Click);
            // 
            // btnXoaDonThuoc
            // 
            this.btnXoaDonThuoc.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaDonThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDonThuoc.Location = new System.Drawing.Point(928, 241);
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
            this.btnThemDonThuoc.Location = new System.Drawing.Point(565, 241);
            this.btnThemDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDonThuoc.Name = "btnThemDonThuoc";
            this.btnThemDonThuoc.Size = new System.Drawing.Size(99, 39);
            this.btnThemDonThuoc.TabIndex = 23;
            this.btnThemDonThuoc.Text = "Thêm";
            this.btnThemDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDonThuoc.UseVisualStyleBackColor = true;
            this.btnThemDonThuoc.Click += new System.EventHandler(this.btnThemDonThuoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(545, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ngày kê đơn";
            // 
            // dateNgayKeDon
            // 
            this.dateNgayKeDon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayKeDon.Location = new System.Drawing.Point(716, 102);
            this.dateNgayKeDon.Name = "dateNgayKeDon";
            this.dateNgayKeDon.Size = new System.Drawing.Size(215, 26);
            this.dateNgayKeDon.TabIndex = 36;
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
        private System.Windows.Forms.Label labMaDT;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label labMaBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Button btnCapNhatDonThuoc;
        private System.Windows.Forms.Button btnXoaDonThuoc;
        private System.Windows.Forms.Button btnThemDonThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrangThaiTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgayKeDon;
    }
}