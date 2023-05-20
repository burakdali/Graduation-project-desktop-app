using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SinanInc.BL
{
    class CLS_STUDENTS
    {

        public DataTable GET_CURRENT_COURSES_FOR_STUDENT_FILE(string DAY, int CURRENT_HOUR,int STUDENT_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@DAY", SqlDbType.VarChar,50);
            param[0].Value = DAY;

            param[1] = new SqlParameter("@CURRENT_HOUR", SqlDbType.Int);
            param[1].Value = CURRENT_HOUR;

            param[2] = new SqlParameter("@STUDENT_ID", SqlDbType.Int);
            param[2].Value = STUDENT_ID;

            DT = DAL.SelectData("GET_CURRENT_COURSES_FOR_STUDENT_FILE", param);
            DAL.Close();
            return DT;


        }
        
        public DataTable GET_ALL_CLASSES_FOR_ADDING_STUDENT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_CLASSES_FOR_ADDING_STUDENT", null);
            DAL.Close();
            return DT;
        }
        public DataTable GET_COURSE_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DAL.Open();
            DT = DAL.SelectData("GET_COURSE_ID", null);
            DAL.Close();
            return DT;
        }

        

        

        public DataTable GET_PAYMENT_ID(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.BigInt);
            param[0].Value = id;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_PAYMENT_ID", param);
            DAL.Close();
            return dt;
        }
        public DataTable GET_STUDENT_COURSE_INFO(int STUDENT_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@STUDENT_ID", SqlDbType.Int);
            param[0].Value = STUDENT_ID;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_STUDENT_COURSE_INFO", param);
            DAL.Close();
            return dt;
        }


        public DataTable SELECT_ALL_CLASS_COURSES(string NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar,255);
            param[0].Value = NAME;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("SELECT_ALL_CLASS_COURSES", param);
            DAL.Close();
            return dt;
        }

       

        public DataTable SEARCH_ALL_STUDENTS_FOR_PAYMENTS(string WORD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@WORD", SqlDbType.VarChar, 50);
            param[0].Value = WORD;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_ALL_STUDENTS_FOR_PAYMENTS", param);
            DAL.Close();
            return dt;
        }

        public DataTable SEARCH_ALL_STUDENTS(string WORD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@WORD", SqlDbType.VarChar, 50);
            param[0].Value = WORD;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_ALL_STUDENTS", param);
            DAL.Close();
            return dt;
        }

        public DataTable GET_STUDENTS_BY_SPECIFIC_DAY(string SESSION_DAYS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SESSION_DAYS", SqlDbType.VarChar,50);
            param[0].Value = SESSION_DAYS;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_STUDENTS_BY_SPECIFIC_DAY", param);
            DAL.Close();
            return dt;
        }
        

        

        public DataTable GET_PAID_STATUS(int user_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_PAID_STATUS", param);
            DAL.Close();
            return dt;
        }

        public DataTable GET_UNPAID_VALUE(int user_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_UNPAID_VALUE", param);
            DAL.Close();
            return dt;
        }
        public DataTable GET_PAYMENT_REPORT(int user_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_PAYMENT_REPORT", param);
            DAL.Close();
            return dt;
        }
        
        

        public void MAKE_APAYMENT(int user_id, int payment_amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@user_id", SqlDbType.BigInt);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@payment_amount", SqlDbType.BigInt);
            param[1].Value = payment_amount;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("MAKE_APAYMENT", param);
            DAL.Close();


        }
        public void INCREASING_COURSE_COUNT(int STUDENT_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@STUDENT_ID", SqlDbType.Int);
            param[0].Value = STUDENT_ID;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("INCREASING_COURSE_COUNT", param);
            DAL.Close();


        }
        public DataTable GET_SEESSION_PRICE(int STUDENT_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@STUDENT_ID", SqlDbType.Int);
            param[0].Value = STUDENT_ID;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_SEESSION_PRICE", param);

            DAL.Close();
            return dt;

        }


        public DataTable GET_TODAYS_SCHEDULE(string DAY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@DAY", SqlDbType.VarChar,50);
            param[0].Value = DAY;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_TODAYS_SCHEDULE", param);

            DAL.Close();
            return dt;

        }

        public void ADD_PAYMENT_FROM_DAILY_REPORT(int STUDENT_ID, int PAID_VALUE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@STUDENT_ID", SqlDbType.Int);
            param[0].Value = STUDENT_ID;

            param[1] = new SqlParameter("@PAID_VALUE", SqlDbType.Int);
            param[1].Value = PAID_VALUE;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_PAYMENT_FROM_DAILY_REPORT", param);
            DAL.Close();


        }

        public void ADD_DELAYED_PAYMENT_FROM_DAILY_REPORT(int STUDENT_ID, int PAID_VALUE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@STUDENT_ID", SqlDbType.Int);
            param[0].Value = STUDENT_ID;

            param[1] = new SqlParameter("@PAID_VALUE", SqlDbType.Int);
            param[1].Value = PAID_VALUE;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_DELAYED_PAYMENT_FROM_DAILY_REPORT", param);
            DAL.Close();


        }

        public void ADD_DAILY_SESSION(int STUDENT_ID, DateTime SESSION_DATE, string PAID_STATUS, string PAID_AMOUNT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@STUDENT_ID", SqlDbType.Int);
            param[0].Value = STUDENT_ID;

            param[1] = new SqlParameter("@SESSION_DATE", SqlDbType.DateTime);
            param[1].Value = SESSION_DATE;

            param[2] = new SqlParameter("@PAID_STATUS", SqlDbType.VarChar, 50);
            param[2].Value = PAID_STATUS;

            param[3] = new SqlParameter("@PAID_AMOUNT", SqlDbType.VarChar, 50);
            param[3].Value = PAID_AMOUNT;


            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_DAILY_SESSION", param);
            DAL.Close();

        }

        

        }
    
}
