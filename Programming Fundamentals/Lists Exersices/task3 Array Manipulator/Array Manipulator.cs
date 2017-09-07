using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_Array_Manipulator
{
    public class Program
    {
        public static void Main()
        {
            var currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();                      

            while (true)
            {
                var operation = Console.ReadLine().Split(' ').ToArray();

                if (operation[0] == "add")
                {
                    int index = int.Parse(operation[1]);
                    int element = int.Parse(operation[2]);
                    AddElement(index, element, currentList);                                               
                }
                else if (operation[0] == "contains")
                {
                    int element = int.Parse(operation[1]);
                    Console.WriteLine(ConstainElement(element, currentList));                    
                }
                else if (operation[0] == "remove")
                {
                    int index = int.Parse(operation[1]);
                    RemoveElement(index, currentList);                    
                }
                else if (operation[0] == "addMany")
                {
                    int index = int.Parse(operation[1]);
                    var element = new List<int>();

                    if (index > currentList.Count)
                    {
                        Print(currentList);
                        break;
                    }
                    else
                    {
                        for (int j = 2; j < operation.Length; j++)
                        {
                            element.Add(int.Parse(operation[j]));
                        }
                        AddMany(index, element, currentList);
                    }                      
                }
                else if (operation[0] == "shift")
                {
                    int position = int.Parse(operation[1]);
                    ShiftElements(position, currentList);                    
                }
                else if (operation[0] == "sumPairs")
                {
                    SumPairs(currentList);                    
                }
                else if (operation[0] == "print")
                {
                    Print(currentList);
                    break;                
                }
            }          
        }

        //add - adds element at the specified index
        public static List<int> AddElement(int index, int element, List<int> currentList)
        {
            currentList.Insert(index, element);             
            return currentList;
        }

        //addMany - adds a set of elements at the specified index.
        public static List<int> AddMany(int index, List<int>element, List<int> currentList)
        {
            currentList.InsertRange(index, element);            
            return currentList;
        }

        //contains<element> – prints the index of the first occurrence of the specified element(if exists) in the array or -1 if the element is not found.
        public static int ConstainElement(int element, List<int> currentList)
        {
            int index = -1;
            if (currentList.Contains(element))
            {
                for (int i = 0; i < currentList.Count; i++)
                {
                    if (currentList[i] == element)
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }
        //remove<index> – removes the element at the specified index.
        public static List<int> RemoveElement(int index, List<int> currentList)
        {
            currentList.RemoveAt(index);
            return currentList;
        }

        //shift<positions> – shifts every element of the array the number of positions to the left (with rotation)
        public static List<int> ShiftElements(int position, List<int> currentList)
        {
            position = position % currentList.Count;
                var endList = new List<int>();
                for (int i = 0; i < position; i++)
                {
                    endList.Add(currentList[i]);
                }
                currentList.RemoveRange(0, position);
                currentList.AddRange(endList);                
                return currentList;                     
        }

        //sumPairs – sums the elements in the array by pairs(first + second, third + fourth, …).
        public static List<int> SumPairs(List<int> currentList)
        {
            var sumPair = new List<int>();
            if (currentList.Count%2 !=0)
            {
                currentList.Add(0);
            }
            for (int i = 0; i < currentList.Count-1; i+=2)
            {
                sumPair.Add(currentList[i]+ currentList[i+1]);
            }
            currentList.Clear();
            currentList.AddRange(sumPair);
            return currentList;
        }

        //print – stop receiving more commands and print the last state of the array
        public static void Print(List<int> currentList)
        {
            Console.WriteLine($"[{string.Join(", ", currentList)}]");            
        }
    }
}