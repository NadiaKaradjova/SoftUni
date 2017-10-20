namespace FoodShortage
{
    public abstract class Human : IBuyer
    {
        private string name;
        private int age;

        protected Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        protected int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int Food { get; protected set; }

        public abstract void BuyFood();
    }
}