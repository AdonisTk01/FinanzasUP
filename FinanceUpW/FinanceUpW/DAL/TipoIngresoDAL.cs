using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceUpW.DAL
{
    public static class TipoIngresoDAL
    {
        public static List<string> ObtenerTodos()
        {
            var lista = new List<string>();
            DataTable dt = Database.ExecuteQuery("SELECT Nombre FROM TiposIngreso");

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(row["Nombre"].ToString());
            }
            return lista;
        }

        public static void Insertar(string nombre)
        {
            string query = "INSERT INTO TiposIngreso (Nombre) VALUES (@Nombre)";
            SqlParameter[] parametros = {
                new SqlParameter("@Nombre", nombre)
            };
            Database.ExecuteNonQuery(query, parametros);
        }
    }
}