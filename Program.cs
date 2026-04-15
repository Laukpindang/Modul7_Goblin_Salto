using Modul7_103022400106;


Console.WriteLine();
//Rawikara
var filmFavorit = new FilmFavorit_103022400106();
var watchlist = new Watchlist_103022400106();

filmFavorit.readJson();

Console.WriteLine("\n");

watchlist.readJson();