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
    public partial class FRM_ADD_NEW_CLASS : Form
    {
        BL.CLS_CLASSES clas = new BL.CLS_CLASSES();
        public string identifier;
        public int classId;
        public FRM_ADD_NEW_CLASS()
        {
            InitializeComponent();            
        }

        public void setIdentifier(string identifier)
        {
            this.identifier = identifier;
        }
     
        private void CanelBtn_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clas.GET_ALL_CLASSES();

                if (txt_class_num.Text != "")
                {
                    
                    if (identifier == "Add")
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (txt_class_num.Text == dt.Rows[i][0].ToString() || txtName.Text == dt.Rows[i][1].ToString())
                            {
                                MessageBox.Show("الصف الذي تقوم باضافته موجود مسبقاً", "تحذير!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        DialogResult diag = MessageBox.Show("هل انت متأكد من اضافة الصف الحالي", "اضافة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (diag == DialogResult.Yes)
                        {
                            clas.ADD_NEW_CLASS(Convert.ToInt32(txt_class_num.Text), txtName.Text);
                            MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("تم الغاء عملية الاضافة");
                        }


                    }
                    else if (identifier == "Edit")
                    {
                        DialogResult diag = MessageBox.Show("هل انت متأكد من تعديل الصف الحالي", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (diag == DialogResult.Yes)
                        {
                            clas.UPDATE_CLASSES(Convert.ToInt32(txt_class_num.Text), txtName.Text, classId);
                            MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("تم الغاء عملية التعديل");
                        }
                    }
                }
            }
            catch (Exception)
            {
                                MessageBox.Show("يوجد خطأ في البيانات المحددة");

            }
        }

        private void FRM_ADD_NEW_CLASS_Load(object sender, EventArgs e)
        {

        }
        
    }
}
