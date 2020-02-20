namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.myBtn = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_textBox = new System.Windows.Forms.TextBox();
            this.serialPort_button = new System.Windows.Forms.Button();
            this.temp_radioButton = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(2, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(579, 346);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "myChart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.labelChange);
            // 
            // myBtn
            // 
            this.myBtn.Location = new System.Drawing.Point(340, 415);
            this.myBtn.Name = "myBtn";
            this.myBtn.Size = new System.Drawing.Size(75, 23);
            this.myBtn.TabIndex = 4;
            this.myBtn.Text = "Time Start";
            this.myBtn.UseVisualStyleBackColor = true;
            this.myBtn.Click += new System.EventHandler(this.myButtonClicked);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(481, 376);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(62, 16);
            this.rb1.TabIndex = 5;
            this.rb1.TabStop = true;
            this.rb1.Text = "ramdom";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(481, 398);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(36, 16);
            this.rb2.TabIndex = 6;
            this.rb2.TabStop = true;
            this.rb2.Text = "sin";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mySerialPort
            // 
            this.mySerialPort.PortName = "COM8";
            // 
            // serialPort_textBox
            // 
            this.serialPort_textBox.Location = new System.Drawing.Point(13, 375);
            this.serialPort_textBox.Multiline = true;
            this.serialPort_textBox.Name = "serialPort_textBox";
            this.serialPort_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serialPort_textBox.Size = new System.Drawing.Size(153, 63);
            this.serialPort_textBox.TabIndex = 8;
            // 
            // serialPort_button
            // 
            this.serialPort_button.Location = new System.Drawing.Point(172, 415);
            this.serialPort_button.Name = "serialPort_button";
            this.serialPort_button.Size = new System.Drawing.Size(75, 23);
            this.serialPort_button.TabIndex = 9;
            this.serialPort_button.Text = "Serial Open";
            this.serialPort_button.UseVisualStyleBackColor = true;
            this.serialPort_button.Click += new System.EventHandler(this.serialPort_button_Click);
            // 
            // temp_radioButton
            // 
            this.temp_radioButton.AutoSize = true;
            this.temp_radioButton.Enabled = false;
            this.temp_radioButton.Location = new System.Drawing.Point(481, 420);
            this.temp_radioButton.Name = "temp_radioButton";
            this.temp_radioButton.Size = new System.Drawing.Size(82, 16);
            this.temp_radioButton.TabIndex = 10;
            this.temp_radioButton.TabStop = true;
            this.temp_radioButton.Text = "Temperature";
            this.temp_radioButton.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(587, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(687, 346);
            this.cartesianChart1.TabIndex = 11;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 450);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.temp_radioButton);
            this.Controls.Add(this.serialPort_button);
            this.Controls.Add(this.serialPort_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.myBtn);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "myForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button myBtn;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.TextBox serialPort_textBox;
        private System.Windows.Forms.Button serialPort_button;
        private System.Windows.Forms.RadioButton temp_radioButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}

