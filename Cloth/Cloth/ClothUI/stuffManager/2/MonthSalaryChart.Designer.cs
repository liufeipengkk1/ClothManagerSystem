namespace ClothUI.stuffManager._2
{
    partial class MonthSalaryChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthSalaryChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pal_top = new System.Windows.Forms.Panel();
            this.pal_chart = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cbo_year = new System.Windows.Forms.ComboBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pal_top.SuspendLayout();
            this.pal_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.Controls.Add(this.btn_ok);
            this.pal_top.Controls.Add(this.cbo_year);
            this.pal_top.Controls.Add(this.lbl_year);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(736, 35);
            this.pal_top.TabIndex = 0;
            // 
            // pal_chart
            // 
            this.pal_chart.Controls.Add(this.chart);
            this.pal_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_chart.Location = new System.Drawing.Point(0, 35);
            this.pal_chart.Name = "pal_chart";
            this.pal_chart.Size = new System.Drawing.Size(736, 407);
            this.pal_chart.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.Location = new System.Drawing.Point(175, 7);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(33, 23);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // cbo_year
            // 
            this.cbo_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_year.FormattingEnabled = true;
            this.cbo_year.Location = new System.Drawing.Point(48, 9);
            this.cbo_year.Name = "cbo_year";
            this.cbo_year.Size = new System.Drawing.Size(121, 20);
            this.cbo_year.TabIndex = 6;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(7, 12);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(35, 12);
            this.lbl_year.TabIndex = 5;
            this.lbl_year.Text = "年份:";
            // 
            // chart
            // 
            chartArea1.Name = "员工工资";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.ChartArea = "员工工资";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "基本工资";
            series2.ChartArea = "员工工资";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "提成";
            series3.ChartArea = "员工工资";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "总工资";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(736, 407);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // MonthSalaryChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 442);
            this.Controls.Add(this.pal_chart);
            this.Controls.Add(this.pal_top);
            this.Name = "MonthSalaryChart";
            this.Text = "MonthSalaryChart";
            this.Load += new System.EventHandler(this.MonthSalaryChart_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.pal_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Panel pal_chart;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ComboBox cbo_year;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}