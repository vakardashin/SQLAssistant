using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace ScanDal
{
    public class DbServerFactorySqlLite
    {
        public static IDbConnection GetDbConnection()
        {
            // SQLite строка подключения к БД
            string strCnn = @"Data Source=""C:\Work\C#\WinDbTestApp\SQLite\dbtest.db"";Version=3;";
            SQLiteConnection cnn = new SQLiteConnection(strCnn);
            return cnn;
        }
    }
}
