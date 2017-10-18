using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string currentMode;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private List<Harvester> harvesters;
    private List<Provider> providers;

    public DraftManager()
    {
        this.currentMode = "Full";
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
    }


    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);

        try
        {
            if (type == "Sonic")
            {
                var sonicFactor = int.Parse(arguments[4]);
                harvesters.Add(new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor));
            }
            else
            {
                harvesters.Add(new HammerHarvester(id, oreOutput, energyRequirement));
            }
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }

        return $"Successfully registered {type} Harvester - {id}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);

        try
        {
            if (type == "Solar")
            {
                providers.Add(new SolarProvider(id, energyOutput));
            }
            else
            {
                
                providers.Add(new PressureProvider(id, energyOutput));
            }
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }

        return $"Successfully registered {type} Provider - {id}";
    }
    public string Day()
    {
        double totalEnergyNeeded = 0;
        double summedOreOutput = 0;
        
        double summedEnergyOutput = providers.Sum(p => p.EnergyOutput);
        this.totalStoredEnergy += summedEnergyOutput;

        switch (currentMode)
        {
            case "Full":
                totalEnergyNeeded = harvesters.Sum(e => e.EnergyRequirement);
                if (totalStoredEnergy >= totalEnergyNeeded)
                {
                    summedOreOutput = this.harvesters.Sum(h => h.OreOutput);
                    this.totalMinedOre += summedOreOutput;
                    this.totalStoredEnergy -= totalEnergyNeeded;
                }
                break;
            case "Half":
                totalEnergyNeeded = harvesters.Sum(e => e.EnergyRequirement)*0.6;
                if (totalStoredEnergy >= totalEnergyNeeded)
                {
                    summedOreOutput = this.harvesters.Sum(h => h.OreOutput)*0.5;
                    this.totalMinedOre += summedOreOutput;
                    this.totalStoredEnergy -= totalEnergyNeeded;
                }
                break;
            case "Energy":
                break;
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {summedEnergyOutput}");
        sb.Append($"Plumbus Ore Mined: {summedOreOutput}");
        return sb.ToString();
    }

    public string Mode(List<string> arguments)
    {
        var mode = arguments[0];
        this.currentMode = mode;
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        if (this.harvesters.Any(h => h.Id == id))
        {
            return this.harvesters.First(h => h.Id == id).ToString();
        }

        if (this.providers.Any(h => h.Id == id))
        {
            return this.providers.First(h => h.Id == id).ToString();
        }

        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
       var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalStoredEnergy}");
        sb.Append($"Total Mined Plumbus Ore: {totalMinedOre}");
        return sb.ToString();
    }

}