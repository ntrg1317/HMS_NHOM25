namespace HMS_NHOM25
{
    partial class Danh_sách_bác_sĩ
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cobTrangThaiBS = new System.Windows.Forms.ComboBox();
            this.cobDiaChiBS = new System.Windows.Forms.ComboBox();
            this.cobGioiTinhBS = new System.Windows.Forms.ComboBox();
            this.DOBBS = new System.Windows.Forms.DateTimePicker();
            this.txtSDTBS = new System.Windows.Forms.TextBox();
            this.txtBangCapBS = new System.Windows.Forms.TextBox();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labNgaySinh = new System.Windows.Forms.Label();
            this.labTenBS = new System.Windows.Forms.Label();
            this.labMaBS = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiemBS = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSuaBS = new System.Windows.Forms.Button();
            this.btnXoaBS = new System.Windows.Forms.Button();
            this.btnThemBS = new System.Windows.Forms.Button();
            this.btnTimKiemBS = new System.Windows.Forms.Button();
            this.cobChuyenMonBS = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cobChuyenMonBS);
            this.groupBox1.Controls.Add(this.cobTrangThaiBS);
            this.groupBox1.Controls.Add(this.cobDiaChiBS);
            this.groupBox1.Controls.Add(this.cobGioiTinhBS);
            this.groupBox1.Controls.Add(this.DOBBS);
            this.groupBox1.Controls.Add(this.txtSDTBS);
            this.groupBox1.Controls.Add(this.txtBangCapBS);
            this.groupBox1.Controls.Add(this.txtTenBS);
            this.groupBox1.Controls.Add(this.txtMaBS);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labNgaySinh);
            this.groupBox1.Controls.Add(this.labTenBS);
            this.groupBox1.Controls.Add(this.labMaBS);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(35, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bác sĩ";
            // 
            // cobTrangThaiBS
            // 
            this.cobTrangThaiBS.FormattingEnabled = true;
            this.cobTrangThaiBS.Items.AddRange(new object[] {
            "Hoạt Động",
            "Ngừng hoạt động"});
            this.cobTrangThaiBS.Location = new System.Drawing.Point(790, 148);
            this.cobTrangThaiBS.Name = "cobTrangThaiBS";
            this.cobTrangThaiBS.Size = new System.Drawing.Size(184, 28);
            this.cobTrangThaiBS.TabIndex = 17;
            // 
            // cobDiaChiBS
            // 
            this.cobDiaChiBS.FormattingEnabled = true;
            this.cobDiaChiBS.Items.AddRange(new object[] {
            "Đống Đa, Hà Nội",
            "Hai Bà Trưng, Hà Nội",
            "Phù Cừ, Hưng Yên"});
            this.cobDiaChiBS.Location = new System.Drawing.Point(450, 94);
            this.cobDiaChiBS.Name = "cobDiaChiBS";
            this.cobDiaChiBS.Size = new System.Drawing.Size(180, 28);
            this.cobDiaChiBS.TabIndex = 16;
            // 
            // cobGioiTinhBS
            // 
            this.cobGioiTinhBS.FormattingEnabled = true;
            this.cobGioiTinhBS.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cobGioiTinhBS.Location = new System.Drawing.Point(450, 48);
            this.cobGioiTinhBS.Name = "cobGioiTinhBS";
            this.cobGioiTinhBS.Size = new System.Drawing.Size(180, 28);
            this.cobGioiTinhBS.TabIndex = 15;
            this.cobGioiTinhBS.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DOBBS
            // 
            this.DOBBS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBBS.Location = new System.Drawing.Point(130, 150);
            this.DOBBS.Name = "DOBBS";
            this.DOBBS.Size = new System.Drawing.Size(182, 26);
            this.DOBBS.TabIndex = 13;
            // 
            // txtSDTBS
            // 
            this.txtSDTBS.Location = new System.Drawing.Point(450, 150);
            this.txtSDTBS.Name = "txtSDTBS";
            this.txtSDTBS.Size = new System.Drawing.Size(180, 26);
            this.txtSDTBS.TabIndex = 12;
            // 
            // txtBangCapBS
            // 
            this.txtBangCapBS.Location = new System.Drawing.Point(790, 50);
            this.txtBangCapBS.Name = "txtBangCapBS";
            this.txtBangCapBS.Size = new System.Drawing.Size(184, 26);
            this.txtBangCapBS.TabIndex = 11;
            // 
            // txtTenBS
            // 
            this.txtTenBS.Location = new System.Drawing.Point(130, 96);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(184, 26);
            this.txtTenBS.TabIndex = 10;
            // 
            // txtMaBS
            // 
            this.txtMaBS.Location = new System.Drawing.Point(130, 47);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(184, 26);
            this.txtMaBS.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(682, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Trạng thái";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(682, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chuyên môn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(682, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bằng cấp";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(373, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(373, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(373, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // labNgaySinh
            // 
            this.labNgaySinh.AutoSize = true;
            this.labNgaySinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNgaySinh.Location = new System.Drawing.Point(37, 158);
            this.labNgaySinh.Name = "labNgaySinh";
            this.labNgaySinh.Size = new System.Drawing.Size(78, 20);
            this.labNgaySinh.TabIndex = 2;
            this.labNgaySinh.Text = "Ngày sinh";
            // 
            // labTenBS
            // 
            this.labTenBS.AutoSize = true;
            this.labTenBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBS.Location = new System.Drawing.Point(37, 102);
            this.labTenBS.Name = "labTenBS";
            this.labTenBS.Size = new System.Drawing.Size(77, 20);
            this.labTenBS.TabIndex = 1;
            this.labTenBS.Text = "Họ và tên";
            this.labTenBS.Click += new System.EventHandler(this.label2_Click);
            // 
            // labMaBS
            // 
            this.labMaBS.AutoSize = true;
            this.labMaBS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBS.Location = new System.Drawing.Point(37, 50);
            this.labMaBS.Name = "labMaBS";
            this.labMaBS.Size = new System.Drawing.Size(76, 20);
            this.labMaBS.TabIndex = 0;
            this.labMaBS.Text = "Mã bác sĩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(46, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(67, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên bác sĩ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtTimKiemBS
            // 
            this.txtTimKiemBS.Location = new System.Drawing.Point(165, 271);
            this.txtTimKiemBS.Name = "txtTimKiemBS";
            this.txtTimKiemBS.Size = new System.Drawing.Size(184, 26);
            this.txtTimKiemBS.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 259);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnSuaBS
            // 
            this.btnSuaBS.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBS.Location = new System.Drawing.Point(764, 265);
            this.btnSuaBS.Name = "btnSuaBS";
            this.btnSuaBS.Size = new System.Drawing.Size(103, 39);
            this.btnSuaBS.TabIndex = 22;
            this.btnSuaBS.Text = "Sửa";
            this.btnSuaBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBS.UseVisualStyleBackColor = true;
            // 
            // btnXoaBS
            // 
            this.btnXoaBS.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBS.Location = new System.Drawing.Point(932, 265);
            this.btnXoaBS.Name = "btnXoaBS";
            this.btnXoaBS.Size = new System.Drawing.Size(96, 39);
            this.btnXoaBS.TabIndex = 21;
            this.btnXoaBS.Text = "Xóa";
            this.btnXoaBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBS.UseVisualStyleBackColor = true;
            // 
            // btnThemBS
            // 
            this.btnThemBS.Image = global::HMS_NHOM25.Properties.Resources.add_user__1_;
            this.btnThemBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBS.Location = new System.Drawing.Point(598, 265);
            this.btnThemBS.Name = "btnThemBS";
            this.btnThemBS.Size = new System.Drawing.Size(99, 39);
            this.btnThemBS.TabIndex = 20;
            this.btnThemBS.Text = "Thêm";
            this.btnThemBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemBS.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemBS
            // 
            this.btnTimKiemBS.Image = global::HMS_NHOM25.Properties.Resources.find__1_;
            this.btnTimKiemBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemBS.Location = new System.Drawing.Point(412, 265);
            this.btnTimKiemBS.Name = "btnTimKiemBS";
            this.btnTimKiemBS.Size = new System.Drawing.Size(115, 39);
            this.btnTimKiemBS.TabIndex = 19;
            this.btnTimKiemBS.Text = "Tìm kiếm";
            this.btnTimKiemBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemBS.UseVisualStyleBackColor = true;
            // 
            // cobChuyenMonBS
            // 
            this.cobChuyenMonBS.FormattingEnabled = true;
            this.cobChuyenMonBS.Items.AddRange(new object[] {
            "Sản",
            "Tim Mạch",
            "Răng - Hàm - Mặt",
            "Da liễu"});
            this.cobChuyenMonBS.Location = new System.Drawing.Point(790, 94);
            this.cobChuyenMonBS.Name = "cobChuyenMonBS";
            this.cobChuyenMonBS.Size = new System.Drawing.Size(180, 28);
            this.cobChuyenMonBS.TabIndex = 18;
            // 
            // Danh_sách_bác_sĩ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSuaBS);
            this.Controls.Add(this.btnXoaBS);
            this.Controls.Add(this.btnThemBS);
            this.Controls.Add(this.btnTimKiemBS);
            this.Controls.Add(this.txtTimKiemBS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Danh_sách_bác_sĩ";
            this.Text = "Danh_sách_bác_sĩ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labMaBS;
        private System.Windows.Forms.Label labNgaySinh;
        private System.Windows.Forms.Label labTenBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDTBS;
        private System.Windows.Forms.TextBox txtBangCapBS;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.DateTimePicker DOBBS;
        private System.Windows.Forms.ComboBox cobGioiTinhBS;
        private System.Windows.Forms.ComboBox cobDiaChiBS;
        private System.Windows.Forms.ComboBox cobTrangThaiBS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiemBS;
        private System.Windows.Forms.Button btnTimKiemBS;
        private System.Windows.Forms.Button btnThemBS;
        private System.Windows.Forms.Button btnXoaBS;
        private System.Windows.Forms.Button btnSuaBS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cobChuyenMonBS;
    }
}