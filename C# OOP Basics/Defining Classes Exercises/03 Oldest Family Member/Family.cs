namespace OldestFamilyMember
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person currentPerson)
        {
            this.members.Add(currentPerson);
        }

        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(x => x.Age).First(); 
        }
    }
}
