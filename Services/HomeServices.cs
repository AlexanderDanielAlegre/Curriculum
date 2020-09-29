using System;
using System.Data;
using System.Data.SqlClient;

namespace Curriculum.Services
{
    public class HomeServices
    {
        public void ExecuteSP(SqlConnection sql, string stored_procedures )
        {
            using (sql)
            {
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(stored_procedures, sql);
                //sql.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                //da.Fill(dt);
            }
        }

        public DataTable LlenarDataGreed(SqlConnection sql)
        {
            using (sql)
            {
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                //cmd = new SqlCommand(sql);
                cmd.CommandText = "Select * from datos_personales";

                sql.Open();
                //cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //cmd.ExecuteNonQuery();
                //ds.Tables[0]=dt;
                //da.Fill(ds[0]);
                da.Fill(dt);
                return dt;
            }
        }

    }
}
