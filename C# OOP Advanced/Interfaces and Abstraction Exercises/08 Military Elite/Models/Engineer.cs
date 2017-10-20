using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, double salary, string corps, IList<IRepair> parts)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Parts = parts;
        }

        public IList<IRepair> Parts { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder().AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            sb.Append($"  {string.Join(Environment.NewLine + "  ", this.Parts)}");
            return sb.ToString();
        }
    }
}