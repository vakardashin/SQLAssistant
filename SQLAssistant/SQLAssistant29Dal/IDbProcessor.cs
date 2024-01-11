using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLAssistant29Dal
{
    public interface IDbProcessor
    {
        object ExecuteSqlScalar(string sql);
        List<List<string>> ExecuteSqlSelect(string sql);
        int ExecuteSqlCommand(string sql);
    }
}
