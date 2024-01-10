namespace HMS_NHOM25
{
    partial class DieuTri
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
            this.btnDT = new System.Windows.Forms.Button();
            this.btnDVSD = new System.Windows.Forms.Button();
            this.btnLSDT = new System.Windows.Forms.Button();
            this.panelHienThi = new System.Windows.Forms.Panel();
            this.panelDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDanhMuc.Controls.Add(this.btnDT);
            this.panelDanhMuc.Controls.Add(this.btnDVSD);
            this.panelDanhMuc.Controls.Add(this.btnLSDT);
            this.panelDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(970, 51);
            this.panelDanhMuc.TabIndex = 0;
            // 
            // btnDT
            // 
            this.btnDT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDT.BackColor = System.Drawing.Color.Lavender;
            this.btnDT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDT.Location = new System.Drawing.Point(646, 0);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(323, 51);
            this.btnDT.TabIndex = 2;
            this.btnDT.Text = "Đơn thuốc";
            this.btnDT.UseVisualStyleBackColor = false;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // btnDVSD
            // 
            this.btnDVSD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDVSD.BackColor = System.Drawing.Color.Lavender;
            this.btnDVSD.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDVSD.Location = new System.Drawing.Point(323, 0);
            this.btnDVSD.Name = "btnDVSD";
            this.btnDVSD.Size = new System.Drawing.Size(323, 51);
            this.btnDVSD.TabIndex = 1;
            this.btnDVSD.Text = "Dịch vụ sử dụng";
            this.btnDVSD.UseVisualStyleBackColor = false;
            this.btnDVSD.Click += new System.EventHandler(this.btnDVSD_Click);
            // 
            // btnLSDT
            // 
            this.btnLSDT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLSDT.BackColor = System.Drawing.Color.Lavender;
            this.btnLSDT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLSDT.Location = new System.Drawing.Point(0, 0);
            this.btnLSDT.Name = "btnLSDT";
            this.btnLSDT.Size = new System.Drawing.Size(323, 51);
            this.btnLSDT.TabIndex = 0;
            this.btnLSDT.Text = "Lịch sử điều trị";
            this.btnLSDT.UseVisualStyleBackColor = false;
            this.btnLSDT.Click += new System.EventHandler(this.btnLSDT_Click);
            // 
            // panelHienThi
            // 
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHienThi.Location = new System.Drawing.Point(0, 51);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(970, 624);
            this.panelHienThi.TabIndex = 1;
            // 
            // DieuTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 675);
            this.Controls.Add(this.panelHienThi);
            this.Controls.Add(this.panelDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DieuTri";
            this.Text = "BaoCaoThongKe";
            this.panelDanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Button btnLSDT;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.Button btnDVSD;
        private System.Windows.Forms.Panel panelHienThi;
    }
}