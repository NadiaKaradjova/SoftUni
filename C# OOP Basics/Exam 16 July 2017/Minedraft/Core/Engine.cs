using System;
using System.Data;
using System.Linq;

public class Engine
{
    private DraftManager manager;

    public Engine()
    {
        this.manager = new DraftManager();
    }

    public void Run()
    {
        string input;

        while ((input = Console.ReadLine()) != "Shutdown" )
        {
            var arguments = input.Split().ToList();
            var command = arguments[0];
            arguments.RemoveAt(0);

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(manager.RegisterHarvester(arguments));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(manager.RegisterProvider(arguments));
                    break;
                case "Day":
                    Console.WriteLine(manager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(manager.Mode(arguments));
                    break;
                case "Check":
                    Console.WriteLine(manager.Check(arguments));
                    break;
            }
            
        }
        Console.WriteLine(manager.ShutDown());
    }
}