using System;
using System.Text;
using Animals.Exeptions;

namespace Animals.Models
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new InvalidInputExeptions();
                }
                this.gender = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidInputExeptions();
                }
                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidInputExeptions();
                }
                this.name = value;
            }
        }

        public virtual string ProduceSound()
        {
            return "Not implemented!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}")
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .Append($"{ProduceSound()}");

            return sb.ToString();
        }
    }
}