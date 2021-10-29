using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataBaseLib
{
    public class DBConfig
    {
        public string DataSource { get; set; }
        public string Version { get; set; }
        
        public override string ToString()
        {
            return $"Data Source={DataSource};";
        }

        public static DBConfig dBConfig (string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException();

            if (!File.Exists(path)) throw new FileNotFoundException();

            using var file = new FileStream(path, FileMode.Open);

            var res = JsonSerializer.DeserializeAsync<DBConfig>(file).Result;

            return res;
        }
    }
}
