﻿public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power, double groundSaturation) : base(name, power)
    {
        this.groundSaturation = groundSaturation;
    }

    public override double GetPower()
    {
        return base.Power * groundSaturation;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Ground Saturation: {groundSaturation:f2}";
        }
}