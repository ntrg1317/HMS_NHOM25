namespace HMS_NHOM25
{
    partial class ThongKeThuoc
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSuDungThuoc = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.chartSuDungThuoc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDungThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuDungThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thống kê thuốc";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.chartSuDungThuoc);
            this.panel3.Controls.Add(this.dgvSuDungThuoc);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(4, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 813);
            this.panel3.TabIndex = 5;
            // 
            // dgvSuDungThuoc
            // 
            this.dgvSuDungThuoc.AllowUserToAddRows = false;
            this.dgvSuDungThuoc.AllowUserToDeleteRows = false;
            this.dgvSuDungThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuDungThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuDungThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuDungThuoc.Location = new System.Drawing.Point(20, 54);
            this.dgvSuDungThuoc.Name = "dgvSuDungThuoc";
            this.dgvSuDungThuoc.ReadOnly = true;
            this.dgvSuDungThuoc.RowHeadersWidth = 51;
            this.dgvSuDungThuoc.RowTemplate.Height = 24;
            this.dgvSuDungThuoc.Size = new System.Drawing.Size(272, 354);
            this.dgvSuDungThuoc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thống kê 8 loại thuốc được sử dụng nhiều nhất";
            // 
            // chartSuDungThuoc
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Năm";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Title = "Số lượng";
            chartArea1.Name = "ChartArea1";
            this.chartSuDungThuoc.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 9.698997F;
            legend1.Position.Width = 21.96836F;
            legend1.Position.X = 77.03163F;
            legend1.Position.Y = 8F;
            this.chartSuDungThuoc.Legends.Add(legend1);
            this.chartSuDungThuoc.Location = new System.Drawing.Point(310, 54);
            this.chartSuDungThuoc.Name = "chartSuDungThuoc";
            this.chartSuDungThuoc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Thuốc";
            this.chartSuDungThuoc.Series.Add(series1);
            this.chartSuDungThuoc.Size = new System.Drawing.Size(581, 354);
            this.chartSuDungThuoc.TabIndex = 8;
            this.chartSuDungThuoc.Text = "Số lượng bệnh nhân theo năm";
            // 
            // ThongKeThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 953);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeThuoc";
            this.Text = "ThongKeThuoc";
            this.Load += new System.EventHandler(this.ThongKeThuoc_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDungThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuDungThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSuDungThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSuDungThuoc;
    }
}