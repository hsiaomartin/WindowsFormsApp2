using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Queue<double> dataQueue = new Queue<double>(100);

        private int curValue = 0;

        private int num = 5;//每次刪除增加幾個點
        public Form1()
        {
            InitializeComponent();
        }
        private void myButtonClicked(object sender, EventArgs e)
        {
            InitChart();

        }
        private void InitChart()
        {
            //定義圖表區域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定義儲存和顯示點的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("S1");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            //設定圖表顯示樣式
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 100;
            this.chart1.ChartAreas[0].AxisX.Interval = 5;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //設定標題
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "XXX顯示";
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //設定圖表顯示樣式
            this.chart1.Series[0].Color = Color.Red;

            this.chart1.Series[0].Points.Clear();
        }


    }



}
