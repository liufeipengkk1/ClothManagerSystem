namespace ClothUI.stuffManager._3
{
    partial class StatisticMgr
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
            this.pal_top = new System.Windows.Forms.Panel();
            this.cbx_month = new System.Windows.Forms.ComboBox();
            this.btn_saleDetail = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_seach = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.list_data = new System.Windows.Forms.ListView();
            this.cbx_year = new System.Windows.Forms.ComboBox();
            this.pal_top.SuspendLayout();
            this.pal_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pal_top.Controls.Add(this.cbx_year);
            this.pal_top.Controls.Add(this.cbx_month);
            this.pal_top.Controls.Add(this.btn_saleDetail);
            this.pal_top.Controls.Add(this.txt_search);
            this.pal_top.Controls.Add(this.lbl_seach);
            this.pal_top.Controls.Add(this.btn_search);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(859, 45);
            this.pal_top.TabIndex = 0;
            // 
            // cbx_month
            // 
            this.cbx_month.FormattingEnabled = true;
            this.cbx_month.Location = new System.Drawing.Point(495, 20);
            this.cbx_month.Name = "cbx_month";
            this.cbx_month.Size = new System.Drawing.Size(75, 20);
            this.cbx_month.TabIndex = 15;
            this.cbx_month.Text = "时间";
            // 
            // btn_saleDetail
            // 
            this.btn_saleDetail.Location = new System.Drawing.Point(614, 19);
            this.btn_saleDetail.Name = "btn_saleDetail";
            this.btn_saleDetail.Size = new System.Drawing.Size(75, 23);
            this.btn_saleDetail.TabIndex = 14;
            this.btn_saleDetail.Text = "销售详情";
            this.btn_saleDetail.UseVisualStyleBackColor = true;
            this.btn_saleDetail.Click += new System.EventHandler(this.btn_saleDetail_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(183, 20);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(224, 21);
            this.txt_search.TabIndex = 11;
            // 
            // lbl_seach
            // 
            this.lbl_seach.AutoSize = true;
            this.lbl_seach.Location = new System.Drawing.Point(10, 23);
            this.lbl_seach.Name = "lbl_seach";
            this.lbl_seach.Size = new System.Drawing.Size(167, 12);
            this.lbl_seach.TabIndex = 10;
            this.lbl_seach.Text = "可输入员工信息进行模糊查询:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(576, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 23);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "ss";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pal_fill
            // 
            this.pal_fill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pal_fill.Controls.Add(this.list_data);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 45);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(859, 432);
            this.pal_fill.TabIndex = 1;
            // 
            // list_data
            // 
            this.list_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_data.FullRowSelect = true;
            this.list_data.GridLines = true;
            this.list_data.Location = new System.Drawing.Point(0, 0);
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(859, 432);
            this.list_data.TabIndex = 0;
            this.list_data.UseCompatibleStateImageBehavior = false;
            this.list_data.View = System.Windows.Forms.View.Details;
            // 
            // cbx_year
            // 
            this.cbx_year.FormattingEnabled = true;
            this.cbx_year.Location = new System.Drawing.Point(413, 20);
            this.cbx_year.Name = "cbx_year";
            this.cbx_year.Size = new System.Drawing.Size(75, 20);
            this.cbx_year.TabIndex = 16;
            this.cbx_year.Text = "年";
            // 
            // StatisticMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 477);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_top);
            this.Name = "StatisticMgr";
            this.Text = "StatisticMgr";
            this.Load += new System.EventHandler(this.StatisticMgr_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.pal_fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_seach;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.ListView list_data;
        private System.Windows.Forms.Button btn_saleDetail;
        private System.Windows.Forms.ComboBox cbx_month;
        private System.Windows.Forms.ComboBox cbx_year;
    }
}