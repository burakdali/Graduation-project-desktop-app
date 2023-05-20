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
    public partial class FRM_MAKE_APAYMENT : Form
    {
        BL.CLS_STUDENTS student = new BL.CLS_STUDENTS();
        FRM_STUDENT_FILE studentfile = new FRM_STUDENT_FILE();

        
        public FRM_MAKE_APAYMENT()
        {
            InitializeComponent();
           
        }
  
        private void FRM_MAKE_APAYMENT_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchBox.Text != "")
                {
                    dataGridView1.DataSource = student.SEARCH_ALL_STUDENTS(txtSearchBox.Text);
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("يوجد خطأ في البيانات المحددة");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnShowReport.Visible = true;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                lblRepId.Text = student.GET_PAYMENT_ID(id).Rows[0][0].ToString();
                lblStId.Text = id.ToString();
                txtSudentFnamePay.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ShootBtn.Enabled = true;
                lblRestAmount.Text = student.GET_UNPAID_VALUE(id).Rows[0][0].ToString();
                lblTotlaPaid.Text = student.GET_PAID_STATUS(id).Rows[0][0].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("يوجد خطأ في البيانات المحددة");

            }

        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            Close();

        }

       

        private void ShootBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int unpayed = Convert.ToInt32(student.GET_UNPAID_VALUE(Convert.ToInt32(lblStId.Text)).Rows[0][0].ToString());

                if (Convert.ToInt32(txtPayAmount.Text) <= unpayed)
                {
                    if (txtSudentFnamePay.Text != null && txtPayAmount.Text != null)
                    {
                        DialogResult result = MessageBox.Show("هل أنت متأكد من عملية الدفع الحالية", "عملية دفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            student.MAKE_APAYMENT(Convert.ToInt32(lblStId.Text), Convert.ToInt32(txtPayAmount.Text));
                            this.txtPayAmount.Clear();
                            this.txtSudentFnamePay.Clear();
                            this.dataGridView1.DataSource = null;
                            this.lblStId.Text = "Value";
                            this.lblRepId.Text = "Value";
                            this.lblRestAmount.Text = "Value";
                            this.lblTotlaPaid.Text = "Value";
                            MessageBox.Show("تم حفظ عملية الدفع", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجى التأكد من صحة البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                else
                {
                    MessageBox.Show("المبلغ المراد دفعه أكبر من المبلغ المترتب على الطالب", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("يوجد خطأ في البيانات المحددة");
            }

        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_PAYMENT_RECORD frm = new FRM_PAYMENT_RECORD();
                frm.dgvReport.DataSource = student.GET_PAYMENT_REPORT(Convert.ToInt32(lblStId.Text));
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("يوجد خطأ في البيانات المحددة");
            }
        }

        private void txtPayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        
       

      

        
    }
}
