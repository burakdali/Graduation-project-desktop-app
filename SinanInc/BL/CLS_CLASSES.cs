using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SinanInc.BL
{
    class CLS_CLASSES
    {
        public DataTable GET_CLASS_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DAL.Open();
            DT = DAL.SelectData("GET_CLASS_ID", null);
            DAL.Close();
            return DT;
        }
        public DataTable GET_CLASS_ROOM_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DAL.Open();
            DT = DAL.SelectData("GET_CLASS_ROOM_ID", null);
            DAL.Close();
            return DT;
        }
        public DataTable GET_ALL_CLASSROOMS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DAL.Open();
            DT = DAL.SelectData("GET_ALL_CLASSROOMS", null);
            DAL.Close();
            return DT;
        }

        public DataTable GET_ALL_SCEDULES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DAL.Open();
            DT = DAL.SelectData("GET_ALL_SCEDULES", null);
            DAL.Close();
            return DT;
        }

        public DataTable ADD_NEW_CLASSROOM(string CLASS_ROOM_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CLASS_ROOM_NAME", SqlDbType.VarChar,50);
            param[0].Value = CLASS_ROOM_NAME;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_NEW_CLASSROOM", param);

            DAL.Close();
            return dt;

        }

        public DataTable UPDATE_CLASSES(int year, string name, int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@year", SqlDbType.Int);
            param[0].Value = year;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 255);
            param[1].Value = name;

            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = id;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("UPDATE_CLASSES", param);

            DAL.Close();
            return dt;

        }

        public DataTable SEARCH_ALL_CLASSES(string WORD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@WORD", SqlDbType.NVarChar,255);
            param[0].Value = WORD;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_ALL_CLASSES", param);

            DAL.Close();
            return dt;

        }

        public DataTable GET_CLASS_ID_FROM_NAME(string NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar,255);
            param[0].Value = NAME;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_CLASS_ID_FROM_NAME", param);

            DAL.Close();
            return dt;

        }

        public DataTable GET_CLASS_ROOM_ID_FROM_NAME(string CLASS_ROOM_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CLASS_ROOM_NAME", SqlDbType.VarChar, 50);
            param[0].Value = CLASS_ROOM_NAME;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_CLASS_ROOM_ID_FROM_NAME", param);

            DAL.Close();
            return dt;

        }
        public DataTable GET_ALL_CLASSES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DAL.Open();
            DT = DAL.SelectData("GET_ALL_CLASSES", null);
            DAL.Close();
            return DT;
        }

        public void ADD_NEW_CLASS(int year, string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@year", SqlDbType.Int);
            param[0].Value = year;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar,255);
            param[1].Value = name;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_NEW_CLASS", param);
            DAL.Close();


        }

        public void ADD_NEW_SCHEDUALE_DAY(int CLASS_ID, int CLASS_ROOM_ID, string COURSE_NAME,int START_TIME,int END_TIME,string DAY)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@CLASS_ID", SqlDbType.Int);
            param[0].Value = CLASS_ID;

            param[1] = new SqlParameter("@CLASS_ROOM_ID", SqlDbType.Int);
            param[1].Value = CLASS_ROOM_ID;

            param[2] = new SqlParameter("@COURSE_NAME", SqlDbType.VarChar, 50);
            param[2].Value = COURSE_NAME;

            param[3] = new SqlParameter("@START_TIME", SqlDbType.Int);
            param[3].Value = START_TIME;

            param[4] = new SqlParameter("@END_TIME", SqlDbType.Int);
            param[4].Value = END_TIME;

            param[5] = new SqlParameter("@DAY", SqlDbType.VarChar,50);
            param[5].Value = DAY;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_NEW_SCHEDUALE_DAY", param);
            DAL.Close();


        }
        

        public void DROP_SELECTED_CLASSROOM(int CLASS_ROOM_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CLASS_ROOM_ID", SqlDbType.Int);
            param[0].Value = CLASS_ROOM_ID;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("DROP_SELECTED_CLASSROOM", param);
            DAL.Close();


        }

        public void DELETE_SCHEDULE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("DELETE_SCHEDULE", null);
            DAL.Close();
        }
    }
}
