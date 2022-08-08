using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HW._13.Task2
{
    public class Song
    {
        public string SongName { get; set; }
        public double SongDuration { get; set; }
        public string SongAuthor { get; set; }
        public DateTime SongYear { get; set; }
        public Genre SongGenre { get; set; }

        public enum Genre
        {
            classic = 1,
            pop,
            rock,
            unselected
        }

        public List<Song> songs = new List<Song>();

        public void CreateSong()
        {
            Console.WriteLine("Please enter your songs");
            var song = new Song();

            Console.WriteLine("Please enter song Name");
            song.SongName = Console.ReadLine();

            Console.WriteLine("Please enter song Duration");
            song.SongDuration = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter song year in format: dd.mm.yyyy");
            DateTime yearOfSong = new DateTime();
            yearOfSong.ToShortDateString();
            yearOfSong = DateTime.Parse(Console.ReadLine());
            song.SongYear = yearOfSong;

            Console.WriteLine("Please enter song Author");
            song.SongAuthor = Console.ReadLine();

            Console.WriteLine("Please enter the genre: 1 - calssic, 2 - pop, 3 - rock, all others inputs will be named as 'unselected'!");
            var userSongGenre = Console.ReadLine();
            if(Int32.Parse(userSongGenre).Equals(true))
            {   
                song.SongGenre = (Genre)Int32.Parse(userSongGenre);
            }
            else if (Int32.Parse(userSongGenre).Equals(false))
            {
                song.SongGenre = Genre.unselected;
            }

            string json = JsonSerializer.Serialize(song);

            Console.WriteLine("\n");
            Console.WriteLine("After serialie to json \n" + json + "\n");

            Song? restoredSong = JsonSerializer.Deserialize<Song>(json);

            Console.WriteLine("After deserialize to json \n" + restoredSong);

            songs.Add(song);
        }

        public void GetSongData()
        {
            Console.WriteLine("These are all your songs data");
            foreach (var songData in songs)
            {
                Console.WriteLine($"Engineer description :\n {songData.ToString()}");
            }
        }

        public override string ToString()
        {
            return $"Title: {SongName}, Minutes: {SongDuration}, Year: {SongYear}, Genre: {SongGenre} ";
        }
    }
}
