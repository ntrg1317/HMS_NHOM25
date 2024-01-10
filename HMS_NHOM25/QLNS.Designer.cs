namespace HMS_NHOM25
{
    partial class QLNS
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
            this.btnDSNVTN = new System.Windows.Forms.Button();
            this.btnDSDuocSi = new System.Windows.Forms.Button();
            this.btnDSBS = new System.Windows.Forms.Button();
            this.panelHienThi = new System.Windows.Forms.Panel();
            this.btnQTV = new System.Windows.Forms.Button();
            this.panelDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDanhMuc.Controls.Add(this.btnQTV);
            this.panelDanhMuc.Controls.Add(this.btnDSNVTN);
            this.panelDanhMuc.Controls.Add(this.btnDSDuocSi);
            this.panelDanhMuc.Controls.Add(this.btnDSBS);
            this.panelDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(970, 51);
            this.panelDanhMuc.TabIndex = 0;
            // 
            // btnDSNVTN
            // 
            this.btnDSNVTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSNVTN.BackColor = System.Drawing.Color.Lavender;
            this.btnDSNVTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSNVTN.Location = new System.Drawing.Point(484, 0);
            this.btnDSNVTN.Name = "btnDSNVTN";
            this.btnDSNVTN.Size = new System.Drawing.Size(242, 51);
            this.btnDSNVTN.TabIndex = 2;
            this.btnDSNVTN.Text = "Nhân viên thu ngân";
            this.btnDSNVTN.UseVisualStyleBackColor = false;
            this.btnDSNVTN.Click += new System.EventHandler(this.btnDSNVTN_Click);
            // 
            // btnDSDuocSi
            // 
            this.btnDSDuocSi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSDuocSi.BackColor = System.Drawing.Color.Lavender;
            this.btnDSDuocSi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSDuocSi.Location = new System.Drawing.Point(242, 0);
            this.btnDSDuocSi.Name = "btnDSDuocSi";
            this.btnDSDuocSi.Size = new System.Drawing.Size(242, 51);
            this.btnDSDuocSi.TabIndex = 1;
            this.btnDSDuocSi.Text = "Dược sĩ";
            this.btnDSDuocSi.UseVisualStyleBackColor = false;
            this.btnDSDuocSi.Click += new System.EventHandler(this.btnDSDuocSi_Click);
            // 
            // btnDSBS
            // 
            this.btnDSBS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDSBS.BackColor = System.Drawing.Color.Lavender;
            this.btnDSBS.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSBS.Location = new System.Drawing.Point(0, 0);
            this.btnDSBS.Name = "btnDSBS";
            this.btnDSBS.Size = new System.Drawing.Size(242, 51);
            this.btnDSBS.TabIndex = 0;
            this.btnDSBS.Text = "Bác sĩ";
            this.btnDSBS.UseVisualStyleBackColor = false;
            this.btnDSBS.Click += new System.EventHandler(this.btnDSBS_Click);
            // 
            // panelHienThi
            // 
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHienThi.Location = new System.Drawing.Point(0, 51);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(970, 624);
            this.panelHienThi.TabIndex = 1;
            // 
            // btnQTV
            // 
            this.btnQTV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQTV.BackColor = System.Drawing.Color.Lavender;
            this.btnQTV.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQTV.Location = new System.Drawing.Point(726, 0);
            this.btnQTV.Name = "btnQTV";
            this.btnQTV.Size = new System.Drawing.Size(242, 51);
            this.btnQTV.TabIndex = 3;
            this.btnQTV.Text = "Quản trị viên";
            this.btnQTV.UseVisualStyleBackColor = false;
            this.btnQTV.Click += new System.EventHandler(this.btnQTV_Click);
            // 
            // QLNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 675);
            this.Controls.Add(this.panelHienThi);
            this.Controls.Add(this.panelDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLNS";
            this.Text = "BaoCaoThongKe";
            this.panelDanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Button btnDSBS;
        private System.Windows.Forms.Button btnDSNVTN;
        private System.Windows.Forms.Button btnDSDuocSi;
        private System.Windows.Forms.Panel panelHienThi;
        private System.Windows.Forms.Button btnQTV;
    }
}