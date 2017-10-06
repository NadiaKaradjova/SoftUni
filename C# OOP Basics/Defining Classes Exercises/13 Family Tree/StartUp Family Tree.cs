namespace FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    

    public class Family_Tree
    {
        public static void Main()
        {
            var searchedPerson = Console.ReadLine();
            var allPeople = new List<Person>();
            string inputLine;

            while ((inputLine = Console.ReadLine()) != "End")
            {
                if (inputLine.Contains("-"))
                {
                    var info = inputLine.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                    var parentInfo = info[0];
                    var childInfo = info[1];
                    
                    var parent = new Person();

                    if (parentInfo.Contains("/"))
                    {
                        parent.BirthDay = parentInfo;
                    }
                    else
                    {
                        parent.Name = parentInfo;
                    }

                    var child = new Person();

                    if (childInfo.Contains("/"))
                    {
                        child.BirthDay = childInfo;
                    }
                    else
                    {
                        child.Name = childInfo;
                    }

                    AddParentIfMissing(allPeople, parent);
                    if (parent.Name != null)
                    {
                        allPeople.FirstOrDefault(p => p.Name == parent.Name).AddChild(child);
                    }
                    else
                    {
                        allPeople.FirstOrDefault(p => p.BirthDay == parent.BirthDay).AddChild(child);
                    }
                    
                }
                else
                {
                    var info = inputLine.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = info[0] + " " + info[1];
                    var birthDay = info[2];
                    var added = false;
                    for (int i = 0; i < allPeople.Count; i++)
                    {
                        if (allPeople[i].Name == name)
                        {
                            allPeople[i].BirthDay = birthDay;
                            added = true;
                        }

                        if (allPeople[i].BirthDay == birthDay)
                        {
                            allPeople[i].Name = name;
                            added = true;
                        }

                        allPeople[i].AddChildrenInfo(name, birthDay);
                    }
                    if (!added)
                    {
                        var person = new Person() { Name = name, BirthDay = birthDay};
                        allPeople.Add(person);
                    }                   
                }
            }

            Print(allPeople, searchedPerson);
        }

        private static void Print(List<Person> allPeople, string searchedPersonParam)
        {
            Person person;
            if (searchedPersonParam.Contains("/"))
            {
                person = allPeople.FirstOrDefault(p => p.BirthDay == searchedPersonParam);                
            }
            else
            {
                person = allPeople.FirstOrDefault(p => p.Name == searchedPersonParam);
            }
            Console.WriteLine($"{person.Name} {person.BirthDay}");
            Console.WriteLine("Parents:");
            var parents = allPeople.Where(p => p.FindChildName(person.Name) != null );
            foreach (var parent in parents)
            {
                Console.WriteLine($"{parent.Name} {parent.BirthDay}");
            }
            Console.WriteLine("Children:");
            foreach (var child in person.Children)
            {
                Console.WriteLine($"{child.Name} {child.BirthDay}");
            }


        }

        private static void AddParentIfMissing(List<Person> allPeople, Person parent)
        {
            if (parent.Name != null && allPeople.Any(p => p.Name == parent.Name))
            {
                return;
            }

            if (parent.BirthDay != null && allPeople.Any(p => p.BirthDay == parent.BirthDay))
            {
                return;
            }

            allPeople.Add(parent);
        }
    }
}
