using System;

namespace MilitaryElite
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeName)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeName;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()}" + Environment.NewLine + $"Code Number: {this.CodeNumber}";
        }
    }
}