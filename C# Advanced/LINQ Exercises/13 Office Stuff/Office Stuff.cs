using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _13_Office_Stuff
{
    public class _13_Office_Stuff
    {
        public static void Main()
        {
            var result = new SortedDictionary<string, Dictionary<string, int>>();

            var n = int.Parse(Console.ReadLine());
            var pattern = new Regex(@"[A-Za-z]");

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Trim('|').Split(new[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var company = input[0];
                var quantity = int.Parse(input[1]);
                var product = input[2];
                var companyMatch = pattern.Match(company);
                var productMatch = pattern.Match(product);
                if (companyMatch.Success && productMatch.Success)
                {
                    if (!result.ContainsKey(company))
                    {
                        result[company] = new Dictionary<string, int>();
                    }

                    if (!result[company].ContainsKey(product))
                    {
                        result[company][product] = 0;
                    }
                    result[company][product] += quantity;
                }

            }

            foreach (var company in result)
            {
                var agregatedProducts = company.Value;
                Console.Write($"{company.Key}: ");
                var sb = new StringBuilder();
                foreach (var product in agregatedProducts)
                {
                    sb.Append($"{product.Key}-{product.Value}, ");
                }
                sb.Length -= 2;
                Console.WriteLine(sb);
            }
        }
    }
}
