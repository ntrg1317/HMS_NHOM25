namespace HMS_NHOM25
{
    partial class AddThuoc
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
            this.components = new System.ComponentModel.Container();
            this.labAddBS = new System.Windows.Forms.Label();
            this.palAddBS = new System.Windows.Forms.Panel();
            this.ptbYTe = new System.Windows.Forms.PictureBox();
            this.grbAddInfoThuocM = new System.Windows.Forms.GroupBox();
            this.dateNSX = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuongThuocM = new System.Windows.Forms.TextBox();
            this.labSDTNVYTeM = new System.Windows.Forms.Label();
            this.txtTenThuocM = new System.Windows.Forms.TextBox();
            this.labNSX = new System.Windows.Forms.Label();
            this.labTenThuocM = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThoatAddThuoc = new System.Windows.Forms.Button();
            this.btnSaveInfoThuoc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateHSD = new System.Windows.Forms.DateTimePicker();
            this.labHSD = new System.Windows.Forms.Label();
            this.txtGiaThuocM = new System.Windows.Forms.TextBox();
            this.labGiaThuocM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.palAddBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).BeginInit();
            this.grbAddInfoThuocM.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(320, 32);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(191, 36);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Thêm Thuốc";
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbYTe);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(-6, 0);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(809, 101);
            this.palAddBS.TabIndex = 4;
            // 
            // ptbYTe
            // 
            this.ptbYTe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbYTe.Image = global::HMS_NHOM25.Properties.Resources.medicine;
            this.ptbYTe.Location = new System.Drawing.Point(233, 22);
            this.ptbYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbYTe.Name = "ptbYTe";
            this.ptbYTe.Size = new System.Drawing.Size(93, 43);
            this.ptbYTe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbYTe.TabIndex = 3;
            this.ptbYTe.TabStop = false;
            // 
            // grbAddInfoThuocM
            // 
            this.grbAddInfoThuocM.Controls.Add(this.label1);
            this.grbAddInfoThuocM.Controls.Add(this.txtGiaThuocM);
            this.grbAddInfoThuocM.Controls.Add(this.labGiaThuocM);
            this.grbAddInfoThuocM.Controls.Add(this.dateHSD);
            this.grbAddInfoThuocM.Controls.Add(this.labHSD);
            this.grbAddInfoThuocM.Controls.Add(this.dateNSX);
            this.grbAddInfoThuocM.Controls.Add(this.txtSoLuongThuocM);
            this.grbAddInfoThuocM.Controls.Add(this.labSDTNVYTeM);
            this.grbAddInfoThuocM.Controls.Add(this.txtTenThuocM);
            this.grbAddInfoThuocM.Controls.Add(this.labNSX);
            this.grbAddInfoThuocM.Controls.Add(this.labTenThuocM);
            this.grbAddInfoThuocM.ForeColor = System.Drawing.Color.Red;
            this.grbAddInfoThuocM.Location = new System.Drawing.Point(30, 125);
            this.grbAddInfoThuocM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoThuocM.Name = "grbAddInfoThuocM";
            this.grbAddInfoThuocM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoThuocM.Size = new System.Drawing.Size(729, 217);
            this.grbAddInfoThuocM.TabIndex = 5;
            this.grbAddInfoThuocM.TabStop = false;
            this.grbAddInfoThuocM.Text = "Thông tin thuốc mới";
            // 
            // dateNSX
            // 
            this.dateNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNSX.Location = new System.Drawing.Point(161, 101);
            this.dateNSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNSX.Name = "dateNSX";
            this.dateNSX.Size = new System.Drawing.Size(152, 26);
            this.dateNSX.TabIndex = 12;
            // 
            // txtSoLuongThuocM
            // 
            this.txtSoLuongThuocM.Location = new System.Drawing.Point(530, 39);
            this.txtSoLuongThuocM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongThuocM.Name = "txtSoLuongThuocM";
            this.txtSoLuongThuocM.Size = new System.Drawing.Size(154, 26);
            this.txtSoLuongThuocM.TabIndex = 9;
            // 
            // labSDTNVYTeM
            // 
            this.labSDTNVYTeM.AutoSize = true;
            this.labSDTNVYTeM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labSDTNVYTeM.Location = new System.Drawing.Point(409, 42);
            this.labSDTNVYTeM.Name = "labSDTNVYTeM";
            this.labSDTNVYTeM.Size = new System.Drawing.Size(72, 20);
            this.labSDTNVYTeM.TabIndex = 4;
            this.labSDTNVYTeM.Text = "Số lượng";
            // 
            // txtTenThuocM
            // 
            this.txtTenThuocM.Location = new System.Drawing.Point(160, 36);
            this.txtTenThuocM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenThuocM.Name = "txtTenThuocM";
            this.txtTenThuocM.Size = new System.Drawing.Size(154, 26);
            this.txtTenThuocM.TabIndex = 3;
            // 
            // labNSX
            // 
            this.labNSX.AutoSize = true;
            this.labNSX.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labNSX.Location = new System.Drawing.Point(35, 107);
            this.labNSX.Name = "labNSX";
            this.labNSX.Size = new System.Drawing.Size(42, 20);
            this.labNSX.TabIndex = 2;
            this.labNSX.Text = "NSX";
            // 
            // labTenThuocM
            // 
            this.labTenThuocM.AutoSize = true;
            this.labTenThuocM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenThuocM.Location = new System.Drawing.Point(34, 42);
            this.labTenThuocM.Name = "labTenThuocM";
            this.labTenThuocM.Size = new System.Drawing.Size(80, 20);
            this.labTenThuocM.TabIndex = 1;
            this.labTenThuocM.Text = "Tên thuốc";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnThoatAddThuoc
            // 
            this.btnThoatAddThuoc.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            this.btnThoatAddThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddThuoc.Location = new System.Drawing.Point(443, 363);
            this.btnThoatAddThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddThuoc.Name = "btnThoatAddThuoc";
            this.btnThoatAddThuoc.Size = new System.Drawing.Size(141, 39);
            this.btnThoatAddThuoc.TabIndex = 9;
            this.btnThoatAddThuoc.Text = "Thoát";
            this.btnThoatAddThuoc.UseVisualStyleBackColor = true;
            // 
            // btnSaveInfoThuoc
            // 
            this.btnSaveInfoThuoc.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveInfoThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInfoThuoc.Location = new System.Drawing.Point(190, 363);
            this.btnSaveInfoThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfoThuoc.Name = "btnSaveInfoThuoc";
            this.btnSaveInfoThuoc.Size = new System.Drawing.Size(154, 39);
            this.btnSaveInfoThuoc.TabIndex = 8;
            this.btnSaveInfoThuoc.Text = "Lưu thông tin";
            this.btnSaveInfoThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInfoThuoc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::HMS_NHOM25.Properties.Resources.doctor;
            this.label3.Location = new System.Drawing.Point(151, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // dateHSD
            // 
            this.dateHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHSD.Location = new System.Drawing.Point(530, 101);
            this.dateHSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateHSD.Name = "dateHSD";
            this.dateHSD.Size = new System.Drawing.Size(152, 26);
            this.dateHSD.TabIndex = 14;
            // 
            // labHSD
            // 
            this.labHSD.AutoSize = true;
            this.labHSD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labHSD.Location = new System.Drawing.Point(409, 107);
            this.labHSD.Name = "labHSD";
            this.labHSD.Size = new System.Drawing.Size(44, 20);
            this.labHSD.TabIndex = 13;
            this.labHSD.Text = "HSD";
            // 
            // txtGiaThuocM
            // 
            this.txtGiaThuocM.Location = new System.Drawing.Point(161, 161);
            this.txtGiaThuocM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaThuocM.Name = "txtGiaThuocM";
            this.txtGiaThuocM.Size = new System.Drawing.Size(154, 26);
            this.txtGiaThuocM.TabIndex = 16;
            // 
            // labGiaThuocM
            // 
            this.labGiaThuocM.AutoSize = true;
            this.labGiaThuocM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labGiaThuocM.Location = new System.Drawing.Point(33, 167);
            this.labGiaThuocM.Name = "labGiaThuocM";
            this.labGiaThuocM.Size = new System.Drawing.Size(78, 20);
            this.labGiaThuocM.TabIndex = 15;
            this.labGiaThuocM.Text = "Giá thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(321, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "(VNĐ)";
            // 
            // AddThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 430);
            this.Controls.Add(this.btnThoatAddThuoc);
            this.Controls.Add(this.btnSaveInfoThuoc);
            this.Controls.Add(this.grbAddInfoThuocM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.palAddBS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNVYTe";
            this.Load += new System.EventHandler(this.AddThuoc_Load);
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).EndInit();
            this.grbAddInfoThuocM.ResumeLayout(false);
            this.grbAddInfoThuocM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbYTe;
        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.GroupBox grbAddInfoThuocM;
        private System.Windows.Forms.Label labNSX;
        private System.Windows.Forms.Label labTenThuocM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTenThuocM;
        private System.Windows.Forms.Label labSDTNVYTeM;
        private System.Windows.Forms.DateTimePicker dateNSX;
        private System.Windows.Forms.TextBox txtSoLuongThuocM;
        private System.Windows.Forms.Button btnSaveInfoThuoc;
        private System.Windows.Forms.Button btnThoatAddThuoc;
        private System.Windows.Forms.DateTimePicker dateHSD;
        private System.Windows.Forms.Label labHSD;
        private System.Windows.Forms.TextBox txtGiaThuocM;
        private System.Windows.Forms.Label labGiaThuocM;
        private System.Windows.Forms.Label label1;
    }
}