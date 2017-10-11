using OnlineRadioDatabase.Exceptions;
using System;

namespace OnlineRadioDatabase.Models
{
    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, string duration)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Duration = duration;
        }

        public string ArtistName
        {
            get { return this.artistName; }
            private set
            {
                if (value == null || value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artistName = value;
            }
        }

        public string SongName
        {
            get { return this.songName; }
            private set
            {
                if (value == null || value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                this.songName = value;
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            private set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get { return this.seconds; }
            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }

        private string Duration
        {
            set
            {
                var timeParams = value.Split(':');
                int minites, seconds;
                try
                {
                    minites = int.Parse(timeParams[0]);
                    seconds = int.Parse(timeParams[1]);
                }
                catch (FormatException)
                {
                    throw new InvalidSongLengthException();
                }
                this.Minutes = minites;
                this.Seconds = seconds;
            }
        }
    }
}