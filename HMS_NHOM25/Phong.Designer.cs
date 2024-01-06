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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phong));
            this.dgvInforPhong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grb = new System.Windows.Forms.GroupBox();
            this.cobTenPhong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtSoLuongPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.labTenBN = new System.Windows.Forms.Label();
            this.labMaBN = new System.Windows.Forms.Label();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.txtTKTenPhong = new System.Windows.Forms.TextBox();
            this.labTenPhong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforPhong)).BeginInit();
            this.grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInforPhong
            // 
            this.dgvInforPhong.AllowUserToAddRows = false;
            this.dgvInforPhong.AllowUserToDeleteRows = false;
            this.dgvInforPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInforPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvInforPhong, "dgvInforPhong");
            this.dgvInforPhong.Name = "dgvInforPhong";
            this.dgvInforPhong.ReadOnly = true;
            this.dgvInforPhong.RowTemplate.Height = 24;
            this.dgvInforPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInforPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInforPhong_CellClick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // grb
            // 
            this.grb.Controls.Add(this.cobTenPhong);
            this.grb.Controls.Add(this.label4);
            this.grb.Controls.Add(this.txtGiaPhong);
            this.grb.Controls.Add(this.txtSoLuongPhong);
            this.grb.Controls.Add(this.label1);
            this.grb.Controls.Add(this.label3);
            this.grb.Controls.Add(this.txtMaPhong);
            this.grb.Controls.Add(this.labTenBN);
            this.grb.Controls.Add(this.labMaBN);
            this.grb.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.grb, "grb");
            this.grb.Name = "grb";
            this.grb.TabStop = false;
            // 
            // cobTenPhong
            // 
            this.cobTenPhong.FormattingEnabled = true;
            this.cobTenPhong.Items.AddRange(new object[] {
            resources.GetString("cobTenPhong.Items"),
            resources.GetString("cobTenPhong.Items1"),
            resources.GetString("cobTenPhong.Items2"),
            resources.GetString("cobTenPhong.Items3"),
            resources.GetString("cobTenPhong.Items4"),
            resources.GetString("cobTenPhong.Items5"),
            resources.GetString("cobTenPhong.Items6"),
            resources.GetString("cobTenPhong.Items7"),
            resources.GetString("cobTenPhong.Items8"),
            resources.GetString("cobTenPhong.Items9")});
            resources.ApplyResources(this.cobTenPhong, "cobTenPhong");
            this.cobTenPhong.Name = "cobTenPhong";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Name = "label4";
            // 
            // txtGiaPhong
            // 
            resources.ApplyResources(this.txtGiaPhong, "txtGiaPhong");
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaPhong_KeyPress);
            // 
            // txtSoLuongPhong
            // 
            resources.ApplyResources(this.txtSoLuongPhong, "txtSoLuongPhong");
            this.txtSoLuongPhong.Name = "txtSoLuongPhong";
            this.txtSoLuongPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongPhong_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Name = "label3";
            // 
            // txtMaPhong
            // 
            resources.ApplyResources(this.txtMaPhong, "txtMaPhong");
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            // 
            // labTenBN
            // 
            resources.ApplyResources(this.labTenBN, "labTenBN");
            this.labTenBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenBN.Name = "labTenBN";
            // 
            // labMaBN
            // 
            resources.ApplyResources(this.labMaBN, "labMaBN");
            this.labMaBN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labMaBN.Name = "labMaBN";
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.ForeColor = System.Drawing.Color.Black;
            this.btnSuaPhong.Image = global::HMS_NHOM25.Properties.Resources.revision__1_;
            resources.ApplyResources(this.btnSuaPhong, "btnSuaPhong");
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPhong.Image = global::HMS_NHOM25.Properties.Resources.cross__1_;
            resources.ApplyResources(this.btnXoaPhong, "btnXoaPhong");
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.ForeColor = System.Drawing.Color.Black;
            this.btnThemPhong.Image = global::HMS_NHOM25.Properties.Resources.add1;
            resources.ApplyResources(this.btnThemPhong, "btnThemPhong");
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // txtTKTenPhong
            // 
            resources.ApplyResources(this.txtTKTenPhong, "txtTKTenPhong");
            this.txtTKTenPhong.Name = "txtTKTenPhong";
            this.txtTKTenPhong.TextChanged += new System.EventHandler(this.txtTKTenPhong_TextChanged);
            // 
            // labTenPhong
            // 
            resources.ApplyResources(this.labTenPhong, "labTenPhong");
            this.labTenPhong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labTenPhong.Name = "labTenPhong";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Name = "label5";
            // 
            // Phong
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSuaPhong);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.txtTKTenPhong);
            this.Controls.Add(this.labTenPhong);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInforPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforPhong)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInforPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtSoLuongPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label labTenBN;
        private System.Windows.Forms.Label labMaBN;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.TextBox txtTKTenPhong;
        private System.Windows.Forms.Label labTenPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cobTenPhong;
    }
}