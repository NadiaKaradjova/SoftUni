namespace FoodShortage
{
    public class Citizens : Human
    {
        private string birthDate;
        private string id;

        public Citizens(string name, int age, string id, string birthDate) : base(name, age)
        {
            this.BirthDate = birthDate;
            this.Id = id;
        }

        public string Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public string BirthDate
        {
            get { return this.birthDate; }
            private set { this.birthDate = value; }
        }

        public override void BuyFood()
        {
            base.Food += 10;
        }
    }
}