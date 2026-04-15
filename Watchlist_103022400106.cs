using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_103022400106
{
    public class Watchlist_103022400106
    {
        [JsonIgnore]
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "jurnal7_2_103022400106.json");

        public class Watchlist
        {
            [JsonPropertyName("watchlistName")]
            public string name { get; set; }
            [JsonPropertyName("createdBy")]
            public string creator { get; set; }
            [JsonPropertyName("movies")]
            public List<WatchlistItem> movies { get; set; }
        }

        public class WatchlistItem
        {
            [JsonPropertyName("id")]
            public string id { get; set; }
            [JsonPropertyName("title")]
            public string title { get; set; }
            [JsonPropertyName("year")]
            public int year { get; set; }
            [JsonPropertyName("genre")]
            public string genre { get; set; }
            [JsonPropertyName("rating")]
            public double rating { get; set; }
        }

        public void readJson()
        {
            string jsonString = File.ReadAllText(_filePath);
            Watchlist watchlist = JsonSerializer.Deserialize<Watchlist>(jsonString);
            Console.WriteLine($"Watchlist Name: {watchlist.name} \nCreated By: {watchlist.creator}");
            Console.WriteLine("Movies:");
            Console.WriteLine("-------");
            foreach (var movie in watchlist.movies)
            {
                Console.WriteLine($"ID: {movie.id} \nTitle: {movie.title} \nYear: {movie.year}\nGenre: {movie.genre}\nRating: {movie.rating}\n");
            }
        }
    }
}
