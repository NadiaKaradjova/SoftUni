using System;

namespace Mankind
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine().Split();
                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);

                var workerInfo = Console.ReadLine().Split();
                var worker = new Worker(workerInfo[0], workerInfo[1], double.Parse(workerInfo[2]), double.Parse(workerInfo[3]));
                Console.WriteLine(student);
               // Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}