using ScanDal;
using SQLAssistant10Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
