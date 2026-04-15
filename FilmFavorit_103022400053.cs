using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_103022300053
{
    internal class FilmFavorit_103022400053
    {
        public class Film
        {
            [JsonPropertyName("title")]
            public string title { get; set; }
            [JsonPropertyName("director")]
            public string director { get; set; }
            [JsonPropertyName("year")]
            public string year { get; set; }
            [JsonPropertyName("genre")]
            public string genre { get; set; }
            [JsonPropertyName("rating")]
            public string rating { get; set; }
            [JsonPropertyName("durationMinutes")]
            public string durationMinutes { get; set; }
            [JsonPropertyName("isWatched")]
            public bool isWatched { get; set; }
        }
        public void ReadJson()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103022400053.json");
            Film film = JsonSerializer.Deserialize<Film>(jsonString);
            Console.WriteLine($"Judul: {film.title}, director: {film.director}, tahun: {film.year}, genre: {film.genre}, rating: {film.rating}, durasi: {film.durationMinutes} menit, sudah menonton: {film.isWatched}");
        }
    }
}
