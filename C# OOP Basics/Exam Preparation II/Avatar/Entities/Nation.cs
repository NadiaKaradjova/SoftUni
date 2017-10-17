using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public void AddBender(Bender bender) => this.benders.Add(bender);
    public void AddMonument(Monument momument) => this.monuments.Add(momument);

    public double GetTotalPoints()
    {
        var power = this.benders.Sum(p => p.GetPower());
        var bonus = this.monuments.Sum(a => a.GetPoints());

        return power + power / 100 * bonus;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        if (this.benders.Count > 0)
        {
            sb.AppendLine($"Benders:");
            sb.AppendLine(string.Join(Environment.NewLine, benders));
        }
        else
        {
            sb.AppendLine($"Benders: None");
        }

        if (this.monuments.Count>0)
        {
            sb.AppendLine($"Monuments:");
            sb.AppendLine(string.Join(Environment.NewLine, monuments));
        }
        else
        {
            sb.AppendLine($"Monuments: None");
        }

        return sb.ToString().Trim();
    }

    public void KillYourself()
    {
        this.benders.Clear();
        this.monuments.Clear();
    }
}