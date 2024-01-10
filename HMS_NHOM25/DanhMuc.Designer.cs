namespace HMS_NHOM25
{
    partial class DanhMuc
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
            this.btnDSPhong = new System.Windows.Forms.Button();
            this.btnBN = new System.Windows.Forms.Button();
            this.panelHienThi = new System.Windows.Forms.Panel();
            this.btnDSDvu = new System.Windows.Forms.Button();
            this.btnDSHD = new System.Windows.Forms.Button();
            this.btnDSThuoc = new System.Windows.Forms.Button();
            this.btnDSNhanSu = new System.Windows.Forms.Button();
            this.panelDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDanhMuc.Controls.Add(this.btnDSNhanSu);
            this.panelDanhMuc.Controls.Add(this.btnDSThuoc);
            this.panelDanhMuc.Controls.Add(this.btnDSHD);
            this.panelDanhMuc.Controls.Add(this.btnDSDvu);
            this.panelDanhMuc.Controls.Add(this.btnDSDonThuoc);
            this.panelDanhMuc.Controls.Add(this.btnDSPhong);
            this.panelDanhMuc.Controls.Add(this.btnBN);
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
            this.btnDSDonThuoc.Location = new System.Drawing.Point(276, 0);
            this.btnDSDonThuoc.Name = "btnDSDonThuoc";
            this.btnDSDonThuoc.Size = new System.Drawing.Size(138, 69);
            this.btnDSDonThuoc.TabIndex = 2;
            this.btnDSDonThuoc.Text = "Danh Sách\r\nĐơn Thuốc";
            this.btnDSDonThuoc.UseVisualStyleBackColor = false;
            this.btnDSDonThuoc.Click += new System.EventHandler(this.btnDSDonThuoc_Click);
            // 
            // btnDSPhong
            // 
            this.btnDSPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSPhong.BackColor = System.Drawing.Color.Lavender;
            this.btnDSPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSPhong.Location = new System.Drawing.Point(138, 0);
            this.btnDSPhong.Name = "btnDSPhong";
            this.btnDSPhong.Size = new System.Drawing.Size(138, 69);
            this.btnDSPhong.TabIndex = 1;
            this.btnDSPhong.Text = "Danh Sách\r\nPhòng";
            this.btnDSPhong.UseVisualStyleBackColor = false;
            this.btnDSPhong.Click += new System.EventHandler(this.btnDSPhong_Click);
            // 
            // btnBN
            // 
            this.btnBN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBN.BackColor = System.Drawing.Color.Lavender;
            this.btnBN.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBN.Location = new System.Drawing.Point(0, 0);
            this.btnBN.Name = "btnBN";
            this.btnBN.Size = new System.Drawing.Size(138, 69);
            this.btnBN.TabIndex = 0;
            this.btnBN.Text = "Danh Sách \r\nBệnh Nhân";
            this.btnBN.UseVisualStyleBackColor = false;
            this.btnBN.Click += new System.EventHandler(this.btnBN_Click);
            // 
            // panelHienThi
            // 
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHienThi.Location = new System.Drawing.Point(0, 69);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(970, 675);
            this.panelHienThi.TabIndex = 1;
            // 
            // btnDSDvu
            // 
            this.btnDSDvu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSDvu.BackColor = System.Drawing.Color.Lavender;
            this.btnDSDvu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSDvu.Location = new System.Drawing.Point(414, 0);
            this.btnDSDvu.Name = "btnDSDvu";
            this.btnDSDvu.Size = new System.Drawing.Size(138, 69);
            this.btnDSDvu.TabIndex = 3;
            this.btnDSDvu.Text = "Danh Sách\r\nDịch Vụ";
            this.btnDSDvu.UseVisualStyleBackColor = false;
            this.btnDSDvu.Click += new System.EventHandler(this.btnDSDvu_Click);
            // 
            // btnDSHD
            // 
            this.btnDSHD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSHD.BackColor = System.Drawing.Color.Lavender;
            this.btnDSHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSHD.Location = new System.Drawing.Point(552, 0);
            this.btnDSHD.Name = "btnDSHD";
            this.btnDSHD.Size = new System.Drawing.Size(149, 69);
            this.btnDSHD.TabIndex = 4;
            this.btnDSHD.Text = "Danh Sách\r\nHoá Đơn";
            this.btnDSHD.UseVisualStyleBackColor = false;
            this.btnDSHD.Click += new System.EventHandler(this.btnDSHD_Click);
            // 
            // btnDSThuoc
            // 
            this.btnDSThuoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSThuoc.BackColor = System.Drawing.Color.Lavender;
            this.btnDSThuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSThuoc.Location = new System.Drawing.Point(701, 0);
            this.btnDSThuoc.Name = "btnDSThuoc";
            this.btnDSThuoc.Size = new System.Drawing.Size(138, 69);
            this.btnDSThuoc.TabIndex = 5;
            this.btnDSThuoc.Text = "Danh Sách\r\nThuốc";
            this.btnDSThuoc.UseVisualStyleBackColor = false;
            this.btnDSThuoc.Click += new System.EventHandler(this.btnDSThuoc_Click);
            // 
            // btnDSNhanSu
            // 
            this.btnDSNhanSu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSNhanSu.BackColor = System.Drawing.Color.Lavender;
            this.btnDSNhanSu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSNhanSu.Location = new System.Drawing.Point(839, 0);
            this.btnDSNhanSu.Name = "btnDSNhanSu";
            this.btnDSNhanSu.Size = new System.Drawing.Size(138, 69);
            this.btnDSNhanSu.TabIndex = 6;
            this.btnDSNhanSu.Text = "Danh Sách\r\nNhân sự";
            this.btnDSNhanSu.UseVisualStyleBackColor = false;
            this.btnDSNhanSu.Click += new System.EventHandler(this.btnDSNhanSu_Click);
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 744);
            this.Controls.Add(this.panelHienThi);
            this.Controls.Add(this.panelDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMuc";
            this.Text = "BaoCaoThongKe";
            this.panelDanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Button btnBN;
        private System.Windows.Forms.Button btnDSDonThuoc;
        private System.Windows.Forms.Button btnDSPhong;
        private System.Windows.Forms.Panel panelHienThi;
        private System.Windows.Forms.Button btnDSNhanSu;
        private System.Windows.Forms.Button btnDSThuoc;
        private System.Windows.Forms.Button btnDSHD;
        private System.Windows.Forms.Button btnDSDvu;
    }
}