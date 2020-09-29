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
    }
}
