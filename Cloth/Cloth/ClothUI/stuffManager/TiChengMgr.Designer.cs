namespace ClothUI.stuffManager
{
    partial class TiChengMgr
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
            this.dataGridView_TiCheng = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuIte_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.pal_bottom = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ways = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Down = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Up = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pal_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TiCheng)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.pal_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.Controls.Add(this.dataGridView_TiCheng);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(626, 391);
            this.pal_top.TabIndex = 0;
            // 
            // dataGridView_TiCheng
            // 
            this.dataGridView_TiCheng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TiCheng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoName,
            this.Ways,
            this.Down,
            this.Up,
            this.Money});
            this.dataGridView_TiCheng.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView_TiCheng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_TiCheng.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_TiCheng.Name = "dataGridView_TiCheng";
            this.dataGridView_TiCheng.RowTemplate.Height = 23;
            this.dataGridView_TiCheng.Size = new System.Drawing.Size(626, 391);
            this.dataGridView_TiCheng.TabIndex = 0;
            this.dataGridView_TiCheng.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TiCheng_CellEnter);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_modify,
            this.ToolStripMenuIte_delete,
            this.ToolStripMenuItem_insert});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 70);
            // 
            // ToolStripMenuItem_modify
            // 
            this.ToolStripMenuItem_modify.Name = "ToolStripMenuItem_modify";
            this.ToolStripMenuItem_modify.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_modify.Text = "修改";
            this.ToolStripMenuItem_modify.Click += new System.EventHandler(this.ToolStripMenuItem_modify_Click);
            // 
            // ToolStripMenuIte_delete
            // 
            this.ToolStripMenuIte_delete.Name = "ToolStripMenuIte_delete";
            this.ToolStripMenuIte_delete.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuIte_delete.Text = "删除";
            this.ToolStripMenuIte_delete.Click += new System.EventHandler(this.ToolStripMenuIte_delete_Click);
            // 
            // ToolStripMenuItem_insert
            // 
            this.ToolStripMenuItem_insert.Name = "ToolStripMenuItem_insert";
            this.ToolStripMenuItem_insert.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_insert.Text = "新增";
            this.ToolStripMenuItem_insert.Click += new System.EventHandler(this.ToolStripMenuItem_insert_Click);
            // 
            // pal_bottom
            // 
            this.pal_bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pal_bottom.Controls.Add(this.btn_cancel);
            this.pal_bottom.Controls.Add(this.btn_ok);
            this.pal_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_bottom.Location = new System.Drawing.Point(0, 357);
            this.pal_bottom.Name = "pal_bottom";
            this.pal_bottom.Size = new System.Drawing.Size(626, 34);
            this.pal_bottom.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(539, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(459, 5);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // SoName
            // 
            this.SoName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoName.HeaderText = "提成方案名称";
            this.SoName.Name = "SoName";
            this.SoName.ReadOnly = true;
            // 
            // Ways
            // 
            this.Ways.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ways.HeaderText = "方法";
            this.Ways.Name = "Ways";
            this.Ways.ReadOnly = true;
            this.Ways.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Down
            // 
            this.Down.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Down.HeaderText = "下限值";
            this.Down.Name = "Down";
            this.Down.ReadOnly = true;
            // 
            // Up
            // 
            this.Up.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Up.HeaderText = "上限值";
            this.Up.Name = "Up";
            this.Up.ReadOnly = true;
            // 
            // Money
            // 
            this.Money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Money.HeaderText = "金额（比例）";
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            // 
            // TiChengMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 391);
            this.Controls.Add(this.pal_bottom);
            this.Controls.Add(this.pal_top);
            this.Name = "TiChengMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提成管理";
            this.Load += new System.EventHandler(this.TiChengMgr_Load);
            this.pal_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TiCheng)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.pal_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Panel pal_bottom;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridView dataGridView_TiCheng;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_modify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuIte_delete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ways;
        private System.Windows.Forms.DataGridViewTextBoxColumn Down;
        private System.Windows.Forms.DataGridViewTextBoxColumn Up;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        //private System.Windows.Forms.DataGridViewTextBoxColumn SoName;
    }
}