namespace ClothUI
{
    partial class AddPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPerson));
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_sex = new System.Windows.Forms.TextBox();
            this.txt_birday = new System.Windows.Forms.TextBox();
            this.btn_birthday = new System.Windows.Forms.Button();
            this.pal_dayChoose = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_today = new System.Windows.Forms.Button();
            this.monthCal_choose = new System.Windows.Forms.MonthCalendar();
            this.btn_entryTime = new System.Windows.Forms.Button();
            this.txt_entryTime = new System.Windows.Forms.TextBox();
            this.txt_nation = new System.Windows.Forms.TextBox();
            this.txt_hometown = new System.Windows.Forms.TextBox();
            this.txt_edu = new System.Windows.Forms.TextBox();
            this.txt_specialty = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_school = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_telnumber = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_bankNumber = new System.Windows.Forms.TextBox();
            this.toolTip_BankNumber = new System.Windows.Forms.ToolTip(this.components);
            this.pal_bankNumber = new System.Windows.Forms.Panel();
            this.txt_bankNumberTop = new System.Windows.Forms.TextBox();
            this.txt_bankName = new System.Windows.Forms.TextBox();
            this.cbx_department = new System.Windows.Forms.ComboBox();
            this.cbx_office = new System.Windows.Forms.ComboBox();
            this.txt_zhicheng = new System.Windows.Forms.TextBox();
            this.txt_resume = new System.Windows.Forms.TextBox();
            this.txt_mark = new System.Windows.Forms.TextBox();
            this.btn_personOK = new System.Windows.Forms.Button();
            this.btn_personCancel = new System.Windows.Forms.Button();
            this.pic_header = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip_picHead = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_upLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_takePic = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_setPhoto = new System.Windows.Forms.Button();
            this.btn_deletePhoto = new System.Windows.Forms.Button();
            this.pal_tkPhoto = new System.Windows.Forms.Panel();
            this.pal_tkPhoto_photo = new System.Windows.Forms.Panel();
            this.btn_takephoto = new System.Windows.Forms.Button();
            this.btn_photoCancel = new System.Windows.Forms.Button();
            this.pic_photo = new System.Windows.Forms.PictureBox();
            this.pal_dayChoose.SuspendLayout();
            this.pal_bankNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header)).BeginInit();
            this.contextMenuStrip_picHead.SuspendLayout();
            this.pal_tkPhoto.SuspendLayout();
            this.pal_tkPhoto_photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(83, 81);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(103, 19);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.Text = "刘飞鹏";
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sex
            // 
            this.txt_sex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sex.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_sex.Location = new System.Drawing.Point(293, 81);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(103, 19);
            this.txt_sex.TabIndex = 1;
            this.txt_sex.Text = "男";
            this.txt_sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_birday
            // 
            this.txt_birday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_birday.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_birday.Location = new System.Drawing.Point(83, 117);
            this.txt_birday.Name = "txt_birday";
            this.txt_birday.Size = new System.Drawing.Size(103, 19);
            this.txt_birday.TabIndex = 2;
            this.txt_birday.Text = "刘飞鹏";
            this.txt_birday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_birthday
            // 
            this.btn_birthday.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_birthday.BackgroundImage")));
            this.btn_birthday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_birthday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_birthday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_birthday.Location = new System.Drawing.Point(192, 116);
            this.btn_birthday.Name = "btn_birthday";
            this.btn_birthday.Size = new System.Drawing.Size(22, 23);
            this.btn_birthday.TabIndex = 3;
            this.btn_birthday.UseVisualStyleBackColor = true;
            this.btn_birthday.Click += new System.EventHandler(this.btn_birthday_Click);
            // 
            // pal_dayChoose
            // 
            this.pal_dayChoose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pal_dayChoose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pal_dayChoose.Controls.Add(this.btn_cancel);
            this.pal_dayChoose.Controls.Add(this.btn_today);
            this.pal_dayChoose.Controls.Add(this.monthCal_choose);
            this.pal_dayChoose.Location = new System.Drawing.Point(123, 144);
            this.pal_dayChoose.Name = "pal_dayChoose";
            this.pal_dayChoose.Size = new System.Drawing.Size(0, 0);
            this.pal_dayChoose.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(174, 181);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(43, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_today
            // 
            this.btn_today.Location = new System.Drawing.Point(123, 181);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(44, 23);
            this.btn_today.TabIndex = 1;
            this.btn_today.Text = "今天";
            this.btn_today.UseVisualStyleBackColor = true;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // monthCal_choose
            // 
            this.monthCal_choose.Location = new System.Drawing.Point(0, 0);
            this.monthCal_choose.Name = "monthCal_choose";
            this.monthCal_choose.TabIndex = 0;
            this.monthCal_choose.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btn_entryTime
            // 
            this.btn_entryTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_entryTime.BackgroundImage")));
            this.btn_entryTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_entryTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_entryTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entryTime.Location = new System.Drawing.Point(402, 116);
            this.btn_entryTime.Name = "btn_entryTime";
            this.btn_entryTime.Size = new System.Drawing.Size(22, 23);
            this.btn_entryTime.TabIndex = 6;
            this.btn_entryTime.UseVisualStyleBackColor = true;
            this.btn_entryTime.Click += new System.EventHandler(this.btn_entryTime_Click);
            // 
            // txt_entryTime
            // 
            this.txt_entryTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_entryTime.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_entryTime.Location = new System.Drawing.Point(293, 117);
            this.txt_entryTime.Name = "txt_entryTime";
            this.txt_entryTime.Size = new System.Drawing.Size(103, 19);
            this.txt_entryTime.TabIndex = 5;
            this.txt_entryTime.Text = "刘飞鹏";
            this.txt_entryTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nation
            // 
            this.txt_nation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nation.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_nation.Location = new System.Drawing.Point(83, 151);
            this.txt_nation.Name = "txt_nation";
            this.txt_nation.Size = new System.Drawing.Size(103, 19);
            this.txt_nation.TabIndex = 7;
            this.txt_nation.Text = "汉";
            this.txt_nation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_hometown
            // 
            this.txt_hometown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hometown.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_hometown.Location = new System.Drawing.Point(293, 151);
            this.txt_hometown.Name = "txt_hometown";
            this.txt_hometown.Size = new System.Drawing.Size(103, 19);
            this.txt_hometown.TabIndex = 8;
            this.txt_hometown.Text = "临武";
            this.txt_hometown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_edu
            // 
            this.txt_edu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_edu.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_edu.Location = new System.Drawing.Point(83, 187);
            this.txt_edu.Name = "txt_edu";
            this.txt_edu.Size = new System.Drawing.Size(103, 19);
            this.txt_edu.TabIndex = 9;
            this.txt_edu.Text = "本科";
            this.txt_edu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_specialty
            // 
            this.txt_specialty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_specialty.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_specialty.Location = new System.Drawing.Point(293, 187);
            this.txt_specialty.Name = "txt_specialty";
            this.txt_specialty.Size = new System.Drawing.Size(103, 19);
            this.txt_specialty.TabIndex = 10;
            this.txt_specialty.Text = "计算机";
            this.txt_specialty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_id.Location = new System.Drawing.Point(83, 222);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(137, 16);
            this.txt_id.TabIndex = 11;
            this.txt_id.Text = "431025199307021236";
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_email.Location = new System.Drawing.Point(294, 223);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(131, 16);
            this.txt_email.TabIndex = 12;
            this.txt_email.Text = "763567527@qq.com";
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_school
            // 
            this.txt_school.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_school.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_school.Location = new System.Drawing.Point(83, 256);
            this.txt_school.Name = "txt_school";
            this.txt_school.Size = new System.Drawing.Size(341, 19);
            this.txt_school.TabIndex = 13;
            this.txt_school.Text = "四川大学计算机学院";
            this.txt_school.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_address
            // 
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_address.Location = new System.Drawing.Point(83, 294);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(208, 19);
            this.txt_address.TabIndex = 14;
            this.txt_address.Text = "四川大学计算机学院";
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_telnumber
            // 
            this.txt_telnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telnumber.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_telnumber.Location = new System.Drawing.Point(383, 294);
            this.txt_telnumber.Name = "txt_telnumber";
            this.txt_telnumber.Size = new System.Drawing.Size(185, 19);
            this.txt_telnumber.TabIndex = 15;
            this.txt_telnumber.Text = "18708170502";
            this.txt_telnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_salary
            // 
            this.txt_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_salary.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_salary.Location = new System.Drawing.Point(83, 329);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(103, 19);
            this.txt_salary.TabIndex = 16;
            this.txt_salary.Text = "50000";
            this.txt_salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bankNumber
            // 
            this.txt_bankNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bankNumber.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_bankNumber.Location = new System.Drawing.Point(293, 330);
            this.txt_bankNumber.Name = "txt_bankNumber";
            this.txt_bankNumber.Size = new System.Drawing.Size(103, 16);
            this.txt_bankNumber.TabIndex = 17;
            this.txt_bankNumber.Text = "6227003819030396710";
            this.txt_bankNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bankNumber.TextChanged += new System.EventHandler(this.txt_bankNumber_TextChanged);
            this.txt_bankNumber.MouseEnter += new System.EventHandler(this.txt_bankNumber_MouseEnter);
            this.txt_bankNumber.MouseLeave += new System.EventHandler(this.txt_bankNumber_MouseLeave);
            this.txt_bankNumber.MouseHover += new System.EventHandler(this.txt_bankNumber_MouseHover);
            // 
            // pal_bankNumber
            // 
            this.pal_bankNumber.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pal_bankNumber.Controls.Add(this.txt_bankNumberTop);
            this.pal_bankNumber.Location = new System.Drawing.Point(247, 281);
            this.pal_bankNumber.Name = "pal_bankNumber";
            this.pal_bankNumber.Size = new System.Drawing.Size(0, 0);
            this.pal_bankNumber.TabIndex = 18;
            // 
            // txt_bankNumberTop
            // 
            this.txt_bankNumberTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_bankNumberTop.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_bankNumberTop.Location = new System.Drawing.Point(0, 0);
            this.txt_bankNumberTop.Name = "txt_bankNumberTop";
            this.txt_bankNumberTop.Size = new System.Drawing.Size(0, 33);
            this.txt_bankNumberTop.TabIndex = 0;
            // 
            // txt_bankName
            // 
            this.txt_bankName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bankName.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_bankName.Location = new System.Drawing.Point(472, 330);
            this.txt_bankName.Name = "txt_bankName";
            this.txt_bankName.Size = new System.Drawing.Size(96, 19);
            this.txt_bankName.TabIndex = 19;
            this.txt_bankName.Text = "中国建设银行";
            this.txt_bankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbx_department
            // 
            this.cbx_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_department.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_department.FormattingEnabled = true;
            this.cbx_department.Location = new System.Drawing.Point(105, 358);
            this.cbx_department.Name = "cbx_department";
            this.cbx_department.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_department.Size = new System.Drawing.Size(109, 28);
            this.cbx_department.TabIndex = 20;
            this.cbx_department.Text = "xxx部";
            // 
            // cbx_office
            // 
            this.cbx_office.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_office.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_office.FormattingEnabled = true;
            this.cbx_office.Location = new System.Drawing.Point(294, 358);
            this.cbx_office.Name = "cbx_office";
            this.cbx_office.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_office.Size = new System.Drawing.Size(102, 28);
            this.cbx_office.TabIndex = 21;
            this.cbx_office.Text = "销售员";
            // 
            // txt_zhicheng
            // 
            this.txt_zhicheng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_zhicheng.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_zhicheng.Location = new System.Drawing.Point(472, 362);
            this.txt_zhicheng.Name = "txt_zhicheng";
            this.txt_zhicheng.Size = new System.Drawing.Size(84, 19);
            this.txt_zhicheng.TabIndex = 22;
            this.txt_zhicheng.Text = "无职称";
            this.txt_zhicheng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_resume
            // 
            this.txt_resume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_resume.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_resume.Location = new System.Drawing.Point(82, 392);
            this.txt_resume.Multiline = true;
            this.txt_resume.Name = "txt_resume";
            this.txt_resume.Size = new System.Drawing.Size(485, 124);
            this.txt_resume.TabIndex = 23;
            this.txt_resume.Text = "不得了";
            // 
            // txt_mark
            // 
            this.txt_mark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mark.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_mark.Location = new System.Drawing.Point(82, 527);
            this.txt_mark.Multiline = true;
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(485, 120);
            this.txt_mark.TabIndex = 24;
            this.txt_mark.Text = "无";
            // 
            // btn_personOK
            // 
            this.btn_personOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_personOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personOK.Image = ((System.Drawing.Image)(resources.GetObject("btn_personOK.Image")));
            this.btn_personOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personOK.Location = new System.Drawing.Point(447, 661);
            this.btn_personOK.Name = "btn_personOK";
            this.btn_personOK.Size = new System.Drawing.Size(57, 23);
            this.btn_personOK.TabIndex = 25;
            this.btn_personOK.Text = "确定";
            this.btn_personOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_personOK.UseVisualStyleBackColor = true;
            this.btn_personOK.Click += new System.EventHandler(this.btn_personOK_Click);
            // 
            // btn_personCancel
            // 
            this.btn_personCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_personCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personCancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_personCancel.Image")));
            this.btn_personCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personCancel.Location = new System.Drawing.Point(510, 661);
            this.btn_personCancel.Name = "btn_personCancel";
            this.btn_personCancel.Size = new System.Drawing.Size(57, 23);
            this.btn_personCancel.TabIndex = 26;
            this.btn_personCancel.Text = "取消";
            this.btn_personCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_personCancel.UseVisualStyleBackColor = true;
            this.btn_personCancel.Click += new System.EventHandler(this.btn_personCancel_Click);
            // 
            // pic_header
            // 
            this.pic_header.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pic_header.ContextMenuStrip = this.contextMenuStrip_picHead;
            this.pic_header.Location = new System.Drawing.Point(439, 78);
            this.pic_header.Name = "pic_header";
            this.pic_header.Size = new System.Drawing.Size(128, 197);
            this.pic_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_header.TabIndex = 27;
            this.pic_header.TabStop = false;
            // 
            // contextMenuStrip_picHead
            // 
            this.contextMenuStrip_picHead.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_upLoad,
            this.menu_takePic});
            this.contextMenuStrip_picHead.Name = "contextMenuStrip_picHead";
            this.contextMenuStrip_picHead.Size = new System.Drawing.Size(137, 48);
            // 
            // menu_upLoad
            // 
            this.menu_upLoad.Name = "menu_upLoad";
            this.menu_upLoad.Size = new System.Drawing.Size(136, 22);
            this.menu_upLoad.Text = "从电脑上传";
            this.menu_upLoad.Click += new System.EventHandler(this.menu_upLoad_Click);
            // 
            // menu_takePic
            // 
            this.menu_takePic.Name = "menu_takePic";
            this.menu_takePic.Size = new System.Drawing.Size(136, 22);
            this.menu_takePic.Text = "摄像头拍照";
            this.menu_takePic.Click += new System.EventHandler(this.menu_takePic_Click);
            // 
            // btn_setPhoto
            // 
            this.btn_setPhoto.FlatAppearance.BorderSize = 0;
            this.btn_setPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btn_setPhoto.Image")));
            this.btn_setPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setPhoto.Location = new System.Drawing.Point(430, 45);
            this.btn_setPhoto.Name = "btn_setPhoto";
            this.btn_setPhoto.Size = new System.Drawing.Size(67, 23);
            this.btn_setPhoto.TabIndex = 28;
            this.btn_setPhoto.Text = "贴照片";
            this.btn_setPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setPhoto.UseVisualStyleBackColor = true;
            this.btn_setPhoto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_setPhoto_MouseClick);
            // 
            // btn_deletePhoto
            // 
            this.btn_deletePhoto.FlatAppearance.BorderSize = 0;
            this.btn_deletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePhoto.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletePhoto.Image")));
            this.btn_deletePhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deletePhoto.Location = new System.Drawing.Point(499, 45);
            this.btn_deletePhoto.Name = "btn_deletePhoto";
            this.btn_deletePhoto.Size = new System.Drawing.Size(67, 23);
            this.btn_deletePhoto.TabIndex = 29;
            this.btn_deletePhoto.Text = "删照片";
            this.btn_deletePhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deletePhoto.UseVisualStyleBackColor = true;
            this.btn_deletePhoto.Click += new System.EventHandler(this.btn_deletePhoto_Click);
            // 
            // pal_tkPhoto
            // 
            this.pal_tkPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pal_tkPhoto.Controls.Add(this.btn_photoCancel);
            this.pal_tkPhoto.Controls.Add(this.btn_takephoto);
            this.pal_tkPhoto.Controls.Add(this.pal_tkPhoto_photo);
            this.pal_tkPhoto.Location = new System.Drawing.Point(127, 74);
            this.pal_tkPhoto.Name = "pal_tkPhoto";
            this.pal_tkPhoto.Size = new System.Drawing.Size(444, 356);
            this.pal_tkPhoto.TabIndex = 30;
            // 
            // pal_tkPhoto_photo
            // 
            this.pal_tkPhoto_photo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pal_tkPhoto_photo.Controls.Add(this.pic_photo);
            this.pal_tkPhoto_photo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pal_tkPhoto_photo.Location = new System.Drawing.Point(0, 0);
            this.pal_tkPhoto_photo.Name = "pal_tkPhoto_photo";
            this.pal_tkPhoto_photo.Size = new System.Drawing.Size(444, 324);
            this.pal_tkPhoto_photo.TabIndex = 0;
            // 
            // btn_takephoto
            // 
            this.btn_takephoto.Location = new System.Drawing.Point(275, 330);
            this.btn_takephoto.Name = "btn_takephoto";
            this.btn_takephoto.Size = new System.Drawing.Size(75, 23);
            this.btn_takephoto.TabIndex = 1;
            this.btn_takephoto.Text = "拍照";
            this.btn_takephoto.UseVisualStyleBackColor = true;
            this.btn_takephoto.Click += new System.EventHandler(this.btn_takephoto_Click);
            // 
            // btn_photoCancel
            // 
            this.btn_photoCancel.Location = new System.Drawing.Point(364, 330);
            this.btn_photoCancel.Name = "btn_photoCancel";
            this.btn_photoCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_photoCancel.TabIndex = 2;
            this.btn_photoCancel.Text = "取消";
            this.btn_photoCancel.UseVisualStyleBackColor = true;
            this.btn_photoCancel.Click += new System.EventHandler(this.btn_photoCancel_Click);
            // 
            // pic_photo
            // 
            this.pic_photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_photo.Location = new System.Drawing.Point(0, 0);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(444, 324);
            this.pic_photo.TabIndex = 0;
            this.pic_photo.TabStop = false;
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(580, 686);
            this.Controls.Add(this.pal_tkPhoto);
            this.Controls.Add(this.btn_deletePhoto);
            this.Controls.Add(this.btn_setPhoto);
            this.Controls.Add(this.pal_dayChoose);
            this.Controls.Add(this.pic_header);
            this.Controls.Add(this.btn_personCancel);
            this.Controls.Add(this.btn_personOK);
            this.Controls.Add(this.txt_mark);
            this.Controls.Add(this.txt_resume);
            this.Controls.Add(this.txt_zhicheng);
            this.Controls.Add(this.cbx_office);
            this.Controls.Add(this.cbx_department);
            this.Controls.Add(this.txt_bankName);
            this.Controls.Add(this.pal_bankNumber);
            this.Controls.Add(this.txt_bankNumber);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_telnumber);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_school);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_specialty);
            this.Controls.Add(this.txt_edu);
            this.Controls.Add(this.txt_hometown);
            this.Controls.Add(this.txt_nation);
            this.Controls.Add(this.btn_entryTime);
            this.Controls.Add(this.txt_entryTime);
            this.Controls.Add(this.btn_birthday);
            this.Controls.Add(this.txt_birday);
            this.Controls.Add(this.txt_sex);
            this.Controls.Add(this.txt_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "AddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.AddPerson_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddPerson_KeyDown);
            this.pal_dayChoose.ResumeLayout(false);
            this.pal_bankNumber.ResumeLayout(false);
            this.pal_bankNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header)).EndInit();
            this.contextMenuStrip_picHead.ResumeLayout(false);
            this.pal_tkPhoto.ResumeLayout(false);
            this.pal_tkPhoto_photo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_sex;
        private System.Windows.Forms.TextBox txt_birday;
        private System.Windows.Forms.Button btn_birthday;
        private System.Windows.Forms.Panel pal_dayChoose;
        private System.Windows.Forms.MonthCalendar monthCal_choose;
        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.Button btn_entryTime;
        private System.Windows.Forms.TextBox txt_entryTime;
        private System.Windows.Forms.TextBox txt_nation;
        private System.Windows.Forms.TextBox txt_hometown;
        private System.Windows.Forms.TextBox txt_edu;
        private System.Windows.Forms.TextBox txt_specialty;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_school;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_telnumber;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_bankNumber;
        private System.Windows.Forms.ToolTip toolTip_BankNumber;
        private System.Windows.Forms.Panel pal_bankNumber;
        private System.Windows.Forms.TextBox txt_bankNumberTop;
        private System.Windows.Forms.TextBox txt_bankName;
        private System.Windows.Forms.ComboBox cbx_department;
        private System.Windows.Forms.ComboBox cbx_office;
        private System.Windows.Forms.TextBox txt_zhicheng;
        private System.Windows.Forms.TextBox txt_resume;
        private System.Windows.Forms.TextBox txt_mark;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_personOK;
        private System.Windows.Forms.Button btn_personCancel;
        private System.Windows.Forms.PictureBox pic_header;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_picHead;
        private System.Windows.Forms.ToolStripMenuItem menu_upLoad;
        private System.Windows.Forms.ToolStripMenuItem menu_takePic;
        private System.Windows.Forms.Button btn_setPhoto;
        private System.Windows.Forms.Button btn_deletePhoto;
        private System.Windows.Forms.Panel pal_tkPhoto;
        private System.Windows.Forms.Button btn_photoCancel;
        private System.Windows.Forms.Button btn_takephoto;
        private System.Windows.Forms.Panel pal_tkPhoto_photo;
        private System.Windows.Forms.PictureBox pic_photo;
    }
}