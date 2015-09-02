namespace ClothUI.clothManager
{
    partial class SaleChart
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
            this.pal_chart = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pal_top = new System.Windows.Forms.Panel();
            this.cbo_year = new System.Windows.Forms.ComboBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.btn_money = new System.Windows.Forms.Button();
            this.btn_number = new System.Windows.Forms.Button();
            this.pal_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.pal_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_chart
            // 
            this.pal_chart.Controls.Add(this.chart);
            this.pal_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_chart.Location = new System.Drawing.Point(0, 35);
            this.pal_chart.Name = "pal_chart";
            this.pal_chart.Size = new System.Drawing.Size(736, 407);
            this.pal_chart.TabIndex = 3;
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
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "员工基本工资";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(736, 407);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // pal_top
            // 
            this.pal_top.Controls.Add(this.btn_number);
            this.pal_top.Controls.Add(this.btn_money);
            this.pal_top.Controls.Add(this.cbo_year);
            this.pal_top.Controls.Add(this.lbl_year);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(736, 35);
            this.pal_top.TabIndex = 2;
            // 
            // cbo_year
            // 
            this.cbo_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_year.FormattingEnabled = true;
            this.cbo_year.Location = new System.Drawing.Point(54, 10);
            this.cbo_year.Name = "cbo_year";
            this.cbo_year.Size = new System.Drawing.Size(121, 20);
            this.cbo_year.TabIndex = 1;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(13, 13);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(35, 12);
            this.lbl_year.TabIndex = 0;
            this.lbl_year.Text = "年份:";
            // 
            // btn_money
            // 
            this.btn_money.Location = new System.Drawing.Point(182, 8);
            this.btn_money.Name = "btn_money";
            this.btn_money.Size = new System.Drawing.Size(75, 23);
            this.btn_money.TabIndex = 2;
            this.btn_money.Text = "销售额";
            this.btn_money.UseVisualStyleBackColor = true;
            this.btn_money.Click += new System.EventHandler(this.btn_monry_Click);
            // 
            // btn_number
            // 
            this.btn_number.Location = new System.Drawing.Point(263, 8);
            this.btn_number.Name = "btn_number";
            this.btn_number.Size = new System.Drawing.Size(75, 23);
            this.btn_number.TabIndex = 3;
            this.btn_number.Text = "销售量";
            this.btn_number.UseVisualStyleBackColor = true;
            this.btn_number.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // SaleChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 442);
            this.Controls.Add(this.pal_chart);
            this.Controls.Add(this.pal_top);
            this.Name = "SaleChart";
            this.Text = "SaleChart";
            this.Load += new System.EventHandler(this.SaleChart_Load);
            this.pal_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.ComboBox cbo_year;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Button btn_number;
        private System.Windows.Forms.Button btn_money;
    }
}