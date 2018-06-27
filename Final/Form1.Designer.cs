namespace Final
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(39, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1028, 556);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button5);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.comboBox2);
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.checkedListBox2);
			this.tabPage1.Controls.Add(this.checkedListBox1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.textBox3);
			this.tabPage1.Controls.Add(this.textBox2);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1020, 527);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "首頁";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(253, 357);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(92, 59);
			this.button5.TabIndex = 14;
			this.button5.Text = "刪除飲料";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(253, 281);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(92, 59);
			this.button4.TabIndex = 13;
			this.button4.Text = "刪除食物";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(58, 376);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(151, 23);
			this.comboBox2.TabIndex = 12;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(58, 300);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(151, 23);
			this.comboBox1.TabIndex = 11;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(811, 446);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(103, 30);
			this.button3.TabIndex = 10;
			this.button3.Text = "決定飲料";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(632, 446);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 30);
			this.button2.TabIndex = 9;
			this.button2.Text = "決定食物";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkedListBox2
			// 
			this.checkedListBox2.FormattingEnabled = true;
			this.checkedListBox2.Location = new System.Drawing.Point(547, 236);
			this.checkedListBox2.Name = "checkedListBox2";
			this.checkedListBox2.Size = new System.Drawing.Size(451, 164);
			this.checkedListBox2.TabIndex = 8;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(547, 14);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(451, 184);
			this.checkedListBox1.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(265, 45);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(198, 160);
			this.button1.TabIndex = 6;
			this.button1.Text = "新增資料";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(134, 180);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 25);
			this.textBox3.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(134, 118);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 25);
			this.textBox2.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.textBox1.Location = new System.Drawing.Point(134, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 25);
			this.textBox1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "屬性(F/D):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "價位:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "名稱:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1020, 527);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "資料表";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(6, 284);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 27;
			this.dataGridView2.Size = new System.Drawing.Size(1008, 228);
			this.dataGridView2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(1008, 262);
			this.dataGridView1.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.chart2);
			this.tabPage3.Controls.Add(this.chart1);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1020, 527);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "飲食紀錄";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// chart2
			// 
			chartArea1.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart2.Legends.Add(legend1);
			this.chart2.Location = new System.Drawing.Point(518, 15);
			this.chart2.Name = "chart2";
			this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series1.Legend = "Legend1";
			series1.Name = "Frequency2";
			this.chart2.Series.Add(series1);
			this.chart2.Size = new System.Drawing.Size(475, 477);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart2";
			// 
			// chart1
			// 
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(26, 15);
			this.chart1.Name = "chart1";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series2.Legend = "Legend1";
			series2.Name = "Frequency1";
			series2.XValueMember = "Id";
			series2.YValueMembers = "Price";
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(456, 477);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.chart3);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1020, 527);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "開銷紀錄";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// chart3
			// 
			chartArea3.AxisX.Interval = 1D;
			chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
			chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
			chartArea3.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart3.Legends.Add(legend3);
			this.chart3.Location = new System.Drawing.Point(3, 16);
			this.chart3.Name = "chart3";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series3.Legend = "Legend1";
			series3.MarkerColor = System.Drawing.Color.Red;
			series3.MarkerSize = 15;
			series3.Name = "kane";
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series3.YValuesPerPoint = 6;
			this.chart3.Series.Add(series3);
			this.chart3.Size = new System.Drawing.Size(986, 491);
			this.chart3.TabIndex = 0;
			this.chart3.Text = "chart3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1079, 608);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
	}
}

