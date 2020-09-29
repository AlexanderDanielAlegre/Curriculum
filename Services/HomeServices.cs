using System;
using System.Data;
using System.Data.SqlClient;

namespace Curriculum.Services
{
    public class HomeServices
    {
        public void ExecuteSP(SqlConnection sql )
        {
            using (sql)
            {
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("sp_CrearTabla", sql);
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
