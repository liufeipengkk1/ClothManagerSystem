namespace SalePersonUI
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.pal_top = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_saleperson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_jiesuan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_iddelete = new System.Windows.Forms.TextBox();
            this.lab_iddelete = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_office = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture_header = new System.Windows.Forms.PictureBox();
            this.pal_bottom = new System.Windows.Forms.Panel();
            this.lbl_showMoney = new System.Windows.Forms.Label();
            this.lbl_mark = new System.Windows.Forms.Label();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.dataGrid_cloth = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClothSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.pal_list = new System.Windows.Forms.Panel();
            this.list_name = new System.Windows.Forms.ListView();
            this.pal_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_header)).BeginInit();
            this.pal_bottom.SuspendLayout();
            this.pal_fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cloth)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.pal_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.Control;
            this.pal_top.Controls.Add(this.btn_search);
            this.pal_top.Controls.Add(this.txt_saleperson);
            this.pal_top.Controls.Add(this.label6);
            this.pal_top.Controls.Add(this.label5);
            this.pal_top.Controls.Add(this.lbl_jiesuan);
            this.pal_top.Controls.Add(this.label4);
            this.pal_top.Controls.Add(this.txt_iddelete);
            this.pal_top.Controls.Add(this.lab_iddelete);
            this.pal_top.Controls.Add(this.txt_id);
            this.pal_top.Controls.Add(this.lbl_id);
            this.pal_top.Controls.Add(this.lbl_state);
            this.pal_top.Controls.Add(this.lbl_office);
            this.pal_top.Controls.Add(this.lbl_name);
            this.pal_top.Controls.Add(this.label3);
            this.pal_top.Controls.Add(this.label2);
            this.pal_top.Controls.Add(this.label1);
            this.pal_top.Controls.Add(this.picture_header);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(913, 106);
            this.pal_top.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(831, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(21, 20);
            this.btn_search.TabIndex = 17;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_saleperson
            // 
            this.txt_saleperson.Location = new System.Drawing.Point(671, 42);
            this.txt_saleperson.Name = "txt_saleperson";
            this.txt_saleperson.Size = new System.Drawing.Size(154, 21);
            this.txt_saleperson.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "销 售 员：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "使用说明：F1:退款 F5刷新表单 control + enter 结算 F8更改密码";
            // 
            // lbl_jiesuan
            // 
            this.lbl_jiesuan.AutoSize = true;
            this.lbl_jiesuan.Location = new System.Drawing.Point(381, 45);
            this.lbl_jiesuan.Name = "lbl_jiesuan";
            this.lbl_jiesuan.Size = new System.Drawing.Size(23, 12);
            this.lbl_jiesuan.TabIndex = 13;
            this.lbl_jiesuan.Text = "lbl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "结算状态:";
            // 
            // txt_iddelete
            // 
            this.txt_iddelete.Location = new System.Drawing.Point(671, 72);
            this.txt_iddelete.Name = "txt_iddelete";
            this.txt_iddelete.Size = new System.Drawing.Size(185, 21);
            this.txt_iddelete.TabIndex = 11;
            this.txt_iddelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_iddelete_KeyDown);
            // 
            // lab_iddelete
            // 
            this.lab_iddelete.AutoSize = true;
            this.lab_iddelete.Location = new System.Drawing.Point(600, 75);
            this.lab_iddelete.Name = "lab_iddelete";
            this.lab_iddelete.Size = new System.Drawing.Size(65, 12);
            this.lab_iddelete.TabIndex = 10;
            this.lab_iddelete.Text = "删除商品：";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(383, 72);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(185, 21);
            this.txt_id.TabIndex = 8;
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(312, 75);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 12);
            this.lbl_id.TabIndex = 7;
            this.lbl_id.Text = "添加商品：";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(204, 75);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(53, 12);
            this.lbl_state.TabIndex = 6;
            this.lbl_state.Text = "网络正常";
            // 
            // lbl_office
            // 
            this.lbl_office.AutoSize = true;
            this.lbl_office.Location = new System.Drawing.Point(204, 46);
            this.lbl_office.Name = "lbl_office";
            this.lbl_office.Size = new System.Drawing.Size(41, 12);
            this.lbl_office.TabIndex = 5;
            this.lbl_office.Text = "销售员";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(202, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 12);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "saleperson";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "联网状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "职     务：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓     名：";
            // 
            // picture_header
            // 
            this.picture_header.Image = ((System.Drawing.Image)(resources.GetObject("picture_header.Image")));
            this.picture_header.Location = new System.Drawing.Point(2, 0);
            this.picture_header.Name = "picture_header";
            this.picture_header.Size = new System.Drawing.Size(98, 106);
            this.picture_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_header.TabIndex = 0;
            this.picture_header.TabStop = false;
            // 
            // pal_bottom
            // 
            this.pal_bottom.BackColor = System.Drawing.SystemColors.Control;
            this.pal_bottom.Controls.Add(this.lbl_showMoney);
            this.pal_bottom.Controls.Add(this.lbl_mark);
            this.pal_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_bottom.Location = new System.Drawing.Point(0, 340);
            this.pal_bottom.Name = "pal_bottom";
            this.pal_bottom.Size = new System.Drawing.Size(913, 138);
            this.pal_bottom.TabIndex = 1;
            // 
            // lbl_showMoney
            // 
            this.lbl_showMoney.AutoSize = true;
            this.lbl_showMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_showMoney.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_showMoney.Location = new System.Drawing.Point(66, 30);
            this.lbl_showMoney.Name = "lbl_showMoney";
            this.lbl_showMoney.Size = new System.Drawing.Size(131, 75);
            this.lbl_showMoney.TabIndex = 1;
            this.lbl_showMoney.Text = "100";
            // 
            // lbl_mark
            // 
            this.lbl_mark.AutoSize = true;
            this.lbl_mark.Font = new System.Drawing.Font("SimSun", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_mark.Location = new System.Drawing.Point(12, 42);
            this.lbl_mark.Name = "lbl_mark";
            this.lbl_mark.Size = new System.Drawing.Size(80, 56);
            this.lbl_mark.TabIndex = 0;
            this.lbl_mark.Text = "￥";
            // 
            // pal_fill
            // 
            this.pal_fill.Controls.Add(this.dataGrid_cloth);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 106);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(913, 234);
            this.pal_fill.TabIndex = 2;
            // 
            // dataGrid_cloth
            // 
            this.dataGrid_cloth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_cloth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LogoName,
            this.Style,
            this.Color,
            this.ClothSize,
            this.SalePrice});
            this.dataGrid_cloth.ContextMenuStrip = this.contextMenuStrip;
            this.dataGrid_cloth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_cloth.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_cloth.Name = "dataGrid_cloth";
            this.dataGrid_cloth.ReadOnly = true;
            this.dataGrid_cloth.RowTemplate.Height = 23;
            this.dataGrid_cloth.Size = new System.Drawing.Size(913, 234);
            this.dataGrid_cloth.TabIndex = 0;
            this.dataGrid_cloth.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_cloth_CellMouseEnter);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "条纹码";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // LogoName
            // 
            this.LogoName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LogoName.HeaderText = "品牌";
            this.LogoName.Name = "LogoName";
            this.LogoName.ReadOnly = true;
            // 
            // Style
            // 
            this.Style.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Style.HeaderText = "款式";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Color.HeaderText = "颜色";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // ClothSize
            // 
            this.ClothSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClothSize.HeaderText = "尺寸";
            this.ClothSize.Name = "ClothSize";
            this.ClothSize.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalePrice.HeaderText = "售价";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_delete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // ToolStripMenuItem_delete
            // 
            this.ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            this.ToolStripMenuItem_delete.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_delete.Text = "删除";
            this.ToolStripMenuItem_delete.Click += new System.EventHandler(this.ToolStripMenuItem_delete_Click);
            // 
            // pal_list
            // 
            this.pal_list.Controls.Add(this.list_name);
            this.pal_list.Location = new System.Drawing.Point(671, 67);
            this.pal_list.Name = "pal_list";
            this.pal_list.Size = new System.Drawing.Size(230, 188);
            this.pal_list.TabIndex = 18;
            // 
            // list_name
            // 
            this.list_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_name.FullRowSelect = true;
            this.list_name.GridLines = true;
            this.list_name.Location = new System.Drawing.Point(0, 0);
            this.list_name.MultiSelect = false;
            this.list_name.Name = "list_name";
            this.list_name.Size = new System.Drawing.Size(230, 188);
            this.list_name.TabIndex = 0;
            this.list_name.UseCompatibleStateImageBehavior = false;
            this.list_name.View = System.Windows.Forms.View.Details;
            this.list_name.DoubleClick += new System.EventHandler(this.list_name_DoubleClick);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 478);
            this.Controls.Add(this.pal_list);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_bottom);
            this.Controls.Add(this.pal_top);
            this.KeyPreview = true;
            this.Name = "Sale";
            this.Text = "销售平台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sale_KeyDown);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_header)).EndInit();
            this.pal_bottom.ResumeLayout(false);
            this.pal_bottom.PerformLayout();
            this.pal_fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cloth)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.pal_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Panel pal_bottom;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.DataGridView dataGrid_cloth;
        private System.Windows.Forms.Label lbl_mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClothSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_header;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label lbl_office;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_iddelete;
        private System.Windows.Forms.Label lab_iddelete;
        private System.Windows.Forms.Label lbl_showMoney;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.Label lbl_jiesuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_saleperson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel pal_list;
        private System.Windows.Forms.ListView list_name;
    }
}