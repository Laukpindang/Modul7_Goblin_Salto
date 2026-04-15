using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_103022400106
{
    public class GenreDictionary_103022400106
    {
        [JsonIgnore]
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "jurnal7_3_103022400106.json");

        public class GenreDictionary
        {
            [JsonPropertyName("category")]
            public string Category { get; set; }
            [JsonPropertyName("GenreInfo")]
            public GenreInfo Info { get; set; }
        }

        public class GenreInfo
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }
            [JsonPropertyName("name")]
            public string Name { get; set; }
            [JsonPropertyName("description")]
            public string Description { get; set; }
            [JsonPropertyName("popularMovies")]
            public List<string> PopularMovies { get; set; }

        }

        public class GenreObject
        {
            [JsonPropertyName("GenreDictionary")]
            public GenreDictionary genreDictionary { get; set; }

        }

        public void readJson()
        {
            string jsonString = File.ReadAllText(_filePath);
            GenreObject genreDict = JsonSerializer.Deserialize<GenreObject>(jsonString);
            Console.WriteLine($"Category: {genreDict.genreDictionary.Category}");
            Console.WriteLine($"ID: {genreDict.genreDictionary.Info.Id}");
            Console.WriteLine($"Name: {genreDict.genreDictionary.Info.Name}");
            Console.WriteLine($"Description: {genreDict.genreDictionary.Info.Description}");
            Console.WriteLine("Popular Movies:");
            foreach (var movie in genreDict.genreDictionary.Info.PopularMovies)
            {
                Console.WriteLine($"- {movie}");
            }
        }
    }
}
