using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongException : ArgumentException
    {
        private const string DefaultMessage = "Invalid song.";

        public InvalidSongException():base(DefaultMessage)
        {
                
        }

        public InvalidSongException(string message) : base(message)
        {

        }
    }
}
