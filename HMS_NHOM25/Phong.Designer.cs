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
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.labTenPhong = new System.Windows.Forms.Label();
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.dgvDanhMucPhong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.txtTenPhong);
            this.grbTimKiem.Controls.Add(this.labTenPhong);
            this.grbTimKiem.Controls.Add(this.btnTimKiemPhong);
            this.grbTimKiem.ForeColor = System.Drawing.Color.Red;
            this.grbTimKiem.Location = new System.Drawing.Point(31, 12);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(927, 67);
            this.grbTimKiem.TabIndex = 29;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(134, 24);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(164, 22);
            this.txtTenPhong.TabIndex = 29;
            // 
            // labTenPhong
            // 
            this.labTenPhong.AutoSize = true;
            this.labTenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenPhong.Location = new System.Drawing.Point(33, 29);
            this.labTenPhong.Name = "labTenPhong";
            this.labTenPhong.Size = new System.Drawing.Size(72, 16);
            this.labTenPhong.TabIndex = 30;
            this.labTenPhong.Text = "Tên phòng";
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.Image = global::HMS_NHOM25.Properties.Resources.find__1_;
            this.btnTimKiemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPhong.Location = new System.Drawing.Point(400, 18);
            this.btnTimKiemPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(104, 35);
            this.btnTimKiemPhong.TabIndex = 28;
            this.btnTimKiemPhong.Text = "Tìm kiếm";
            this.btnTimKiemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPhong.UseVisualStyleBackColor = true;
            // 
            // dgvDanhMucPhong
            // 
            this.dgvDanhMucPhong.AllowUserToAddRows = false;
            this.dgvDanhMucPhong.AllowUserToDeleteRows = false;
            this.dgvDanhMucPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucPhong.Location = new System.Drawing.Point(31, 136);
            this.dgvDanhMucPhong.Name = "dgvDanhMucPhong";
            this.dgvDanhMucPhong.ReadOnly = true;
            this.dgvDanhMucPhong.RowHeadersWidth = 51;
            this.dgvDanhMucPhong.RowTemplate.Height = 24;
            this.dgvDanhMucPhong.Size = new System.Drawing.Size(901, 524);
            this.dgvDanhMucPhong.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Danh sách phòng";
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 683);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDanhMucPhong);
            this.Controls.Add(this.grbTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phong";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label labTenPhong;
        private System.Windows.Forms.DataGridView dgvDanhMucPhong;
        private System.Windows.Forms.Label label2;
    }
}