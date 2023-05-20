using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BCrypt.Net;

namespace SinanInc.PL
{
    public partial class FRM_Login : Form
    {

        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        BL.CLS_STUDENTS student = new BL.CLS_STUDENTS();
        public string thisDay;

        const string password = "burakburak";

        
        

        public FRM_Login()
        {
            InitializeComponent();
            
        }

        

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            DataTable dt = log.Login(txtUserName.Text);
            if (dt.Rows.Count > 0)
            {

                if (BCrypt.Net.BCrypt.Verify(txtPwd.Text, dt.Rows[0][1].ToString()))
                {
                    FRM_Main.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;

                    FRM_Main.getMainForm.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    FRM_Main.getMainForm.تسجيلالخروجToolStripMenuItem.Enabled = true;
                    FRM_Main.getMainForm.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    FRM_Main.getMainForm.btnTeacherSalary.Visible = true;
                    FRM_Main.getMainForm.dataGridView1.Visible = true;
                    FRM_Main.getMainForm.dgv_currentCourses.Visible = true;
                    FRM_Main.getMainForm.btnlogin.Visible = false;
                    FRM_Main.getMainForm.btnAddClass.Visible = true;
                    FRM_Main.getMainForm.btnAddCourses.Visible = true;
                    FRM_Main.getMainForm.btnClasses.Visible = true;
                    FRM_Main.getMainForm.btnClassroom.Visible = true;
                    FRM_Main.getMainForm.btnCoursesShow.Visible = true;
                    FRM_Main.getMainForm.btnPayment.Visible = true;
                    FRM_Main.getMainForm.btnShowSt.Visible = true;
                    FRM_Main.getMainForm.btnTeachers.Visible = true;
                    FRM_Main.getMainForm.iconButton2.Visible = true;
                    FRM_Main.getMainForm.panel6.Visible = true;
                    FRM_Main.getMainForm.panel5.Visible = true;
                    Program.UserName = dt.Rows[0][1].ToString();

                    FRM_Main.getMainForm.menuStrip1.Visible = true;
                }
                else
                {
                    MessageBox.Show("كلمة السر خاطئة");
                }
            }
            else
            {
                MessageBox.Show("المستخدم غير مسجل في قاعدة البيانات");
            }


            //FRM_Main.getMainForm.dataGridView1.DataSource = student.GET_STUDENTS_BY_SPECIFIED_DAY_FOR_MAIN(thisDay);


            this.Close();
        }

        

        

    }
}
