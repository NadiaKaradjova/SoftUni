using BorderControl.Interfaces;

namespace BorderControl.Models
{
    public class Citizens : IIdentifiable
    {
        private string name;
        private int age;

        public Citizens(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Id { get; private set; }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }
    }
}