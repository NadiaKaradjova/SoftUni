namespace OldestFamilyMember
{
    using System;

    public class _03_Oldest_Family_Member
    {
        public static void Main()
        {
            var family = new Family();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var personName = input[0];
                var personAge = int.Parse(input[1]);

                var currentPerson = new Person(personName, personAge);
                family.AddMember(currentPerson);                
            }
            var oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
