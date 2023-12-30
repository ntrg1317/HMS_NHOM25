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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phong));
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.labTenPhong = new System.Windows.Forms.Label();
            this.grbDanhMucPhong = new System.Windows.Forms.GroupBox();
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.colThongTinChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhMucPhong = new System.Windows.Forms.DataGridView();
            this.grbTimKiem.SuspendLayout();
            this.grbDanhMucPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.txtTenPhong);
            this.grbTimKiem.Controls.Add(this.labTenPhong);
            this.grbTimKiem.Controls.Add(this.btnTimKiemPhong);
            this.grbTimKiem.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.grbTimKiem, "grbTimKiem");
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.TabStop = false;
            // 
            // txtTenPhong
            // 
            resources.ApplyResources(this.txtTenPhong, "txtTenPhong");
            this.txtTenPhong.Name = "txtTenPhong";
            // 
            // labTenPhong
            // 
            resources.ApplyResources(this.labTenPhong, "labTenPhong");
            this.labTenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenPhong.Name = "labTenPhong";
            // 
            // grbDanhMucPhong
            // 
            resources.ApplyResources(this.grbDanhMucPhong, "grbDanhMucPhong");
            this.grbDanhMucPhong.Controls.Add(this.dgvDanhMucPhong);
            this.grbDanhMucPhong.ForeColor = System.Drawing.Color.Red;
            this.grbDanhMucPhong.Name = "grbDanhMucPhong";
            this.grbDanhMucPhong.TabStop = false;
            this.grbDanhMucPhong.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.Image = global::HMS_NHOM25.Properties.Resources.find__1_;
            resources.ApplyResources(this.btnTimKiemPhong, "btnTimKiemPhong");
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.UseVisualStyleBackColor = true;
            // 
            // colThongTinChiTiet
            // 
            this.colThongTinChiTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.colThongTinChiTiet, "colThongTinChiTiet");
            this.colThongTinChiTiet.Name = "colThongTinChiTiet";
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.colTrangThai, "colTrangThai");
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTienPhong
            // 
            this.colTienPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.colTienPhong, "colTienPhong");
            this.colTienPhong.Name = "colTienPhong";
            // 
            // colSoGiuong
            // 
            this.colSoGiuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.colSoGiuong, "colSoGiuong");
            this.colSoGiuong.Name = "colSoGiuong";
            this.colSoGiuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSoGiuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTenPhong
            // 
            this.colTenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.colTenPhong, "colTenPhong");
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMaPhong
            // 
            this.colMaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.colMaPhong, "colMaPhong");
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvDanhMucPhong
            // 
            this.dgvDanhMucPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colSoGiuong,
            this.colTienPhong,
            this.colTrangThai,
            this.colThongTinChiTiet});
            resources.ApplyResources(this.dgvDanhMucPhong, "dgvDanhMucPhong");
            this.dgvDanhMucPhong.Name = "dgvDanhMucPhong";
            this.dgvDanhMucPhong.RowTemplate.Height = 24;
            this.dgvDanhMucPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucPhong_CellContentClick);
            // 
            // Phong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.grbDanhMucPhong);
            this.Controls.Add(this.grbTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbDanhMucPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label labTenPhong;
        private System.Windows.Forms.GroupBox grbDanhMucPhong;
        private System.Windows.Forms.DataGridView dgvDanhMucPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoGiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colThongTinChiTiet;
    }
}