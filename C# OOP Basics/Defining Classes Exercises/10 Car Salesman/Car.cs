namespace CarSalesman
{
    public class Car
    {
        private string model;
        private string engine;
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, string engine)
        {
            this.model = model;
            this.engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public string Model { get { return this.model; } }
        public string Engine { get { return this.engine; } }
    }
}
