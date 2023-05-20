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
    public partial class FRM_STUDENT_FILE : Form
    {
        BL.CLS_STUDENTS student = new BL.CLS_STUDENTS();
        public FRM_STUDENT_FILE()
        {
            InitializeComponent();
        }     

        private void FRM_STUDENT_FILE_Load(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_MAKE_APAYMENT frm = new FRM_MAKE_APAYMENT();

                frm.txtSearchBox.Enabled = false;
                frm.lblStId.Text = txtStudentId.Text.ToString();
                frm.txtSudentFnamePay.Text = txtFullName.Text.ToString();
                frm.lblRestAmount.Text = student.GET_UNPAID_VALUE(Convert.ToInt32(txtStudentId.Text)).Rows[0][0].ToString();
                frm.lblTotlaPaid.Text = student.GET_PAID_STATUS(Convert.ToInt32(frm.lblStId.Text)).Rows[0][0].ToString();
                frm.txtSudentFnamePay.Enabled = false;
                frm.ShootBtn.Enabled = true;
                frm.txtPayAmount.TabIndex = 0;
                frm.ShowDialog();
            }
            catch (Exception)
            {
                                MessageBox.Show("يوجد خطأ في البيانات المحددة");

            }
        }


        
    }
}
