using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SinanInc.BL
{
    class CLS_TEACHERS
    {
        public DataTable GET_TEACHER_ID_FROM_NAME(string NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NAME", SqlDbType.VarChar,50);
            param[0].Value = NAME;

            

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_TEACHER_ID_FROM_NAME", param);
            DAL.Close();
            return dt;
        }

        
        public DataTable GET_ALL_TEACHERS_FOR_ADDING_COURSE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DAL.Open();
            DT = DAL.SelectData("GET_ALL_TEACHERS_FOR_ADDING_COURSE", null);
            DAL.Close();
            return DT;
        }

       

        public DataTable SEARCH_ALL_TEACHERS(string WORD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@WORD", SqlDbType.VarChar, 50);
            param[0].Value = WORD;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_ALL_TEACHERS", param);
            DAL.Close();
            return dt;
        }
    }
}
