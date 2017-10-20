using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            smartphone.MakeCall(numbers);
            smartphone.Browse(urls);

            Console.WriteLine(smartphone);
        }
    }
}