using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Citizens : IIdentifiable, IBirthable
    {
        private string name;
        private int age;

        public Citizens(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
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

        public string BirthDate { get; private set; }
    }
}