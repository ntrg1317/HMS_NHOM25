namespace HMS_NHOM25
{
    partial class ThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labTKBenhNhan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartTyLeTangTruong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTyLeTangTruong = new System.Windows.Forms.DataGridView();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTyLeTangTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyLeTangTruong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // labTKBenhNhan
            // 
            this.labTKBenhNhan.AutoSize = true;
            this.labTKBenhNhan.BackColor = System.Drawing.Color.Lavender;
            this.labTKBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTKBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTKBenhNhan.Location = new System.Drawing.Point(330, 27);
            this.labTKBenhNhan.Name = "labTKBenhNhan";
            this.labTKBenhNhan.Size = new System.Drawing.Size(284, 38);
            this.labTKBenhNhan.TabIndex = 1;
            this.labTKBenhNhan.Text = "Thống kê doanh thu";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.chartTyLeTangTruong);
            this.panel3.Controls.Add(this.dgvTyLeTangTruong);
            this.panel3.Controls.Add(this.chartDoanhThu);
            this.panel3.Controls.Add(this.dgvDoanhThu);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(4, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 1094);
            this.panel3.TabIndex = 5;
            // 
            // chartTyLeTangTruong
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Title = "Tháng";
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.Title = "Tỷ lệ tăng trưởng (%)";
            chartArea3.Name = "ChartArea1";
            this.chartTyLeTangTruong.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Far;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.chartTyLeTangTruong.Legends.Add(legend3);
            this.chartTyLeTangTruong.Location = new System.Drawing.Point(20, 789);
            this.chartTyLeTangTruong.Name = "chartTyLeTangTruong";
            this.chartTyLeTangTruong.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.HotPink;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.White;
            series3.MarkerColor = System.Drawing.Color.MediumVioletRed;
            series3.MarkerSize = 8;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series3.Name = "Tỷ lệ tăng trưởng (%)";
            this.chartTyLeTangTruong.Series.Add(series3);
            this.chartTyLeTangTruong.Size = new System.Drawing.Size(873, 293);
            this.chartTyLeTangTruong.TabIndex = 10;
            this.chartTyLeTangTruong.Text = "chartTKDauBung";
            // 
            // dgvTyLeTangTruong
            // 
            this.dgvTyLeTangTruong.AllowUserToDeleteRows = false;
            this.dgvTyLeTangTruong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTyLeTangTruong.BackgroundColor = System.Drawing.Color.White;
            this.dgvTyLeTangTruong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTyLeTangTruong.Location = new System.Drawing.Point(522, 54);
            this.dgvTyLeTangTruong.Name = "dgvTyLeTangTruong";
            this.dgvTyLeTangTruong.RowHeadersWidth = 51;
            this.dgvTyLeTangTruong.RowTemplate.Height = 24;
            this.dgvTyLeTangTruong.Size = new System.Drawing.Size(371, 356);
            this.dgvTyLeTangTruong.TabIndex = 9;
            // 
            // chartDoanhThu
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.Title = "Tháng";
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.Title = "Tổng tiền (VNĐ)";
            chartArea4.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Far;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.MaximumAutoSize = 30F;
            legend4.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend4);
            this.chartDoanhThu.Location = new System.Drawing.Point(20, 428);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.DeepPink;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Doanh thu (VNĐ)";
            this.chartDoanhThu.Series.Add(series4);
            this.chartDoanhThu.Size = new System.Drawing.Size(873, 339);
            this.chartDoanhThu.TabIndex = 8;
            this.chartDoanhThu.Text = "Số lượng bệnh nhân theo năm";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(20, 54);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(475, 356);
            this.dgvDoanhThu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(598, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thống kê doanh thu và tỷ lệ tăng trưởng doanh thu trong năm 2023 (theo thán" +
    "g) ";
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(952, 1102);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labTKBenhNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeDoanhThu";
            this.Text = "ThongKeDoanhThu";
            this.Load += new System.EventHandler(this.ThongKeDoanhThu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTyLeTangTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyLeTangTruong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTKBenhNhan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataGridView dgvTyLeTangTruong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTyLeTangTruong;
    }
}