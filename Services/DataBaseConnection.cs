using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;

namespace Curriculum.Services
{
    public class DataBaseConnection
    {
        public SqlConnection CrearConexion()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Curriculum"].ConnectionString;


            SqlConnection sql = new SqlConnection(connectionString);

            return sql;


        }

        //public void ExecuteCommand()
        //{
        //    //var connectionString = ConfigurationManager.ConnectionStrings["Curriculum"].ConnectionString;
        //    using (SqlConnection connection = new SqlConnection(@"Server=localhost;DataBase=Curriculum; Trusted_Connection=True;"))
        //    {
        //        var sqlString = "Select * from datos_personales";
        //        using (SqlCommand command = new SqlCommand(sqlString, connection))
        //        {
        //            command.Connection.Open();
        //            command.ExecuteNonQuery();
        //        }

        //    }
        //}
    }
}
