using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanDal
{
    public class DbServerFactoryMySql
    {
        public static IDbConnection GetDbConnection()
        {
            // My SQL строка подключения к БД
            string strCnn = "Server=localhost;User ID = root;Password=root;Database=arnion";
            MySqlConnection cnn = new MySqlConnection(strCnn);
            return cnn;
        }
    }
}
