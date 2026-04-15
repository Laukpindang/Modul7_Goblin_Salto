using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_103022400106
{
    public class FilmFavorit_103022400106
    {
        [JsonIgnore]
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "jurnal7_1_103022400106.json");

        public class Film
        {
            [JsonPropertyName("title")]
            public string Title { get; set; }
            [JsonPropertyName("director")]
            public string Director { get; set; }
            [JsonPropertyName("year")]
            public string Year { get; set; }
            [JsonPropertyName("genre")]
            public string Genre { get; set; }
            [JsonPropertyName("rating")]
            public string Rating { get; set; }
            [JsonPropertyName("durationMinutes")]
            public string Duration { get; set; }
            [JsonPropertyName("isWatched")]
            public bool IsWatched { get; set; }
        }

        public void readJson()
        {
            string jsonString = File.ReadAllText(_filePath);
            Film film = JsonSerializer.Deserialize<Film>(jsonString);

            Console.WriteLine($"Title: {film.Title} \nDirector: {film.Director} \nYear: {film.Year}\nGenre: {film.Genre}\nRating: {film.Genre}\nDuration: {film.Duration}\nIs Watched: {film.IsWatched}");
        }

    }
}
