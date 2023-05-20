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
    public partial class FRM_SHOW_STUDENTS : Form
    {
        BL.CLS_STUDENTS student = new BL.CLS_STUDENTS();
        int tempId;
        public FRM_SHOW_STUDENTS()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DayOfWeek wk = DateTime.Today.DayOfWeek;
                String hour = DateTime.Now.ToString("HH");
                FRM_STUDENT_FILE frm = new FRM_STUDENT_FILE();
                tempId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                frm.dgv_showAllCourses.DataSource = student.GET_STUDENT_COURSE_INFO(tempId);
                frm.dgv_currentCourses.DataSource = student.GET_CURRENT_COURSES_FOR_STUDENT_FILE(wk.ToString(), Convert.ToInt32(hour), studentId);
                frm.txtStudentId.Text = studentId.ToString();
                frm.txtFullName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtTelNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.ShowDialog();
                txtSearch.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("يوجد خطأ في البيانات المحددة");
            }

        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    dataGridView1.DataSource = student.SEARCH_ALL_STUDENTS(txtSearch.Text);
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("البيانات المدخلة خاطئة");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != null || dataGridView1.Rows[0].Cells[0].Value.ToString() != null)
            {
                txtSearch.Text = "بحث";
                dataGridView1.DataSource = null;
                txtSearch.Focus();
                Close();
            }
            else
            {
                Close();
            }
        }

       

    }
}
