using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_Fix_Emails
{
    public class task6_Fix_Emails
    {
        public static void Main()
        {
            var text = File.ReadLines("input.txt").ToArray();

            var listOfPeople = new Dictionary<string, string>();

            for (int i = 0; i < text.Length - 1; i += 2)
            {

                if (!listOfPeople.ContainsKey(text[i]))
                {
                    listOfPeople[text[i]] = "";
                }

                listOfPeople[text[i]] += text[i + 1];
            }

            var sorted = listOfPeople
                .Where(a => !(a.Value.EndsWith("us")) && !(a.Value.EndsWith("com")));

            File.Delete("output.txt");

            foreach (var item in sorted)
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}{Environment.NewLine}");
            }
        }
    }
}
