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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            txtServerName.Text = Properties.Settings.Default.Server;
            txtDatabaseName.Text = Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbSql.Checked = true;
                txtUserName.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rbWindows.Checked = true;
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.ReadOnly = true;
                txtPassword.ReadOnly = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Server = txtServerName.Text;
            Properties.Settings.Default.Database = txtDatabaseName.Text;
            Properties.Settings.Default.Mode = rbSql.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.UserName = txtUserName.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الاعدادات الجديدة");



        }

        private void rbSql_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.ReadOnly = false;
            txtPassword.ReadOnly = false;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.ReadOnly = true;
            txtPassword.ReadOnly = true;
        }
    }
}
