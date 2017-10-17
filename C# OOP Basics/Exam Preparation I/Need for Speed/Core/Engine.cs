using System;

public class Engine
{
    private CarManager manager;

    public Engine()
    {
        this.manager = new CarManager();
    }

    public void Run()
    {
        var command = Console.ReadLine();

        while (command != "Cops Are Here")
        {
            var cmdArg = command.Split();

            int id;
            string type;
            int raceId;

            switch (cmdArg[0])
            {
                case "register":
                    id = int.Parse(cmdArg[1]);
                    type = cmdArg[2];
                    string brand = cmdArg[3];
                    string model = cmdArg[4];
                    int yearOfProduction = int.Parse(cmdArg[5]);
                    int horsepower = int.Parse(cmdArg[6]);
                    int acceleration = int.Parse(cmdArg[7]);
                    int suspension = int.Parse(cmdArg[8]);
                    int durability = int.Parse(cmdArg[9]);
                    manager.Register(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                    break;

                case "check":
                    Console.WriteLine(manager.Check(int.Parse(cmdArg[1])));
                    break;

                case "open":
                    id = int.Parse(cmdArg[1]);
                    type = cmdArg[2];
                    int length = int.Parse(cmdArg[3]);
                    string route = cmdArg[4];
                    int prizePool = int.Parse(cmdArg[5]);
                    manager.Open(id, type, length, route, prizePool);
                    break;

                case "participate":
                    int carId = int.Parse(cmdArg[1]);
                    raceId = int.Parse(cmdArg[2]);
                    manager.Participate(carId, raceId);
                    break;

                case "start":
                    raceId = int.Parse(cmdArg[1]);
                    Console.WriteLine(manager.Start(raceId));
                    
                    break;

                case "park":
                    id = int.Parse(cmdArg[1]);
                    manager.Park(id);
                    break;

                case "unpark":
                    id = int.Parse(cmdArg[1]);
                    manager.Unpark(id);
                    break;

                case "tune":
                    int tuneIndex = int.Parse(cmdArg[1]);
                    string addOns = cmdArg[2];
                    manager.Tune(tuneIndex, addOns);
                    break;
            }

            command = Console.ReadLine();
        }
    }
}