namespace HMS_NHOM25
{
    partial class TTDanhSachDT
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
            this.ptbBS = new System.Windows.Forms.PictureBox();
            this.labAddBS = new System.Windows.Forms.Label();
            this.dgvDSDonThuoc = new System.Windows.Forms.DataGridView();
            this.btnChiTietDT = new System.Windows.Forms.Button();
            this.labDS = new System.Windows.Forms.Label();
            this.palAddBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // palAddBS
            // 
            this.palAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palAddBS.Controls.Add(this.ptbBS);
            this.palAddBS.Controls.Add(this.labAddBS);
            this.palAddBS.Location = new System.Drawing.Point(-7, 0);
            this.palAddBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palAddBS.Name = "palAddBS";
            this.palAddBS.Size = new System.Drawing.Size(1109, 124);
            this.palAddBS.TabIndex = 8;
            // 
            // ptbBS
            // 
            this.ptbBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptbBS.Image = global::HMS_NHOM25.Properties.Resources.online_pharmacy;
            this.ptbBS.Location = new System.Drawing.Point(265, 27);
            this.ptbBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbBS.Name = "ptbBS";
            this.ptbBS.Size = new System.Drawing.Size(79, 60);
            this.ptbBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBS.TabIndex = 3;
            this.ptbBS.TabStop = false;
            // 
            // labAddBS
            // 
            this.labAddBS.AutoSize = true;
            this.labAddBS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labAddBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAddBS.Location = new System.Drawing.Point(350, 32);
            this.labAddBS.Name = "labAddBS";
            this.labAddBS.Size = new System.Drawing.Size(499, 55);
            this.labAddBS.TabIndex = 0;
            this.labAddBS.Text = "Danh sách đơn thuốc";
            // 
            // dgvDSDonThuoc
            // 
            this.dgvDSDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDonThuoc.Location = new System.Drawing.Point(60, 227);
            this.dgvDSDonThuoc.Name = "dgvDSDonThuoc";
            this.dgvDSDonThuoc.RowHeadersWidth = 62;
            this.dgvDSDonThuoc.RowTemplate.Height = 28;
            this.dgvDSDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDonThuoc.Size = new System.Drawing.Size(944, 456);
            this.dgvDSDonThuoc.TabIndex = 9;
            // 
            // btnChiTietDT
            // 
            this.btnChiTietDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietDT.Image = global::HMS_NHOM25.Properties.Resources.pills;
            this.btnChiTietDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietDT.Location = new System.Drawing.Point(459, 749);
            this.btnChiTietDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChiTietDT.Name = "btnChiTietDT";
            this.btnChiTietDT.Size = new System.Drawing.Size(120, 48);
            this.btnChiTietDT.TabIndex = 26;
            this.btnChiTietDT.Text = "Chi tiết";
            this.btnChiTietDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChiTietDT.UseVisualStyleBackColor = true;
            this.btnChiTietDT.Click += new System.EventHandler(this.btnChiTietDT_Click);
            // 
            // labDS
            // 
            this.labDS.AutoSize = true;
            this.labDS.ForeColor = System.Drawing.Color.Red;
            this.labDS.Location = new System.Drawing.Point(56, 171);
            this.labDS.Name = "labDS";
            this.labDS.Size = new System.Drawing.Size(161, 20);
            this.labDS.TabIndex = 27;
            this.labDS.Text = "Danh sách đơn thuốc";
            // 
            // TTDanhSachDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 874);
            this.Controls.Add(this.labDS);
            this.Controls.Add(this.btnChiTietDT);
            this.Controls.Add(this.dgvDSDonThuoc);
            this.Controls.Add(this.palAddBS);
            this.Name = "TTDanhSachDT";
            this.Text = "TTDanhSachDT";
            this.Load += new System.EventHandler(this.TTDanhSachDT_Load);
            this.palAddBS.ResumeLayout(false);
            this.palAddBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel palAddBS;
        private System.Windows.Forms.PictureBox ptbBS;
        private System.Windows.Forms.Label labAddBS;
        private System.Windows.Forms.DataGridView dgvDSDonThuoc;
        private System.Windows.Forms.Button btnChiTietDT;
        private System.Windows.Forms.Label labDS;
    }
}