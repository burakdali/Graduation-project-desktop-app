using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SinanInc.BL
{
    class CLS_COURSE
    {
        public void ADD_NEW_COURSE(string COURSE_NAME, DateTime START_DATE, DateTime END_DATE, int PRICE, int CLASS_ID, int TEACHER_ID,int ACTIVE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];

           
            param[0] = new SqlParameter("@COURSE_NAME", SqlDbType.VarChar, 50);
            param[0].Value = COURSE_NAME;

            param[1] = new SqlParameter("@START_DATE", SqlDbType.DateTime);
            param[1].Value = START_DATE;

            param[2] = new SqlParameter("@END_DATE", SqlDbType.DateTime);
            param[2].Value = END_DATE;

            param[3] = new SqlParameter("@COURSE_PRICE", SqlDbType.Int);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@CLASS_ID", SqlDbType.Int);
            param[4].Value = CLASS_ID;

            param[5] = new SqlParameter("@TEACHER_ID", SqlDbType.Int);
            param[5].Value = TEACHER_ID;

            param[6] = new SqlParameter("@ACTIVE", SqlDbType.Int);
            param[6].Value = ACTIVE;

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_NEW_COURSE", param);
            DAL.Close();

        }
        public void UPDATE_COURSE(int id,string COURSE_NAME, DateTime START_DATE, DateTime END_DATE, int price, int CLASS_ID, int TEACHER_ID, int ACTIVE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@id", SqlDbType.BigInt);
            param[0].Value = id;

            param[1] = new SqlParameter("@COURSE_NAME", SqlDbType.VarChar, 50);
            param[1].Value = COURSE_NAME;

            param[2] = new SqlParameter("@START_DATE", SqlDbType.DateTime);
            param[2].Value = START_DATE;

            param[3] = new SqlParameter("@END_DATE", SqlDbType.DateTime);
            param[3].Value = END_DATE;

            param[4] = new SqlParameter("@price", SqlDbType.Int);
            param[4].Value = price;

            param[5] = new SqlParameter("@CLASS_ID", SqlDbType.Int);
            param[5].Value = CLASS_ID;

            param[6] = new SqlParameter("@TEACHER_ID", SqlDbType.Int);
            param[6].Value = TEACHER_ID;

            param[7] = new SqlParameter("@ACTIVE", SqlDbType.Int);
            param[7].Value = ACTIVE;

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("UPDATE_COURSE", param);
            DAL.Close();

        }

        public void ADD_TEACHER_SALARY(int unpaid, int user_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@unpaid", SqlDbType.BigInt);
            param[0].Value = unpaid;

            param[1] = new SqlParameter("@user_id", SqlDbType.BigInt);
            param[1].Value = user_id;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_TEACHER_SALARY", param);
            DAL.Close();


        }
        public DataTable GET_CURRENT_COURSES_FOR_MAIN(string DAY, int CURRENT_HOUR)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@DAY", SqlDbType.VarChar,50);
            param[0].Value = DAY;

            param[1] = new SqlParameter("@CURRENT_HOUR", SqlDbType.Int);
            param[1].Value = CURRENT_HOUR;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_CURRENT_COURSES_FOR_MAIN", param);
            DAL.Close();
            return dt;
        }
        public DataTable SEARCH_COURSES(string Word)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Word", SqlDbType.VarChar, 50);
            param[0].Value = Word;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_COURSES", param);
            DAL.Close();
            return dt;
        }

        public DataTable GET_ALL_COURCES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_COURCES",null);
            DAL.Close();
            return dt;
        }

        public DataTable DELETE_CURRENT_COURSE(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.BigInt);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("DELETE_CURRENT_COURSE", param);
            DAL.Close();
            return dt;
        }
        
    }
}
