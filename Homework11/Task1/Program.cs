using System;
using Newtonsoft.Json;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song userSong1 = new();

            var something = GetSongData(userSong1);

            Console.WriteLine("Anonymous song serialized: ");
            string jsonData = JsonConvert.SerializeObject(something);
            Console.WriteLine(jsonData);
        }

        static dynamic GetSongData(Song song)
        {
            Console.Write("Please, enter song name: ");
            song.Name = Console.ReadLine();

            song.Duration = Validator.GetPositiveDouble("Please, enter song duration in minutes: ");
            song.Author = Validator.GetValidName("Please, enter song author: ");
            song.ReleaseYear = Validator.GetValidYear("Please, enter song release year: ");
            Song.Genre genre = song.GetSongGenre();

            song.DisplayInfo();
            Console.WriteLine($"Song genre: {genre}");
            Console.WriteLine();

            var anonymousSong = new
            {
                Title = song.Name,
                Minutes = song.Duration,
                AlbumYear = song.ReleaseYear,
            };

            Console.WriteLine("anonymousSong: ");
            Console.WriteLine($"Song title: {anonymousSong.Title}");
            Console.WriteLine($"Song duration: {anonymousSong.Minutes}");
            Console.WriteLine($"Song year: {anonymousSong.AlbumYear}");

            return anonymousSong;
        }
    }
}