using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SinanInc.BL
{
    class CLS_USERS
    {
        public DataTable GET_ALL_USERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
             DataTable dt = new DataTable();
             dt = DAL.SelectData("GET_ALL_USERS", null);
            DAL.Close();
            return dt;
        }
       

        

        public void DELETE_CURRENT_USER(int USER_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@USER_ID", SqlDbType.Int);
            param[0].Value = USER_ID;

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("DELETE_CURRENT_USER", param);
            DAL.Close();
            
        }

        public DataTable GET_USER_IMAGE(int USER_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@USER_ID", SqlDbType.Int);
            param[0].Value = USER_ID;

            DT = DAL.SelectData("GET_USER_IMAGE", param);
            DAL.Close();
            return DT;          
        }
    }
}
