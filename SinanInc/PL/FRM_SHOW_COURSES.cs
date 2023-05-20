using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinanInc.PL
{
    public partial class FRM_SHOW_COURSES : Form
    {
        BL.CLS_COURSE course = new BL.CLS_COURSE();
        public FRM_SHOW_COURSES()
        {
            InitializeComponent();

        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                FRM_ADD_NEW_COURSE frm = new FRM_ADD_NEW_COURSE();
                FRM_ADD_NEW_COURSE.identify = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                frm.txt_course_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.cmb_class_select.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.cmb_teacher_select.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.txt_price.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.btnAdd.Text = "تعديل";
                FRM_ADD_NEW_COURSE.state = "Edit";
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("يوجد خطأ في اجراء العملية");
            }

        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DialogResult diag = MessageBox.Show("سوف يتم حذف المقرر المحدد", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diag == DialogResult.Yes)
                {
                    course.DELETE_CURRENT_COURSE(id);
                    MessageBox.Show("تم حذف المقرر المحدد");
                    dataGridView1.DataSource = course.SEARCH_COURSES(txt_search.Text);
                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطأ في البيانات المدخلة");
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                dataGridView1.DataSource = course.SEARCH_COURSES(txt_search.Text);
                btnEdit.Enabled = true;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        
    }
}
