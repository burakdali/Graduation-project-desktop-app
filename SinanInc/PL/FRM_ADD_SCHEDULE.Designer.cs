namespace SinanInc.PL
{
    partial class FRM_ADD_SCHEDULE
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_eHour = new System.Windows.Forms.DateTimePicker();
            this.dtp_sHour = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Day = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmBox_ClsRoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmBox_Class = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmBox_Course = new System.Windows.Forms.ComboBox();
            this.btnAddClassroom = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعديل";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAddClassroom);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(788, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 299);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmBox_ClsRoom);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmBox_Class);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmBox_Course);
            this.panel2.Controls.Add(this.dtp_Day);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtp_eHour);
            this.panel2.Controls.Add(this.dtp_sHour);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 299);
            this.panel2.TabIndex = 1;
            // 
            // dtp_eHour
            // 
            this.dtp_eHour.Location = new System.Drawing.Point(20, 188);
            this.dtp_eHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_eHour.Name = "dtp_eHour";
            this.dtp_eHour.RightToLeftLayout = true;
            this.dtp_eHour.Size = new System.Drawing.Size(233, 29);
            this.dtp_eHour.TabIndex = 19;
            // 
            // dtp_sHour
            // 
            this.dtp_sHour.Location = new System.Drawing.Point(20, 145);
            this.dtp_sHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_sHour.Name = "dtp_sHour";
            this.dtp_sHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_sHour.RightToLeftLayout = true;
            this.dtp_sHour.Size = new System.Drawing.Size(233, 29);
            this.dtp_sHour.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(271, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "ساعة الانتهاء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(276, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "ساعة البداية";
            // 
            // dtp_Day
            // 
            this.dtp_Day.Location = new System.Drawing.Point(20, 85);
            this.dtp_Day.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_Day.Name = "dtp_Day";
            this.dtp_Day.Size = new System.Drawing.Size(233, 29);
            this.dtp_Day.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(276, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "التاريخ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(689, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "القاعة";
            // 
            // cmBox_ClsRoom
            // 
            this.cmBox_ClsRoom.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_ClsRoom.FormattingEnabled = true;
            this.cmBox_ClsRoom.Location = new System.Drawing.Point(412, 188);
            this.cmBox_ClsRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmBox_ClsRoom.Name = "cmBox_ClsRoom";
            this.cmBox_ClsRoom.Size = new System.Drawing.Size(271, 30);
            this.cmBox_ClsRoom.TabIndex = 26;
            this.cmBox_ClsRoom.SelectedIndexChanged += new System.EventHandler(this.cmBox_ClsRoom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(689, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "الصف";
            // 
            // cmBox_Class
            // 
            this.cmBox_Class.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_Class.FormattingEnabled = true;
            this.cmBox_Class.Location = new System.Drawing.Point(412, 88);
            this.cmBox_Class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmBox_Class.Name = "cmBox_Class";
            this.cmBox_Class.Size = new System.Drawing.Size(271, 30);
            this.cmBox_Class.TabIndex = 24;
            this.cmBox_Class.SelectedValueChanged += new System.EventHandler(this.cmBox_Class_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(690, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "المادة";
            // 
            // cmBox_Course
            // 
            this.cmBox_Course.Font = new System.Drawing.Font("STC Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_Course.FormattingEnabled = true;
            this.cmBox_Course.Location = new System.Drawing.Point(412, 138);
            this.cmBox_Course.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmBox_Course.Name = "cmBox_Course";
            this.cmBox_Course.Size = new System.Drawing.Size(272, 30);
            this.cmBox_Course.TabIndex = 22;
            this.cmBox_Course.SelectedIndexChanged += new System.EventHandler(this.cmBox_Course_SelectedIndexChanged);
            // 
            // btnAddClassroom
            // 
            this.btnAddClassroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClassroom.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClassroom.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddClassroom.IconColor = System.Drawing.Color.Blue;
            this.btnAddClassroom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddClassroom.IconSize = 30;
            this.btnAddClassroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClassroom.Location = new System.Drawing.Point(0, 67);
            this.btnAddClassroom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddClassroom.Name = "btnAddClassroom";
            this.btnAddClassroom.Size = new System.Drawing.Size(228, 58);
            this.btnAddClassroom.TabIndex = 22;
            this.btnAddClassroom.Text = "إضافة قاعة جديدة";
            this.btnAddClassroom.UseVisualStyleBackColor = true;
            this.btnAddClassroom.Click += new System.EventHandler(this.btnAddClassroom_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.btnClose.IconColor = System.Drawing.Color.Red;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(0, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 58);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة للبرنامج";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FRM_ADD_SCHEDULE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 327);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("STC Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_SCHEDULE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة برنامج ";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_eHour;
        private System.Windows.Forms.DateTimePicker dtp_sHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.DateTimePicker dtp_Day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmBox_ClsRoom;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmBox_Class;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmBox_Course;
        private FontAwesome.Sharp.IconButton btnAddClassroom;
    }
}