namespace ClothUI
{
    partial class ClothMgr
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
            this.btn_saleMgr = new System.Windows.Forms.Button();
            this.btn_clothMgr = new System.Windows.Forms.Button();
            this.pal_right = new System.Windows.Forms.Panel();
            this.pal_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_left
            // 
            this.pal_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pal_left.Controls.Add(this.btn_saleMgr);
            this.pal_left.Controls.Add(this.btn_clothMgr);
            this.pal_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pal_left.Location = new System.Drawing.Point(0, 0);
            this.pal_left.Name = "pal_left";
            this.pal_left.Size = new System.Drawing.Size(119, 413);
            this.pal_left.TabIndex = 0;
            // 
            // btn_saleMgr
            // 
            this.btn_saleMgr.Location = new System.Drawing.Point(12, 76);
            this.btn_saleMgr.Name = "btn_saleMgr";
            this.btn_saleMgr.Size = new System.Drawing.Size(91, 39);
            this.btn_saleMgr.TabIndex = 5;
            this.btn_saleMgr.Text = "销售情况";
            this.btn_saleMgr.UseVisualStyleBackColor = true;
            this.btn_saleMgr.Click += new System.EventHandler(this.btn_saleMgr_Click);
            // 
            // btn_clothMgr
            // 
            this.btn_clothMgr.Location = new System.Drawing.Point(12, 21);
            this.btn_clothMgr.Name = "btn_clothMgr";
            this.btn_clothMgr.Size = new System.Drawing.Size(91, 39);
            this.btn_clothMgr.TabIndex = 4;
            this.btn_clothMgr.Text = "商品管理";
            this.btn_clothMgr.UseVisualStyleBackColor = true;
            this.btn_clothMgr.Click += new System.EventHandler(this.btn_clothMgr_Click);
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
            // ClothMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 413);
            this.Controls.Add(this.pal_right);
            this.Controls.Add(this.pal_left);
            this.Name = "ClothMgr";
            this.Text = "ClothMgr";
            this.pal_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_left;
        private System.Windows.Forms.Panel pal_right;
        private System.Windows.Forms.Button btn_saleMgr;
        private System.Windows.Forms.Button btn_clothMgr;
    }
}