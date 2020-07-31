using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Generate_API_Key
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject videogameRatings = new JObject(
            new JProperty("ApiKey", Guid.NewGuid()));

            File.WriteAllText(@"videogames.json", videogameRatings.ToString());

            // write JSON directly to a file
            using (StreamWriter file = File.CreateText(@"videogames.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                videogameRatings.WriteTo(writer);
            }
        }
    }
}
