using System;

namespace Animals.Exeptions
{
    public class InvalidInputExeptions : ArgumentException
    {
        private const string DefaulMessage = "Invalid input!";

        public InvalidInputExeptions() : base(DefaulMessage)
        {
        }
    }
}