using System;
using System.Collections.Generic;
using System.Linq;

    public class TestClient
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var line = input.Split();
                var commandType = line[0];

                switch (commandType)
                {
                    case "Create":
                        Create(line, accounts);
                        break;
                    case "Deposit":
                        Deposit(line, accounts);
                       break;
                    case "Withdraw":
                        Withdraw(line, accounts);
                        break;
                    case "Print":
                        Print(line, accounts);
                       break;
                }

                input = Console.ReadLine();
            }

            }

        private static void Print(string[] line, Dictionary<int, BankAccount> accounts)
        {
            var currentId = int.Parse(line[1]);
            if (accounts.Any(x => x.Key == currentId))
            {
                var current = accounts.First(x => x.Key == currentId);
                Console.WriteLine($"Account ID{current.Key}, balance {current.Value.Balance:f2}");
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
            

        }

        private static void Withdraw(string[] line, Dictionary<int, BankAccount> accounts)
        {
            var currentId = int.Parse(line[1]);
            var amound = double.Parse(line[2]);

            if (!accounts.ContainsKey(currentId))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var current = accounts.First(x => x.Key == currentId);
                if (amound> current.Value.Balance)
                {
                    Console.WriteLine("Insufficient balance");
                    return;
                }
                current.Value.Withdraw(amound);
            }
        }

        private static void Deposit(string[] line, Dictionary<int, BankAccount> accounts)
        {
            var currentId = int.Parse(line[1]);
            var amound = double.Parse(line[2]);

            if (!accounts.ContainsKey(currentId))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var current = accounts.First( x => x.Key == currentId);                
                current.Value.Deposit(amound);                
            }


        }

        private static void Create(string[] line, Dictionary<int, BankAccount> accounts)
        {
            var currentId = int.Parse(line[1]);
            if (!accounts.ContainsKey(currentId))
            {
                var current = new BankAccount();
                current.ID = currentId;
                accounts.Add(currentId, current);
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
    
    }

