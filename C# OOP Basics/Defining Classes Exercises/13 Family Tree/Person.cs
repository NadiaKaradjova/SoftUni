namespace FamilyTree
{
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private List<Person> children;

        public Person()
        {
            this.children = new List<Person>();
        }
        public string BirthDay { get; set; }
        public string Name { get; set; }

        public IReadOnlyList<Person> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public void AddChild(Person child)
        {
            this.children.Add(child);
        }        

        public void AddChildrenInfo(string name, string birthDay)
        {
            if (this.children.FirstOrDefault(c => c.Name == name) != null)
            {
                this.children.FirstOrDefault(c => c.Name == name).BirthDay = birthDay;
                return;
            }

            if (this.children.FirstOrDefault(c => c.BirthDay == birthDay) != null)
            {
                this.children.FirstOrDefault(c => c.BirthDay == birthDay).Name = name;
                return;
            }
        }

        public Person FindChildName(string childName)
        {
            return this.children.FirstOrDefault(ch => ch.Name == childName);
        }
    }
}