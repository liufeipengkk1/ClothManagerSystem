namespace ClothUI.stuffManager._3
{
    partial class SaleDetail
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
            this.pal_bottom = new System.Windows.Forms.Panel();
            this.pal_top = new System.Windows.Forms.Panel();
            this.cbo_month = new System.Windows.Forms.ComboBox();
            this.cbo_year = new System.Windows.Forms.ComboBox();
            this.btn_month = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.list_data = new System.Windows.Forms.ListView();
            this.btn_search = new System.Windows.Forms.Button();
            this.pal_top.SuspendLayout();
            this.pal_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_bottom
            // 
            this.pal_bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pal_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_bottom.Location = new System.Drawing.Point(0, 437);
            this.pal_bottom.Name = "pal_bottom";
            this.pal_bottom.Size = new System.Drawing.Size(505, 36);
            this.pal_bottom.TabIndex = 0;
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pal_top.Controls.Add(this.btn_search);
            this.pal_top.Controls.Add(this.cbo_month);
            this.pal_top.Controls.Add(this.cbo_year);
            this.pal_top.Controls.Add(this.btn_month);
            this.pal_top.Controls.Add(this.btn_all);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(505, 37);
            this.pal_top.TabIndex = 1;
            // 
            // cbo_month
            // 
            this.cbo_month.FormattingEnabled = true;
            this.cbo_month.Location = new System.Drawing.Point(92, 10);
            this.cbo_month.Name = "cbo_month";
            this.cbo_month.Size = new System.Drawing.Size(77, 20);
            this.cbo_month.TabIndex = 4;
            // 
            // cbo_year
            // 
            this.cbo_year.FormattingEnabled = true;
            this.cbo_year.Location = new System.Drawing.Point(9, 10);
            this.cbo_year.Name = "cbo_year";
            this.cbo_year.Size = new System.Drawing.Size(77, 20);
            this.cbo_year.TabIndex = 3;
            // 
            // btn_month
            // 
            this.btn_month.Location = new System.Drawing.Point(427, 7);
            this.btn_month.Name = "btn_month";
            this.btn_month.Size = new System.Drawing.Size(75, 23);
            this.btn_month.TabIndex = 2;
            this.btn_month.Text = "一月内";
            this.btn_month.UseVisualStyleBackColor = true;
            this.btn_month.Click += new System.EventHandler(this.btn_month_Click);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(346, 7);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 0;
            this.btn_all.Text = "所有记录";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // pal_fill
            // 
            this.pal_fill.Controls.Add(this.list_data);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 37);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(505, 400);
            this.pal_fill.TabIndex = 2;
            // 
            // list_data
            // 
            this.list_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_data.FullRowSelect = true;
            this.list_data.GridLines = true;
            this.list_data.Location = new System.Drawing.Point(0, 0);
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(505, 400);
            this.list_data.TabIndex = 0;
            this.list_data.UseCompatibleStateImageBehavior = false;
            this.list_data.View = System.Windows.Forms.View.Details;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(175, 8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(26, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "ss";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // SaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 473);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_top);
            this.Controls.Add(this.pal_bottom);
            this.Name = "SaleDetail";
            this.Text = "销售详情";
            this.Load += new System.EventHandler(this.SaleDetail_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_bottom;
        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Button btn_month;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.ListView list_data;
        private System.Windows.Forms.ComboBox cbo_month;
        private System.Windows.Forms.ComboBox cbo_year;
        private System.Windows.Forms.Button btn_search;
    }
}