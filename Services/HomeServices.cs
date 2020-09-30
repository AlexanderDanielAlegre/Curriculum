using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Curriculum.Domain;

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

        public IList<datos_personales> DevolverLista(SqlConnection sql)
        {
            using (sql)
            {
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("Select * from datos_personales", sql);
                //cmd = new SqlCommand(sql);
                //cmd = ("Select * from datos_personales", sql);

                sql.Open();
                //cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //cmd.ExecuteNonQuery();
                //ds.Tables[0]=dt;
                //da.Fill(ds[0]);
                da.Fill(dt);
                IList<Curriculum.Domain.datos_personales> lista;
                lista = new List<datos_personales>();

                foreach (DataRow dr  in dt.Rows)
                {

                    datos_personales dp = new datos_personales();
                    dp.id = Convert.ToInt32(dr["id"]);
                    dp.Nombre = dr["Nombre"].ToString();
                    dp.Apellido = Convert.ToString(dr["Apellido"]);
                    dp.dni = Convert.ToInt32(dr["Dni"]);

                    lista.Add(dp);
                }

                return lista;
               // IList<Curriculum.Domain.datos_personales> lista = dt.;

                //return dt;
            }
        }

        public DataTable LlenarDataGreed(SqlConnection sql)
        {
            using (sql)
            {
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("Select * from datos_personales", sql);

                sql.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
        }


    }
}
