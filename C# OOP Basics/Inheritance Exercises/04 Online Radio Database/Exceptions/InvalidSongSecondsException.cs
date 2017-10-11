using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string DefaultMessage = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException():base(DefaultMessage)
        {

        }

        public InvalidSongSecondsException(string message) : base(message)
        {

        }
    }
}
