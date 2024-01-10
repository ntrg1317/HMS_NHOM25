namespace HMS_NHOM25
{
    partial class QuanLy
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
            this.panelDanhMuc = new System.Windows.Forms.Panel();
            this.btnDSDonThuoc = new System.Windows.Forms.Button();
            this.btnQLHoaDon = new System.Windows.Forms.Button();
            this.btnDieuTri = new System.Windows.Forms.Button();
            this.panelHienThi = new System.Windows.Forms.Panel();
            this.panelDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDanhMuc.Controls.Add(this.btnDSDonThuoc);
            this.panelDanhMuc.Controls.Add(this.btnQLHoaDon);
            this.panelDanhMuc.Controls.Add(this.btnDieuTri);
            this.panelDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(970, 69);
            this.panelDanhMuc.TabIndex = 0;
            // 
            // btnDSDonThuoc
            // 
            this.btnDSDonThuoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSDonThuoc.BackColor = System.Drawing.Color.Lavender;
            this.btnDSDonThuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSDonThuoc.Location = new System.Drawing.Point(648, 0);
            this.btnDSDonThuoc.Name = "btnDSDonThuoc";
            this.btnDSDonThuoc.Size = new System.Drawing.Size(322, 69);
            this.btnDSDonThuoc.TabIndex = 2;
            this.btnDSDonThuoc.Text = "Quản Lý Phòng";
            this.btnDSDonThuoc.UseVisualStyleBackColor = false;
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLHoaDon.BackColor = System.Drawing.Color.Lavender;
            this.btnQLHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLHoaDon.Location = new System.Drawing.Point(324, 0);
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.Size = new System.Drawing.Size(324, 69);
            this.btnQLHoaDon.TabIndex = 1;
            this.btnQLHoaDon.Text = "Quản Lý Hoá Đơn";
            this.btnQLHoaDon.UseVisualStyleBackColor = false;
            this.btnQLHoaDon.Click += new System.EventHandler(this.btnQLHoaDon_Click);
            // 
            // btnDieuTri
            // 
            this.btnDieuTri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDieuTri.BackColor = System.Drawing.Color.Lavender;
            this.btnDieuTri.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDieuTri.Location = new System.Drawing.Point(0, 0);
            this.btnDieuTri.Name = "btnDieuTri";
            this.btnDieuTri.Size = new System.Drawing.Size(324, 69);
            this.btnDieuTri.TabIndex = 0;
            this.btnDieuTri.Text = "Điều trị";
            this.btnDieuTri.UseVisualStyleBackColor = false;
            this.btnDieuTri.Click += new System.EventHandler(this.btnDieuTri_Click);
            // 
            // panelHienThi
            // 
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHienThi.Location = new System.Drawing.Point(0, 69);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(970, 675);
            this.panelHienThi.TabIndex = 1;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 744);
            this.Controls.Add(this.panelHienThi);
            this.Controls.Add(this.panelDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLy";
            this.Text = "BaoCaoThongKe";
            this.panelDanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Button btnDieuTri;
        private System.Windows.Forms.Button btnDSDonThuoc;
        private System.Windows.Forms.Button btnQLHoaDon;
        private System.Windows.Forms.Panel panelHienThi;
    }
}