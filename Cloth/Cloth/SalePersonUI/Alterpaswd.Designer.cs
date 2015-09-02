namespace SalePersonUI
{
    partial class Alterpaswd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_oldpd = new System.Windows.Forms.TextBox();
            this.txt_newpd = new System.Windows.Forms.TextBox();
            this.txt_finalpd = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_ok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确  认:";
            // 
            // txt_oldpd
            // 
            this.txt_oldpd.Location = new System.Drawing.Point(95, 27);
            this.txt_oldpd.Name = "txt_oldpd";
            this.txt_oldpd.PasswordChar = '*';
            this.txt_oldpd.Size = new System.Drawing.Size(227, 21);
            this.txt_oldpd.TabIndex = 3;
            // 
            // txt_newpd
            // 
            this.txt_newpd.Location = new System.Drawing.Point(95, 61);
            this.txt_newpd.Name = "txt_newpd";
            this.txt_newpd.PasswordChar = '*';
            this.txt_newpd.Size = new System.Drawing.Size(227, 21);
            this.txt_newpd.TabIndex = 4;
            // 
            // txt_finalpd
            // 
            this.txt_finalpd.Location = new System.Drawing.Point(95, 94);
            this.txt_finalpd.Name = "txt_finalpd";
            this.txt_finalpd.PasswordChar = '*';
            this.txt_finalpd.Size = new System.Drawing.Size(227, 21);
            this.txt_finalpd.TabIndex = 5;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(227, 123);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(47, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(280, 123);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(46, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.ForeColor = System.Drawing.Color.Red;
            this.lbl_ok.Location = new System.Drawing.Point(93, 128);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(89, 12);
            this.lbl_ok.TabIndex = 8;
            this.lbl_ok.Text = "两次密码不一样";
            // 
            // Alterpaswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 163);
            this.Controls.Add(this.lbl_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_finalpd);
            this.Controls.Add(this.txt_newpd);
            this.Controls.Add(this.txt_oldpd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alterpaswd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更改密码";
            this.Load += new System.EventHandler(this.Alterpaswd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_oldpd;
        private System.Windows.Forms.TextBox txt_newpd;
        private System.Windows.Forms.TextBox txt_finalpd;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_ok;
    }
}