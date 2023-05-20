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
    public partial class FRM_ADD_NEW_COURSE : Form
    {
        BL.CLS_TEACHERS teacher = new BL.CLS_TEACHERS();
        BL.CLS_COURSE course = new BL.CLS_COURSE();
        BL.CLS_CLASSES clas = new BL.CLS_CLASSES();
        BL.CLS_STUDENTS student = new BL.CLS_STUDENTS();
        FRM_SHOW_COURSES show = new FRM_SHOW_COURSES();
        public static string state;
        public static int identify;

        int id;
       
        public FRM_ADD_NEW_COURSE()
        {
            InitializeComponent();
            try
            {
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                dt = student.GET_ALL_CLASSES_FOR_ADDING_STUDENT();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string myString = dt.Rows[i][0].ToString();
                    cmb_class_select.Items.Add(myString);
                }

                dt2 = teacher.GET_ALL_TEACHERS_FOR_ADDING_COURSE();

                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    string str = dt2.Rows[j][0].ToString();
                    cmb_teacher_select.Items.Add(str);
                }
            }
            catch (Exception)
            {
                
            }
            
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int val, percent, price, salary;
                price = Convert.ToInt32(txt_price.Text);
                DataTable dt = new DataTable();
                dt = course.GET_ALL_COURCES();
                int clasId = Convert.ToInt32(clas.GET_CLASS_ID_FROM_NAME(cmb_class_select.Text).Rows[0][0].ToString());


                if (rdbtnActive.Checked)
                {
                    val = 1;
                }
                else { val = 0; }

                if (txt_course_name.Text != "" && txt_price.Text != "" && cmb_class_select.Text != "" && cmb_teacher_select.Text != "")
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (txt_course_name.Text == dt.Rows[i][2].ToString() && clasId == Convert.ToInt32(dt.Rows[i][1].ToString()))
                        {
                            MessageBox.Show("المقرر المراد اضافته موجود مسبقا", "غير ممكن", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                    DialogResult result = MessageBox.Show("سوف يتم اضافة المقرر", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        int id = Convert.ToInt32(teacher.GET_TEACHER_ID_FROM_NAME(cmb_teacher_select.Text).Rows[0][0].ToString());
                        if (state == "Add")
                        {
                            course.ADD_NEW_COURSE(txt_course_name.Text, dateTimePicker1.Value, dtpEndDate.Value, price, clasId, id, val);
                        }
                        else
                        {
                            course.UPDATE_COURSE(identify, txt_course_name.Text, dateTimePicker1.Value, dtpEndDate.Value, price, clasId, id, val);
                        }
                        percent = Convert.ToInt32(upDownTeacher.Value);
                        salary = (price * percent) / 100;
                        txtTeacherSal.Text = salary.ToString();
                        course.ADD_TEACHER_SALARY(salary, id);
                        MessageBox.Show("تمت الاضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("يرجى التأكد من صحة البيانات المدخلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("يوجد خطأ في البيانات المدخلة");
            }
        }
    }
}
