namespace HMS_NHOM25
{
    partial class KhoThuoc
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
            this.grbInforKhoThuoc = new System.Windows.Forms.GroupBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.labMaThuoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaThuoc = new System.Windows.Forms.TextBox();
            this.labGiaThuoc = new System.Windows.Forms.Label();
            this.dateHSD = new System.Windows.Forms.DateTimePicker();
            this.labHSD = new System.Windows.Forms.Label();
            this.dateNSX = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuongThuoc = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.labSoLuongThuoc = new System.Windows.Forms.Label();
            this.labNSX = new System.Windows.Forms.Label();
            this.labTenThuoc = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labTimKiemThuoc = new System.Windows.Forms.Label();
            this.labTenThuocTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiemThuoc = new System.Windows.Forms.TextBox();
            this.dgvInfoKhoThuoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhatThuoc = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.grbInforKhoThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoKhoThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInforKhoThuoc
            // 
            this.grbInforKhoThuoc.Controls.Add(this.txtMaThuoc);
            this.grbInforKhoThuoc.Controls.Add(this.labMaThuoc);
            this.grbInforKhoThuoc.Controls.Add(this.label2);
            this.grbInforKhoThuoc.Controls.Add(this.txtGiaThuoc);
            this.grbInforKhoThuoc.Controls.Add(this.labGiaThuoc);
            this.grbInforKhoThuoc.Controls.Add(this.dateHSD);
            this.grbInforKhoThuoc.Controls.Add(this.labHSD);
            this.grbInforKhoThuoc.Controls.Add(this.dateNSX);
            this.grbInforKhoThuoc.Controls.Add(this.txtSoLuongThuoc);
            this.grbInforKhoThuoc.Controls.Add(this.txtTenThuoc);
            this.grbInforKhoThuoc.Controls.Add(this.labSoLuongThuoc);
            this.grbInforKhoThuoc.Controls.Add(this.labNSX);
            this.grbInforKhoThuoc.Controls.Add(this.labTenThuoc);
            this.grbInforKhoThuoc.ForeColor = System.Drawing.Color.Red;
            this.grbInforKhoThuoc.Location = new System.Drawing.Point(31, 18);
            this.grbInforKhoThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforKhoThuoc.Name = "grbInforKhoThuoc";
            this.grbInforKhoThuoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInforKhoThuoc.Size = new System.Drawing.Size(904, 134);
            this.grbInforKhoThuoc.TabIndex = 0;
            this.grbInforKhoThuoc.TabStop = false;
            this.grbInforKhoThuoc.Text = "Thông tin thuốc";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(124, 39);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.ReadOnly = true;
            this.txtMaThuoc.Size = new System.Drawing.Size(160, 22);
            this.txtMaThuoc.TabIndex = 20;
            // 
            // labMaThuoc
            // 
            this.labMaThuoc.AutoSize = true;
            this.labMaThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaThuoc.Location = new System.Drawing.Point(26, 44);
            this.labMaThuoc.Name = "labMaThuoc";
            this.labMaThuoc.Size = new System.Drawing.Size(61, 16);
            this.labMaThuoc.TabIndex = 19;
            this.labMaThuoc.Text = "Mã thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(834, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "(VNĐ)";
            // 
            // txtGiaThuoc
            // 
            this.txtGiaThuoc.Location = new System.Drawing.Point(668, 39);
            this.txtGiaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaThuoc.Name = "txtGiaThuoc";
            this.txtGiaThuoc.Size = new System.Drawing.Size(160, 22);
            this.txtGiaThuoc.TabIndex = 17;
            this.txtGiaThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaThuoc_KeyPress);
            // 
            // labGiaThuoc
            // 
            this.labGiaThuoc.AutoSize = true;
            this.labGiaThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labGiaThuoc.Location = new System.Drawing.Point(588, 44);
            this.labGiaThuoc.Name = "labGiaThuoc";
            this.labGiaThuoc.Size = new System.Drawing.Size(52, 16);
            this.labGiaThuoc.TabIndex = 16;
            this.labGiaThuoc.Text = "Giá tiền";
            // 
            // dateHSD
            // 
            this.dateHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHSD.Location = new System.Drawing.Point(389, 81);
            this.dateHSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateHSD.Name = "dateHSD";
            this.dateHSD.Size = new System.Drawing.Size(162, 22);
            this.dateHSD.TabIndex = 15;
            // 
            // labHSD
            // 
            this.labHSD.AutoSize = true;
            this.labHSD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labHSD.Location = new System.Drawing.Point(327, 85);
            this.labHSD.Name = "labHSD";
            this.labHSD.Size = new System.Drawing.Size(36, 16);
            this.labHSD.TabIndex = 14;
            this.labHSD.Text = "HSD";
            // 
            // dateNSX
            // 
            this.dateNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNSX.Location = new System.Drawing.Point(389, 40);
            this.dateNSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNSX.Name = "dateNSX";
            this.dateNSX.Size = new System.Drawing.Size(162, 22);
            this.dateNSX.TabIndex = 13;
            // 
            // txtSoLuongThuoc
            // 
            this.txtSoLuongThuoc.Location = new System.Drawing.Point(668, 80);
            this.txtSoLuongThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongThuoc.Name = "txtSoLuongThuoc";
            this.txtSoLuongThuoc.Size = new System.Drawing.Size(160, 22);
            this.txtSoLuongThuoc.TabIndex = 12;
            this.txtSoLuongThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongThuoc_KeyPress);
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(124, 82);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(160, 22);
            this.txtTenThuoc.TabIndex = 10;
            // 
            // labSoLuongThuoc
            // 
            this.labSoLuongThuoc.AutoSize = true;
            this.labSoLuongThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSoLuongThuoc.Location = new System.Drawing.Point(588, 85);
            this.labSoLuongThuoc.Name = "labSoLuongThuoc";
            this.labSoLuongThuoc.Size = new System.Drawing.Size(60, 16);
            this.labSoLuongThuoc.TabIndex = 5;
            this.labSoLuongThuoc.Text = "Số lượng";
            // 
            // labNSX
            // 
            this.labNSX.AutoSize = true;
            this.labNSX.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNSX.Location = new System.Drawing.Point(327, 44);
            this.labNSX.Name = "labNSX";
            this.labNSX.Size = new System.Drawing.Size(34, 16);
            this.labNSX.TabIndex = 2;
            this.labNSX.Text = "NSX";
            // 
            // labTenThuoc
            // 
            this.labTenThuoc.AutoSize = true;
            this.labTenThuoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenThuoc.Location = new System.Drawing.Point(26, 87);
            this.labTenThuoc.Name = "labTenThuoc";
            this.labTenThuoc.Size = new System.Drawing.Size(66, 16);
            this.labTenThuoc.TabIndex = 1;
            this.labTenThuoc.Text = "Tên thuốc";
            // 
            // labTimKiemThuoc
            // 
            this.labTimKiemThuoc.AutoSize = true;
            this.labTimKiemThuoc.ForeColor = System.Drawing.Color.Red;
            this.labTimKiemThuoc.Location = new System.Drawing.Point(36, 165);
            this.labTimKiemThuoc.Name = "labTimKiemThuoc";
            this.labTimKiemThuoc.Size = new System.Drawing.Size(62, 16);
            this.labTimKiemThuoc.TabIndex = 1;
            this.labTimKiemThuoc.Text = "Tìm kiếm";
            // 
            // labTenThuocTimKiem
            // 
            this.labTenThuocTimKiem.AutoSize = true;
            this.labTenThuocTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenThuocTimKiem.Location = new System.Drawing.Point(58, 196);
            this.labTenThuocTimKiem.Name = "labTenThuocTimKiem";
            this.labTenThuocTimKiem.Size = new System.Drawing.Size(66, 16);
            this.labTenThuocTimKiem.TabIndex = 18;
            this.labTenThuocTimKiem.Text = "Tên thuốc";
            // 
            // txtTimKiemThuoc
            // 
            this.txtTimKiemThuoc.Location = new System.Drawing.Point(155, 191);
            this.txtTimKiemThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemThuoc.Name = "txtTimKiemThuoc";
            this.txtTimKiemThuoc.Size = new System.Drawing.Size(160, 22);
            this.txtTimKiemThuoc.TabIndex = 18;
            this.txtTimKiemThuoc.TextChanged += new System.EventHandler(this.txtTimKiemThuoc_TextChanged);
            // 
            // dgvInfoKhoThuoc
            // 
            this.dgvInfoKhoThuoc.AllowUserToAddRows = false;
            this.dgvInfoKhoThuoc.AllowUserToDeleteRows = false;
            this.dgvInfoKhoThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoKhoThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoKhoThuoc.Location = new System.Drawing.Point(31, 263);
            this.dgvInfoKhoThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoKhoThuoc.Name = "dgvInfoKhoThuoc";
            this.dgvInfoKhoThuoc.ReadOnly = true;
            this.dgvInfoKhoThuoc.RowHeadersWidth = 62;
            this.dgvInfoKhoThuoc.RowTemplate.Height = 28;
            this.dgvInfoKhoThuoc.Size = new System.Drawing.Size(908, 470);
            this.dgvInfoKhoThuoc.TabIndex = 23;
            this.dgvInfoKhoThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoKhoThuoc_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách thuốc";
            // 
            // btnCapNhatThuoc
            // 
            this.btnCapNhatThuoc.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnCapNhatThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatThuoc.Location = new System.Drawing.Point(589, 186);
            this.btnCapNhatThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatThuoc.Name = "btnCapNhatThuoc";
            this.btnCapNhatThuoc.Size = new System.Drawing.Size(107, 31);
            this.btnCapNhatThuoc.TabIndex = 22;
            this.btnCapNhatThuoc.Text = "Cập nhật";
            this.btnCapNhatThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatThuoc.UseVisualStyleBackColor = true;
            this.btnCapNhatThuoc.Click += new System.EventHandler(this.btnCapNhatThuoc_Click);
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaThuoc.Location = new System.Drawing.Point(774, 186);
            this.btnXoaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(85, 31);
            this.btnXoaThuoc.TabIndex = 21;
            this.btnXoaThuoc.Text = "Xóa";
            this.btnXoaThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaThuoc.UseVisualStyleBackColor = true;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Image = global::HMS_NHOM25.Properties.Resources.plus;
            this.btnThemThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemThuoc.Location = new System.Drawing.Point(420, 186);
            this.btnThemThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(88, 31);
            this.btnThemThuoc.TabIndex = 20;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // KhoThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 744);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInfoKhoThuoc);
            this.Controls.Add(this.btnCapNhatThuoc);
            this.Controls.Add(this.btnXoaThuoc);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.txtTimKiemThuoc);
            this.Controls.Add(this.labTenThuocTimKiem);
            this.Controls.Add(this.labTimKiemThuoc);
            this.Controls.Add(this.grbInforKhoThuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhoThuoc";
            this.Text = "KhoThuoc";
            this.grbInforKhoThuoc.ResumeLayout(false);
            this.grbInforKhoThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoKhoThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInforKhoThuoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labNSX;
        private System.Windows.Forms.Label labTenThuoc;
        private System.Windows.Forms.Label labSoLuongThuoc;
        private System.Windows.Forms.TextBox txtSoLuongThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.DateTimePicker dateNSX;
        private System.Windows.Forms.Label labTimKiemThuoc;
        private System.Windows.Forms.Label labTenThuocTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemThuoc;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Button btnCapNhatThuoc;
        private System.Windows.Forms.DataGridView dgvInfoKhoThuoc;
        private System.Windows.Forms.TextBox txtGiaThuoc;
        private System.Windows.Forms.Label labGiaThuoc;
        private System.Windows.Forms.DateTimePicker dateHSD;
        private System.Windows.Forms.Label labHSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label labMaThuoc;
    }
}