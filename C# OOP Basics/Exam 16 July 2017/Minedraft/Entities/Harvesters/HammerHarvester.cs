﻿using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += this.OreOutput * 2;
        this.EnergyRequirement *= 2;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Hammer Harvester - {this.Id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.Append($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString();
    }
}