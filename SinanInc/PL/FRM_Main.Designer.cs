namespace SinanInc.PL
{
    partial class FRM_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انشاءنسخةاحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.استعادةنسخةاحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_currentCourses = new System.Windows.Forms.DataGridView();
            this.btnlogin = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTeacherSalary = new FontAwesome.Sharp.IconButton();
            this.btnClassroom = new FontAwesome.Sharp.IconButton();
            this.btnAddClass = new FontAwesome.Sharp.IconButton();
            this.btnClasses = new FontAwesome.Sharp.IconButton();
            this.btnPayment = new FontAwesome.Sharp.IconButton();
            this.btnAddCourses = new FontAwesome.Sharp.IconButton();
            this.btnCoursesShow = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnTeachers = new FontAwesome.Sharp.IconButton();
            this.btnShowSt = new FontAwesome.Sharp.IconButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentCourses)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.انشاءنسخةاحتياطيةToolStripMenuItem,
            this.استعادةنسخةاحتياطيةToolStripMenuItem,
            this.تسجيلالخروجToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.ملفToolStripMenuItem.Text = "::::";
            // 
            // انشاءنسخةاحتياطيةToolStripMenuItem
            // 
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Name = "انشاءنسخةاحتياطيةToolStripMenuItem";
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Text = "انشاء نسخة احتياطية";
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Click += new System.EventHandler(this.انشاءنسخةاحتياطيةToolStripMenuItem_Click);
            // 
            // استعادةنسخةاحتياطيةToolStripMenuItem
            // 
            this.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةاحتياطيةToolStripMenuItem.Name = "استعادةنسخةاحتياطيةToolStripMenuItem";
            this.استعادةنسخةاحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.استعادةنسخةاحتياطيةToolStripMenuItem.Text = "استعادة نسخة احتياطية";
            this.استعادةنسخةاحتياطيةToolStripMenuItem.Click += new System.EventHandler(this.استعادةنسخةاحتياطيةToolStripMenuItem_Click);
            // 
            // تسجيلالخروجToolStripMenuItem
            // 
            this.تسجيلالخروجToolStripMenuItem.Enabled = false;
            this.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem";
            this.تسجيلالخروجToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج";
            this.تسجيلالخروجToolStripMenuItem.Click += new System.EventHandler(this.تسجيلالخروجToolStripMenuItem_Click);
            // 
            // lblDay
            // 
            this.lblDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDay.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDay.Location = new System.Drawing.Point(442, 14);
            this.lblDay.Name = "lblDay";
            this.lblDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDay.Size = new System.Drawing.Size(247, 56);
            this.lblDay.TabIndex = 35;
            this.lblDay.Text = "FRIDAY";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.BackColor = System.Drawing.Color.Transparent;
            this.lblSec.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSec.Location = new System.Drawing.Point(710, 110);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(45, 32);
            this.lblSec.TabIndex = 33;
            this.lblSec.Text = "00";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(553, 81);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(105, 39);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "22:22";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(374, 81);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(158, 39);
            this.lblDate.TabIndex = 31;
            this.lblDate.Text = "16:5:2020";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 725);
            this.panel1.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnlogin);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 585);
            this.panel4.TabIndex = 52;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(962, 356);
            this.panel6.TabIndex = 56;
            this.panel6.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 356);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المواد المقررة اليوم";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(956, 322);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 356);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(962, 229);
            this.panel5.TabIndex = 55;
            this.panel5.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_currentCourses);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المواد التي تعطى حاليا";
            // 
            // dgv_currentCourses
            // 
            this.dgv_currentCourses.AllowUserToAddRows = false;
            this.dgv_currentCourses.AllowUserToDeleteRows = false;
            this.dgv_currentCourses.AllowUserToResizeColumns = false;
            this.dgv_currentCourses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_currentCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_currentCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_currentCourses.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_currentCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_currentCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_currentCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_currentCourses.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_currentCourses.Location = new System.Drawing.Point(3, 31);
            this.dgv_currentCourses.MultiSelect = false;
            this.dgv_currentCourses.Name = "dgv_currentCourses";
            this.dgv_currentCourses.ReadOnly = true;
            this.dgv_currentCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_currentCourses.Size = new System.Drawing.Size(956, 195);
            this.dgv_currentCourses.TabIndex = 0;
            this.dgv_currentCourses.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlogin.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.btnlogin.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnlogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogin.IconSize = 40;
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.Location = new System.Drawing.Point(486, 41);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnlogin.Size = new System.Drawing.Size(227, 70);
            this.btnlogin.TabIndex = 54;
            this.btnlogin.Text = "تسجيل الدخول";
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblDay);
            this.panel3.Controls.Add(this.lblSec);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 140);
            this.panel3.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.btnTeacherSalary);
            this.panel2.Controls.Add(this.btnClassroom);
            this.panel2.Controls.Add(this.btnAddClass);
            this.panel2.Controls.Add(this.btnClasses);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.btnAddCourses);
            this.panel2.Controls.Add(this.btnCoursesShow);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.btnTeachers);
            this.panel2.Controls.Add(this.btnShowSt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(962, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 725);
            this.panel2.TabIndex = 50;
            // 
            // btnTeacherSalary
            // 
            this.btnTeacherSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacherSalary.FlatAppearance.BorderSize = 0;
            this.btnTeacherSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherSalary.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherSalary.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeacherSalary.IconChar = FontAwesome.Sharp.IconChar.Usps;
            this.btnTeacherSalary.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTeacherSalary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeacherSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherSalary.Location = new System.Drawing.Point(0, 540);
            this.btnTeacherSalary.Name = "btnTeacherSalary";
            this.btnTeacherSalary.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnTeacherSalary.Size = new System.Drawing.Size(282, 60);
            this.btnTeacherSalary.TabIndex = 58;
            this.btnTeacherSalary.Text = "تسديد اجور الاساتذة";
            this.btnTeacherSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacherSalary.UseVisualStyleBackColor = true;
            this.btnTeacherSalary.Visible = false;
            this.btnTeacherSalary.Click += new System.EventHandler(this.btnTeacherSalary_Click);
            // 
            // btnClassroom
            // 
            this.btnClassroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClassroom.FlatAppearance.BorderSize = 0;
            this.btnClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassroom.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassroom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClassroom.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnClassroom.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClassroom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClassroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassroom.Location = new System.Drawing.Point(0, 480);
            this.btnClassroom.Name = "btnClassroom";
            this.btnClassroom.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnClassroom.Size = new System.Drawing.Size(282, 60);
            this.btnClassroom.TabIndex = 57;
            this.btnClassroom.Text = "القاعات";
            this.btnClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassroom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClassroom.UseVisualStyleBackColor = true;
            this.btnClassroom.Visible = false;
            this.btnClassroom.Click += new System.EventHandler(this.btnClassroom_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddClass.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddClass.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClass.Location = new System.Drawing.Point(0, 420);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAddClass.Size = new System.Drawing.Size(282, 60);
            this.btnAddClass.TabIndex = 56;
            this.btnAddClass.Text = "إضافة صفوف جديدة";
            this.btnAddClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Visible = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnClasses
            // 
            this.btnClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasses.FlatAppearance.BorderSize = 0;
            this.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasses.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasses.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClasses.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnClasses.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClasses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClasses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClasses.Location = new System.Drawing.Point(0, 360);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnClasses.Size = new System.Drawing.Size(282, 60);
            this.btnClasses.TabIndex = 55;
            this.btnClasses.Text = "عرض الصفوف";
            this.btnClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClasses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Visible = false;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.btnPayment.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(0, 300);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnPayment.Size = new System.Drawing.Size(282, 60);
            this.btnPayment.TabIndex = 54;
            this.btnPayment.Text = "تسديد الاجور";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Visible = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnAddCourses
            // 
            this.btnAddCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCourses.FlatAppearance.BorderSize = 0;
            this.btnAddCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourses.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourses.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCourses.IconChar = FontAwesome.Sharp.IconChar.Plug;
            this.btnAddCourses.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCourses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourses.Location = new System.Drawing.Point(0, 240);
            this.btnAddCourses.Name = "btnAddCourses";
            this.btnAddCourses.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAddCourses.Size = new System.Drawing.Size(282, 60);
            this.btnAddCourses.TabIndex = 53;
            this.btnAddCourses.Text = "بدء دورة جديدة";
            this.btnAddCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCourses.UseVisualStyleBackColor = true;
            this.btnAddCourses.Visible = false;
            this.btnAddCourses.Click += new System.EventHandler(this.btnAddCourses_Click);
            // 
            // btnCoursesShow
            // 
            this.btnCoursesShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoursesShow.FlatAppearance.BorderSize = 0;
            this.btnCoursesShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoursesShow.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoursesShow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCoursesShow.IconChar = FontAwesome.Sharp.IconChar.Bong;
            this.btnCoursesShow.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCoursesShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCoursesShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoursesShow.Location = new System.Drawing.Point(0, 180);
            this.btnCoursesShow.Name = "btnCoursesShow";
            this.btnCoursesShow.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCoursesShow.Size = new System.Drawing.Size(282, 60);
            this.btnCoursesShow.TabIndex = 52;
            this.btnCoursesShow.Text = "عرض كل المواد";
            this.btnCoursesShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoursesShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCoursesShow.UseVisualStyleBackColor = true;
            this.btnCoursesShow.Visible = false;
            this.btnCoursesShow.Click += new System.EventHandler(this.btnCoursesShow_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconButton2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 120);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(282, 60);
            this.iconButton2.TabIndex = 51;
            this.iconButton2.Text = "برنامج الدوام";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Visible = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeachers.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnTeachers.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTeachers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.Location = new System.Drawing.Point(0, 60);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnTeachers.Size = new System.Drawing.Size(282, 60);
            this.btnTeachers.TabIndex = 49;
            this.btnTeachers.Text = "عرض الأساتذة";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Visible = false;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnShowSt
            // 
            this.btnShowSt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowSt.FlatAppearance.BorderSize = 0;
            this.btnShowSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSt.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowSt.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnShowSt.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowSt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowSt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowSt.Location = new System.Drawing.Point(0, 0);
            this.btnShowSt.Name = "btnShowSt";
            this.btnShowSt.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnShowSt.Size = new System.Drawing.Size(282, 60);
            this.btnShowSt.TabIndex = 48;
            this.btnShowSt.Text = "عرض جميع الطلاب";
            this.btnShowSt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowSt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowSt.UseVisualStyleBackColor = true;
            this.btnShowSt.Visible = false;
            this.btnShowSt.Click += new System.EventHandler(this.btnShowSt_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem1.Text = "اعدادات الاتصال بالسيرفر";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الواجهة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentCourses)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem انشاءنسخةاحتياطيةToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem استعادةنسخةاحتياطيةToolStripMenuItem;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dgv_currentCourses;
        public FontAwesome.Sharp.IconButton btnlogin;
        public FontAwesome.Sharp.IconButton btnShowSt;
        public FontAwesome.Sharp.IconButton btnTeachers;
        public FontAwesome.Sharp.IconButton iconButton2;
        public FontAwesome.Sharp.IconButton btnCoursesShow;
        public FontAwesome.Sharp.IconButton btnAddCourses;
        public FontAwesome.Sharp.IconButton btnPayment;
        public FontAwesome.Sharp.IconButton btnClasses;
        public FontAwesome.Sharp.IconButton btnAddClass;
        public FontAwesome.Sharp.IconButton btnClassroom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
        public FontAwesome.Sharp.IconButton btnTeacherSalary;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}