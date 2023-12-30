using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLAssistant10Common
{
    public class DbServerConfig
    {
        public string ServerName {  get; set; }
        public DbServerType ServerType { get; set; }
        public string ConnectionString { get; set; }
    }
}
