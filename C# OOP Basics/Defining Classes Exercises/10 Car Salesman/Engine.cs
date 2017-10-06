using System;
using System.Collections.Generic;
using System.Linq;
namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public string Model { get { return this.model; } }
        public int Power { get { return this.power; } }
    }
}
