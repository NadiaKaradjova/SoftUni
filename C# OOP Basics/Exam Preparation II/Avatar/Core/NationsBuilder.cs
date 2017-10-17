using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> wars;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            { "Air", new Nation() },
            { "Earth", new Nation() },
            { "Water", new Nation() },
            { "Fire", new Nation() }
        };
        this.wars = new List<string>();
    }

    

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var secondParam = double.Parse(benderArgs[3]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddBender(new AirBender(name, power, secondParam));
                break;
            case "Earth":
                this.nations[type].AddBender(new EarthBender(name, power, secondParam));
                break;
            case "Water":
                this.nations[type].AddBender(new WaterBender(name, power, secondParam));
                break;
            case "Fire":
                this.nations[type].AddBender(new FireBender(name, power, secondParam));
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddMonument(new AirMonument(name, affinity));
                break;
            case "Earth":
                this.nations[type].AddMonument(new EarthMonument(name, affinity));
                break;
            case "Water":
                this.nations[type].AddMonument(new WaterMonument(name, affinity));
                break;
            case "Fire":
                this.nations[type].AddMonument(new FireMonument(name, affinity));
                break;
        }
    }

    public string GetStatus(string nationsType)
    {
        return $"{nationsType} Nation" + Environment.NewLine + this.nations[nationsType].ToString();
    }

    public void IssueWar(string nationsType)
    {
        var winner = nations.OrderByDescending(t => t.Value.GetTotalPoints());
        var winnerType = winner.First().Key;

        foreach (var nation in nations.Where(n => n.Key !=winnerType))
        {
            nation.Value.KillYourself();
        }

        wars.Add(nationsType);
    }

    public string GetWarsRecord()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < wars.Count; i++)
        {
            sb.AppendLine($"War {i + 1} issued by {wars[i]}");
        }
        return sb.ToString();
    }
}