namespace ClothUI.stuffManager._1
{
    partial class Leave
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
            this.lab_time = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_days = new System.Windows.Forms.Label();
            this.txt_days = new System.Windows.Forms.TextBox();
            this.lbl_reason = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.Location = new System.Drawing.Point(13, 13);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(41, 12);
            this.lab_time.TabIndex = 0;
            this.lab_time.Text = "时间：";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(47, 7);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(101, 21);
            this.dateTimePicker.TabIndex = 1;
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Location = new System.Drawing.Point(154, 13);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(41, 12);
            this.lbl_days.TabIndex = 2;
            this.lbl_days.Text = "天数：";
            // 
            // txt_days
            // 
            this.txt_days.Location = new System.Drawing.Point(189, 7);
            this.txt_days.Name = "txt_days";
            this.txt_days.Size = new System.Drawing.Size(108, 21);
            this.txt_days.TabIndex = 3;
            // 
            // lbl_reason
            // 
            this.lbl_reason.AutoSize = true;
            this.lbl_reason.Location = new System.Drawing.Point(13, 46);
            this.lbl_reason.Name = "lbl_reason";
            this.lbl_reason.Size = new System.Drawing.Size(41, 12);
            this.lbl_reason.TabIndex = 4;
            this.lbl_reason.Text = "原因：";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(47, 46);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(250, 231);
            this.txt_reason.TabIndex = 5;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(200, 283);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(42, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(250, 283);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(47, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 311);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.lbl_reason);
            this.Controls.Add(this.txt_days);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lab_time);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Leave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave";
            this.Load += new System.EventHandler(this.Leave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.TextBox txt_days;
        private System.Windows.Forms.Label lbl_reason;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}