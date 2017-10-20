namespace FoodShortage
{
    public class Rebel : Human
    {
        private string group;

        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            this.Group = group;
        }

        public string Group
        {
            get { return this.group; }
            set { this.group = value; }
        }

        public override void BuyFood()
        {
            base.Food += 5;
        }
    }
}