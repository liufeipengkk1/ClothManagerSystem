namespace ClothUI.ActiveManager
{
    partial class SaleActive
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
            this.components = new System.ComponentModel.Container();
            this.pal_top = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_delelte = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pal_middle = new System.Windows.Forms.Panel();
            this.list_active = new System.Windows.Forms.ListView();
            this.pal_bottom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.list_cloth = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_add = new System.Windows.Forms.ToolStripMenuItem();
            this.asToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pal_top.SuspendLayout();
            this.pal_middle.SuspendLayout();
            this.pal_bottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pal_top.Controls.Add(this.btn_edit);
            this.pal_top.Controls.Add(this.button1);
            this.pal_top.Controls.Add(this.btn_delelte);
            this.pal_top.Controls.Add(this.btn_add);
            this.pal_top.Controls.Add(this.dateTimePicker);
            this.pal_top.Controls.Add(this.label1);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(811, 45);
            this.pal_top.TabIndex = 0;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(481, 19);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "编辑活动";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "显示销量";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delelte
            // 
            this.btn_delelte.Location = new System.Drawing.Point(400, 19);
            this.btn_delelte.Name = "btn_delelte";
            this.btn_delelte.Size = new System.Drawing.Size(75, 23);
            this.btn_delelte.TabIndex = 3;
            this.btn_delelte.Text = "删除活动";
            this.btn_delelte.UseVisualStyleBackColor = true;
            this.btn_delelte.Click += new System.EventHandler(this.btn_delelte_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(308, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "添加活动";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(118, 18);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 21);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
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
            // pal_middle
            // 
            this.pal_middle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pal_middle.Controls.Add(this.list_active);
            this.pal_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_middle.Location = new System.Drawing.Point(0, 45);
            this.pal_middle.Name = "pal_middle";
            this.pal_middle.Size = new System.Drawing.Size(811, 396);
            this.pal_middle.TabIndex = 1;
            // 
            // list_active
            // 
            this.list_active.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_active.FullRowSelect = true;
            this.list_active.GridLines = true;
            this.list_active.Location = new System.Drawing.Point(0, 0);
            this.list_active.MultiSelect = false;
            this.list_active.Name = "list_active";
            this.list_active.Size = new System.Drawing.Size(811, 396);
            this.list_active.TabIndex = 0;
            this.list_active.UseCompatibleStateImageBehavior = false;
            this.list_active.View = System.Windows.Forms.View.Details;
            // 
            // pal_bottom
            // 
            this.pal_bottom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pal_bottom.Controls.Add(this.panel2);
            this.pal_bottom.Controls.Add(this.panel1);
            this.pal_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_bottom.Location = new System.Drawing.Point(0, 230);
            this.pal_bottom.Name = "pal_bottom";
            this.pal_bottom.Size = new System.Drawing.Size(811, 211);
            this.pal_bottom.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.list_cloth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 180);
            this.panel2.TabIndex = 1;
            // 
            // list_cloth
            // 
            this.list_cloth.ContextMenuStrip = this.contextMenuStrip;
            this.list_cloth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_cloth.FullRowSelect = true;
            this.list_cloth.GridLines = true;
            this.list_cloth.Location = new System.Drawing.Point(0, 0);
            this.list_cloth.Name = "list_cloth";
            this.list_cloth.Size = new System.Drawing.Size(811, 180);
            this.list_cloth.TabIndex = 0;
            this.list_cloth.UseCompatibleStateImageBehavior = false;
            this.list_cloth.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_add});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(113, 26);
            // 
            // ToolStripMenuItem_add
            // 
            this.ToolStripMenuItem_add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asToolStripMenuItem});
            this.ToolStripMenuItem_add.Name = "ToolStripMenuItem_add";
            this.ToolStripMenuItem_add.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_add.Text = "添加到";
            this.ToolStripMenuItem_add.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStripMenuItem_add_DropDownItemClicked);
            // 
            // asToolStripMenuItem
            // 
            this.asToolStripMenuItem.Name = "asToolStripMenuItem";
            this.asToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.asToolStripMenuItem.Text = "as";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 31);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "最难销售的商品：";
            // 
            // SaleActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 441);
            this.Controls.Add(this.pal_bottom);
            this.Controls.Add(this.pal_middle);
            this.Controls.Add(this.pal_top);
            this.Name = "SaleActive";
            this.Text = "SaleActive";
            this.Load += new System.EventHandler(this.SaleActive_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.pal_middle.ResumeLayout(false);
            this.pal_bottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delelte;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pal_middle;
        private System.Windows.Forms.Panel pal_bottom;
        private System.Windows.Forms.ListView list_active;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView list_cloth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_add;
        private System.Windows.Forms.ToolStripMenuItem asToolStripMenuItem;

    }
}