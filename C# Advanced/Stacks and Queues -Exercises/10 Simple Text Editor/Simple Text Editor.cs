using System;
using System.Collections.Generic;

namespace _10_Simple_Text_Editor
{
    public class _10_Simple_Text_Editor
    {
        public static void Main()
        {
            string text = String.Empty;
            var n = int.Parse(Console.ReadLine());

            var temp = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];

                switch (command)
                {
                    case "1":
                        {
                            var newText = input[1];
                            temp.Push(text);
                            text = text + newText;
                        }
                        break;
                    case "2":
                        {
                            var count = int.Parse(input[1]);
                            temp.Push(text);
                            text = text.Remove(text.Length - count, count);
                        }
                        break;
                    case "3":
                        {
                            var index = int.Parse(input[1]);
                            Console.WriteLine(text[index-1]);
                        }
                        break;
                    case "4":
                        {
                            text = temp.Pop();
                        }
                        break;
                }
            }
        }
    }
}
