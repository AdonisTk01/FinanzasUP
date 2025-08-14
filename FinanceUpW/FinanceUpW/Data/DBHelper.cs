using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceUpW.Data
{
    public static class DbHelper
    {
        private static readonly string connString =
            ConfigurationManager.ConnectionStrings["FinanceUpDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
    }
}