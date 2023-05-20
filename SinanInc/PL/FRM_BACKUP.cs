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
    public partial class FRM_BACKUP : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-G6NIR0Q;Database=Modern_Institute;Integrated Security=true");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLocate_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath; 
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string filename = txtFileName.Text + "\\Modern_Institute_DB" + DateTime.Now.ToShortDateString().Replace('/','-')
                                +"  -  " + DateTime.Now.ToLongTimeString().Replace(':','-');
            string strQuery = "Backup Database Modern_Institute to Disk='" + filename + ".bak'";
            cmd = new SqlCommand(strQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("تم انشاء النسخة الاحتياطية بنجاح","نجاح",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            Close();
        }
    }
}
