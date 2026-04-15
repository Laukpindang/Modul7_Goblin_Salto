using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_103022300053
{
    internal class Watchlist_103022400053
    {
        public class Movie
        {
            [JsonPropertyName("id")]
            public string id {  get; set; }
            [JsonPropertyName("title")]
            public string title { get; set; }
            [JsonPropertyName("year")]
            public int year { get; set; }
            [JsonPropertyName("genre")]
            public string genre { get; set; }
            [JsonPropertyName("rating")]
            public double rating{ get; set; }
        }
        public class WatchList
        {
            [JsonPropertyName("watchlistName")]
            public string watchlistName { get; set; }
            [JsonPropertyName("createdBy")]
            public string createdBy { get; set; }
            [JsonPropertyName("movies")]
            public List<Movie> movies { get; set; }
        }
        public void ReadJson()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103022400053.json");
            WatchList watchlist = JsonSerializer.Deserialize<WatchList>(jsonString);
            Console.WriteLine($"Watchlist Name : {watchlist.watchlistName}");
            Console.WriteLine($"Created By : {watchlist.createdBy}");
            Console.WriteLine($"Movies:");
            foreach (var mov in watchlist.movies)
            {
                Console.WriteLine($"{mov.id} {mov.title} ({mov.year} - {mov.rating})");
            }
        }
    }
}
