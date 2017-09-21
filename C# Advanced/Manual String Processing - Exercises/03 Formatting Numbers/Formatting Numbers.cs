using System;

namespace _03_Formatting_Numbers
{
    public class _03_Formatting_Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var numberOne = int.Parse(numbers[0]);
            var hex = $"{numberOne:X}";            
            var binary = Convert.ToString(numberOne, 2);
            binary = binary.PadLeft(10, '0').Substring(0, 10);
            var numberTwo = double.Parse(numbers[1]);
            var numberThree = double.Parse(numbers[2]);

            Console.WriteLine($"|{hex, -10}|{binary}|{numberTwo, 10:f2}|{numberThree, -10:f3}|");  
        }
    }
}
