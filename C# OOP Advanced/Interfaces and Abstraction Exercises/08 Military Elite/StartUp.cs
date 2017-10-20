using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        private static IList<ISoldier> army;

        public static void Main()
        {
            army = new List<ISoldier>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                var args = input.Split();

                var type = args[0];

                switch (type)
                {
                    case "Private":
                        army.Add(new Private(args[1], args[2], args[3], double.Parse(args[4])));
                        break;

                    case "Spy":
                        army.Add(new Spy(args[1], args[2], args[3], int.Parse(args[4])));
                        break;

                    case "LeutenantGeneral":
                        var privates = ExtractPrivates(args.Skip(5).ToList());
                        army.Add(new LeutenantGeneral(args[1], args[2], args[3], double.Parse(args[4]), privates));
                        break;

                    case "Engineer":
                        if (args[5] != "Airforces" && args[5] != "Marines")
                        {
                            break;
                        }
                        var parts = ExtractParts(args.Skip(6).ToList());
                        army.Add(new Engineer(args[1], args[2], args[3], double.Parse(args[4]), args[5], parts));

                        break;

                    case "Commando":
                        if (args[5] != "Airforces" && args[5] != "Marines")
                        {
                            break;
                        }
                        var missions = ExtractMissions(args.Skip(6).ToList());
                        army.Add(new Commando(args[1], args[2], args[3], double.Parse(args[4]), args[5], missions));
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier);
            }
        }

        private static IList<IRepair> ExtractParts(IList<string> parts)
        {
            var list = new List<IRepair>();

            for (int i = 0; i < parts.Count - 1; i += 2)
            {
                list.Add(new Repair(parts[i], int.Parse(parts[i + 1])));
            }
            return list;
        }

        private static IList<IMission> ExtractMissions(IList<string> missions)
        {
            var list = new List<IMission>();

            for (int i = 0; i < missions.Count - 1; i += 2)
            {
                if (missions[i + 1] != "inProgress" && missions[i + 1] != "Finished")
                {
                    continue;
                }
                list.Add(new Mission(missions[i], missions[i + 1]));
            }
            return list;
        }

        private static IList<ISoldier> ExtractPrivates(IList<string> soldiers)
        {
            var list = new List<ISoldier>();
            foreach (var member in soldiers)
            {
                list.Add(army.First(x => x.Id == member));
            }

            return list;
        }
    }
}