namespace ClothUI.ActiveManager
{
    partial class ActivityMgr
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
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_activity = new System.Windows.Forms.Button();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.pal_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_left
            // 
            this.pal_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pal_left.Controls.Add(this.btn_history);
            this.pal_left.Controls.Add(this.btn_activity);
            this.pal_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pal_left.Location = new System.Drawing.Point(0, 0);
            this.pal_left.Name = "pal_left";
            this.pal_left.Size = new System.Drawing.Size(119, 397);
            this.pal_left.TabIndex = 0;
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(12, 72);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(91, 39);
            this.btn_history.TabIndex = 7;
            this.btn_history.Text = "历史记录";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_activity
            // 
            this.btn_activity.Location = new System.Drawing.Point(12, 17);
            this.btn_activity.Name = "btn_activity";
            this.btn_activity.Size = new System.Drawing.Size(91, 39);
            this.btn_activity.TabIndex = 6;
            this.btn_activity.Text = "销售活动";
            this.btn_activity.UseVisualStyleBackColor = true;
            this.btn_activity.Click += new System.EventHandler(this.btn_activity_Click);
            // 
            // pal_fill
            // 
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(119, 0);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(663, 397);
            this.pal_fill.TabIndex = 1;
            // 
            // ActivityMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 397);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_left);
            this.Name = "ActivityMgr";
            this.Text = "活动管理";
            this.Load += new System.EventHandler(this.ActivityMgr_Load);
            this.pal_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_left;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_activity;
    }
}