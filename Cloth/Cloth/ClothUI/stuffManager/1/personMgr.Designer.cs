namespace ClothUI
{
    partial class personMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personMgr));
            this.pal_top = new System.Windows.Forms.Panel();
            this.btn_signOut = new System.Windows.Forms.Button();
            this.btn_state = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pal_middle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.list_data = new System.Windows.Forms.ListView();
            this.contextMenuStrip_state = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.在职ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.离职ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.休假ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pal_top.SuspendLayout();
            this.pal_middle.SuspendLayout();
            this.pal_fill.SuspendLayout();
            this.contextMenuStrip_state.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.Color.Gainsboro;
            this.pal_top.Controls.Add(this.btn_signOut);
            this.pal_top.Controls.Add(this.btn_state);
            this.pal_top.Controls.Add(this.btn_search);
            this.pal_top.Controls.Add(this.btn_export);
            this.pal_top.Controls.Add(this.btn_import);
            this.pal_top.Controls.Add(this.btn_print);
            this.pal_top.Controls.Add(this.btn_delete);
            this.pal_top.Controls.Add(this.btn_edit);
            this.pal_top.Controls.Add(this.btn_add);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(859, 47);
            this.pal_top.TabIndex = 0;
            // 
            // btn_signOut
            // 
            this.btn_signOut.FlatAppearance.BorderSize = 0;
            this.btn_signOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signOut.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_signOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_signOut.Image")));
            this.btn_signOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signOut.Location = new System.Drawing.Point(429, 7);
            this.btn_signOut.Name = "btn_signOut";
            this.btn_signOut.Size = new System.Drawing.Size(74, 34);
            this.btn_signOut.TabIndex = 8;
            this.btn_signOut.Text = "退出";
            this.btn_signOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_signOut.UseVisualStyleBackColor = true;
            this.btn_signOut.Click += new System.EventHandler(this.btn_signOut_Click);
            // 
            // btn_state
            // 
            this.btn_state.FlatAppearance.BorderSize = 0;
            this.btn_state.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_state.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_state.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_state.Image = ((System.Drawing.Image)(resources.GetObject("btn_state.Image")));
            this.btn_state.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_state.Location = new System.Drawing.Point(332, 7);
            this.btn_state.Name = "btn_state";
            this.btn_state.Size = new System.Drawing.Size(91, 34);
            this.btn_state.TabIndex = 7;
            this.btn_state.Text = "在职状态";
            this.btn_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_state.UseVisualStyleBackColor = true;
            this.btn_state.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_state_MouseClick);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(766, 8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 34);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "高级查询";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_export
            // 
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_export.Image = ((System.Drawing.Image)(resources.GetObject("btn_export.Image")));
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.Location = new System.Drawing.Point(252, 7);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(74, 34);
            this.btn_export.TabIndex = 5;
            this.btn_export.Text = "导出";
            this.btn_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_import
            // 
            this.btn_import.FlatAppearance.BorderSize = 0;
            this.btn_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_import.Image = ((System.Drawing.Image)(resources.GetObject("btn_import.Image")));
            this.btn_import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_import.Location = new System.Drawing.Point(693, 7);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(74, 34);
            this.btn_import.TabIndex = 4;
            this.btn_import.Text = "导入";
            this.btn_import.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_import.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_print.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.Image")));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(613, 7);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(74, 34);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "打印";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(172, 8);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(74, 34);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "删除";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(92, 8);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(74, 34);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "编辑";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(12, 8);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(74, 34);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pal_middle
            // 
            this.pal_middle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pal_middle.Controls.Add(this.button1);
            this.pal_middle.Controls.Add(this.txt_search);
            this.pal_middle.Controls.Add(this.lbl_search);
            this.pal_middle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_middle.Location = new System.Drawing.Point(0, 47);
            this.pal_middle.Name = "pal_middle";
            this.pal_middle.Size = new System.Drawing.Size(859, 26);
            this.pal_middle.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(365, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(118, 3);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(240, 21);
            this.txt_search.TabIndex = 1;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(13, 6);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(101, 12);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "员工信息模糊查询";
            // 
            // pal_fill
            // 
            this.pal_fill.Controls.Add(this.list_data);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 73);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(859, 404);
            this.pal_fill.TabIndex = 3;
            // 
            // list_data
            // 
            this.list_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_data.FullRowSelect = true;
            this.list_data.GridLines = true;
            this.list_data.Location = new System.Drawing.Point(0, 0);
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(859, 404);
            this.list_data.TabIndex = 0;
            this.list_data.UseCompatibleStateImageBehavior = false;
            this.list_data.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip_state
            // 
            this.contextMenuStrip_state.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.在职ToolStripMenuItem,
            this.toolStripSeparator1,
            this.离职ToolStripMenuItem,
            this.toolStripSeparator2,
            this.休假ToolStripMenuItem});
            this.contextMenuStrip_state.Name = "contextMenuStrip_state";
            this.contextMenuStrip_state.Size = new System.Drawing.Size(101, 82);
            this.contextMenuStrip_state.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_state_ItemClicked);
            // 
            // 在职ToolStripMenuItem
            // 
            this.在职ToolStripMenuItem.Name = "在职ToolStripMenuItem";
            this.在职ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.在职ToolStripMenuItem.Text = "在职";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // 离职ToolStripMenuItem
            // 
            this.离职ToolStripMenuItem.Name = "离职ToolStripMenuItem";
            this.离职ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.离职ToolStripMenuItem.Text = "离职";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // 休假ToolStripMenuItem
            // 
            this.休假ToolStripMenuItem.Name = "休假ToolStripMenuItem";
            this.休假ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.休假ToolStripMenuItem.Text = "休假";
            // 
            // personMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 477);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_middle);
            this.Controls.Add(this.pal_top);
            this.Name = "personMgr";
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.personMgr_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_middle.ResumeLayout(false);
            this.pal_middle.PerformLayout();
            this.pal_fill.ResumeLayout(false);
            this.contextMenuStrip_state.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_signOut;
        private System.Windows.Forms.Button btn_state;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel pal_middle;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.ListView list_data;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_state;
        private System.Windows.Forms.ToolStripMenuItem 在职ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 离职ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 休假ToolStripMenuItem;
    }
}