using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace Modul7_103022300053
{
    public class FilmFavorit_103022400088
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public string rating { get; set; }
        public string duration { get; set; }

        public bool isWatched { get; set; }
    }

    public class showFilm
    {
        public void readJSON()
        {
            string path = "D:\\New folder\\Modul7_Goblin_Salto\\jurnal7_1_103022400088.json";
            string jsonString = File.ReadAllText(path);
            FilmFavorit_103022400088 film = JsonSerializer.Deserialize<FilmFavorit_103022400088>(jsonString);
            Console.WriteLine($"Film Berjudul {film.title} yang disutradarai oleh {film.director} dan terbit di tahun {film.year} dengan genre {film.genre}. film ini memiliki rating {film.rating} yang berdurasi {film.duration} dan saya sudah menonton: {film.isWatched} ");

        }
    }
}