namespace ClothUI.ActiveManager
{
    partial class ClothChoose
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
            this.pal_fill = new System.Windows.Forms.Panel();
            this.list_data = new System.Windows.Forms.ListView();
            this.pal_top = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_time = new System.Windows.Forms.ComboBox();
            this.pal_fill.SuspendLayout();
            this.pal_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_fill
            // 
            this.pal_fill.Controls.Add(this.list_data);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 35);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(848, 420);
            this.pal_fill.TabIndex = 0;
            // 
            // list_data
            // 
            this.list_data.CheckBoxes = true;
            this.list_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_data.FullRowSelect = true;
            this.list_data.GridLines = true;
            this.list_data.Location = new System.Drawing.Point(0, 0);
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(848, 420);
            this.list_data.TabIndex = 0;
            this.list_data.UseCompatibleStateImageBehavior = false;
            this.list_data.View = System.Windows.Forms.View.Details;
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pal_top.Controls.Add(this.cbx_time);
            this.pal_top.Controls.Add(this.btn_cancel);
            this.pal_top.Controls.Add(this.btn_ok);
            this.pal_top.Controls.Add(this.btn_search);
            this.pal_top.Controls.Add(this.txt_search);
            this.pal_top.Controls.Add(this.label1);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(848, 35);
            this.pal_top.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(648, 8);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(567, 8);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(432, 8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(40, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(150, 10);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(276, 21);
            this.txt_search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入商品信息模糊查询:";
            // 
            // cbx_time
            // 
            this.cbx_time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_time.FormattingEnabled = true;
            this.cbx_time.Location = new System.Drawing.Point(478, 10);
            this.cbx_time.Name = "cbx_time";
            this.cbx_time.Size = new System.Drawing.Size(83, 20);
            this.cbx_time.TabIndex = 26;
            this.cbx_time.Text = "进货时间";
            this.cbx_time.SelectedIndexChanged += new System.EventHandler(this.cbx_time_SelectedIndexChanged);
            // 
            // ClothChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 455);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_top);
            this.Name = "ClothChoose";
            this.Text = "商品选择";
            this.Load += new System.EventHandler(this.ClothChoose_Load);
            this.pal_fill.ResumeLayout(false);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.ListView list_data;
        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cbx_time;
    }
}