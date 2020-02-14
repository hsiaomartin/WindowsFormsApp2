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
        private bool serialPort_is_open = false;
        private int curValue = 0;
        private int label_counter = 0;
        private int num = 5;//每次刪除增加幾個點
        private delegate void InvokeUpdateState(string state);
        public Form1()
        {
            InitializeComponent();
            InitChart();

        }
        private void myButtonClicked(object sender, EventArgs e)
        {
            this.timer1.Start();

        }
        private void labelChange(object sender, EventArgs e) {   //label click event
            label_counter += 1;
         //  label1. Text = label_counter.ToString();
          //  label1.Text = this.timer1.Interval.ToString();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateQueueValue();
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataQueue.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue.ElementAt(i));

            }
                label_counter += this.timer1.Interval;
                label1.Text = label_counter.ToString() + "ms";            
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
            series1.ChartType = SeriesChartType.Line;
            this.chart1.Series.Add(series1);
            //設定圖表顯示樣式
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 40;
            this.chart1.ChartAreas[0].AxisX.Interval = 1;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //設定標題
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "顯示";
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //設定圖表顯示樣式
            this.chart1.Series[0].Color = Color.Red;
            if (rb1.Checked)
            {
                this.chart1.Titles[0].Text = string.Format(" {0} 顯示", rb1.Text);
                this.chart1.Series[0].ChartType = SeriesChartType.Line;

            }
            if (rb2.Checked)
            {
                this.chart1.Titles[0].Text = string.Format(" {0} 顯示", rb2.Text);
                this.chart1.Series[0].ChartType = SeriesChartType.Spline;
            }
            this.chart1.Series[0].Points.Clear();
        }

        private void UpdateQueueValue()
        {

            if (dataQueue.Count > 100)
            {
                //先出列
                for (int i = 0; i < num; i++)
                {
                    dataQueue.Dequeue();
                }
            }
            if (rb1.Checked)
            {
                this.chart1.Titles[0].Text = string.Format(" {0} 顯示", rb1.Text);
                Random r = new Random();
                for (int i = 0; i < num; i++)
                {
                    dataQueue.Enqueue(r.Next(0, 100));
                }

            }
            if (rb2.Checked)
            {
                this.chart1.Titles[0].Text = string.Format(" {0} 顯示", rb2.Text);
                for (int i = 0; i < num; i++)
                {
                    //對curValue只取[0,360]之間的值
                    curValue = curValue % 360;
                    //對得到的正弦值，放大50倍，並上移50
                    dataQueue.Enqueue((50 * Math.Sin(curValue * Math.PI / 180)) + 50);
                    curValue = curValue + 10;
                }
            }




            if (temp_radioButton.Checked) {
                this.chart1.Titles[0].Text = string.Format("{0}顯示","溫度");
                string indata = mySerialPort.ReadLine();
               // string RegularExpressions = "^(([0-9]+\\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\\.[0-9]+)|([0-9]*[1-9][0-9]*))$";


                Invoke(new Action<string>(
                    (s) =>
                    {
                       
                     //   if (indata == RegularExpressions)
                      //  {
                            float indata_r = float.Parse(s);
                            for (int i = 0; i < num; i++)
                            {
                                dataQueue.Enqueue(indata_r);
                            }
                      //  }
                    }
                    ), indata);
                }
            

        }

            private void mySerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {


            //SerialPort sp = (SerialPort)sender;
            //string indata = sp.ReadExisting();
            string indata = mySerialPort.ReadLine() ;
            //string RegularExpressions = "^(([0-9]+\\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\\.[0-9]+)|([0-9]*[1-9][0-9]*))$";
            //textBox1.Text = indata;
            Invoke(new Action<string>(
                    (s) =>
                    {    //if (indata== RegularExpressions)
                        // {
                                serialPort_textBox.Text += s + " °C\r\n";

                                serialPort_textBox.SelectionStart = serialPort_textBox.Text.Length;

                                serialPort_textBox.ScrollToCaret();
                       // }
                    }
                ), indata);
            




        }

        private void serialPort_button_Click(object sender, EventArgs e)
        {
            if (!serialPort_is_open)
            {
                serialPort_is_open = true;
                serialPort_button.Text = "Serial Close";
                this.mySerialPort.Open();

                temp_radioButton.Enabled = true;
            }
            else
            {
                serialPort_is_open = false;
                serialPort_button.Text = "Serial Open";
                this.mySerialPort.Close();
                rb1.Checked = true;
                temp_radioButton.Checked = false;
                temp_radioButton.Enabled = false;
            }
                
        }
    }



}
