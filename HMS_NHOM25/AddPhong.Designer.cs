namespace HMS_NHOM25
{
    partial class AddPhong
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbAddInfoNVYTeM = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtSoLuongPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labTenBN = new System.Windows.Forms.Label();
            this.palAddBS = new System.Windows.Forms.Panel();
            this.ptbYTe = new System.Windows.Forms.PictureBox();
            this.labAddBS = new System.Windows.Forms.Label();
            this.btnThoatAddPhong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveInfoPhong = new System.Windows.Forms.Button();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.grbAddInfoNVYTeM.SuspendLayout();
            this.palAddBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbAddInfoNVYTeM
            // 
            this.grbAddInfoNVYTeM.Controls.Add(this.txtTenPhong);
            this.grbAddInfoNVYTeM.Controls.Add(this.label4);
            this.grbAddInfoNVYTeM.Controls.Add(this.txtGiaPhong);
            this.grbAddInfoNVYTeM.Controls.Add(this.txtSoLuongPhong);
            this.grbAddInfoNVYTeM.Controls.Add(this.label1);
            this.grbAddInfoNVYTeM.Controls.Add(this.label2);
            this.grbAddInfoNVYTeM.Controls.Add(this.labTenBN);
            this.grbAddInfoNVYTeM.ForeColor = System.Drawing.Color.Red;
            this.grbAddInfoNVYTeM.Location = new System.Drawing.Point(32, 84);
            this.grbAddInfoNVYTeM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoNVYTeM.Name = "grbAddInfoNVYTeM";
            this.grbAddInfoNVYTeM.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoNVYTeM.Size = new System.Drawing.Size(729, 194);
            this.grbAddInfoNVYTeM.TabIndex = 12;
            this.grbAddInfoNVYTeM.TabStop = false;
            this.grbAddInfoNVYTeM.Text = "Thông tin phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(336, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "(VNĐ)";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(145, 114);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(184, 26);
            this.txtGiaPhong.TabIndex = 27;
            this.txtGiaPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaPhong_KeyPress);
            // 
            // txtSoLuongPhong
            // 
            this.txtSoLuongPhong.Location = new System.Drawing.Point(478, 59);
            this.txtSoLuongPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongPhong.Name = "txtSoLuongPhong";
            this.txtSoLuongPhong.Size = new System.Drawing.Size(184, 26);
            this.txtSoLuongPhong.TabIndex = 26;
            this.txtSoLuongPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongPhong_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(40, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Giá phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(379, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Số lượng";
            // 
            // labTenBN
            // 
            this.labTenBN.AutoSize = true;
            this.labTenBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBN.Location = new System.Drawing.Point(40, 62);
            this.labTenBN.Name = "labTenBN";
            this.labTenBN.Size = new System.Drawing.Size(85, 20);
            this.labTenBN.TabIndex = 21;
            this.labTenBN.Text = "Tên phòng";
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbYTe);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(-4, -32);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(809, 101);
            this.palAddBS.TabIndex = 11;
            // 
            // ptbYTe
            // 
            this.ptbYTe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbYTe.Image = global::HMS_NHOM25.Properties.Resources.hotel__1_;
            this.ptbYTe.Location = new System.Drawing.Point(237, 41);
            this.ptbYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbYTe.Name = "ptbYTe";
            this.ptbYTe.Size = new System.Drawing.Size(91, 32);
            this.ptbYTe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbYTe.TabIndex = 3;
            this.ptbYTe.TabStop = false;
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(324, 41);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(186, 32);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Thêm Phòng";
            // 
            // btnThoatAddPhong
            // 
            this.btnThoatAddPhong.Image = global::HMS_NHOM25.Properties.Resources.cancel;
            this.btnThoatAddPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddPhong.Location = new System.Drawing.Point(415, 312);
            this.btnThoatAddPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddPhong.Name = "btnThoatAddPhong";
            this.btnThoatAddPhong.Size = new System.Drawing.Size(141, 39);
            this.btnThoatAddPhong.TabIndex = 15;
            this.btnThoatAddPhong.Text = "Thoát";
            this.btnThoatAddPhong.UseVisualStyleBackColor = true;
            this.btnThoatAddPhong.Click += new System.EventHandler(this.btnThoatAddPhong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::HMS_NHOM25.Properties.Resources.doctor;
            this.label3.Location = new System.Drawing.Point(153, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 10;
            // 
            // btnSaveInfoPhong
            // 
            this.btnSaveInfoPhong.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveInfoPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInfoPhong.Location = new System.Drawing.Point(208, 312);
            this.btnSaveInfoPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfoPhong.Name = "btnSaveInfoPhong";
            this.btnSaveInfoPhong.Size = new System.Drawing.Size(154, 39);
            this.btnSaveInfoPhong.TabIndex = 14;
            this.btnSaveInfoPhong.Text = "Lưu thông tin";
            this.btnSaveInfoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInfoPhong.UseVisualStyleBackColor = true;
            this.btnSaveInfoPhong.Click += new System.EventHandler(this.btnSaveInfoPhong_Click);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(145, 59);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(184, 26);
            this.txtTenPhong.TabIndex = 29;
            // 
            // AddPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 385);
            this.Controls.Add(this.btnThoatAddPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveInfoPhong);
            this.Controls.Add(this.grbAddInfoNVYTeM);
            this.Controls.Add(this.palAddBS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPhong";
            this.Load += new System.EventHandler(this.AddPhong_Load);
            this.grbAddInfoNVYTeM.ResumeLayout(false);
            this.grbAddInfoNVYTeM.PerformLayout();
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoatAddPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSaveInfoPhong;
        private System.Windows.Forms.GroupBox grbAddInfoNVYTeM;
        private System.Windows.Forms.PictureBox ptbYTe;
        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtSoLuongPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTenBN;
        private System.Windows.Forms.TextBox txtTenPhong;
    }
}