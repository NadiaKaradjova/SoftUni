using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Pet : IBirthable
    {
        private string name;

        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string BirthDate { get; private set; }
    }
}
