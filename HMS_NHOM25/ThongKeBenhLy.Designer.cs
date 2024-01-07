namespace HMS_NHOM25
{
    partial class ThongKeBenhLy
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartTKLoaiBenh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.chartTKDauCo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCacLoaiBenh = new System.Windows.Forms.DataGridView();
            this.dgvDauDauNam = new System.Windows.Forms.DataGridView();
            this.dgvDauCo2023 = new System.Windows.Forms.DataGridView();
            this.chartTKDauDau = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKLoaiBenh)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDauCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacLoaiBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDauDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauDauNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauCo2023)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDauDau)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thống kê bệnh lý";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.dgvCacLoaiBenh);
            this.panel3.Controls.Add(this.chartTKLoaiBenh);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(5, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(709, 366);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // chartTKLoaiBenh
            // 
            this.chartTKLoaiBenh.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chartTKLoaiBenh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chartTKLoaiBenh.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTKLoaiBenh.Legends.Add(legend1);
            this.chartTKLoaiBenh.Location = new System.Drawing.Point(234, 54);
            this.chartTKLoaiBenh.Name = "chartTKLoaiBenh";
            this.chartTKLoaiBenh.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Bệnh nhân";
            series1.ShadowColor = System.Drawing.Color.DarkGray;
            this.chartTKLoaiBenh.Series.Add(series1);
            this.chartTKLoaiBenh.Size = new System.Drawing.Size(448, 300);
            this.chartTKLoaiBenh.TabIndex = 4;
            this.chartTKLoaiBenh.Text = "chartTKLoaiBenh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thống kê các loại bệnh ";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.dgvDauCo2023);
            this.panel4.Controls.Add(this.dgvDauDauNam);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.chartTKDauCo);
            this.panel4.Controls.Add(this.chartTKDauDau);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(5, 463);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(709, 584);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thống kê số bệnh nhân đau cơ năm 2023 (theo tháng)";
            // 
            // chartTKDauCo
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chartTKDauCo.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 13.48837F;
            legend2.Position.Width = 27.96421F;
            legend2.Position.X = 72.0358F;
            legend2.Position.Y = 5F;
            this.chartTKDauCo.Legends.Add(legend2);
            this.chartTKDauCo.Location = new System.Drawing.Point(234, 343);
            this.chartTKDauCo.Name = "chartTKDauCo";
            this.chartTKDauCo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerColor = System.Drawing.Color.Purple;
            series2.MarkerSize = 6;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Bệnh nhân";
            this.chartTKDauCo.Series.Add(series2);
            this.chartTKDauCo.Size = new System.Drawing.Size(448, 216);
            this.chartTKDauCo.TabIndex = 5;
            this.chartTKDauCo.Text = "chartTKDauBung";
            // 
            this.label6.Location = new System.Drawing.Point(382, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thống kê số bệnh nhân đau cơ theo tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(483, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thống kê số bệnh nhân đau đầu theo năm (giai đoạn 2020-2024)";
            // 
            // dgvCacLoaiBenh
            // 
            this.dgvCacLoaiBenh.AllowUserToAddRows = false;
            this.dgvCacLoaiBenh.AllowUserToDeleteRows = false;
            this.dgvCacLoaiBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCacLoaiBenh.BackgroundColor = System.Drawing.Color.White;
            this.dgvCacLoaiBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCacLoaiBenh.Location = new System.Drawing.Point(20, 54);
            this.dgvCacLoaiBenh.Name = "dgvCacLoaiBenh";
            this.dgvCacLoaiBenh.ReadOnly = true;
            this.dgvCacLoaiBenh.RowHeadersWidth = 51;
            this.dgvCacLoaiBenh.RowTemplate.Height = 24;
            this.dgvCacLoaiBenh.Size = new System.Drawing.Size(199, 300);
            this.dgvCacLoaiBenh.TabIndex = 7;
            // 
            // chartTKDauDau
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.Name = "ChartArea1";
            this.chartTKDauDau.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            legend3.Position.Auto = false;
            legend3.Position.Height = 13.48837F;
            legend3.Position.Width = 27.96421F;
            legend3.Position.X = 72.0358F;
            legend3.Position.Y = 5F;
            this.chartTKDauDau.Legends.Add(legend3);
            this.chartTKDauDau.Location = new System.Drawing.Point(234, 51);
            this.chartTKDauDau.Name = "chartTKDauDau";
            this.chartTKDauDau.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Purple;
            series3.MarkerSize = 6;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Bệnh nhân";
            this.chartTKDauDau.Series.Add(series3);
            this.chartTKDauDau.Size = new System.Drawing.Size(448, 216);
            this.chartTKDauDau.TabIndex = 4;
            this.chartTKDauDau.Text = "chartTKDauBung";
            // 
            // dgvDauDauNam
            // 
            this.dgvDauDauNam.AllowUserToAddRows = false;
            this.dgvDauDauNam.AllowUserToDeleteRows = false;
            this.dgvDauDauNam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDauDauNam.BackgroundColor = System.Drawing.Color.White;
            this.dgvDauDauNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauDauNam.Location = new System.Drawing.Point(20, 51);
            this.dgvDauDauNam.Name = "dgvDauDauNam";
            this.dgvDauDauNam.ReadOnly = true;
            this.dgvDauDauNam.RowHeadersWidth = 51;
            this.dgvDauDauNam.RowTemplate.Height = 24;
            this.dgvDauDauNam.Size = new System.Drawing.Size(199, 216);
            this.dgvDauDauNam.TabIndex = 8;
            // 
            // dgvDauCo2023
            // 
            this.dgvDauCo2023.AllowUserToAddRows = false;
            this.dgvDauCo2023.AllowUserToDeleteRows = false;
            this.dgvDauCo2023.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDauCo2023.BackgroundColor = System.Drawing.Color.White;
            this.dgvDauCo2023.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauCo2023.Location = new System.Drawing.Point(20, 343);
            this.dgvDauCo2023.Name = "dgvDauCo2023";
            this.dgvDauCo2023.ReadOnly = true;
            this.dgvDauCo2023.RowHeadersWidth = 51;
            this.dgvDauCo2023.RowTemplate.Height = 24;
            this.dgvDauCo2023.Size = new System.Drawing.Size(199, 216);
            this.dgvDauCo2023.TabIndex = 9;
            this.label5.Location = new System.Drawing.Point(31, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thống kê số bệnh nhân đau đầu theo năm";
            // 
            // ThongKeBenhLy
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(726, 1102);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeBenhLy";
            this.Load += new System.EventHandler(this.ThongKeBenhLy_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKLoaiBenh)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDauCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacLoaiBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDauDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauDauNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauCo2023)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDauDau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSLBN2023;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource soLuongBNtheoNamBindingSource;
        private System.Windows.Forms.BindingSource hMSDataSet2BindingSource;
        private System.Windows.Forms.Label labTKBenhNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKLoaiBenh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKDauCo;
        private System.Windows.Forms.DataGridView dgvCacLoaiBenh;
        private System.Windows.Forms.DataGridView dgvDauCo2023;
        private System.Windows.Forms.DataGridView dgvDauDauNam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKDauDau;
    }
}