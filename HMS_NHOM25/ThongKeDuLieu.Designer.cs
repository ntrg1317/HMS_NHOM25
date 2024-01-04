namespace HMS_NHOM25
{
    partial class ThongKeDuLieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.revenueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.nămDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tôngDoanhThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataThongKe1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DataThongKe1_ = new HMS_NHOM25._DataThongKe1_();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataThongKe1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataThongKe1_)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nămDataGridViewTextBoxColumn,
            this.tôngDoanhThuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.revenueBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(342, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(362, 196);
            this.dataGridView1.TabIndex = 1;
            // 
            // revenueBindingSource1
            // 
            this.revenueBindingSource1.DataMember = "Revenue";
            this.revenueBindingSource1.DataSource = this.dataThongKe1BindingSource;
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataMember = "Revenue";
            this.revenueBindingSource.DataSource = this.dataThongKe1BindingSource;
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.GhostWhite;
            this.pieChart1.Location = new System.Drawing.Point(12, 50);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pieChart1.Size = new System.Drawing.Size(301, 228);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.Text = "Biểu đồ doanh thu theo năm";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(342, 189);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 30);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // nămDataGridViewTextBoxColumn
            // 
            this.nămDataGridViewTextBoxColumn.DataPropertyName = "Năm";
            this.nămDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.nămDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nămDataGridViewTextBoxColumn.Name = "nămDataGridViewTextBoxColumn";
            this.nămDataGridViewTextBoxColumn.Width = 125;
            // 
            // tôngDoanhThuDataGridViewTextBoxColumn
            // 
            this.tôngDoanhThuDataGridViewTextBoxColumn.DataPropertyName = "Tổng doanh thu";
            this.tôngDoanhThuDataGridViewTextBoxColumn.HeaderText = "Tổng doanh thu";
            this.tôngDoanhThuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tôngDoanhThuDataGridViewTextBoxColumn.Name = "tôngDoanhThuDataGridViewTextBoxColumn";
            this.tôngDoanhThuDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataThongKe1BindingSource
            // 
            this.dataThongKe1BindingSource.DataSource = this._DataThongKe1_;
            this.dataThongKe1BindingSource.Position = 0;
            // 
            // _DataThongKe1_
            // 
            this._DataThongKe1_.DataSetName = "DataThongKe1\'";
            this._DataThongKe1_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThongKeDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 558);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeDuLieu";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataThongKe1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DataThongKe1_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nămDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tôngDoanhThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private System.Windows.Forms.BindingSource dataThongKe1BindingSource;
        private _DataThongKe1_ _DataThongKe1_;
        private System.Windows.Forms.BindingSource revenueBindingSource1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Button btnLoad;
    }
}