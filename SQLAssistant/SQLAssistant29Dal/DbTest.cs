using SQLAssistant10Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanDal
{
    public class DbTest
    {
        public static string DoDbTest(DbServerConfig config)
        {
            string s = "";

            // создаём объект для подключения к БД
            using (var cnn = DbServerFactory.GetDbConnection(config))
            // using (var cnn = DbServerFactoryMsSql.GetDbConnection())
            // using (var cnn = DbServerFactorySqlLite.GetDbConnection())
            {
                var cmd = cnn.CreateCommand();
                // запрос
                // cmd.CommandText = "SELECT id_categories, categories_name FROM goods_categories WHERE id_categories >= 11";
                cmd.CommandText = "SELECT 1";
                // устанавливаем соединение с БД
                cnn.Open();
                var rdr = cmd.ExecuteReader();
                // читаем результат
                while (rdr.Read())
                {
                    // s += (string)rdr[0].ToString() + " " + rdr[1].ToString() + Environment.NewLine;
                    s += (string)rdr[0].ToString();
                }
            }
            return s;
        }
    }
}
