namespace ClothUI
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pal_top = new System.Windows.Forms.Panel();
            this.btn_signOut = new System.Windows.Forms.Button();
            this.picture_Head = new System.Windows.Forms.PictureBox();
            this.btn_activeMgr = new System.Windows.Forms.Button();
            this.btn_clothMgr = new System.Windows.Forms.Button();
            this.btn_stuffMgr = new System.Windows.Forms.Button();
            this.pal_mid = new System.Windows.Forms.Panel();
            this.pal_bottom = new System.Windows.Forms.Panel();
            this.lbl_bottom = new System.Windows.Forms.Label();
            this.pal_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Head)).BeginInit();
            this.pal_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.Highlight;
            this.pal_top.Controls.Add(this.btn_signOut);
            this.pal_top.Controls.Add(this.picture_Head);
            this.pal_top.Controls.Add(this.btn_activeMgr);
            this.pal_top.Controls.Add(this.btn_clothMgr);
            this.pal_top.Controls.Add(this.btn_stuffMgr);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(980, 93);
            this.pal_top.TabIndex = 0;
            // 
            // btn_signOut
            // 
            this.btn_signOut.Location = new System.Drawing.Point(279, 12);
            this.btn_signOut.Name = "btn_signOut";
            this.btn_signOut.Size = new System.Drawing.Size(82, 70);
            this.btn_signOut.TabIndex = 5;
            this.btn_signOut.Text = "退出";
            this.btn_signOut.UseVisualStyleBackColor = true;
            this.btn_signOut.Click += new System.EventHandler(this.btn_signOut_Click);
            // 
            // picture_Head
            // 
            this.picture_Head.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_Head.Image = ((System.Drawing.Image)(resources.GetObject("picture_Head.Image")));
            this.picture_Head.Location = new System.Drawing.Point(890, 3);
            this.picture_Head.Name = "picture_Head";
            this.picture_Head.Size = new System.Drawing.Size(90, 87);
            this.picture_Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Head.TabIndex = 4;
            this.picture_Head.TabStop = false;
            // 
            // btn_activeMgr
            // 
            this.btn_activeMgr.Location = new System.Drawing.Point(189, 12);
            this.btn_activeMgr.Name = "btn_activeMgr";
            this.btn_activeMgr.Size = new System.Drawing.Size(82, 70);
            this.btn_activeMgr.TabIndex = 2;
            this.btn_activeMgr.Text = "活动管理";
            this.btn_activeMgr.UseVisualStyleBackColor = true;
            this.btn_activeMgr.Click += new System.EventHandler(this.btn_activeMgr_Click);
            // 
            // btn_clothMgr
            // 
            this.btn_clothMgr.Location = new System.Drawing.Point(100, 12);
            this.btn_clothMgr.Name = "btn_clothMgr";
            this.btn_clothMgr.Size = new System.Drawing.Size(82, 70);
            this.btn_clothMgr.TabIndex = 1;
            this.btn_clothMgr.Text = "商品管理";
            this.btn_clothMgr.UseVisualStyleBackColor = true;
            this.btn_clothMgr.Click += new System.EventHandler(this.btn_clothMgr_Click);
            // 
            // btn_stuffMgr
            // 
            this.btn_stuffMgr.Location = new System.Drawing.Point(12, 12);
            this.btn_stuffMgr.Name = "btn_stuffMgr";
            this.btn_stuffMgr.Size = new System.Drawing.Size(82, 70);
            this.btn_stuffMgr.TabIndex = 0;
            this.btn_stuffMgr.Text = "人事管理";
            this.btn_stuffMgr.UseVisualStyleBackColor = true;
            this.btn_stuffMgr.Click += new System.EventHandler(this.btn_stuffMgr_Click);
            // 
            // pal_mid
            // 
            this.pal_mid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pal_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_mid.Location = new System.Drawing.Point(0, 93);
            this.pal_mid.Name = "pal_mid";
            this.pal_mid.Size = new System.Drawing.Size(980, 413);
            this.pal_mid.TabIndex = 1;
            // 
            // pal_bottom
            // 
            this.pal_bottom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pal_bottom.Controls.Add(this.lbl_bottom);
            this.pal_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_bottom.Location = new System.Drawing.Point(0, 482);
            this.pal_bottom.Name = "pal_bottom";
            this.pal_bottom.Size = new System.Drawing.Size(980, 24);
            this.pal_bottom.TabIndex = 2;
            // 
            // lbl_bottom
            // 
            this.lbl_bottom.AutoSize = true;
            this.lbl_bottom.Location = new System.Drawing.Point(4, 4);
            this.lbl_bottom.Name = "lbl_bottom";
            this.lbl_bottom.Size = new System.Drawing.Size(89, 12);
            this.lbl_bottom.TabIndex = 0;
            this.lbl_bottom.Text = "服装通管理软件";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 506);
            this.Controls.Add(this.pal_bottom);
            this.Controls.Add(this.pal_mid);
            this.Controls.Add(this.pal_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Admin";
            this.Text = "店长管理窗口";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResizeEnd += new System.EventHandler(this.Admin_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Admin_KeyDown);
            this.pal_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Head)).EndInit();
            this.pal_bottom.ResumeLayout(false);
            this.pal_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Button btn_clothMgr;
        private System.Windows.Forms.Button btn_stuffMgr;
        private System.Windows.Forms.Button btn_activeMgr;
        private System.Windows.Forms.PictureBox picture_Head;
        private System.Windows.Forms.Panel pal_mid;
        private System.Windows.Forms.Panel pal_bottom;
        private System.Windows.Forms.Label lbl_bottom;
        private System.Windows.Forms.Button btn_signOut;
    }
}