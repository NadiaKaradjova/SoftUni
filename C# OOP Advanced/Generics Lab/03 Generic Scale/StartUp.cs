using System;

public class StartUp
{
    public static void Main()
    {
        Scale<int> scale = new Scale<int>(3, 5);
        Console.WriteLine(scale.GetHavier());
    }
}