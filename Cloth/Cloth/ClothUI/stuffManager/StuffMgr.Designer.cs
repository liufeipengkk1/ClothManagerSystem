namespace ClothUI
{
    partial class StuffMgr
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
            this.pal_left = new System.Windows.Forms.Panel();
            this.btn_TiChengMentMgr = new System.Windows.Forms.Button();
            this.btn_statisticMgr = new System.Windows.Forms.Button();
            this.btn_salaryMgr = new System.Windows.Forms.Button();
            this.btn_stuffMgr = new System.Windows.Forms.Button();
            this.pal_right = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pal_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_left
            // 
            this.pal_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pal_left.Controls.Add(this.btn_TiChengMentMgr);
            this.pal_left.Controls.Add(this.btn_statisticMgr);
            this.pal_left.Controls.Add(this.btn_salaryMgr);
            this.pal_left.Controls.Add(this.btn_stuffMgr);
            this.pal_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pal_left.Location = new System.Drawing.Point(0, 0);
            this.pal_left.Name = "pal_left";
            this.pal_left.Size = new System.Drawing.Size(119, 413);
            this.pal_left.TabIndex = 0;
            // 
            // btn_TiChengMentMgr
            // 
            this.btn_TiChengMentMgr.Location = new System.Drawing.Point(13, 187);
            this.btn_TiChengMentMgr.Name = "btn_TiChengMentMgr";
            this.btn_TiChengMentMgr.Size = new System.Drawing.Size(91, 36);
            this.btn_TiChengMentMgr.TabIndex = 3;
            this.btn_TiChengMentMgr.Text = "提成管理";
            this.btn_TiChengMentMgr.UseVisualStyleBackColor = true;
            this.btn_TiChengMentMgr.Click += new System.EventHandler(this.btn_TiChengMentMgr_Click);
            // 
            // btn_statisticMgr
            // 
            this.btn_statisticMgr.Location = new System.Drawing.Point(13, 133);
            this.btn_statisticMgr.Name = "btn_statisticMgr";
            this.btn_statisticMgr.Size = new System.Drawing.Size(91, 38);
            this.btn_statisticMgr.TabIndex = 2;
            this.btn_statisticMgr.Text = "统计管理";
            this.btn_statisticMgr.UseVisualStyleBackColor = true;
            this.btn_statisticMgr.Click += new System.EventHandler(this.btn_statisticMgr_Click);
            // 
            // btn_salaryMgr
            // 
            this.btn_salaryMgr.Location = new System.Drawing.Point(13, 77);
            this.btn_salaryMgr.Name = "btn_salaryMgr";
            this.btn_salaryMgr.Size = new System.Drawing.Size(91, 39);
            this.btn_salaryMgr.TabIndex = 1;
            this.btn_salaryMgr.Text = "工资管理";
            this.btn_salaryMgr.UseVisualStyleBackColor = true;
            this.btn_salaryMgr.Click += new System.EventHandler(this.btn_salaryMgr_Click);
            // 
            // btn_stuffMgr
            // 
            this.btn_stuffMgr.Location = new System.Drawing.Point(13, 22);
            this.btn_stuffMgr.Name = "btn_stuffMgr";
            this.btn_stuffMgr.Size = new System.Drawing.Size(91, 39);
            this.btn_stuffMgr.TabIndex = 0;
            this.btn_stuffMgr.Text = "员工管理";
            this.btn_stuffMgr.UseVisualStyleBackColor = true;
            this.btn_stuffMgr.Click += new System.EventHandler(this.btn_stuffMgr_Click);
            // 
            // pal_right
            // 
            this.pal_right.BackColor = System.Drawing.SystemColors.Info;
            this.pal_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_right.Location = new System.Drawing.Point(119, 0);
            this.pal_right.Name = "pal_right";
            this.pal_right.Size = new System.Drawing.Size(861, 413);
            this.pal_right.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(250, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // StuffMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 413);
            this.Controls.Add(this.pal_right);
            this.Controls.Add(this.pal_left);
            this.Name = "StuffMgr";
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.StuffMgr_Load);
            this.pal_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_left;
        private System.Windows.Forms.Button btn_stuffMgr;
        private System.Windows.Forms.Panel pal_right;
        private System.Windows.Forms.Button btn_salaryMgr;
        private System.Windows.Forms.Button btn_statisticMgr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TiChengMentMgr;
    }
}