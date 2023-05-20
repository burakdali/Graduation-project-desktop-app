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
    public partial class FRM_ADD_SCHEDULE : Form
    {
        BL.CLS_CLASSES clas = new BL.CLS_CLASSES();
        BL.CLS_STUDENTS student = new BL.CLS_STUDENTS();
        public FRM_ADD_SCHEDULE()
        {
            InitializeComponent();
            dtp_sHour.Format = DateTimePickerFormat.Time;
            dtp_eHour.Format = DateTimePickerFormat.Time;
            btnAdd.Enabled = false;

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt = student.GET_ALL_CLASSES_FOR_ADDING_STUDENT();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string myString = dt.Rows[i][0].ToString();
                cmBox_Class.Items.Add(myString);
            }
            dt2 = clas.GET_ALL_CLASSROOMS();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                string myString2 = dt2.Rows[i][1].ToString();
                cmBox_ClsRoom.Items.Add(myString2);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_SCHEDULE frm = new FRM_SCHEDULE();
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                dt = clas.GET_CLASS_ID_FROM_NAME(cmBox_Class.Text);
                dt2 = clas.GET_CLASS_ROOM_ID_FROM_NAME(cmBox_ClsRoom.Text);
                int classRoomId = Convert.ToInt32(dt2.Rows[0][0]);
                int classId = Convert.ToInt32(dt.Rows[0][0]);
                clas.ADD_NEW_SCHEDUALE_DAY(classId, classRoomId, cmBox_Course.Text, Convert.ToInt32(dtp_sHour.Value.Hour),
                    Convert.ToInt32(dtp_eHour.Value.Hour), dtp_Day.Value.DayOfWeek.ToString());
                MessageBox.Show("تمت اضافة اليوم بنجاح", "اتمام العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.dgv_Schedule.DataSource = clas.GET_ALL_SCEDULES();
                cmBox_Course.Items.Clear();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطأ غير معلوم");
            }

        }

        private void cmBox_Class_SelectedValueChanged(object sender, EventArgs e)
        {
                cmBox_Course.Text = "";
                cmBox_Course.Items.Clear();
                DataTable dt = student.SELECT_ALL_CLASS_COURSES(cmBox_Class.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string myString = dt.Rows[i][0].ToString();
                    cmBox_Course.Items.Add(myString);
                }
                test();
            
                
            
        }
        private void test()
        {
            if (cmBox_Class.Text != "" && cmBox_ClsRoom.Text != "" && cmBox_Course.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {

            }
        }

        private void cmBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            test();
        }

        private void cmBox_ClsRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            test();

        }

        private void btnAddClassroom_Click(object sender, EventArgs e)
        {
            FRM_CLASS_ROOM frm = new FRM_CLASS_ROOM();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
