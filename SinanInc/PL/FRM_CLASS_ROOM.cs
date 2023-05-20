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
    public partial class FRM_CLASS_ROOM : Form
    {
        BL.CLS_CLASSES clas = new BL.CLS_CLASSES();
        public FRM_CLASS_ROOM()
        {
            InitializeComponent();
            dgv_ShowClassrooms.DataSource = clas.GET_ALL_CLASSROOMS();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Visible = true;
            btnAddClick.Visible = true;
        }

        private void btnAddClick_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("لا يمكن اضافة قيمة فارغة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < dgv_ShowClassrooms.RowCount; i++)
            {
                if (txtName.Text == dgv_ShowClassrooms.Rows[i].Cells[1].Value.ToString())
                {
                    MessageBox.Show("القيمة المختارة تم اختيارها مسبقاً", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            clas.ADD_NEW_CLASSROOM(txtName.Text);
            MessageBox.Show("تم إضافة القاعة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_ShowClassrooms.DataSource = clas.GET_ALL_CLASSROOMS();
            txtName.Visible = false;
            btnAddClick.Visible = false;
            txtName.Text = null;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من حذف القاعة الحالية", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    clas.DROP_SELECTED_CLASSROOM(Convert.ToInt32(dgv_ShowClassrooms.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم حذف القاعة بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_ShowClassrooms.DataSource = clas.GET_ALL_CLASSROOMS();


                }
                else { }
            }
            catch (Exception)
            {
                MessageBox.Show("لم يتم تحديد قاعة لحذفها");

            }
            
            
        }

        
    }
}
