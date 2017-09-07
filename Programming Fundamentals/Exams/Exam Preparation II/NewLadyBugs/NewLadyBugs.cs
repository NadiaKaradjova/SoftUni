using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLadyBugs
{
    public class NewLadyBugs
    {
        public static void Main()
        {
            var field = new int[int.Parse(Console.ReadLine())];
            var index = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < field.Length; i++)
            {
                if (index.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }
            
            var input = Console.ReadLine();

            while (input != "end")
            {

                if (field.Length <= 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var line = input.Split().ToArray();
                int indexStart = int.Parse(line[0]);
                int moves = int.Parse(line[2]);

                
                if (indexStart < 0 || indexStart >= field.Length || moves == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                else if (line[1] == "right")
                {
                    MoveRight(field, indexStart, moves);
                }

                else if (line[1] == "left")
                {
                    MoveLeft(field, indexStart, moves);
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        public static void MoveRight(int[] field, int indexStart, int moves)
        {
            var newIndex = indexStart + moves;

            while (newIndex >= 0 && newIndex < field.Length)
                {
                    if (field[indexStart] == 1 && field[newIndex] == 0)
                    {
                        field[newIndex] = 1;
                        field[indexStart] = 0;
                    }
                    else
                    {
                        newIndex = newIndex + moves;                        
                    }
                }  
            
            if (newIndex < 0 || newIndex >= field.Length)
            {
                field[indexStart] = 0;                
            }
            
        }

        public static void MoveLeft(int[] field, int indexStart, int moves)
        {
            var newIndex = indexStart - moves;

            while (newIndex >= 0 && newIndex < field.Length)
            {
                if (field[indexStart] == 1 && field[newIndex] == 0)
                {
                    field[newIndex] = 1;
                    field[indexStart] = 0;
                }
                else
                {
                    newIndex = newIndex - moves;
                }
            }

            if (newIndex < 0 || newIndex >= field.Length)
            {
                field[indexStart] = 0;
            }

        }
    }
}
