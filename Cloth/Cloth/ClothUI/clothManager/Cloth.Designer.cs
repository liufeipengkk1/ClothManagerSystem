namespace ClothUI
{
    partial class UCloth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCloth));
            this.pal_top = new System.Windows.Forms.Panel();
            this.cbx_time = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cbx_saleState = new System.Windows.Forms.ComboBox();
            this.cbx_color = new System.Windows.Forms.ComboBox();
            this.cbx_size = new System.Windows.Forms.ComboBox();
            this.cbx_style = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_seach = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.pal_bottom = new System.Windows.Forms.Panel();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.list_cloth = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_alter = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onsaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offshalvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_export = new System.Windows.Forms.ToolStripMenuItem();
            this.pal_top.SuspendLayout();
            this.pal_fill.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pal_top.Controls.Add(this.cbx_time);
            this.pal_top.Controls.Add(this.btn_delete);
            this.pal_top.Controls.Add(this.cbx_saleState);
            this.pal_top.Controls.Add(this.cbx_color);
            this.pal_top.Controls.Add(this.cbx_size);
            this.pal_top.Controls.Add(this.cbx_style);
            this.pal_top.Controls.Add(this.txt_search);
            this.pal_top.Controls.Add(this.lbl_seach);
            this.pal_top.Controls.Add(this.btn_search);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(931, 45);
            this.pal_top.TabIndex = 0;
            // 
            // cbx_time
            // 
            this.cbx_time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_time.FormattingEnabled = true;
            this.cbx_time.Location = new System.Drawing.Point(679, 20);
            this.cbx_time.Name = "cbx_time";
            this.cbx_time.Size = new System.Drawing.Size(83, 20);
            this.cbx_time.TabIndex = 25;
            this.cbx_time.Text = "进货时间";
            this.cbx_time.SelectedIndexChanged += new System.EventHandler(this.cbx_time_SelectedIndexChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(768, 18);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cbx_saleState
            // 
            this.cbx_saleState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_saleState.FormattingEnabled = true;
            this.cbx_saleState.Location = new System.Drawing.Point(590, 20);
            this.cbx_saleState.Name = "cbx_saleState";
            this.cbx_saleState.Size = new System.Drawing.Size(83, 20);
            this.cbx_saleState.TabIndex = 23;
            this.cbx_saleState.Text = "销售状态";
            this.cbx_saleState.SelectedIndexChanged += new System.EventHandler(this.cbx_saleState_SelectedIndexChanged);
            // 
            // cbx_color
            // 
            this.cbx_color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_color.FormattingEnabled = true;
            this.cbx_color.Location = new System.Drawing.Point(516, 20);
            this.cbx_color.Name = "cbx_color";
            this.cbx_color.Size = new System.Drawing.Size(70, 20);
            this.cbx_color.TabIndex = 22;
            this.cbx_color.Text = "颜色";
            this.cbx_color.SelectedIndexChanged += new System.EventHandler(this.cbx_color_SelectedIndexChanged);
            // 
            // cbx_size
            // 
            this.cbx_size.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_size.FormattingEnabled = true;
            this.cbx_size.Location = new System.Drawing.Point(439, 20);
            this.cbx_size.Name = "cbx_size";
            this.cbx_size.Size = new System.Drawing.Size(71, 20);
            this.cbx_size.TabIndex = 21;
            this.cbx_size.Text = "尺码";
            this.cbx_size.SelectedIndexChanged += new System.EventHandler(this.cbx_size_SelectedIndexChanged);
            // 
            // cbx_style
            // 
            this.cbx_style.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_style.FormattingEnabled = true;
            this.cbx_style.Location = new System.Drawing.Point(363, 20);
            this.cbx_style.Name = "cbx_style";
            this.cbx_style.Size = new System.Drawing.Size(70, 20);
            this.cbx_style.TabIndex = 20;
            this.cbx_style.Text = "款式";
            this.cbx_style.SelectedIndexChanged += new System.EventHandler(this.cbx_style_SelectedIndexChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(185, 20);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(137, 21);
            this.txt_search.TabIndex = 15;
            // 
            // lbl_seach
            // 
            this.lbl_seach.AutoSize = true;
            this.lbl_seach.Location = new System.Drawing.Point(12, 23);
            this.lbl_seach.Name = "lbl_seach";
            this.lbl_seach.Size = new System.Drawing.Size(167, 12);
            this.lbl_seach.TabIndex = 14;
            this.lbl_seach.Text = "可输入商品信息进行模糊查询:";
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(325, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 23);
            this.btn_search.TabIndex = 16;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pal_bottom
            // 
            this.pal_bottom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pal_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_bottom.Location = new System.Drawing.Point(0, 399);
            this.pal_bottom.Name = "pal_bottom";
            this.pal_bottom.Size = new System.Drawing.Size(931, 24);
            this.pal_bottom.TabIndex = 1;
            // 
            // pal_fill
            // 
            this.pal_fill.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pal_fill.Controls.Add(this.list_cloth);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 45);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(931, 354);
            this.pal_fill.TabIndex = 2;
            // 
            // list_cloth
            // 
            this.list_cloth.CheckBoxes = true;
            this.list_cloth.ContextMenuStrip = this.contextMenuStrip;
            this.list_cloth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_cloth.FullRowSelect = true;
            this.list_cloth.GridLines = true;
            this.list_cloth.Location = new System.Drawing.Point(0, 0);
            this.list_cloth.Name = "list_cloth";
            this.list_cloth.Size = new System.Drawing.Size(931, 354);
            this.list_cloth.TabIndex = 0;
            this.list_cloth.UseCompatibleStateImageBehavior = false;
            this.list_cloth.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_alter,
            this.ToolStripMenuItem_export});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // ToolStripMenuItem_alter
            // 
            this.ToolStripMenuItem_alter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseToolStripMenuItem,
            this.onsaleToolStripMenuItem,
            this.offshalvesToolStripMenuItem});
            this.ToolStripMenuItem_alter.Name = "ToolStripMenuItem_alter";
            this.ToolStripMenuItem_alter.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_alter.Text = "更改销售状态";
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.warehouseToolStripMenuItem.Text = "warehouse";
            this.warehouseToolStripMenuItem.Click += new System.EventHandler(this.warehouseToolStripMenuItem_Click);
            // 
            // onsaleToolStripMenuItem
            // 
            this.onsaleToolStripMenuItem.Name = "onsaleToolStripMenuItem";
            this.onsaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onsaleToolStripMenuItem.Text = "onsale";
            this.onsaleToolStripMenuItem.Click += new System.EventHandler(this.onsaleToolStripMenuItem_Click);
            // 
            // offshalvesToolStripMenuItem
            // 
            this.offshalvesToolStripMenuItem.Name = "offshalvesToolStripMenuItem";
            this.offshalvesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.offshalvesToolStripMenuItem.Text = "offshalves";
            this.offshalvesToolStripMenuItem.Click += new System.EventHandler(this.offshalvesToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_export
            // 
            this.ToolStripMenuItem_export.Name = "ToolStripMenuItem_export";
            this.ToolStripMenuItem_export.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_export.Text = "导出清单";
            this.ToolStripMenuItem_export.Click += new System.EventHandler(this.ToolStripMenuItem_export_Click);
            // 
            // UCloth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 423);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_bottom);
            this.Controls.Add(this.pal_top);
            this.Name = "UCloth";
            this.Text = "Cloth";
            this.Load += new System.EventHandler(this.Cloth_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.pal_fill.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_seach;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbx_color;
        private System.Windows.Forms.ComboBox cbx_size;
        private System.Windows.Forms.ComboBox cbx_style;
        private System.Windows.Forms.Panel pal_bottom;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.ComboBox cbx_saleState;
        private System.Windows.Forms.ListView list_cloth;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cbx_time;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_alter;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_export;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onsaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offshalvesToolStripMenuItem;
    }
}