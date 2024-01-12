using ScanDal;
using SQLAssistant10Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SQLAssistant29Dal
{
    public class DbProcessor : IDbProcessor
    {
        public DbServerConfig Config { get; set; }
        public DbProcessor(DbServerConfig config )
        {
            Config = config;
        }
        public object ExecuteSqlScalar(string sql)
        {
            using (var cnn = DbServerFactory.GetDbConnection(Config))
            {
                var cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                cnn.Open();
                object result = cmd.ExecuteScalar();
                return result;
            }
        }
        public List<List<string>> ExecuteSqlSelect(string sql)
        { 
            var mainList = new List<List<string>>();
            using (var cnn = DbServerFactory.GetDbConnection(Config))
            { 
                var cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                cnn.Open();
                var reader = cmd.ExecuteReader();
                var columns = new List<string>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    columns.Add(reader.GetName(i));
                }
                mainList.Add(columns);
                while (reader.Read())
                {
                    var fields = new List<string>();
                    for(int i = 0;i < reader.FieldCount; i++)
                    {
                        fields.Add(reader[i].ToString());
                    }
                    mainList.Add(fields);
                }
            }
            return mainList;
        }
        public int ExecuteSqlCommand(string sql)
        {
            using (var cnn = DbServerFactory.GetDbConnection(Config))
            {
                var cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                cnn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
        }
        public int ExecuteSqlFile(string fileName)
        {
            using (var cnn = DbServerFactory.GetDbConnection(Config))
            {
                string data = File.ReadAllText(fileName);
                var cmd = cnn.CreateCommand();
                cmd.CommandText = data;
                cnn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
        }
    }
}
