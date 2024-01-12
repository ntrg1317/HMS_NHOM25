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
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.labTenBN = new System.Windows.Forms.Label();
            this.labMaBN = new System.Windows.Forms.Label();
            this.grb = new System.Windows.Forms.GroupBox();
            this.cobTenDV = new System.Windows.Forms.ComboBox();
            this.dateNgayDung = new System.Windows.Forms.DateTimePicker();
            this.lablNgayDung = new System.Windows.Forms.Label();
            this.txtTKTenDV = new System.Windows.Forms.TextBox();
            this.labTenPhong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnSuaBNDV = new System.Windows.Forms.Button();
            this.btnXoaBNDV = new System.Windows.Forms.Button();
            this.labAddBS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDichVu)).BeginInit();
            this.grb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(875, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "(VNĐ)";
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(685, 35);
            this.txtGiaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(184, 26);
            this.txtGiaDV.TabIndex = 18;
            this.txtGiaDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaDV_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(33, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
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
            this.dgvInforDichVu.Location = new System.Drawing.Point(37, 430);
            this.dgvInforDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInforDichVu.Name = "dgvInforDichVu";
            this.dgvInforDichVu.ReadOnly = true;
            this.dgvInforDichVu.RowHeadersWidth = 51;
            this.dgvInforDichVu.RowTemplate.Height = 24;
            this.dgvInforDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInforDichVu.Size = new System.Drawing.Size(1020, 392);
            this.dgvInforDichVu.TabIndex = 32;
            this.dgvInforDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInforDichVu_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(562, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Giá dịch vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(184, 35);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(184, 26);
            this.txtMaDV.TabIndex = 13;
            // 
            // labTenBN
            // 
            this.labTenBN.AutoSize = true;
            this.labTenBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBN.Location = new System.Drawing.Point(62, 88);
            this.labTenBN.Name = "labTenBN";
            this.labTenBN.Size = new System.Drawing.Size(89, 20);
            this.labTenBN.TabIndex = 12;
            this.labTenBN.Text = "Tên dịch vụ";
            // 
            // labMaBN
            // 
            this.labMaBN.AutoSize = true;
            this.labMaBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBN.Location = new System.Drawing.Point(62, 39);
            this.labMaBN.Name = "labMaBN";
            this.labMaBN.Size = new System.Drawing.Size(84, 20);
            this.labMaBN.TabIndex = 11;
            this.labMaBN.Text = "Mã dịch vụ";
            // 
            // grb
            // 
            this.grb.Controls.Add(this.cobTenDV);
            this.grb.Controls.Add(this.dateNgayDung);
            this.grb.Controls.Add(this.label4);
            this.grb.Controls.Add(this.txtGiaDV);
            this.grb.Controls.Add(this.lablNgayDung);
            this.grb.Controls.Add(this.label1);
            this.grb.Controls.Add(this.txtMaDV);
            this.grb.Controls.Add(this.labTenBN);
            this.grb.Controls.Add(this.labMaBN);
            this.grb.ForeColor = System.Drawing.Color.Red;
            this.grb.Location = new System.Drawing.Point(37, 94);
            this.grb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Name = "grb";
            this.grb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Size = new System.Drawing.Size(1001, 128);
            this.grb.TabIndex = 35;
            this.grb.TabStop = false;
            this.grb.Text = "Thông tin dịch vụ";
            // 
            // cobTenDV
            // 
            this.cobTenDV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobTenDV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobTenDV.FormattingEnabled = true;
            this.cobTenDV.Items.AddRange(new object[] {
            "Chụp X-Quang                 ",
            "Tiêm phòng                    ",
            "Ðo huyết áp                   ",
            "Ðiều trị răng                 ",
            "Mạch và nhịp tim              ",
            "Kiểm tra da liễu              ",
            "Tu vấn dinh dưỡng             ",
            "Phẫu thuậtt mắt               ",
            "Ðiều trị nội tiết             ",
            "Hấp thụ chất dinh dưỡng       ",
            "Kiểm tra tai mũi họng         ",
            "Tư vấn tâm lý                 ",
            "Phẫu thuật cơ xương khớp      ",
            "Thăm hỏa                      ",
            "Chụp cắt lớp                  ",
            "Tiêm vaccine                  ",
            "Tư vấn phòng mạch             ",
            "Điều trị cảm mạo              ",
            "Chẩn đoán máu                 ",
            "Phẫu thuật gan                ",
            "Điều trị da liễu              ",
            "Chụp cộng hưởng từ (MRI)      ",
            "Tư vấn lịch sự                ",
            "Điều trị dạ dày               ",
            "Tiêm insulin                  ",
            "Tư vấn tình cảm gia đình      ",
            "Kiểm tra cholesterol          ",
            "Điều trị đau lưng             ",
            "Tư vấn chế độ ăn uống         ",
            "Chụp cắt lớp 3D               ",
            "Điều trị hô hấp               ",
            "Tiêm chủng cơ bản             ",
            "Chăm sóc thương tổn           ",
            "Phẫu thuật thẩm mỹ            ",
            "Tư vấn yoga và thiền          ",
            "Kiểm tra tiểu đường           ",
            "Điều trị thần kinh            ",
            "Chụp nội soi                  ",
            "Tư vấn quản lý stress         ",
            "Phẫu thuật thận               ",
            "Kiểm tra mắt                  ",
            "Phẫu thuật tim mạch           ",
            "Tư vấn hút thuốc lá           ",
            "Điều trị ung thư              ",
            "Chụp siêu âm                  ",
            "Tư vấn tình dục               ",
            "Kiểm tra tiền sử y học        ",
            "Điều trị viêm nhiễm           ",
            "Tư vấn giảm cân               ",
            "Chụp cộng hưởng từ (CT)       ",
            "Điều trị tiểu đường           ",
            "Tiêm chủng nâng cao           ",
            "Phẫu thuật chỉnh hình         ",
            "Tư vấn tập thể dục            ",
            "Kiểm tra huyết áp             ",
            "Điều trị stress và lo âu      ",
            "Chụp cắt lớp 4D               ",
            "Tư vấn chăm sóc trẻ sơ sinh   ",
            "Phẫu thuật ruột thừa          ",
            "Chụp nghiệm ADN               ",
            "Tư vấn dinh dưỡng             ",
            "Kiểm tra tai mũi họng         ",
            "Tư vấn tâm lý                 ",
            "Phẫu thuật cơ xương khớp      ",
            "Thăm hỏa                      ",
            "Chụp cắt lớp                  ",
            "Tiêm vaccine                  ",
            "Tư vấn phòng mạch             ",
            "Điều trị cảm mạo              ",
            "Chẩn đoán máu                 ",
            "Điều trị da liễu              ",
            "Chụp cộng hưởng từ (MRI)      ",
            "Tư vấn lịch sự                ",
            "Điều trị dạ dày               ",
            "Tiêm insulin                  ",
            "Tư vấn tình cảm gia đình      ",
            "Kiểm tra cholesterol          ",
            "Điều trị đau lưng             ",
            "Tư vấn chế độ ăn uống         "});
            this.cobTenDV.Location = new System.Drawing.Point(184, 79);
            this.cobTenDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobTenDV.Name = "cobTenDV";
            this.cobTenDV.Size = new System.Drawing.Size(183, 28);
            this.cobTenDV.TabIndex = 21;
            // 
            // dateNgayDung
            // 
            this.dateNgayDung.CustomFormat = "yyyy-MM-dd";
            this.dateNgayDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDung.Location = new System.Drawing.Point(685, 81);
            this.dateNgayDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayDung.Name = "dateNgayDung";
            this.dateNgayDung.Size = new System.Drawing.Size(184, 26);
            this.dateNgayDung.TabIndex = 20;
            this.dateNgayDung.Visible = false;
            // 
            // lablNgayDung
            // 
            this.lablNgayDung.AutoSize = true;
            this.lablNgayDung.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lablNgayDung.Location = new System.Drawing.Point(562, 85);
            this.lablNgayDung.Name = "lablNgayDung";
            this.lablNgayDung.Size = new System.Drawing.Size(106, 20);
            this.lablNgayDung.TabIndex = 16;
            this.lablNgayDung.Text = "Ngày sử dụng";
            this.lablNgayDung.Visible = false;
            // 
            // txtTKTenDV
            // 
            this.txtTKTenDV.Location = new System.Drawing.Point(184, 34);
            this.txtTKTenDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTKTenDV.Name = "txtTKTenDV";
            this.txtTKTenDV.Size = new System.Drawing.Size(184, 26);
            this.txtTKTenDV.TabIndex = 36;
            this.txtTKTenDV.TextChanged += new System.EventHandler(this.txtTKTenDV_TextChanged);
            // 
            // labTenPhong
            // 
            this.labTenPhong.AutoSize = true;
            this.labTenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenPhong.Location = new System.Drawing.Point(71, 40);
            this.labTenPhong.Name = "labTenPhong";
            this.labTenPhong.Size = new System.Drawing.Size(89, 20);
            this.labTenPhong.TabIndex = 37;
            this.labTenPhong.Text = "Tên dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTKTenDV);
            this.groupBox1.Controls.Add(this.labTenPhong);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(32, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1002, 81);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.ForeColor = System.Drawing.Color.Black;
            this.btnSuaDV.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDV.Location = new System.Drawing.Point(500, 348);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(120, 39);
            this.btnSuaDV.TabIndex = 40;
            this.btnSuaDV.Text = "Cập nhật";
            this.btnSuaDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDV.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDV.Location = new System.Drawing.Point(806, 348);
            this.btnXoaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(96, 39);
            this.btnXoaDV.TabIndex = 39;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.ForeColor = System.Drawing.Color.Black;
            this.btnThemDV.Image = global::HMS_NHOM25.Properties.Resources.add2;
            this.btnThemDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDV.Location = new System.Drawing.Point(217, 348);
            this.btnThemDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(99, 39);
            this.btnThemDV.TabIndex = 38;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnSuaBNDV
            // 
            this.btnSuaBNDV.ForeColor = System.Drawing.Color.Black;
            this.btnSuaBNDV.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            this.btnSuaBNDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBNDV.Location = new System.Drawing.Point(500, 348);
            this.btnSuaBNDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaBNDV.Name = "btnSuaBNDV";
            this.btnSuaBNDV.Size = new System.Drawing.Size(120, 39);
            this.btnSuaBNDV.TabIndex = 40;
            this.btnSuaBNDV.Text = "Cập nhật";
            this.btnSuaBNDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBNDV.UseVisualStyleBackColor = true;
            this.btnSuaBNDV.Visible = false;
            this.btnSuaBNDV.Click += new System.EventHandler(this.btnSuaBNDV_Click);
            // 
            // btnXoaBNDV
            // 
            this.btnXoaBNDV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaBNDV.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnXoaBNDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBNDV.Location = new System.Drawing.Point(806, 348);
            this.btnXoaBNDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaBNDV.Name = "btnXoaBNDV";
            this.btnXoaBNDV.Size = new System.Drawing.Size(96, 39);
            this.btnXoaBNDV.TabIndex = 39;
            this.btnXoaBNDV.Text = "Xóa";
            this.btnXoaBNDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBNDV.UseVisualStyleBackColor = true;
            this.btnXoaBNDV.Visible = false;
            this.btnXoaBNDV.Click += new System.EventHandler(this.btnXoaBNDV_Click);
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(398, 28);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(263, 32);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Danh sách dịch vụ";
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1091, 844);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labAddBS);
            this.Controls.Add(this.btnSuaBNDV);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.btnXoaBNDV);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInforDichVu);
            this.Controls.Add(this.grb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DichVu";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDichVu)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInforDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label labTenBN;
        private System.Windows.Forms.Label labMaBN;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.TextBox txtTKTenDV;
        private System.Windows.Forms.Label labTenPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgayDung;
        private System.Windows.Forms.Label lablNgayDung;
        private System.Windows.Forms.Button btnSuaBNDV;
        private System.Windows.Forms.Button btnXoaBNDV;
        private System.Windows.Forms.ComboBox cobTenDV;
        private System.Windows.Forms.Label labAddBS;
    }
}