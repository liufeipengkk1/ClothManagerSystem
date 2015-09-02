namespace ClothUI.clothManager
{
    partial class AddActive
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.txt_activeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_choose = new System.Windows.Forms.Button();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.dataGrid_cloth = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClothSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pal_top.SuspendLayout();
            this.pal_fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cloth)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pal_top.Controls.Add(this.btn_ok);
            this.pal_top.Controls.Add(this.dateTimePicker_end);
            this.pal_top.Controls.Add(this.txt_activeID);
            this.pal_top.Controls.Add(this.label3);
            this.pal_top.Controls.Add(this.btn_choose);
            this.pal_top.Controls.Add(this.txt_reason);
            this.pal_top.Controls.Add(this.label2);
            this.pal_top.Controls.Add(this.dateTimePicker_start);
            this.pal_top.Controls.Add(this.label1);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(663, 150);
            this.pal_top.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(608, 12);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(37, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(470, 13);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(84, 21);
            this.dateTimePicker_end.TabIndex = 7;
            // 
            // txt_activeID
            // 
            this.txt_activeID.Location = new System.Drawing.Point(72, 13);
            this.txt_activeID.Name = "txt_activeID";
            this.txt_activeID.Size = new System.Drawing.Size(225, 21);
            this.txt_activeID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "活动编号：";
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(561, 12);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(41, 23);
            this.btn_choose.TabIndex = 4;
            this.btn_choose.Text = "选择";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(72, 43);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(573, 96);
            this.txt_reason.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "活动内容：";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(374, 13);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(84, 21);
            this.dateTimePicker_start.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "活动时间：";
            // 
            // pal_fill
            // 
            this.pal_fill.Controls.Add(this.dataGrid_cloth);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 150);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(663, 323);
            this.pal_fill.TabIndex = 1;
            // 
            // dataGrid_cloth
            // 
            this.dataGrid_cloth.AllowUserToOrderColumns = true;
            this.dataGrid_cloth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_cloth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.ClothSize,
            this.col5,
            this.col6});
            this.dataGrid_cloth.ContextMenuStrip = this.contextMenuStrip;
            this.dataGrid_cloth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_cloth.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_cloth.Name = "dataGrid_cloth";
            this.dataGrid_cloth.RowTemplate.Height = 23;
            this.dataGrid_cloth.Size = new System.Drawing.Size(663, 323);
            this.dataGrid_cloth.TabIndex = 0;
            this.dataGrid_cloth.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_cloth_CellMouseEnter);
            // 
            // col1
            // 
            this.col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1.HeaderText = "商品条纹码";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col2.HeaderText = "品牌";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col3.HeaderText = "款式";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col4.HeaderText = "颜色";
            this.col4.Name = "col4";
            // 
            // ClothSize
            // 
            this.ClothSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClothSize.HeaderText = "尺寸";
            this.ClothSize.Name = "ClothSize";
            // 
            // col5
            // 
            this.col5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col5.HeaderText = "原售价";
            this.col5.Name = "col5";
            // 
            // col6
            // 
            this.col6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col6.HeaderText = "活动售价";
            this.col6.Name = "col6";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.导出ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // AddActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 473);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_top);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddActive";
            this.Text = "添加活动";
            this.Load += new System.EventHandler(this.AddActive_Load);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            this.pal_fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cloth)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.DataGridView dataGrid_cloth;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_activeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClothSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6;

    }
}