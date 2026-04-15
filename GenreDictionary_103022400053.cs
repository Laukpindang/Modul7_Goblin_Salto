using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_103022300053
{
    internal class GenreDictionary_103022400053
    {
        public class GenreInfo
        {
            [JsonPropertyName("id")]
            public string id { get; set; }
            [JsonPropertyName("name")]
            public string name { get; set; }
            [JsonPropertyName("description")]
            public string description { get; set; }
            [JsonPropertyName("popularMovies")]
            public List<string> popularMovies { get; set; }
        }
        public class GenreDictionary
        {
            [JsonPropertyName("category")]
            public string category { get; set; }
            [JsonPropertyName("GenreInfo")]
            public GenreInfo GenreInfo { get; set; }
        }
        public class JSG
        {
            [JsonPropertyName("GenreDictionary")]
            public GenreDictionary GenreDictionary { get; set; }
        }
        public void ReadJson()
        {
            string jsonString = File.ReadAllText("jurnal7_3_103022400053.json");
            JSG gd = JsonSerializer.Deserialize<JSG>(jsonString);
            Console.WriteLine($"ID : {gd.GenreDictionary.GenreInfo.id}");
            Console.WriteLine($"Name : {gd.GenreDictionary.GenreInfo.name}");
            Console.WriteLine($"Description : {gd.GenreDictionary.GenreInfo.description}");
            Console.Write($"Popular Movies :");
            gd.GenreDictionary.GenreInfo.popularMovies.ForEach(x => Console.Write(x+", "));
        }
    }
}
