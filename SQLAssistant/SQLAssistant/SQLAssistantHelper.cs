using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLAssistant
{
    public class SQLAssistantHelper
    {
        public static bool DoSelect(string sql)
        {
            bool b = false;
            string s = sql.ToLower();

            bool hasSelect = s.Contains("select");
            bool hasInsert = s.Contains("insert");
            bool hasUpdate = s.Contains("update");
            if (hasSelect && !hasInsert && !hasUpdate)
                b = true;
            return b;
        }
        public static string FormatResultsSimple(List<List<string>> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var subList in list)
            {
                foreach (var item in subList)
                {
                    sb.Append(item.ToString() + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
