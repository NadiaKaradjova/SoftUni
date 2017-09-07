using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_Exercises
{
    public class task1_Exercises
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var exercises = new List<Exercise>();

            while (input != "go go go")
            {
                var line = input.Split(new char[] { '-', '>', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var topic = line[0];
                var courseName = line[1];
                var judgeContestLink = line[2];
                var problems = line.Skip(3).ToList();

                var newExercise = new Exercise()
                { Topic = topic, CourseName = courseName, JudgeContestLink = judgeContestLink, Problems = problems };

                exercises.Add(newExercise);

                input = Console.ReadLine();
            }

            foreach (var item in exercises)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");
                for (int i = 0; i < item.Problems.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {item.Problems[i]}");
                }
            }
        }
        public class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }
        }
    }

}
