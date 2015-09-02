namespace ClothUI.stuffManager._2
{
    partial class SalaryMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryMgr));
            this.pal_top = new System.Windows.Forms.Panel();
            this.btn_chart = new System.Windows.Forms.Button();
            this.cbx_month = new System.Windows.Forms.ComboBox();
            this.cbx_year = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_seach = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.pal_bottom = new System.Windows.Forms.Panel();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.list_data = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Alter = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Chart = new System.Windows.Forms.ToolStripMenuItem();
            this.pal_top.SuspendLayout();
            this.pal_fill.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pal_top.Controls.Add(this.btn_chart);
            this.pal_top.Controls.Add(this.cbx_month);
            this.pal_top.Controls.Add(this.cbx_year);
            this.pal_top.Controls.Add(this.txt_search);
            this.pal_top.Controls.Add(this.lbl_seach);
            this.pal_top.Controls.Add(this.btn_search);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(861, 45);
            this.pal_top.TabIndex = 0;
            // 
            // btn_chart
            // 
            this.btn_chart.Location = new System.Drawing.Point(627, 18);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new System.Drawing.Size(89, 23);
            this.btn_chart.TabIndex = 15;
            this.btn_chart.Text = "员工工资曲线";
            this.btn_chart.UseVisualStyleBackColor = true;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // cbx_month
            // 
            this.cbx_month.FormattingEnabled = true;
            this.cbx_month.Location = new System.Drawing.Point(498, 20);
            this.cbx_month.Name = "cbx_month";
            this.cbx_month.Size = new System.Drawing.Size(76, 20);
            this.cbx_month.TabIndex = 14;
            // 
            // cbx_year
            // 
            this.cbx_year.FormattingEnabled = true;
            this.cbx_year.Location = new System.Drawing.Point(416, 20);
            this.cbx_year.Name = "cbx_year";
            this.cbx_year.Size = new System.Drawing.Size(76, 20);
            this.cbx_year.TabIndex = 13;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(185, 20);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(224, 21);
            this.txt_search.TabIndex = 11;
            // 
            // lbl_seach
            // 
            this.lbl_seach.AutoSize = true;
            this.lbl_seach.Location = new System.Drawing.Point(12, 23);
            this.lbl_seach.Name = "lbl_seach";
            this.lbl_seach.Size = new System.Drawing.Size(167, 12);
            this.lbl_seach.TabIndex = 10;
            this.lbl_seach.Text = "可输入员工信息进行模糊查询:";
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(589, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 23);
            this.btn_search.TabIndex = 12;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pal_bottom
            // 
            this.pal_bottom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pal_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_bottom.Location = new System.Drawing.Point(0, 389);
            this.pal_bottom.Name = "pal_bottom";
            this.pal_bottom.Size = new System.Drawing.Size(861, 24);
            this.pal_bottom.TabIndex = 1;
            // 
            // pal_fill
            // 
            this.pal_fill.Controls.Add(this.list_data);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 45);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(861, 344);
            this.pal_fill.TabIndex = 2;
            // 
            // list_data
            // 
            this.list_data.ContextMenuStrip = this.contextMenuStrip;
            this.list_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_data.FullRowSelect = true;
            this.list_data.GridLines = true;
            this.list_data.Location = new System.Drawing.Point(0, 0);
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(861, 344);
            this.list_data.TabIndex = 0;
            this.list_data.UseCompatibleStateImageBehavior = false;
            this.list_data.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Alter,
            this.ToolStripMenuItem_Chart});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 48);
            // 
            // ToolStripMenuItem_Alter
            // 
            this.ToolStripMenuItem_Alter.Name = "ToolStripMenuItem_Alter";
            this.ToolStripMenuItem_Alter.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_Alter.Text = "更改基本工资";
            this.ToolStripMenuItem_Alter.Click += new System.EventHandler(this.ToolStripMenuItem_Alter_Click);
            // 
            // ToolStripMenuItem_Chart
            // 
            this.ToolStripMenuItem_Chart.Name = "ToolStripMenuItem_Chart";
            this.ToolStripMenuItem_Chart.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_Chart.Text = "工资曲线图";
            this.ToolStripMenuItem_Chart.Click += new System.EventHandler(this.ToolStripMenuItem_Chart_Click);
            // 
            // SalaryMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 413);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_bottom);
            this.Controls.Add(this.pal_top);
            this.Name = "SalaryMgr";
            this.Text = "工资管理";
            this.Load += new System.EventHandler(this.SalaryMgr_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.pal_fill.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_seach;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel pal_bottom;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.ListView list_data;
        private System.Windows.Forms.ComboBox cbx_year;
        private System.Windows.Forms.ComboBox cbx_month;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Alter;
        private System.Windows.Forms.Button btn_chart;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Chart;
    }
}