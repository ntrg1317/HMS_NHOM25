namespace HMS_NHOM25
{
    partial class QLPhong
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
            this.panelHienThi = new System.Windows.Forms.Panel();
            this.labHeaderLSDT = new System.Windows.Forms.Label();
            this.panelDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDanhMuc.Controls.Add(this.labHeaderLSDT);
            this.panelDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(970, 73);
            this.panelDanhMuc.TabIndex = 0;
            // 
            // panelHienThi
            // 
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHienThi.Location = new System.Drawing.Point(0, 73);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(970, 602);
            this.panelHienThi.TabIndex = 1;
            // 
            // labHeaderLSDT
            // 
            this.labHeaderLSDT.AutoSize = true;
            this.labHeaderLSDT.BackColor = System.Drawing.Color.Transparent;
            this.labHeaderLSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeaderLSDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labHeaderLSDT.Location = new System.Drawing.Point(394, 22);
            this.labHeaderLSDT.Name = "labHeaderLSDT";
            this.labHeaderLSDT.Size = new System.Drawing.Size(223, 29);
            this.labHeaderLSDT.TabIndex = 45;
            this.labHeaderLSDT.Text = "Trạng Thái Phòng";
            // 
            // QLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 675);
            this.Controls.Add(this.panelHienThi);
            this.Controls.Add(this.panelDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLPhong";
            this.Text = "BaoCaoThongKe";
            this.panelDanhMuc.ResumeLayout(false);
            this.panelDanhMuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Panel panelHienThi;
        private System.Windows.Forms.Label labHeaderLSDT;
    }
}