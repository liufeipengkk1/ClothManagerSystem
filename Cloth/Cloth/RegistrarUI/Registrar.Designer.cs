namespace RegistrarUI
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            this.pal_top = new System.Windows.Forms.Panel();
            this.lbl_netState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_uesrOffice = new System.Windows.Forms.Label();
            this.lbl_office = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.picture_header = new System.Windows.Forms.PictureBox();
            this.pal_bottom = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_uploadNum = new System.Windows.Forms.Label();
            this.lbl_upload = new System.Windows.Forms.Label();
            this.progressBar_upload = new System.Windows.Forms.ProgressBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.pal_fill = new System.Windows.Forms.Panel();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClothColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClothSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClothLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.pal_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_header)).BeginInit();
            this.pal_bottom.SuspendLayout();
            this.pal_fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pal_top
            // 
            this.pal_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pal_top.Controls.Add(this.lbl_netState);
            this.pal_top.Controls.Add(this.label1);
            this.pal_top.Controls.Add(this.lbl_uesrOffice);
            this.pal_top.Controls.Add(this.lbl_office);
            this.pal_top.Controls.Add(this.lbl_userName);
            this.pal_top.Controls.Add(this.lab_name);
            this.pal_top.Controls.Add(this.picture_header);
            this.pal_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_top.Location = new System.Drawing.Point(0, 0);
            this.pal_top.Name = "pal_top";
            this.pal_top.Size = new System.Drawing.Size(914, 100);
            this.pal_top.TabIndex = 0;
            // 
            // lbl_netState
            // 
            this.lbl_netState.AutoSize = true;
            this.lbl_netState.Location = new System.Drawing.Point(181, 75);
            this.lbl_netState.Name = "lbl_netState";
            this.lbl_netState.Size = new System.Drawing.Size(29, 12);
            this.lbl_netState.TabIndex = 6;
            this.lbl_netState.Text = "正常";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "联网状态：";
            // 
            // lbl_uesrOffice
            // 
            this.lbl_uesrOffice.AutoSize = true;
            this.lbl_uesrOffice.Location = new System.Drawing.Point(181, 47);
            this.lbl_uesrOffice.Name = "lbl_uesrOffice";
            this.lbl_uesrOffice.Size = new System.Drawing.Size(41, 12);
            this.lbl_uesrOffice.TabIndex = 4;
            this.lbl_uesrOffice.Text = "进货员";
            // 
            // lbl_office
            // 
            this.lbl_office.AutoSize = true;
            this.lbl_office.Location = new System.Drawing.Point(109, 47);
            this.lbl_office.Name = "lbl_office";
            this.lbl_office.Size = new System.Drawing.Size(65, 12);
            this.lbl_office.TabIndex = 3;
            this.lbl_office.Text = "职    务：";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(181, 13);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(17, 12);
            this.lbl_userName.TabIndex = 2;
            this.lbl_userName.Text = "刘";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(107, 13);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(65, 12);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "姓    名：";
            // 
            // picture_header
            // 
            this.picture_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_header.Image = ((System.Drawing.Image)(resources.GetObject("picture_header.Image")));
            this.picture_header.Location = new System.Drawing.Point(0, 0);
            this.picture_header.Name = "picture_header";
            this.picture_header.Size = new System.Drawing.Size(86, 100);
            this.picture_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_header.TabIndex = 0;
            this.picture_header.TabStop = false;
            // 
            // pal_bottom
            // 
            this.pal_bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pal_bottom.Controls.Add(this.label2);
            this.pal_bottom.Controls.Add(this.lbl_uploadNum);
            this.pal_bottom.Controls.Add(this.lbl_upload);
            this.pal_bottom.Controls.Add(this.progressBar_upload);
            this.pal_bottom.Controls.Add(this.btn_cancel);
            this.pal_bottom.Controls.Add(this.btn_ok);
            this.pal_bottom.Controls.Add(this.lbl_count);
            this.pal_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pal_bottom.Location = new System.Drawing.Point(0, 471);
            this.pal_bottom.Name = "pal_bottom";
            this.pal_bottom.Size = new System.Drawing.Size(914, 25);
            this.pal_bottom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(250, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "F1 导入清单；F2导出清单：F8 更改密码";
            // 
            // lbl_uploadNum
            // 
            this.lbl_uploadNum.AutoSize = true;
            this.lbl_uploadNum.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_uploadNum.ForeColor = System.Drawing.Color.Red;
            this.lbl_uploadNum.Location = new System.Drawing.Point(210, 5);
            this.lbl_uploadNum.Name = "lbl_uploadNum";
            this.lbl_uploadNum.Size = new System.Drawing.Size(19, 12);
            this.lbl_uploadNum.TabIndex = 5;
            this.lbl_uploadNum.Text = "23";
            // 
            // lbl_upload
            // 
            this.lbl_upload.AutoSize = true;
            this.lbl_upload.ForeColor = System.Drawing.Color.Red;
            this.lbl_upload.Location = new System.Drawing.Point(163, 5);
            this.lbl_upload.Name = "lbl_upload";
            this.lbl_upload.Size = new System.Drawing.Size(41, 12);
            this.lbl_upload.TabIndex = 4;
            this.lbl_upload.Text = "已上传";
            // 
            // progressBar_upload
            // 
            this.progressBar_upload.Location = new System.Drawing.Point(57, 3);
            this.progressBar_upload.Maximum = 10000;
            this.progressBar_upload.Name = "progressBar_upload";
            this.progressBar_upload.Size = new System.Drawing.Size(100, 19);
            this.progressBar_upload.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(827, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(746, 0);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_count.Location = new System.Drawing.Point(4, 4);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(35, 12);
            this.lbl_count.TabIndex = 0;
            this.lbl_count.Text = "共0件";
            // 
            // pal_fill
            // 
            this.pal_fill.Controls.Add(this.dataGridView_data);
            this.pal_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pal_fill.Location = new System.Drawing.Point(0, 100);
            this.pal_fill.Name = "pal_fill";
            this.pal_fill.Size = new System.Drawing.Size(914, 371);
            this.pal_fill.TabIndex = 2;
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LogoName,
            this.Style,
            this.ClothColor,
            this.ClothSize,
            this.Price,
            this.Standard,
            this.ClothLevel,
            this.Manufacture,
            this.Checkcode,
            this.UpLoad});
            this.dataGridView_data.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_data.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_data.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.RowTemplate.Height = 23;
            this.dataGridView_data.Size = new System.Drawing.Size(914, 371);
            this.dataGridView_data.TabIndex = 0;
            this.dataGridView_data.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_data_CellBeginEdit);
            this.dataGridView_data.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_data_CellEndEdit);
            this.dataGridView_data.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_data_CellMouseEnter);
            this.dataGridView_data.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_data_RowsAdded);
            this.dataGridView_data.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_data_RowsRemoved);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "条纹码";
            this.ID.Name = "ID";
            // 
            // LogoName
            // 
            this.LogoName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LogoName.HeaderText = "品牌";
            this.LogoName.Name = "LogoName";
            this.LogoName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LogoName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Style
            // 
            this.Style.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Style.HeaderText = "款式";
            this.Style.Name = "Style";
            // 
            // ClothColor
            // 
            this.ClothColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClothColor.HeaderText = "颜色";
            this.ClothColor.Name = "ClothColor";
            // 
            // ClothSize
            // 
            this.ClothSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClothSize.HeaderText = "尺码";
            this.ClothSize.Name = "ClothSize";
            this.ClothSize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClothSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "定价";
            this.Price.Name = "Price";
            // 
            // Standard
            // 
            this.Standard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Standard.HeaderText = "标准";
            this.Standard.Name = "Standard";
            // 
            // ClothLevel
            // 
            this.ClothLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClothLevel.HeaderText = "衣服等级";
            this.ClothLevel.Name = "ClothLevel";
            this.ClothLevel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClothLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Manufacture
            // 
            this.Manufacture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manufacture.HeaderText = "出产商";
            this.Manufacture.Name = "Manufacture";
            this.Manufacture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Manufacture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Checkcode
            // 
            this.Checkcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Checkcode.HeaderText = "校验码";
            this.Checkcode.Name = "Checkcode";
            // 
            // UpLoad
            // 
            this.UpLoad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpLoad.HeaderText = "上传状态";
            this.UpLoad.Name = "UpLoad";
            this.UpLoad.ReadOnly = true;
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
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 496);
            this.Controls.Add(this.pal_fill);
            this.Controls.Add(this.pal_bottom);
            this.Controls.Add(this.pal_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Registrar";
            this.Text = "进货员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Registrar_KeyDown);
            this.pal_top.ResumeLayout(false);
            this.pal_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_header)).EndInit();
            this.pal_bottom.ResumeLayout(false);
            this.pal_bottom.PerformLayout();
            this.pal_fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pal_top;
        private System.Windows.Forms.Panel pal_bottom;
        private System.Windows.Forms.Panel pal_fill;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.PictureBox picture_header;
        private System.Windows.Forms.Label lbl_uesrOffice;
        private System.Windows.Forms.Label lbl_office;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_netState;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.ProgressBar progressBar_upload;
        private System.Windows.Forms.Label lbl_upload;
        private System.Windows.Forms.Label lbl_uploadNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClothColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClothSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Standard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClothLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpLoad;
    }
}