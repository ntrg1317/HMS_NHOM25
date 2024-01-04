namespace HMS_NHOM25
{
    partial class DichVu
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInforDichVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.labTenBN = new System.Windows.Forms.Label();
            this.labMaBN = new System.Windows.Forms.Label();
            this.grb = new System.Windows.Forms.GroupBox();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.txtTKTenDV = new System.Windows.Forms.TextBox();
            this.labTenPhong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDichVu)).BeginInit();
            this.grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(778, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "(VNĐ)";
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(609, 34);
            this.txtGiaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(164, 22);
            this.txtGiaDV.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(29, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Danh sách dịch vụ";
            // 
            // dgvInforDichVu
            // 
            this.dgvInforDichVu.AllowUserToAddRows = false;
            this.dgvInforDichVu.AllowUserToDeleteRows = false;
            this.dgvInforDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInforDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInforDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforDichVu.Location = new System.Drawing.Point(33, 274);
            this.dgvInforDichVu.Name = "dgvInforDichVu";
            this.dgvInforDichVu.ReadOnly = true;
            this.dgvInforDichVu.RowHeadersWidth = 51;
            this.dgvInforDichVu.RowTemplate.Height = 24;
            this.dgvInforDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInforDichVu.Size = new System.Drawing.Size(887, 348);
            this.dgvInforDichVu.TabIndex = 32;
            this.dgvInforDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInforDichVu_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(500, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Giá dịch vụ";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(164, 74);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(164, 22);
            this.txtTenDV.TabIndex = 14;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(164, 34);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(164, 22);
            this.txtMaDV.TabIndex = 13;
            // 
            // labTenBN
            // 
            this.labTenBN.AutoSize = true;
            this.labTenBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBN.Location = new System.Drawing.Point(55, 78);
            this.labTenBN.Name = "labTenBN";
            this.labTenBN.Size = new System.Drawing.Size(76, 16);
            this.labTenBN.TabIndex = 12;
            this.labTenBN.Text = "Tên dịch vụ";
            // 
            // labMaBN
            // 
            this.labMaBN.AutoSize = true;
            this.labMaBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBN.Location = new System.Drawing.Point(55, 37);
            this.labMaBN.Name = "labMaBN";
            this.labMaBN.Size = new System.Drawing.Size(71, 16);
            this.labMaBN.TabIndex = 11;
            this.labMaBN.Text = "Mã dịch vụ";
            // 
            // grb
            // 
            this.grb.Controls.Add(this.label4);
            this.grb.Controls.Add(this.txtGiaDV);
            this.grb.Controls.Add(this.label1);
            this.grb.Controls.Add(this.txtTenDV);
            this.grb.Controls.Add(this.txtMaDV);
            this.grb.Controls.Add(this.labTenBN);
            this.grb.Controls.Add(this.labMaBN);
            this.grb.ForeColor = System.Drawing.Color.Red;
            this.grb.Location = new System.Drawing.Point(29, 17);
            this.grb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Name = "grb";
            this.grb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Size = new System.Drawing.Size(890, 113);
            this.grb.TabIndex = 35;
            this.grb.TabStop = false;
            this.grb.Text = "Thông tin dịch vụ";
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.ForeColor = System.Drawing.Color.Black;
            this.btnSuaDV.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDV.Location = new System.Drawing.Point(596, 182);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(107, 31);
            this.btnSuaDV.TabIndex = 40;
            this.btnSuaDV.Text = "Cập nhật";
            this.btnSuaDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDV.UseVisualStyleBackColor = true;
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDV.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDV.Location = new System.Drawing.Point(783, 182);
            this.btnXoaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(85, 31);
            this.btnXoaDV.TabIndex = 39;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDV.UseVisualStyleBackColor = true;
            // 
            // btnThemDV
            // 
            this.btnThemDV.ForeColor = System.Drawing.Color.Black;
            this.btnThemDV.Image = global::HMS_NHOM25.Properties.Resources.add_user__1_;
            this.btnThemDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDV.Location = new System.Drawing.Point(425, 180);
            this.btnThemDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(88, 31);
            this.btnThemDV.TabIndex = 38;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDV.UseVisualStyleBackColor = true;
            // 
            // txtTKTenDV
            // 
            this.txtTKTenDV.Location = new System.Drawing.Point(194, 187);
            this.txtTKTenDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTKTenDV.Name = "txtTKTenDV";
            this.txtTKTenDV.Size = new System.Drawing.Size(164, 22);
            this.txtTKTenDV.TabIndex = 36;
            this.txtTKTenDV.TextChanged += new System.EventHandler(this.txtTKTenDV_TextChanged);
            // 
            // labTenPhong
            // 
            this.labTenPhong.AutoSize = true;
            this.labTenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenPhong.Location = new System.Drawing.Point(92, 192);
            this.labTenPhong.Name = "labTenPhong";
            this.labTenPhong.Size = new System.Drawing.Size(76, 16);
            this.labTenPhong.TabIndex = 37;
            this.labTenPhong.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(29, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tìm kiếm";
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 638);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.txtTKTenDV);
            this.Controls.Add(this.labTenPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInforDichVu);
            this.Controls.Add(this.grb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DichVu";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDichVu)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInforDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label labTenBN;
        private System.Windows.Forms.Label labMaBN;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.TextBox txtTKTenDV;
        private System.Windows.Forms.Label labTenPhong;
        private System.Windows.Forms.Label label3;
    }
}