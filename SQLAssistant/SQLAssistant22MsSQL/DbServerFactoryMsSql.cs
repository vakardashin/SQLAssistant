using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanDal
{
    public class DbServerFactoryMsSql
    {
        public static IDbConnection GetDbConnection(string connectionString)
        {
            // MS SQL строка подключения к БД
            // string strCnn = "Server=(localdb)\\MSSQLLocalDB;Integrated Security=true";
            SqlConnection cnn = new SqlConnection(connectionString);
            return cnn;
        }
    }
}
