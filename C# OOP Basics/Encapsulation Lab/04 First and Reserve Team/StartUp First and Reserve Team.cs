using System;

public class First_and_Reserve_Team
{

    public static void Main()
    {
        var teams = new Team("proba");

        var lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));
           
            teams.AddPlayer(person);
        }

        Console.WriteLine($"First team have {teams.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {teams.ReserveTeam.Count} players");        
    }
}


