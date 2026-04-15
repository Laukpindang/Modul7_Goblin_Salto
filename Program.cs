using Modul7_103022400106;
using Modul7_103022300053;
using Modul7_103022300053;

showFilm film = new showFilm();
film.readJSON();

showWatchlist watchlist = new showWatchlist();
watchlist.readJSON();

GenreDictionary_103022400088 genreDictionary = new GenreDictionary_103022400088();
genreDictionary.readJSON();


Console.WriteLine();
//Rawikara
var filmFavorit = new FilmFavorit_103022400106();
var watchlist = new Watchlist_103022400106();
var genreDictionary = new GenreDictionary_103022400106();

filmFavorit.readJson();

Console.WriteLine("\n");

watchlist.readJson();

Console.WriteLine("\n");

genreDictionary.readJson();

FilmFavorit_103022400053 fff = new FilmFavorit_103022400053();
fff.ReadJson();
Console.WriteLine();
Watchlist_103022400053 wlf = new Watchlist_103022400053();
wlf.ReadJson();
Console.WriteLine();
GenreDictionary_103022400053 gdf = new GenreDictionary_103022400053();
gdf.ReadJson();
Console.WriteLine();