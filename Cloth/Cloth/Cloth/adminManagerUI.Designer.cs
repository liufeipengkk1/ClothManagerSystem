namespace ClothUI
{
    partial class adminManagerUI
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_detail = new System.Windows.Forms.Panel();
            this.btn_personMg = new System.Windows.Forms.Button();
            this.btn_sheetMg = new System.Windows.Forms.Button();
            this.btn_price = new System.Windows.Forms.Button();
            this.bnt_active = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatuslbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 279);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(560, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "状态信息";
            // 
            // toolStripStatuslbl
            // 
            this.toolStripStatuslbl.Name = "toolStripStatuslbl";
            this.toolStripStatuslbl.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatuslbl.Text = "状态信息";
            // 
            // panel_detail
            // 
            this.panel_detail.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_detail.Location = new System.Drawing.Point(123, 0);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Size = new System.Drawing.Size(437, 279);
            this.panel_detail.TabIndex = 1;
            // 
            // btn_personMg
            // 
            this.btn_personMg.Location = new System.Drawing.Point(22, 28);
            this.btn_personMg.Name = "btn_personMg";
            this.btn_personMg.Size = new System.Drawing.Size(75, 23);
            this.btn_personMg.TabIndex = 2;
            this.btn_personMg.Text = "员工管理";
            this.btn_personMg.UseVisualStyleBackColor = true;
            // 
            // btn_sheetMg
            // 
            this.btn_sheetMg.Location = new System.Drawing.Point(22, 75);
            this.btn_sheetMg.Name = "btn_sheetMg";
            this.btn_sheetMg.Size = new System.Drawing.Size(75, 23);
            this.btn_sheetMg.TabIndex = 3;
            this.btn_sheetMg.Text = "清单管理";
            this.btn_sheetMg.UseVisualStyleBackColor = true;
            // 
            // btn_price
            // 
            this.btn_price.Location = new System.Drawing.Point(22, 120);
            this.btn_price.Name = "btn_price";
            this.btn_price.Size = new System.Drawing.Size(75, 23);
            this.btn_price.TabIndex = 4;
            this.btn_price.Text = "营业额统计";
            this.btn_price.UseVisualStyleBackColor = true;
            // 
            // bnt_active
            // 
            this.bnt_active.Location = new System.Drawing.Point(22, 168);
            this.bnt_active.Name = "bnt_active";
            this.bnt_active.Size = new System.Drawing.Size(75, 23);
            this.bnt_active.TabIndex = 5;
            this.bnt_active.Text = "商业活动";
            this.bnt_active.UseVisualStyleBackColor = true;
            // 
            // adminManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 301);
            this.Controls.Add(this.bnt_active);
            this.Controls.Add(this.btn_price);
            this.Controls.Add(this.btn_sheetMg);
            this.Controls.Add(this.btn_personMg);
            this.Controls.Add(this.panel_detail);
            this.Controls.Add(this.statusStrip);
            this.Name = "adminManagerUI";
            this.Text = "店长";
            this.Load += new System.EventHandler(this.adminManagerUI_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslbl;
        private System.Windows.Forms.Panel panel_detail;
        private System.Windows.Forms.Button btn_personMg;
        private System.Windows.Forms.Button btn_sheetMg;
        private System.Windows.Forms.Button btn_price;
        private System.Windows.Forms.Button bnt_active;
    }
}