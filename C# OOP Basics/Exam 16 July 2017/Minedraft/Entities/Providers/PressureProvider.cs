using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput = energyOutput * 1.5;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Pressure Provider - {this.Id}");
        sb.Append($"Energy Output: {this.EnergyOutput}");
        return sb.ToString();
    }
}