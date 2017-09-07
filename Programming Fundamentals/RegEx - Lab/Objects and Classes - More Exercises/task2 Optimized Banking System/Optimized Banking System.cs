using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_Optimized_Banking_System
{
    public class task2_Optimized_Banking_System
    {
        public static void Main()
        {
            var bankAccounts = new List<BankAccount>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var line = input.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var newAccount = new BankAccount() { Name = line[1], Bank = line[0], Balance = decimal.Parse(line[2]) };

                bankAccounts.Add(newAccount);

                input = Console.ReadLine();
            }

            var ordered = bankAccounts
                .OrderByDescending(x => x.Balance)
                .ThenBy(y => y.Bank).ToList();

            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }

        }

        public class BankAccount
        {
            public string Name { get; set; }
            public string Bank { get; set; }
            public decimal Balance { get; set; }
        }
        
    }
}
