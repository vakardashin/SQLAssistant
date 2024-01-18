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
        public static string FormatResults(List<List<string>> list)
        {
            // Count sumbols
            int row = 0;
            List<int> counts = new List<int>();
            foreach (var subList in list)
            {
                if(row == 0)
                {
                    foreach (var item in subList)
                    {
                        counts.Add(item.Length);
                    }
                }
                else
                {
                    int column = 0;
                    foreach (var item in subList)
                    {
                        if (counts[column] < item.Length) counts[column] = item.Length;
                        column++;
                    }
                }
                row++;
            }
            StringBuilder sb = new StringBuilder();
            row = 0;
            foreach (var subList in list)
            {
                int column = 0;
                sb.Append(" ");
                foreach (var item in subList)
                {
                    sb.Append(item.ToString().PadRight(counts[column]));
                    sb.Append(" | ");
                    column++;
                }
                sb.AppendLine();
                row++;
                if (row == 1)
                {
                    foreach(var item in counts)
                    {
                        sb.Append(string.Empty.PadRight(item, '-'));
                        sb.Append("--|");
                        // sb.Append(item);
                        column++;
                    }
                    sb.AppendLine();
                }
                
            }
            return sb.ToString();
        }
    }
}
