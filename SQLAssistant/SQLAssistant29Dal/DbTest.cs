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
        public static string DoDbTest()
        {
            string s = "";
           
            // создаём объект для подключения к БД
            using (var cnn = DbServerFactoryMySql.GetDbConnection())
            {
                var cmd = cnn.CreateCommand();
                // запрос
                cmd.CommandText = "SELECT id_categories, categories_name FROM goods_categories WHERE id_categories >= 11";
                // устанавливаем соединение с БД
                cnn.Open();
                var rdr = cmd.ExecuteReader();
                // читаем результат
                while (rdr.Read())
                {
                    s += (string)rdr[0].ToString() + " " + rdr[1].ToString() + Environment.NewLine;
                }
            }
            return s;
        }
    }
}
