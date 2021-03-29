using System;


namespace Task1
{
    sealed class Song
    {
        string _name;
        double _duration;
        string _author;
        int _releaseYear;
        internal enum Genre
        {
            Pop = 0,
            Rock = 1,
            Jazz = 2,
            Blues = 3
        }

        public string Name { get => _name; set => _name = value; }
        public double Duration { get => _duration; set => _duration = value; }
        public string Author { get => _author; set => _author = value; }
        public int ReleaseYear { get => _releaseYear; set => _releaseYear = value; }
        
        internal Genre GetSongGenre()
        {
            Genre songGenre;
            while (true)
            {
                Console.Write("Please, enter song genre: ");
                string userInput = Console.ReadLine();

                bool isValidInt = int.TryParse(userInput, out int genreAsInt);
                bool isValidGenre = Enum.TryParse(userInput, out songGenre);

                if (isValidInt && Enum.IsDefined(typeof(Genre), genreAsInt))
                {
                    songGenre = (Genre)genreAsInt;
                    break;
                }
                else if (isValidGenre && !isValidInt)
                    break;
            }                    
            return songGenre;
        }

        internal void DisplayInfo() 
        {
            Console.WriteLine($"Song name: {Name}");
            Console.WriteLine($"Song duration: {Duration}");
            Console.WriteLine($"Song author: {Author}");
            Console.WriteLine($"Song release year: {ReleaseYear}");
        }
    }
}
