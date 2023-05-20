using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinanInc.PL
{
    public partial class FRM_Main : Form
    {
        BL.CLS_STUDENTS student = new BL.CLS_STUDENTS();
        BL.CLS_CLASSES clas = new BL.CLS_CLASSES();
        BL.CLS_COURSE course = new BL.CLS_COURSE();
        BL.CLS_TEACHERS teacher = new BL.CLS_TEACHERS();

        
        private static FRM_Main frm;
        
        static void frm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_Main getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm=new FRM_Main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FRM_Main()
        {

            InitializeComponent();
            if (frm == null)
                frm = this;
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            String hour = DateTime. Now. ToString("HH");
            dataGridView1.DataSource = student.GET_TODAYS_SCHEDULE(wk.ToString());
            WindowState = FormWindowState.Maximized;
            Timer.Start();          
                        
            dgv_currentCourses.DataSource = course.GET_CURRENT_COURSES_FOR_MAIN(wk.ToString(),Convert.ToInt32(hour));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MM:dd:yyyy");

        }

       
   
        private void btnShowSt_Click(object sender, EventArgs e)
        {
            FRM_SHOW_STUDENTS frm = new FRM_SHOW_STUDENTS();
            frm.ShowDialog();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            FRM_SHOW_TEACHERS frm = new FRM_SHOW_TEACHERS();
            frm.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FRM_SCHEDULE frm = new FRM_SCHEDULE();
            frm.ShowDialog();
        }

        private void btnCoursesShow_Click(object sender, EventArgs e)
        {
            FRM_SHOW_COURSES frm = new FRM_SHOW_COURSES();
            frm.ShowDialog();
        }

        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            FRM_ADD_NEW_COURSE frm = new FRM_ADD_NEW_COURSE();
            FRM_ADD_NEW_COURSE.state = "Add";
            frm.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FRM_MAKE_APAYMENT frm = new FRM_MAKE_APAYMENT();
            frm.ShowDialog();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            FRM_SHOW_CLASSES frm = new FRM_SHOW_CLASSES();
            frm.ShowDialog();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            FRM_ADD_NEW_CLASS frm = new FRM_ADD_NEW_CLASS();
            frm.setIdentifier("Add");
            frm.ShowDialog();
        }

        private void btnClassroom_Click(object sender, EventArgs e)
        {
            FRM_CLASS_ROOM frm = new FRM_CLASS_ROOM();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           FRM_Login frm = new FRM_Login();
            frm.ShowDialog();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            FRM_Login frm = new FRM_Login();
            frm.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد من تسجيل الخروج", "تسجيل الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FRM_Main.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;

                FRM_Main.getMainForm.تسجيلالخروجToolStripMenuItem.Enabled = false;
                FRM_Main.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
                FRM_Main.getMainForm.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = false;

                FRM_Main.getMainForm.dataGridView1.Visible = false;
                FRM_Main.getMainForm.dgv_currentCourses.Visible = false;
                FRM_Main.getMainForm.btnlogin.Visible = true;
                FRM_Main.getMainForm.btnAddClass.Visible = false;
                FRM_Main.getMainForm.btnAddCourses.Visible = false;
                FRM_Main.getMainForm.btnClasses.Visible = false;
                FRM_Main.getMainForm.btnClassroom.Visible = false;
                FRM_Main.getMainForm.btnCoursesShow.Visible = false;
                FRM_Main.getMainForm.btnPayment.Visible = false;
                FRM_Main.getMainForm.btnShowSt.Visible = false;
                FRM_Main.getMainForm.btnTeachers.Visible = false;
                FRM_Main.getMainForm.iconButton2.Visible = false;
                FRM_Main.getMainForm.panel6.Visible = false;
                FRM_Main.getMainForm.panel5.Visible = false;
                FRM_Main.getMainForm.btnTeacherSalary.Visible = false;


            }
            else { }
        }

        private void btnTeacherSalary_Click(object sender, EventArgs e)
        {
            FRM_TEACHER_SALARY frm = new FRM_TEACHER_SALARY();
            frm.ShowDialog();
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void استعادةنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTORE frm = new FRM_RESTORE();
            frm.ShowDialog();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_CONFIG frm = new FRM_CONFIG();
            frm.ShowDialog();
        }

        
    }
}
