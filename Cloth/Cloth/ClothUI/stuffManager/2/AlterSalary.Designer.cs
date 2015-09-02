namespace ClothUI.stuffManager._2
{
    partial class AlterSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_oldSalary = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_new = new System.Windows.Forms.Label();
            this.txt_sa = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原工资:";
            // 
            // lbl_oldSalary
            // 
            this.lbl_oldSalary.AutoSize = true;
            this.lbl_oldSalary.Location = new System.Drawing.Point(76, 18);
            this.lbl_oldSalary.Name = "lbl_oldSalary";
            this.lbl_oldSalary.Size = new System.Drawing.Size(29, 12);
            this.lbl_oldSalary.TabIndex = 1;
            this.lbl_oldSalary.Text = "2000";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(34, 25);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(41, 12);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "label2";
            // 
            // lbl_new
            // 
            this.lbl_new.AutoSize = true;
            this.lbl_new.Location = new System.Drawing.Point(23, 51);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(47, 12);
            this.lbl_new.TabIndex = 2;
            this.lbl_new.Text = "新工资:";
            // 
            // txt_sa
            // 
            this.txt_sa.Location = new System.Drawing.Point(76, 48);
            this.txt_sa.Name = "txt_sa";
            this.txt_sa.Size = new System.Drawing.Size(157, 21);
            this.txt_sa.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(240, 48);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(50, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "原  因:";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(78, 81);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(212, 96);
            this.txt_reason.TabIndex = 7;
            // 
            // AlterSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 189);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_sa);
            this.Controls.Add(this.lbl_new);
            this.Controls.Add(this.lbl_oldSalary);
            this.Controls.Add(this.label1);
            this.Name = "AlterSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更改工资";
            this.Load += new System.EventHandler(this.AlterSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_oldSalary;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_new;
        private System.Windows.Forms.TextBox txt_sa;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_reason;
    }
}