using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace StackerBarChart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.Series["Series1"].IsVisibleInLegend = false; // 圖例說明
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Color = Color.FromArgb(255, 255, 0, 0);
            chart1.Series["Series1"].IsVisibleInLegend = false; // 圖例說明
            chart1.Series["Series1"].ShadowOffset = 3; // SHADOW
            chart1.Series["Series1"].ShadowColor = Color.FromArgb(100, 0, 0, 200);

            chart1.Series.Add("Series2");
            chart1.Series["Series2"].Color = Color.FromArgb(255, 0, 255, 0);
            chart1.Series["Series2"].IsVisibleInLegend = false;
            chart1.Series["Series2"].ShadowOffset = 3;
            chart1.Series["Series2"].ShadowColor = Color.FromArgb(100, 0, 0, 200);

            chart1.Series.Add("Series3");
            chart1.Series["Series3"].Color = Color.FromArgb(255, 0, 0, 100);
            chart1.Series["Series3"].IsVisibleInLegend = false;
            chart1.Series["Series3"].ShadowOffset = 3;
            chart1.Series["Series3"].ShadowColor = Color.FromArgb(100, 0, 0, 200);

            // SeriesChartType
            // https://docs.microsoft.com/zh-tw/dotnet/api/system.windows.forms.datavisualization.charting.seriescharttype?view=netframework-4.8
            chart1.Series["Series1"].ChartType = SeriesChartType.StackedColumn100;
            chart1.Series["Series2"].ChartType = SeriesChartType.StackedColumn100;
            chart1.Series["Series3"].ChartType = SeriesChartType.StackedColumn100;

            //
            chart1.Series["Series1"].Points.AddXY("Slot#1", 100);
            chart1.Series["Series2"].Points.AddXY("Slot#1", 100);
            chart1.Series["Series3"].Points.AddXY("Slot#1", 0);

            chart1.Series["Series1"].Points.AddXY("Slot#2", 10);
            chart1.Series["Series2"].Points.AddXY("Slot#2", 90);
            chart1.Series["Series3"].Points.AddXY("Slot#2", 20);
        }
    }
}
