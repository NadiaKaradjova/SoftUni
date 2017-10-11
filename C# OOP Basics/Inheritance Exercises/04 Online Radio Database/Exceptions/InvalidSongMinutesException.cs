using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string DefaultMessage = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException():base(DefaultMessage)
        {

        }

        public InvalidSongMinutesException(string message) : base(message)
        {

        }
    }
}
