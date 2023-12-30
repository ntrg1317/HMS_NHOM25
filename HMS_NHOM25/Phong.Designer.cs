namespace HMS_NHOM25
{
    partial class Phong
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
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.labTenPhong = new System.Windows.Forms.Label();
            this.panDanhMucPhong = new System.Windows.Forms.Panel();
            this.dgvDanhMucPhong = new System.Windows.Forms.DataGridView();
            this.grbDanhMucPhong = new System.Windows.Forms.GroupBox();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThongTinChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.grbTimKiem.SuspendLayout();
            this.panDanhMucPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucPhong)).BeginInit();
            this.grbDanhMucPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.txtTenPhong);
            this.grbTimKiem.Controls.Add(this.labTenPhong);
            this.grbTimKiem.Controls.Add(this.btnTimKiemPhong);
            this.grbTimKiem.ForeColor = System.Drawing.Color.Red;
            this.grbTimKiem.Location = new System.Drawing.Point(31, 12);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(927, 67);
            this.grbTimKiem.TabIndex = 29;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(134, 24);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(164, 22);
            this.txtTenPhong.TabIndex = 29;
            // 
            // labTenPhong
            // 
            this.labTenPhong.AutoSize = true;
            this.labTenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenPhong.Location = new System.Drawing.Point(33, 29);
            this.labTenPhong.Name = "labTenPhong";
            this.labTenPhong.Size = new System.Drawing.Size(72, 16);
            this.labTenPhong.TabIndex = 30;
            this.labTenPhong.Text = "Tên phòng";
            // 
            // panDanhMucPhong
            // 
            this.panDanhMucPhong.Controls.Add(this.dgvDanhMucPhong);
            this.panDanhMucPhong.Location = new System.Drawing.Point(6, 19);
            this.panDanhMucPhong.Name = "panDanhMucPhong";
            this.panDanhMucPhong.Size = new System.Drawing.Size(892, 434);
            this.panDanhMucPhong.TabIndex = 35;
            // 
            // dgvDanhMucPhong
            // 
            this.dgvDanhMucPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colSoGiuong,
            this.colTienPhong,
            this.colTrangThai,
            this.colThongTinChiTiet});
            this.dgvDanhMucPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMucPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhMucPhong.Name = "dgvDanhMucPhong";
            this.dgvDanhMucPhong.RowHeadersWidth = 51;
            this.dgvDanhMucPhong.RowTemplate.Height = 24;
            this.dgvDanhMucPhong.Size = new System.Drawing.Size(892, 434);
            this.dgvDanhMucPhong.TabIndex = 0;
            // 
            // grbDanhMucPhong
            // 
            this.grbDanhMucPhong.Controls.Add(this.panDanhMucPhong);
            this.grbDanhMucPhong.ForeColor = System.Drawing.Color.Red;
            this.grbDanhMucPhong.Location = new System.Drawing.Point(31, 95);
            this.grbDanhMucPhong.Name = "grbDanhMucPhong";
            this.grbDanhMucPhong.Size = new System.Drawing.Size(927, 443);
            this.grbDanhMucPhong.TabIndex = 34;
            this.grbDanhMucPhong.TabStop = false;
            this.grbDanhMucPhong.Text = "Danh mục phòng";
            // 
            // colMaPhong
            // 
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.MinimumWidth = 6;
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMaPhong.Width = 120;
            // 
            // colTenPhong
            // 
            this.colTenPhong.HeaderText = "Tên phòng";
            this.colTenPhong.MinimumWidth = 6;
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTenPhong.Width = 120;
            // 
            // colSoGiuong
            // 
            this.colSoGiuong.HeaderText = "Số giường";
            this.colSoGiuong.MinimumWidth = 6;
            this.colSoGiuong.Name = "colSoGiuong";
            this.colSoGiuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSoGiuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSoGiuong.Width = 120;
            // 
            // colTienPhong
            // 
            this.colTienPhong.HeaderText = "Tiền phòng";
            this.colTienPhong.MinimumWidth = 6;
            this.colTienPhong.Name = "colTienPhong";
            this.colTienPhong.Width = 170;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrangThai.Width = 170;
            // 
            // colThongTinChiTiet
            // 
            this.colThongTinChiTiet.HeaderText = "Thông tin chi tiết";
            this.colThongTinChiTiet.MinimumWidth = 6;
            this.colThongTinChiTiet.Name = "colThongTinChiTiet";
            this.colThongTinChiTiet.Width = 200;
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.Image = global::HMS_NHOM25.Properties.Resources.find__1_;
            this.btnTimKiemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhong.Location = new System.Drawing.Point(400, 18);
            this.btnTimKiemPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(104, 35);
            this.btnTimKiemPhong.TabIndex = 28;
            this.btnTimKiemPhong.Text = "Tìm kiếm";
            this.btnTimKiemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhong.UseVisualStyleBackColor = true;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 550);
            this.Controls.Add(this.grbDanhMucPhong);
            this.Controls.Add(this.grbTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phong";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.panDanhMucPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucPhong)).EndInit();
            this.grbDanhMucPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label labTenPhong;
        private System.Windows.Forms.Panel panDanhMucPhong;
        private System.Windows.Forms.DataGridView dgvDanhMucPhong;
        private System.Windows.Forms.GroupBox grbDanhMucPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoGiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colThongTinChiTiet;
    }
}