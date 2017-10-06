namespace DefineaclassPerson
{
    using System;
    using System.Reflection;

    public class Define_a_class_Person
    {
        static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}
