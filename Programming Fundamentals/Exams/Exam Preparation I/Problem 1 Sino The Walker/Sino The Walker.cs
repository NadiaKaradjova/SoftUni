using System;
using System.Linq;


namespace Demo2
{
    public class Demo2
    {
        public static void Main()
        {
            var timeToLeave = Console.ReadLine().Split(':').Select(ulong.Parse).ToArray();
            ulong hours = timeToLeave[0] * 60 * 60;
            ulong minutes = timeToLeave[1] * 60;
            ulong seconds = timeToLeave[2];

            ulong startingTime = hours + minutes + seconds;

            var steps = ulong.Parse(Console.ReadLine());
            var secondsForStep = ulong.Parse(Console.ReadLine());


            ulong timeForHome = steps * secondsForStep;
            ulong totalTime = startingTime + timeForHome;


            //for minutes & seconds

            var finalMinutes = totalTime / 60;
            var finalSeconds = totalTime % 60;


            //for hours
            var finalHours = finalMinutes / 60;
            finalMinutes = finalMinutes % 60;
            finalHours = (finalHours % 24);


            Console.WriteLine($"Time Arrival: {finalHours:00}:{finalMinutes:00}:{finalSeconds:00}");
        }
    }
}
