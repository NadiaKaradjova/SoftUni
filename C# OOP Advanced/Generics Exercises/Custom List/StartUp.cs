using System;

namespace Custom_List
{
    public class StartUp
    {
        public static void Main()
        {
            CustomList<string> myCustomList = new CustomList<string>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var line = input.Split();

                switch (line[0])
                {
                    case "Add":
                        myCustomList.Add(line[1]);
                        break;

                    case "Remove":
                        myCustomList.Remove(int.Parse(line[1]));
                        break;

                    case "Contains":
                        Console.WriteLine(myCustomList.Contains(line[1]));
                        break;

                    case "Swap":
                        myCustomList.Swap(int.Parse(line[1]), int.Parse(line[2]));
                        break;

                    case "Greater":
                        Console.WriteLine(myCustomList.CountGreaterThan(line[1]));
                        break;

                    case "Max":
                        Console.WriteLine(myCustomList.Max());
                        break;

                    case "Min":
                        Console.WriteLine(myCustomList.Min());
                        break;

                    case "Sort":
                        myCustomList = Sorter.Sort(myCustomList);
                        break;

                    case "Print":
                        foreach (var element in myCustomList)
                        {
                            Console.WriteLine(element);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}