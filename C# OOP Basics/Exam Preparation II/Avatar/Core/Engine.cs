using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private NationsBuilder nation;

    public Engine()
    {
        this.nation = new NationsBuilder();
    }

    public void Run()
    {
        var command = Console.ReadLine();

        while (command != "Quit")
        {
            var param = command.Split().ToList();
            var commandWord = param[0];
            param.RemoveAt(0);

            switch (commandWord)
            {
                case "Bender":
                    nation.AssignBender(param);
                    break;
                case "Monument":
                    nation.AssignMonument(param);
                    break;
                case "Status":
                    Console.WriteLine(nation.GetStatus(param[0]));
                    
                    break;
                case "War":
                    nation.IssueWar(param[0]);
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(nation.GetWarsRecord());
        
    }
}