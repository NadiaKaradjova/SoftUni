using OnlineRadioDatabase.Models;
using System;

namespace OnlineRadioDatabase
{
    public class Online_Radio_Database
    {
        public static void Main()
        {
            var songDB = new SongDB();
            var numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                var input = Console.ReadLine();
                var songParams = input.Split(';');
                try
                {
                    var currentSong = new Song(songParams[0], songParams[1], songParams[2]);
                    songDB.AddSong(currentSong);
                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine(songDB);
        }
    }
}