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
            this.dgvInforPhong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grb = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtSoLuongPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.labTenBN = new System.Windows.Forms.Label();
            this.labMaBN = new System.Windows.Forms.Label();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.txtTKTenPhong = new System.Windows.Forms.TextBox();
            this.labTenPhong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforPhong)).BeginInit();
            this.grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInforPhong
            // 
            this.dgvInforPhong.AllowUserToAddRows = false;
            this.dgvInforPhong.AllowUserToDeleteRows = false;
            this.dgvInforPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInforPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforPhong.Location = new System.Drawing.Point(38, 348);
            this.dgvInforPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInforPhong.Name = "dgvInforPhong";
            this.dgvInforPhong.ReadOnly = true;
            this.dgvInforPhong.RowHeadersWidth = 51;
            this.dgvInforPhong.RowTemplate.Height = 24;
            this.dgvInforPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInforPhong.Size = new System.Drawing.Size(998, 435);
            this.dgvInforPhong.TabIndex = 0;
            this.dgvInforPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInforPhong_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(34, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Danh sách phòng";
            // 
            // grb
            // 
            this.grb.Controls.Add(this.label4);
            this.grb.Controls.Add(this.txtGiaPhong);
            this.grb.Controls.Add(this.txtSoLuongPhong);
            this.grb.Controls.Add(this.label1);
            this.grb.Controls.Add(this.label3);
            this.grb.Controls.Add(this.txtTenPhong);
            this.grb.Controls.Add(this.txtMaPhong);
            this.grb.Controls.Add(this.labTenBN);
            this.grb.Controls.Add(this.labMaBN);
            this.grb.ForeColor = System.Drawing.Color.Red;
            this.grb.Location = new System.Drawing.Point(34, 27);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(1001, 141);
            this.grb.TabIndex = 31;
            this.grb.TabStop = false;
            this.grb.Text = "Thông tin phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(876, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "(VNĐ)";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(686, 92);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(184, 26);
            this.txtGiaPhong.TabIndex = 18;
            // 
            // txtSoLuongPhong
            // 
            this.txtSoLuongPhong.Location = new System.Drawing.Point(686, 43);
            this.txtSoLuongPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongPhong.Name = "txtSoLuongPhong";
            this.txtSoLuongPhong.Size = new System.Drawing.Size(184, 26);
            this.txtSoLuongPhong.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(563, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Giá phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(563, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số lượng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(185, 92);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(184, 26);
            this.txtTenPhong.TabIndex = 14;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(185, 43);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(184, 26);
            this.txtMaPhong.TabIndex = 13;
            // 
            // labTenBN
            // 
            this.labTenBN.AutoSize = true;
            this.labTenBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBN.Location = new System.Drawing.Point(62, 98);
            this.labTenBN.Name = "labTenBN";
            this.labTenBN.Size = new System.Drawing.Size(85, 20);
            this.labTenBN.TabIndex = 12;
            this.labTenBN.Text = "Tên phòng";
            // 
            // labMaBN
            // 
            this.labMaBN.AutoSize = true;
            this.labMaBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBN.Location = new System.Drawing.Point(62, 46);
            this.labMaBN.Name = "labMaBN";
            this.labMaBN.Size = new System.Drawing.Size(80, 20);
            this.labMaBN.TabIndex = 11;
            this.labMaBN.Text = "Mã phòng";
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.ForeColor = System.Drawing.Color.Black;
            this.btnSuaPhong.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPhong.Location = new System.Drawing.Point(670, 234);
            this.btnSuaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(120, 39);
            this.btnSuaPhong.TabIndex = 38;
            this.btnSuaPhong.Text = "Cập nhật";
            this.btnSuaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPhong.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhong.Location = new System.Drawing.Point(880, 234);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(96, 39);
            this.btnXoaPhong.TabIndex = 37;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.ForeColor = System.Drawing.Color.Black;
            this.btnThemPhong.Image = global::HMS_NHOM25.Properties.Resources.add_user__1_;
            this.btnThemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhong.Location = new System.Drawing.Point(477, 231);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(99, 39);
            this.btnThemPhong.TabIndex = 36;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // txtTKTenPhong
            // 
            this.txtTKTenPhong.Location = new System.Drawing.Point(217, 240);
            this.txtTKTenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTKTenPhong.Name = "txtTKTenPhong";
            this.txtTKTenPhong.Size = new System.Drawing.Size(184, 26);
            this.txtTKTenPhong.TabIndex = 34;
            this.txtTKTenPhong.TextChanged += new System.EventHandler(this.txtTKTenPhong_TextChanged);
            // 
            // labTenPhong
            // 
            this.labTenPhong.AutoSize = true;
            this.labTenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenPhong.Location = new System.Drawing.Point(103, 246);
            this.labTenPhong.Name = "labTenPhong";
            this.labTenPhong.Size = new System.Drawing.Size(85, 20);
            this.labTenPhong.TabIndex = 35;
            this.labTenPhong.Text = "Tên phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(34, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tìm kiếm";
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 795);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSuaPhong);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.txtTKTenPhong);
            this.Controls.Add(this.labTenPhong);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInforPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Phong";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforPhong)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInforPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtSoLuongPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label labTenBN;
        private System.Windows.Forms.Label labMaBN;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.TextBox txtTKTenPhong;
        private System.Windows.Forms.Label labTenPhong;
        private System.Windows.Forms.Label label5;
    }
}