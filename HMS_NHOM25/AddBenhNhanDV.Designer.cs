namespace HMS_NHOM25
{
    partial class AddBenhNhanDV
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
            this.palAddBS = new System.Windows.Forms.Panel();
            this.labAddBS = new System.Windows.Forms.Label();
            this.grbAddInfoDV = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labTenBN = new System.Windows.Forms.Label();
            this.cobTenDV = new System.Windows.Forms.ComboBox();
            this.dateNgayDV = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbYTe = new System.Windows.Forms.PictureBox();
            this.btnThoatAddBNDichVu = new System.Windows.Forms.Button();
            this.btnSaveBNDV = new System.Windows.Forms.Button();
            this.palAddBS.SuspendLayout();
            this.grbAddInfoDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).BeginInit();
            this.SuspendLayout();
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbYTe);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(0, 0);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(719, 81);
            this.palAddBS.TabIndex = 21;
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(263, 26);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(282, 29);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Thêm Dịch Vụ Sử Dụng";
            // 
            // grbAddInfoDV
            // 
            this.grbAddInfoDV.Controls.Add(this.dateNgayDV);
            this.grbAddInfoDV.Controls.Add(this.cobTenDV);
            this.grbAddInfoDV.Controls.Add(this.label4);
            this.grbAddInfoDV.Controls.Add(this.txtGiaDV);
            this.grbAddInfoDV.Controls.Add(this.label1);
            this.grbAddInfoDV.Controls.Add(this.label2);
            this.grbAddInfoDV.Controls.Add(this.labTenBN);
            this.grbAddInfoDV.ForeColor = System.Drawing.Color.Red;
            this.grbAddInfoDV.Location = new System.Drawing.Point(30, 85);
            this.grbAddInfoDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoDV.Name = "grbAddInfoDV";
            this.grbAddInfoDV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoDV.Size = new System.Drawing.Size(648, 175);
            this.grbAddInfoDV.TabIndex = 22;
            this.grbAddInfoDV.TabStop = false;
            this.grbAddInfoDV.Text = "Thông tin dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(595, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "(VNĐ)";
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(419, 59);
            this.txtGiaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(164, 22);
            this.txtGiaDV.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(336, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Giá dịch vụ";
            // 
            // labTenBN
            // 
            this.labTenBN.AutoSize = true;
            this.labTenBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBN.Location = new System.Drawing.Point(18, 64);
            this.labTenBN.Name = "labTenBN";
            this.labTenBN.Size = new System.Drawing.Size(76, 16);
            this.labTenBN.TabIndex = 21;
            this.labTenBN.Text = "Tên dịch vụ";
            // 
            // cobTenDV
            // 
            this.cobTenDV.FormattingEnabled = true;
            this.cobTenDV.Location = new System.Drawing.Point(115, 59);
            this.cobTenDV.Name = "cobTenDV";
            this.cobTenDV.Size = new System.Drawing.Size(174, 24);
            this.cobTenDV.TabIndex = 27;
            // 
            // dateNgayDV
            // 
            this.dateNgayDV.CustomFormat = "yyyy-MM-dd";
            this.dateNgayDV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDV.Location = new System.Drawing.Point(115, 108);
            this.dateNgayDV.Name = "dateNgayDV";
            this.dateNgayDV.Size = new System.Drawing.Size(174, 22);
            this.dateNgayDV.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ngày sử dụng";
            // 
            // ptbYTe
            // 
            this.ptbYTe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbYTe.Image = global::HMS_NHOM25.Properties.Resources.service;
            this.ptbYTe.Location = new System.Drawing.Point(167, 23);
            this.ptbYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbYTe.Name = "ptbYTe";
            this.ptbYTe.Size = new System.Drawing.Size(84, 34);
            this.ptbYTe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbYTe.TabIndex = 3;
            this.ptbYTe.TabStop = false;
            // 
            // btnThoatAddBNDichVu
            // 
            this.btnThoatAddBNDichVu.Image = global::HMS_NHOM25.Properties.Resources.cancel;
            this.btnThoatAddBNDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddBNDichVu.Location = new System.Drawing.Point(381, 303);
            this.btnThoatAddBNDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddBNDichVu.Name = "btnThoatAddBNDichVu";
            this.btnThoatAddBNDichVu.Size = new System.Drawing.Size(125, 31);
            this.btnThoatAddBNDichVu.TabIndex = 24;
            this.btnThoatAddBNDichVu.Text = "Thoát";
            this.btnThoatAddBNDichVu.UseVisualStyleBackColor = true;
            // 
            // btnSaveBNDV
            // 
            this.btnSaveBNDV.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveBNDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveBNDV.Location = new System.Drawing.Point(197, 303);
            this.btnSaveBNDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveBNDV.Name = "btnSaveBNDV";
            this.btnSaveBNDV.Size = new System.Drawing.Size(137, 31);
            this.btnSaveBNDV.TabIndex = 23;
            this.btnSaveBNDV.Text = "Lưu thông tin";
            this.btnSaveBNDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveBNDV.UseVisualStyleBackColor = true;
            // 
            // AddBenhNhanDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 373);
            this.Controls.Add(this.palAddBS);
            this.Controls.Add(this.btnThoatAddBNDichVu);
            this.Controls.Add(this.btnSaveBNDV);
            this.Controls.Add(this.grbAddInfoDV);
            this.Name = "AddBenhNhanDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBenhNhanDV";
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            this.grbAddInfoDV.ResumeLayout(false);
            this.grbAddInfoDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.PictureBox ptbYTe;
        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.Button btnThoatAddBNDichVu;
        private System.Windows.Forms.Button btnSaveBNDV;
        private System.Windows.Forms.GroupBox grbAddInfoDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTenBN;
        private System.Windows.Forms.DateTimePicker dateNgayDV;
        private System.Windows.Forms.ComboBox cobTenDV;
        private System.Windows.Forms.Label label2;
    }
}