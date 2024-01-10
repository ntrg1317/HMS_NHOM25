namespace HMS_NHOM25
{
    partial class ThongKeHoaDon_ThanhToan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartLuotSDPhong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvLuotSDPhong = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuotSDPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuotSDPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thống kê hóa đơn và thanh toán";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.chartLuotSDPhong);
            this.panel3.Controls.Add(this.dgvLuotSDPhong);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(4, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 813);
            this.panel3.TabIndex = 5;
            // 
            // chartLuotSDPhong
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "Ngày";
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.Title = "Lượt sử dụng";
            chartArea2.Name = "ChartArea1";
            this.chartLuotSDPhong.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLuotSDPhong.Legends.Add(legend2);
            this.chartLuotSDPhong.Location = new System.Drawing.Point(20, 320);
            this.chartLuotSDPhong.Name = "chartLuotSDPhong";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.EmptyPointStyle.BorderWidth = 6;
            series2.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.MidnightBlue;
            series2.MarkerColor = System.Drawing.Color.RoyalBlue;
            series2.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series2.Name = "Bệnh nhân";
            this.chartLuotSDPhong.Series.Add(series2);
            this.chartLuotSDPhong.Size = new System.Drawing.Size(873, 464);
            this.chartLuotSDPhong.TabIndex = 8;
            this.chartLuotSDPhong.Text = "Số lượng bệnh nhân theo năm";
            // 
            // dgvLuotSDPhong
            // 
            this.dgvLuotSDPhong.AllowUserToAddRows = false;
            this.dgvLuotSDPhong.AllowUserToDeleteRows = false;
            this.dgvLuotSDPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuotSDPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvLuotSDPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuotSDPhong.Location = new System.Drawing.Point(20, 54);
            this.dgvLuotSDPhong.Name = "dgvLuotSDPhong";
            this.dgvLuotSDPhong.ReadOnly = true;
            this.dgvLuotSDPhong.RowHeadersWidth = 51;
            this.dgvLuotSDPhong.RowTemplate.Height = 24;
            this.dgvLuotSDPhong.Size = new System.Drawing.Size(873, 249);
            this.dgvLuotSDPhong.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thống kê lượt sử dụng phòng tháng 1/2024";
            // 
            // ThongKeHoaDon_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeHoaDon_ThanhToan";
            this.Text = "ThongKeHoaDon_ThanhToan";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuotSDPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuotSDPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLuotSDPhong;
        private System.Windows.Forms.DataGridView dgvLuotSDPhong;
        private System.Windows.Forms.Label label4;
    }
}