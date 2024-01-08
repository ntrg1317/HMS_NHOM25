namespace HMS_NHOM25
{
    partial class ThongKeBenhNhan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labTKBenhNhan = new System.Windows.Forms.Label();
            this.chartSLBNtheoNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.benhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benhNhanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soLuongBNtheoNamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSLBNtheoNam = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chartSLBN2024 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSLBN2024 = new System.Windows.Forms.DataGridView();
            this.dgvSLBN2023 = new System.Windows.Forms.DataGridView();
            this.labSLBN2023 = new System.Windows.Forms.Label();
            this.chartSLBN2023 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSLBNtheoNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongBNtheoNamBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLBNtheoNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSLBN2024)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLBN2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLBN2023)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSLBN2023)).BeginInit();
            this.SuspendLayout();
            // 
            // labTKBenhNhan
            // 
            this.labTKBenhNhan.AutoSize = true;
            this.labTKBenhNhan.BackColor = System.Drawing.Color.Lavender;
            this.labTKBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTKBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTKBenhNhan.Location = new System.Drawing.Point(311, 27);
            this.labTKBenhNhan.Name = "labTKBenhNhan";
            this.labTKBenhNhan.Size = new System.Drawing.Size(292, 38);
            this.labTKBenhNhan.TabIndex = 0;
            this.labTKBenhNhan.Text = "Thống kê bệnh nhân";
            this.labTKBenhNhan.Click += new System.EventHandler(this.labTKBenhNhan_Click);
            // 
            // chartSLBNtheoNam
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.Title = "Năm";
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.Title = "Số lượng";
            chartArea4.Name = "ChartArea1";
            this.chartSLBNtheoNam.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Far;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Name = "Legend1";
            legend4.Position.Auto = false;
            legend4.Position.Height = 9.698997F;
            legend4.Position.Width = 21.96836F;
            legend4.Position.X = 77.03163F;
            legend4.Position.Y = 8F;
            this.chartSLBNtheoNam.Legends.Add(legend4);
            this.chartSLBNtheoNam.Location = new System.Drawing.Point(332, 70);
            this.chartSLBNtheoNam.Name = "chartSLBNtheoNam";
            this.chartSLBNtheoNam.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Bệnh nhân";
            this.chartSLBNtheoNam.Series.Add(series4);
            this.chartSLBNtheoNam.Size = new System.Drawing.Size(570, 300);
            this.chartSLBNtheoNam.TabIndex = 3;
            this.chartSLBNtheoNam.Text = "Số lượng bệnh nhân theo năm";
            this.chartSLBNtheoNam.Click += new System.EventHandler(this.chartSLBNtheoNam_Click);
            // 
            // benhNhanBindingSource
            // 
            this.benhNhanBindingSource.DataMember = "benhNhan";
            this.benhNhanBindingSource.CurrentChanged += new System.EventHandler(this.benhNhanBindingSource_CurrentChanged);
            // 
            // benhNhanBindingSource1
            // 
            this.benhNhanBindingSource1.DataMember = "benhNhan";
            this.benhNhanBindingSource1.CurrentChanged += new System.EventHandler(this.benhNhanBindingSource1_CurrentChanged);
            // 
            // hMSDataSet2BindingSource
            // 
            this.hMSDataSet2BindingSource.CurrentChanged += new System.EventHandler(this.hMSDataSet2BindingSource_CurrentChanged);
            // 
            // soLuongBNtheoNamBindingSource
            // 
            this.soLuongBNtheoNamBindingSource.DataMember = "SoLuongBNtheoNam";
            this.soLuongBNtheoNamBindingSource.CurrentChanged += new System.EventHandler(this.soLuongBNtheoNamBindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng bệnh nhân theo năm (giai đoạn 2021-2024)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.dgvSLBNtheoNam);
            this.panel1.Controls.Add(this.chartSLBNtheoNam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 386);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvSLBNtheoNam
            // 
            this.dgvSLBNtheoNam.AllowUserToAddRows = false;
            this.dgvSLBNtheoNam.AllowUserToDeleteRows = false;
            this.dgvSLBNtheoNam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSLBNtheoNam.BackgroundColor = System.Drawing.Color.White;
            this.dgvSLBNtheoNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSLBNtheoNam.Location = new System.Drawing.Point(23, 70);
            this.dgvSLBNtheoNam.Name = "dgvSLBNtheoNam";
            this.dgvSLBNtheoNam.ReadOnly = true;
            this.dgvSLBNtheoNam.RowHeadersWidth = 51;
            this.dgvSLBNtheoNam.RowTemplate.Height = 24;
            this.dgvSLBNtheoNam.Size = new System.Drawing.Size(293, 300);
            this.dgvSLBNtheoNam.TabIndex = 6;
            this.dgvSLBNtheoNam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSLBNtheoNam_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng bệnh nhân năm 2022 (theo tháng)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chartSLBN2024
            // 
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.Title = "Tháng";
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.Title = "Số lượng";
            chartArea5.Name = "ChartArea1";
            this.chartSLBN2024.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            legend5.Position.Auto = false;
            legend5.Position.Height = 12.5F;
            legend5.Position.Width = 21.96836F;
            legend5.Position.X = 77.03163F;
            legend5.Position.Y = 3F;
            this.chartSLBN2024.Legends.Add(legend5);
            this.chartSLBN2024.Location = new System.Drawing.Point(332, 27);
            this.chartSLBN2024.Name = "chartSLBN2024";
            this.chartSLBN2024.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Bệnh nhân";
            this.chartSLBN2024.Series.Add(series5);
            this.chartSLBN2024.Size = new System.Drawing.Size(570, 233);
            this.chartSLBN2024.TabIndex = 9;
            this.chartSLBN2024.Text = "Số lượng bệnh nhân theo năm";
            this.chartSLBN2024.Click += new System.EventHandler(this.chartSLBN2024_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.dgvSLBN2024);
            this.panel2.Controls.Add(this.dgvSLBN2023);
            this.panel2.Controls.Add(this.labSLBN2023);
            this.panel2.Controls.Add(this.chartSLBN2023);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chartSLBN2024);
            this.panel2.Location = new System.Drawing.Point(4, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 596);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvSLBN2024
            // 
            this.dgvSLBN2024.AllowUserToAddRows = false;
            this.dgvSLBN2024.AllowUserToDeleteRows = false;
            this.dgvSLBN2024.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSLBN2024.BackgroundColor = System.Drawing.Color.White;
            this.dgvSLBN2024.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSLBN2024.Location = new System.Drawing.Point(23, 27);
            this.dgvSLBN2024.Name = "dgvSLBN2024";
            this.dgvSLBN2024.ReadOnly = true;
            this.dgvSLBN2024.RowHeadersWidth = 51;
            this.dgvSLBN2024.RowTemplate.Height = 24;
            this.dgvSLBN2024.Size = new System.Drawing.Size(293, 233);
            this.dgvSLBN2024.TabIndex = 14;
            // 
            // dgvSLBN2023
            // 
            this.dgvSLBN2023.AllowUserToAddRows = false;
            this.dgvSLBN2023.AllowUserToDeleteRows = false;
            this.dgvSLBN2023.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSLBN2023.BackgroundColor = System.Drawing.Color.White;
            this.dgvSLBN2023.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSLBN2023.Location = new System.Drawing.Point(23, 326);
            this.dgvSLBN2023.Name = "dgvSLBN2023";
            this.dgvSLBN2023.ReadOnly = true;
            this.dgvSLBN2023.RowHeadersWidth = 51;
            this.dgvSLBN2023.RowTemplate.Height = 24;
            this.dgvSLBN2023.Size = new System.Drawing.Size(293, 212);
            this.dgvSLBN2023.TabIndex = 13;
            this.dgvSLBN2023.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSLBN2023_CellContentClick);
            // 
            // labSLBN2023
            // 
            this.labSLBN2023.AutoSize = true;
            this.labSLBN2023.BackColor = System.Drawing.Color.LavenderBlush;
            this.labSLBN2023.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSLBN2023.Location = new System.Drawing.Point(272, 553);
            this.labSLBN2023.Name = "labSLBN2023";
            this.labSLBN2023.Size = new System.Drawing.Size(330, 17);
            this.labSLBN2023.TabIndex = 12;
            this.labSLBN2023.Text = "Số lượng bệnh nhân năm 2023 (theo tháng) ";
            this.labSLBN2023.Click += new System.EventHandler(this.labSLBN2023_Click);
            // 
            // chartSLBN2023
            // 
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.Title = "Tháng";
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.AxisY.Title = "Số lượng";
            chartArea6.Name = "ChartArea1";
            this.chartSLBN2023.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            legend6.Position.Auto = false;
            legend6.Position.Height = 13.74408F;
            legend6.Position.Width = 21.96836F;
            legend6.Position.X = 77.03163F;
            legend6.Position.Y = 3F;
            this.chartSLBN2023.Legends.Add(legend6);
            this.chartSLBN2023.Location = new System.Drawing.Point(332, 326);
            this.chartSLBN2023.Name = "chartSLBN2023";
            this.chartSLBN2023.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Bệnh nhân";
            this.chartSLBN2023.Series.Add(series6);
            this.chartSLBN2023.Size = new System.Drawing.Size(570, 212);
            this.chartSLBN2023.TabIndex = 11;
            this.chartSLBN2023.Text = "Số lượng bệnh nhân theo năm";
            this.chartSLBN2023.Click += new System.EventHandler(this.chartSLBN2023_Click);
            // 
            // ThongKeBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(952, 1102);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labTKBenhNhan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeBenhNhan";
            this.Text = "ThongKeBenhNhan";
            this.Load += new System.EventHandler(this.ThongKeBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSLBNtheoNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongBNtheoNamBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLBNtheoNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSLBN2024)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLBN2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLBN2023)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSLBN2023)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTKBenhNhan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSLBNtheoNam;
        private System.Windows.Forms.BindingSource benhNhanBindingSource;
        private System.Windows.Forms.BindingSource benhNhanBindingSource1;
        private System.Windows.Forms.BindingSource hMSDataSet2BindingSource;
        private System.Windows.Forms.BindingSource soLuongBNtheoNamBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSLBN2024;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labSLBN2023;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSLBN2023;
        private System.Windows.Forms.DataGridView dgvSLBNtheoNam;
        private System.Windows.Forms.DataGridView dgvSLBN2024;
        private System.Windows.Forms.DataGridView dgvSLBN2023;
    }
}