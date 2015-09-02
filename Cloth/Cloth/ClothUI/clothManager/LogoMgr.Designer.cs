namespace ClothUI.clothManager._4
{
    partial class LogoMgr
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pal_bottom = new System.Windows.Forms.Panel();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.list_data = new System.Windows.Forms.ListView();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.pal_top.SuspendLayout();
            this.pal_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pal_top.Controls.Add(this.txt_Name);
            this.pal_top.Controls.Add(this.btn_delete);
            this.pal_top.Controls.Add(this.btn_add);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(368, 32);
            this.pal_top.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(255, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(177, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加品牌";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pal_bottom
            // 
            this.pal_bottom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pal_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_bottom.Location = new System.Drawing.Point(0, 442);
            this.pal_bottom.Name = "pal_bottom";
            this.pal_bottom.Size = new System.Drawing.Size(368, 20);
            this.pal_bottom.TabIndex = 1;
            // 
            // pal_fill
            // 
            this.pal_fill.Controls.Add(this.list_data);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 32);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(368, 410);
            this.pal_fill.TabIndex = 2;
            // 
            // list_data
            // 
            this.list_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_data.FullRowSelect = true;
            this.list_data.GridLines = true;
            this.list_data.Location = new System.Drawing.Point(0, 0);
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(368, 410);
            this.list_data.TabIndex = 0;
            this.list_data.UseCompatibleStateImageBehavior = false;
            this.list_data.View = System.Windows.Forms.View.Details;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(12, 8);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(159, 21);
            this.txt_Name.TabIndex = 1;
            // 
            // LogoMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 462);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_bottom);
            this.Controls.Add(this.pal_top);
            this.Name = "LogoMgr";
            this.Text = "品牌管理";
            this.Load += new System.EventHandler(this.LogoMgr_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.pal_fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pal_bottom;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.ListView list_data;
        private System.Windows.Forms.TextBox txt_Name;
    }
}