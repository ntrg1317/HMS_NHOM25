using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThongKeDuLieu : Form
    {
        public ThongKeDuLieu()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        Func<ChartPoint, string> labelPoint = ChartPoint => string.Format("{0 ({1:P})", ChartPoint.Y, ChartPoint.Participation);
        

        private void btnLoad_Click(object sender, EventArgs e, PieChart pieChart)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in _DataThongKe1_.Revenue)
                series.Add(new PieSeries() { Title = obj.Năm.ToString(), Values = new ChartValues<int> 
                { obj.Tổng_doanh_thu }, DataLabels = true, LabelPoint =  labelPoint});
            pieChart1.Series = series;

        }
    }
}
