namespace ClothUI.ActiveManager
{
    partial class HistoryActive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryActive));
            this.pal_middle = new System.Windows.Forms.Panel();
            this.list_active = new System.Windows.Forms.ListView();
            this.pal_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.btn_watch = new System.Windows.Forms.Button();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pal_middle.SuspendLayout();
            this.pal_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_middle
            // 
            this.pal_middle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pal_middle.Controls.Add(this.list_active);
            this.pal_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_middle.Location = new System.Drawing.Point(0, 45);
            this.pal_middle.Name = "pal_middle";
            this.pal_middle.Size = new System.Drawing.Size(736, 384);
            this.pal_middle.TabIndex = 3;
            // 
            // list_active
            // 
            this.list_active.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_active.FullRowSelect = true;
            this.list_active.GridLines = true;
            this.list_active.Location = new System.Drawing.Point(0, 0);
            this.list_active.MultiSelect = false;
            this.list_active.Name = "list_active";
            this.list_active.Size = new System.Drawing.Size(736, 384);
            this.list_active.TabIndex = 0;
            this.list_active.UseCompatibleStateImageBehavior = false;
            this.list_active.View = System.Windows.Forms.View.Details;
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pal_top.Controls.Add(this.label2);
            this.pal_top.Controls.Add(this.btn_all);
            this.pal_top.Controls.Add(this.btn_search);
            this.pal_top.Controls.Add(this.dateTimePicker_end);
            this.pal_top.Controls.Add(this.btn_watch);
            this.pal_top.Controls.Add(this.dateTimePicker_start);
            this.pal_top.Controls.Add(this.label1);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(736, 45);
            this.pal_top.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "~";
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(363, 19);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 8;
            this.btn_all.Text = "显示所有";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(328, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(29, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(232, 19);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(90, 21);
            this.dateTimePicker_end.TabIndex = 6;
            // 
            // btn_watch
            // 
            this.btn_watch.Location = new System.Drawing.Point(446, 19);
            this.btn_watch.Name = "btn_watch";
            this.btn_watch.Size = new System.Drawing.Size(75, 23);
            this.btn_watch.TabIndex = 5;
            this.btn_watch.Text = "查看活动";
            this.btn_watch.UseVisualStyleBackColor = true;
            this.btn_watch.Click += new System.EventHandler(this.btn_watch_Click);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(118, 18);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(87, 21);
            this.dateTimePicker_start.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入日期进行查询：";
            // 
            // HistoryActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 429);
            this.Controls.Add(this.pal_middle);
            this.Controls.Add(this.pal_top);
            this.Name = "HistoryActive";
            this.Text = "HistoryActive";
            this.Load += new System.EventHandler(this.HistoryActive_Load);
            this.pal_middle.ResumeLayout(false);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_middle;
        private System.Windows.Forms.ListView list_active;
        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Button btn_watch;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}