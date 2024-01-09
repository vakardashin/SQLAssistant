using SQLAssistant10Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanDal
{
    public class DbServerFactory
    {
        public static IDbConnection GetDbConnection(DbServerConfig config)
        {
            switch (config.ServerType) 
            {
                case DbServerType.MySql:
                    return DbServerFactoryMySql.GetDbConnection(config.ConnectionString);
                case DbServerType.MsSql:
                    return DbServerFactoryMsSql.GetDbConnection(config.ConnectionString);
                case DbServerType.SqLite:
                    return DbServerFactorySqlLite.GetDbConnection(config.ConnectionString);
                // break;
                default: 
                    return null;
                    // break;
            }
        }
    }
}
