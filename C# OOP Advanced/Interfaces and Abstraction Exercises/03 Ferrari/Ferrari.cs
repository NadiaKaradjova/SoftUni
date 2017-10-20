using System.Net.Configuration;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        private const string model = "488-Spider";
        private string driverName;

        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
        }

        
        public string DriverName 
        {
            get { return this.driverName; }
            private set { this.driverName = value; }
        }

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public string PushGaz()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{model}/{this.PushBrakes()}/{this.PushGaz()}/{this.DriverName}";
        }
    }
}
