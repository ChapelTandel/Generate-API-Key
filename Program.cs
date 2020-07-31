using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Generate_API_Key
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject videogameRatings = new JObject(
            new JProperty("ApiKey", "ThisIsASampleApiKey"));

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
