namespace SinanInc.PL
{
    partial class FRM_MAKE_APAYMENT
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
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSudentFnamePay = new System.Windows.Forms.TextBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShootBtn = new FontAwesome.Sharp.IconButton();
            this.btnColse = new FontAwesome.Sharp.IconButton();
            this.btnShowReport = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotlaPaid = new System.Windows.Forms.Label();
            this.lblRestAmount = new System.Windows.Forms.Label();
            this.lblStId = new System.Windows.Forms.Label();
            this.lblRepId = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchBox.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(3, 25);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(251, 40);
            this.txtSearchBox.TabIndex = 0;
            this.txtSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(849, 406);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtSudentFnamePay
            // 
            this.txtSudentFnamePay.Enabled = false;
            this.txtSudentFnamePay.Location = new System.Drawing.Point(566, 39);
            this.txtSudentFnamePay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSudentFnamePay.Name = "txtSudentFnamePay";
            this.txtSudentFnamePay.Size = new System.Drawing.Size(201, 29);
            this.txtSudentFnamePay.TabIndex = 3;
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(566, 86);
            this.txtPayAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(201, 29);
            this.txtPayAmount.TabIndex = 5;
            this.txtPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPayAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayAmount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "الاسم ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "معرف الطالب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(773, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "المبلغ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(566, 131);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 29);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "المبلغ المتبقي";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "المبلغ الكلي المدفوع";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "معرف التقرير";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShootBtn);
            this.groupBox1.Controls.Add(this.btnColse);
            this.groupBox1.Controls.Add(this.btnShowReport);
            this.groupBox1.Controls.Add(this.txtSearchBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 632);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات الاساسية";
            // 
            // ShootBtn
            // 
            this.ShootBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShootBtn.Enabled = false;
            this.ShootBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShootBtn.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootBtn.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.ShootBtn.IconColor = System.Drawing.Color.Blue;
            this.ShootBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ShootBtn.IconSize = 30;
            this.ShootBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShootBtn.Location = new System.Drawing.Point(3, 65);
            this.ShootBtn.Name = "ShootBtn";
            this.ShootBtn.Size = new System.Drawing.Size(251, 64);
            this.ShootBtn.TabIndex = 2;
            this.ShootBtn.Text = "تسديد";
            this.ShootBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShootBtn.UseVisualStyleBackColor = true;
            this.ShootBtn.Click += new System.EventHandler(this.ShootBtn_Click);
            // 
            // btnColse
            // 
            this.btnColse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnColse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColse.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColse.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.btnColse.IconColor = System.Drawing.Color.Red;
            this.btnColse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnColse.IconSize = 30;
            this.btnColse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColse.Location = new System.Drawing.Point(3, 565);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(251, 64);
            this.btnColse.TabIndex = 14;
            this.btnColse.Text = "إغلاق";
            this.btnColse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColse.UseVisualStyleBackColor = true;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.Font = new System.Drawing.Font("STC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnShowReport.IconColor = System.Drawing.Color.Blue;
            this.btnShowReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowReport.IconSize = 30;
            this.btnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowReport.Location = new System.Drawing.Point(3, 130);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(251, 64);
            this.btnShowReport.TabIndex = 12;
            this.btnShowReport.Text = "عرض تقرير المدفوعات";
            this.btnShowReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Visible = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 636);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(261, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 198);
            this.panel2.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotlaPaid);
            this.groupBox2.Controls.Add(this.lblRestAmount);
            this.groupBox2.Controls.Add(this.lblStId);
            this.groupBox2.Controls.Add(this.lblRepId);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSudentFnamePay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPayAmount);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 194);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات الاساسية";
            // 
            // lblTotlaPaid
            // 
            this.lblTotlaPaid.AutoSize = true;
            this.lblTotlaPaid.Location = new System.Drawing.Point(11, 97);
            this.lblTotlaPaid.Name = "lblTotlaPaid";
            this.lblTotlaPaid.Size = new System.Drawing.Size(40, 18);
            this.lblTotlaPaid.TabIndex = 23;
            this.lblTotlaPaid.Text = "Value";
            // 
            // lblRestAmount
            // 
            this.lblRestAmount.AutoSize = true;
            this.lblRestAmount.Location = new System.Drawing.Point(10, 71);
            this.lblRestAmount.Name = "lblRestAmount";
            this.lblRestAmount.Size = new System.Drawing.Size(40, 18);
            this.lblRestAmount.TabIndex = 22;
            this.lblRestAmount.Text = "Value";
            // 
            // lblStId
            // 
            this.lblStId.AutoSize = true;
            this.lblStId.Location = new System.Drawing.Point(11, 47);
            this.lblStId.Name = "lblStId";
            this.lblStId.Size = new System.Drawing.Size(40, 18);
            this.lblStId.TabIndex = 21;
            this.lblStId.Text = "Value";
            // 
            // lblRepId
            // 
            this.lblRepId.AutoSize = true;
            this.lblRepId.Location = new System.Drawing.Point(10, 25);
            this.lblRepId.Name = "lblRepId";
            this.lblRepId.Size = new System.Drawing.Size(40, 18);
            this.lblRepId.TabIndex = 20;
            this.lblRepId.Text = "Value";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(261, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 438);
            this.panel3.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 434);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الطلاب";
            // 
            // FRM_MAKE_APAYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1120, 636);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("STC Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_MAKE_APAYMENT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسديد دفعة مالية";
            this.Load += new System.EventHandler(this.FRM_MAKE_APAYMENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtSearchBox;
        public System.Windows.Forms.TextBox txtSudentFnamePay;
        public System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnShowReport;
        private FontAwesome.Sharp.IconButton btnColse;
        public System.Windows.Forms.Label lblStId;
        public System.Windows.Forms.Label lblRepId;
        public System.Windows.Forms.Label lblTotlaPaid;
        public System.Windows.Forms.Label lblRestAmount;
        public FontAwesome.Sharp.IconButton ShootBtn;
    }
}