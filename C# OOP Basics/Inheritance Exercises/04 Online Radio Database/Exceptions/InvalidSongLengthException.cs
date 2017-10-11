using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        private const string DefaultMessage = "Invalid song length.";

        public InvalidSongLengthException():base(DefaultMessage)
        {

        }

        public InvalidSongLengthException(string message) : base(message)
        {

        }
    }
}
