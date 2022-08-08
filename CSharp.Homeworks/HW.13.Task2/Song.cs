﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
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

            Console.WriteLine("Using Newtonsoft Json \n");

            string json = JsonConvert.SerializeObject(song);

            Console.WriteLine("After serialie to json \n" + json + "\n");

            Song? restoredSong = JsonConvert.DeserializeObject<Song>(json);

            Console.WriteLine("After deserialize to json \n" + restoredSong);

            Console.WriteLine("Using System.Text.Json: \n");
            song.JsonSerialize();

            songs.Add(song);
        }

        public void GetSongData()
        {
            Console.WriteLine("These are all your songs data");
            foreach (var songData in songs)
            {
                Console.WriteLine($"Song description :\n {songData.ToString()}");
            }
        }

        public void JsonSerialize()
        {
            var song = new Song();
            string jsonSystem = System.Text.Json.JsonSerializer.Serialize<Song>(song);

            Console.WriteLine("After serialie to json \n" + jsonSystem + "\n");

            Song? restoredSong = System.Text.Json.JsonSerializer.Deserialize<Song>(jsonSystem);

            Console.WriteLine("After deserialize to json \n" + restoredSong);
        }

        public override string ToString()
        {
            return $"Title: {SongName}, Minutes: {SongDuration}, Year: {SongYear}, Genre: {SongGenre} ";
        }
    }
}
