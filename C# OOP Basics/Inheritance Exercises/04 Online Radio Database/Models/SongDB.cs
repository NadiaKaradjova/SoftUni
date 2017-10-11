using System.Text;

namespace OnlineRadioDatabase.Models
{
    public class SongDB
    {
        private int songCount;
        private long totalDurationInSeconds;

        public void AddSong(Song song)
        {
            this.songCount++;
            long currentDurationInSeconds = song.Minutes * 60 + song.Seconds;
            this.totalDurationInSeconds += currentDurationInSeconds;
        }

        public override string ToString()
        {
            long hours = (this.totalDurationInSeconds / 60) / 60;
            long minutes = (this.totalDurationInSeconds / 60) % 60;
            long sesonds = this.totalDurationInSeconds % 60;

            var sb = new StringBuilder();
            sb.AppendLine($"Songs added: {songCount}")
                .Append($"Playlist length: {hours}h {minutes}m {sesonds}s");

            return sb.ToString();
        }
    }
}