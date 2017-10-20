using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, double salary, string corps, IList<IMission> misions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = misions;
        }

        public IList<IMission> Missions { get; private set; }

        public void CompleteMission()
        {
            //TODO
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Missions:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");
            return sb.ToString().Trim();
        }
    }
}