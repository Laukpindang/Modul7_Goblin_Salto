using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Modul7_103022300053
{
    public class Watchlist_103022400088
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
    }
    public class Watchlist
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }

        public List<Watchlist_103022400088> movies { get; set; }

    }

    public class showWatchlist
    {
        public void readJSON()
        {
            string path = "D:\\New folder\\Modul7_Goblin_Salto\\jurnal7_2_103022400088.json";
            string jsonString = File.ReadAllText(path);
            Watchlist watchlist = JsonSerializer.Deserialize<Watchlist>(jsonString);
            Console.WriteLine($"Watchlist {watchlist.watchlistName} dibuat oleh {watchlist.createdBy} dengan film-film berikut:");
            foreach (var movie in watchlist.movies)
            {
                Console.WriteLine($"- {movie.title} ({movie.year}), Genre: {movie.genre}, Rating: {movie.rating}");
            }
        }
    }
}
    
