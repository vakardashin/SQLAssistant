using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SQLAssistant10Common
{
    public class ConfigHelper
    {
        public static void WriteToConfigFile(List<DbServerConfig> configs)
        {
            string fileName = "Config.json";
            string json = JsonConvert.SerializeObject(configs, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
        public static List<DbServerConfig> ReadFromConfigFile()
        {
            string fileName = "Config.json";
            string json = File.ReadAllText(fileName);
            var configs = JsonConvert.DeserializeObject<List<DbServerConfig>>(json);
            return configs;
        }
    }
}
