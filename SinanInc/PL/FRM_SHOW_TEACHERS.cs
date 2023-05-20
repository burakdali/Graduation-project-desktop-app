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
    public partial class FRM_SHOW_TEACHERS : Form
    {
        BL.CLS_TEACHERS teacher = new BL.CLS_TEACHERS();

        public FRM_SHOW_TEACHERS()
        {
            InitializeComponent();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                dgvTeachers.DataSource = teacher.SEARCH_ALL_TEACHERS(txtSearch.Text);
            }
            else
            {
                dgvTeachers.DataSource = null;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
