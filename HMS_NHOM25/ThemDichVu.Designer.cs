﻿namespace HMS_NHOM25
{
    partial class ThemDichVu
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
            this.btnThoatAddDichVu = new System.Windows.Forms.Button();
            this.btnSaveInfoDV = new System.Windows.Forms.Button();
            this.ptbYTe = new System.Windows.Forms.PictureBox();
            this.labAddBS = new System.Windows.Forms.Label();
            this.palAddBS = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grbAddInfoDV = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.labTenBN = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).BeginInit();
            this.palAddBS.SuspendLayout();
            this.grbAddInfoDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoatAddDichVu
            // 
            this.btnThoatAddDichVu.Image = global::HMS_NHOM25.Properties.Resources.cancel;
            this.btnThoatAddDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatAddDichVu.Location = new System.Drawing.Point(410, 322);
            this.btnThoatAddDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoatAddDichVu.Name = "btnThoatAddDichVu";
            this.btnThoatAddDichVu.Size = new System.Drawing.Size(141, 39);
            this.btnThoatAddDichVu.TabIndex = 20;
            this.btnThoatAddDichVu.Text = "Thoát";
            this.btnThoatAddDichVu.UseVisualStyleBackColor = true;
            this.btnThoatAddDichVu.Click += new System.EventHandler(this.btnThoatAddDichVu_Click);
            // 
            // btnSaveInfoDV
            // 
            this.btnSaveInfoDV.Image = global::HMS_NHOM25.Properties.Resources.floppy_disk;
            this.btnSaveInfoDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInfoDV.Location = new System.Drawing.Point(202, 322);
            this.btnSaveInfoDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfoDV.Name = "btnSaveInfoDV";
            this.btnSaveInfoDV.Size = new System.Drawing.Size(154, 39);
            this.btnSaveInfoDV.TabIndex = 19;
            this.btnSaveInfoDV.Text = "Lưu thông tin";
            this.btnSaveInfoDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveInfoDV.UseVisualStyleBackColor = true;
            this.btnSaveInfoDV.Click += new System.EventHandler(this.btnSaveInfoDV_Click);
            // 
            // ptbYTe
            // 
            this.ptbYTe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbYTe.Image = global::HMS_NHOM25.Properties.Resources.service;
            this.ptbYTe.Location = new System.Drawing.Point(224, 31);
            this.ptbYTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbYTe.Name = "ptbYTe";
            this.ptbYTe.Size = new System.Drawing.Size(94, 42);
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
            this.labAddBS.Location = new System.Drawing.Point(315, 41);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(204, 32);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Thêm Dịch Vụ";
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbYTe);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(-9, 1);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(809, 101);
            this.palAddBS.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::HMS_NHOM25.Properties.Resources.doctor;
            this.label3.Location = new System.Drawing.Point(148, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 16;
            // 
            // grbAddInfoDV
            // 
            this.grbAddInfoDV.Controls.Add(this.label4);
            this.grbAddInfoDV.Controls.Add(this.txtGiaDV);
            this.grbAddInfoDV.Controls.Add(this.label1);
            this.grbAddInfoDV.Controls.Add(this.txtTenDV);
            this.grbAddInfoDV.Controls.Add(this.labTenBN);
            this.grbAddInfoDV.ForeColor = System.Drawing.Color.Red;
            this.grbAddInfoDV.Location = new System.Drawing.Point(27, 118);
            this.grbAddInfoDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoDV.Name = "grbAddInfoDV";
            this.grbAddInfoDV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAddInfoDV.Size = new System.Drawing.Size(729, 169);
            this.grbAddInfoDV.TabIndex = 18;
            this.grbAddInfoDV.TabStop = false;
            this.grbAddInfoDV.Text = "Thông tin dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(669, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "(VNĐ)";
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(471, 74);
            this.txtGiaDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(184, 26);
            this.txtGiaDV.TabIndex = 25;
            this.txtGiaDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaDV_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(378, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Giá dịch vụ";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(144, 74);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(184, 26);
            this.txtTenDV.TabIndex = 23;
            // 
            // labTenBN
            // 
            this.labTenBN.AutoSize = true;
            this.labTenBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBN.Location = new System.Drawing.Point(20, 80);
            this.labTenBN.Name = "labTenBN";
            this.labTenBN.Size = new System.Drawing.Size(89, 20);
            this.labTenBN.TabIndex = 21;
            this.labTenBN.Text = "Tên dịch vụ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ThemDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 392);
            this.Controls.Add(this.btnThoatAddDichVu);
            this.Controls.Add(this.btnSaveInfoDV);
            this.Controls.Add(this.palAddBS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbAddInfoDV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemDichVu";
            this.Load += new System.EventHandler(this.AddDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbYTe)).EndInit();
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            this.grbAddInfoDV.ResumeLayout(false);
            this.grbAddInfoDV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoatAddDichVu;
        private System.Windows.Forms.Button btnSaveInfoDV;
        private System.Windows.Forms.PictureBox ptbYTe;
        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbAddInfoDV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label labTenBN;
    }
}