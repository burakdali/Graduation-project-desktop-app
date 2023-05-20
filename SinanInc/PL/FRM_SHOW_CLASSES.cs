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
    public partial class FRM_SHOW_CLASSES : Form
    {
        BL.CLS_CLASSES clas = new BL.CLS_CLASSES();
        public FRM_SHOW_CLASSES()
        {
            InitializeComponent();
            dataGridView1.DataSource = clas.GET_ALL_CLASSES();
        }
 
  
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_ADD_NEW_CLASS frm = new FRM_ADD_NEW_CLASS();
                frm.txt_class_num.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.BtnAdd.Text = "تعديل";
                frm.classId = Convert.ToInt32(clas.GET_CLASS_ID_FROM_NAME(dataGridView1.CurrentRow.Cells[1].Value.ToString()).Rows[0][0]);
                frm.setIdentifier("Edit");

                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("بيانات الصف ناقصة ولا يمكن تعديلها");
            }
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txt_search.Visible = true;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text != "")
                {
                    dataGridView1.DataSource = clas.SEARCH_ALL_CLASSES(txt_search.Text);
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("حصلت مشكلة اثناء استعادة الملفات من قاعدة البيانات");
            }
        }

        
    }
}
