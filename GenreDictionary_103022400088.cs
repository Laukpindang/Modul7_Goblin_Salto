using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_103022300053
{
    public class GenreDictionary_103022400088
    {
        public class gd
        {
            public GenreDictionary GenreDictionary { get; set; }

        }
        public class GenreDictionary 
        {
            public string category { get; set; }
            public GenreInfo GenreInfo { get; set; }
        }

        public class GenreInfo
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public List<String> popularMovies { get; set; }
        }

        public void readJSON() 
        {
            string path = "D:\\New folder\\Modul7_Goblin_Salto\\jurnal7_3_103022400088.json";
            string jsonString = File.ReadAllText(path);
            gd gd = JsonSerializer.Deserialize<gd>(jsonString);
            Console.WriteLine($"ID : {gd.GenreDictionary.GenreInfo.id}\n Name : {gd.GenreDictionary.GenreInfo.name}\n Description : {gd.GenreDictionary.GenreInfo.description}\n Popular Movies : ");
            gd.GenreDictionary.GenreInfo.popularMovies.ForEach(movie => Console.WriteLine($"- {movie}"));
        }

    }

    
}
