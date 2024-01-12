namespace HMS_NHOM25
{
    partial class TaiKhoan
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtTKMaTK = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.txtTMaCV = new System.Windows.Forms.TextBox();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.labMaBN = new System.Windows.Forms.Label();
            this.labTenPhong = new System.Windows.Forms.Label();
            this.grb = new System.Windows.Forms.GroupBox();
            this.labTenBN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInforTaiKhoan = new System.Windows.Forms.DataGridView();
            this.labDS = new System.Windows.Forms.Label();
            this.grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(29, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tìm kiếm";
            // 
            // txtTKMaTK
            // 
            this.txtTKMaTK.Location = new System.Drawing.Point(192, 230);
            this.txtTKMaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTKMaTK.Name = "txtTKMaTK";
            this.txtTKMaTK.Size = new System.Drawing.Size(164, 22);
            this.txtTKMaTK.TabIndex = 43;
            this.txtTKMaTK.TextChanged += new System.EventHandler(this.txtTKMaTK_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(657, 74);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(164, 22);
            this.txtMatKhau.TabIndex = 18;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(657, 34);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(164, 22);
            this.txtTenDN.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(523, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(523, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên đăng nhập";
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.ForeColor = System.Drawing.Color.Black;
            this.btnSuaPhong.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPhong.Location = new System.Drawing.Point(556, 226);
            this.btnSuaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(107, 31);
            this.btnSuaPhong.TabIndex = 47;
            this.btnSuaPhong.Text = "Cập nhật";
            this.btnSuaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPhong.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhong.Location = new System.Drawing.Point(764, 226);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(85, 31);
            this.btnXoaPhong.TabIndex = 46;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.BtnXoaTaiKhoan_Click);
            // 
            // txtTMaCV
            // 
            this.txtTMaCV.Location = new System.Drawing.Point(164, 74);
            this.txtTMaCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTMaCV.Name = "txtTMaCV";
            this.txtTMaCV.Size = new System.Drawing.Size(164, 22);
            this.txtTMaCV.TabIndex = 14;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(164, 34);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.ReadOnly = true;
            this.txtMaTK.Size = new System.Drawing.Size(164, 22);
            this.txtMaTK.TabIndex = 13;
            // 
            // labMaBN
            // 
            this.labMaBN.AutoSize = true;
            this.labMaBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBN.Location = new System.Drawing.Point(55, 37);
            this.labMaBN.Name = "labMaBN";
            this.labMaBN.Size = new System.Drawing.Size(83, 16);
            this.labMaBN.TabIndex = 11;
            this.labMaBN.Text = "Mã tài khoản";
            // 
            // labTenPhong
            // 
            this.labTenPhong.AutoSize = true;
            this.labTenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenPhong.Location = new System.Drawing.Point(91, 235);
            this.labTenPhong.Name = "labTenPhong";
            this.labTenPhong.Size = new System.Drawing.Size(83, 16);
            this.labTenPhong.TabIndex = 44;
            this.labTenPhong.Text = "Mã tài khoản";
            // 
            // grb
            // 
            this.grb.Controls.Add(this.txtMatKhau);
            this.grb.Controls.Add(this.txtTenDN);
            this.grb.Controls.Add(this.label1);
            this.grb.Controls.Add(this.label3);
            this.grb.Controls.Add(this.txtTMaCV);
            this.grb.Controls.Add(this.txtMaTK);
            this.grb.Controls.Add(this.labTenBN);
            this.grb.Controls.Add(this.labMaBN);
            this.grb.ForeColor = System.Drawing.Color.Red;
            this.grb.Location = new System.Drawing.Point(29, 60);
            this.grb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Name = "grb";
            this.grb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Size = new System.Drawing.Size(902, 113);
            this.grb.TabIndex = 42;
            this.grb.TabStop = false;
            this.grb.Text = "Thông tin tài khoản";
            // 
            // labTenBN
            // 
            this.labTenBN.AutoSize = true;
            this.labTenBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBN.Location = new System.Drawing.Point(55, 78);
            this.labTenBN.Name = "labTenBN";
            this.labTenBN.Size = new System.Drawing.Size(74, 16);
            this.labTenBN.TabIndex = 12;
            this.labTenBN.Text = "Mã chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(29, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Danh sách tài khoản";
            // 
            // dgvInforTaiKhoan
            // 
            this.dgvInforTaiKhoan.AllowUserToAddRows = false;
            this.dgvInforTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvInforTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInforTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInforTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforTaiKhoan.Location = new System.Drawing.Point(33, 312);
            this.dgvInforTaiKhoan.Name = "dgvInforTaiKhoan";
            this.dgvInforTaiKhoan.ReadOnly = true;
            this.dgvInforTaiKhoan.RowHeadersWidth = 51;
            this.dgvInforTaiKhoan.RowTemplate.Height = 24;
            this.dgvInforTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInforTaiKhoan.Size = new System.Drawing.Size(898, 420);
            this.dgvInforTaiKhoan.TabIndex = 40;
            this.dgvInforTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInforTaiKhoan_CellClick);
            // 
            // labDS
            // 
            this.labDS.AutoSize = true;
            this.labDS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labDS.Location = new System.Drawing.Point(338, 22);
            this.labDS.Name = "labDS";
            this.labDS.Size = new System.Drawing.Size(246, 29);
            this.labDS.TabIndex = 49;
            this.labDS.Text = "Danh sách tài khoản";
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(970, 744);
            this.Controls.Add(this.labDS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTKMaTK);
            this.Controls.Add(this.btnSuaPhong);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.labTenPhong);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInforTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTKMaTK;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.TextBox txtTMaCV;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label labMaBN;
        private System.Windows.Forms.Label labTenPhong;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Label labTenBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInforTaiKhoan;
        private System.Windows.Forms.Label labDS;
    }
}