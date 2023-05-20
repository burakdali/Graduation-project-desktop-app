using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SinanInc.BL
{
    class CLS_LOGIN
    {
        public DataTable Login(string name)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("LOGIN", param);
            DAL.Close();
            return dt;
        }
    }
}
