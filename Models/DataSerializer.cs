using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieAppWithSeriallizer.Models
{
    internal class DataSerializer
    {
        public static string path = ConfigurationManager.AppSettings["path"];
        public static void Serializer(List<Movie> movies)
        {
            string jsonString = JsonSerializer.Serialize(movies);
            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.WriteLine(jsonString);
            }
        }

        public static List<Movie> Deserialize() {

            if (File.Exists(path)) {
                string jsonString = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<Movie>>(jsonString);
            }
            return new List<Movie>();

        }
    }
}
