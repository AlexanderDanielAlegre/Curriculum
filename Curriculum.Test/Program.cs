using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre = "Ailen";
            //var connectionString = ConfigurationManager.ConnectionStrings["Curriculum"].ConnectionString;
            //using (SqlConnection sql = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand("sp_CrearTabla", sql))
            //    {
            //        //cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        DataTable dt = new DataTable();
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        sql.Open();
            //        cmd.ExecuteNonQuery();
            //        da.Fill(dt);
            //    }
            //}

            Console.Read();
        }
    }
}
