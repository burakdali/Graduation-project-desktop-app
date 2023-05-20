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
    public partial class FRM_RESTORE : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-G6NIR0Q;Database=master;Integrated Security=true");
        SqlCommand cmd;
        public FRM_RESTORE()
        {
            InitializeComponent();
        }

        private void btnLocate_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string strQuery = "Alter Database Modern_Institute SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Modern_Institute From Disk='" + txtFileName.Text + "'";
            cmd = new SqlCommand(strQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("تمت استعادة النسخة الاحتياطية بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
