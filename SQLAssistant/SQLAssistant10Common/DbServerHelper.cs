using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLAssistant10Common
{
    public class DbServerHelper
    {
        public static List<DbServerConfig> GetServerList()
        {
            var lst = new List<DbServerConfig>();
            lst.Add(new DbServerConfig()
            {
                ServerName = "MySQL - localhost - arnion",
                ServerType = DbServerType.MySql,
                ConnectionString = "Server=localhost;User ID = root;Password=root;Database=arnion;AllowZeroDateTime=True"
            });
            lst.Add(new DbServerConfig()
            {
                ServerName = "MS SQL - LocalDB - dbtest",
                ServerType = DbServerType.MsSql,
                ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Trusted_Connection=true" //Integrated Security=true
            });
            lst.Add(new DbServerConfig()
            {
                ServerName = "SQLite - dbtest",
                ServerType = DbServerType.SqLite,
                ConnectionString = @"Data Source = ""C:\Work\C#\SQLAssistant\dbtest.db"";Version=3;",
            });
            return lst;
        }
    }
}
