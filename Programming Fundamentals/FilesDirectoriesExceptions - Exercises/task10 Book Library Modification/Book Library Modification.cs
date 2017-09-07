using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9_Book_Library
{
    public class task9_Book_Library_Modification
    {
        public static void Main()
        {
            var input = File.ReadAllLines("input.txt");

            var newInput = new string[input.Length-2];
                      

            for (int i = 1; i < input.Length-1; i++)
            {
                newInput[i-1] = input[i];
            }
                        
            var books = new List<Book>();
            
            foreach (var item in newInput)           
            {
                var line = item.Split().ToArray();

                var newBook = new Book();

                newBook.Title = line[0];
                newBook.Author = line[1];
                newBook.Publisher = line[2];
                newBook.ReleaseDate = DateTime.ParseExact(line[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                newBook.Isbn = line[4];
                newBook.Price = double.Parse(line[5]);

                books.Add(newBook);
            }

            var dateCheck = DateTime.ParseExact(input[input.Length-1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var sortedBook = books.Where(a => a.ReleaseDate > dateCheck).ToList();

            if (File.Exists("output.txt"))
            {
                File.Delete("output.txt");
            }

            foreach (var item in sortedBook.OrderBy(a => a.ReleaseDate).ThenBy(b => b.Title))
            {
                File.AppendAllText("output.txt", $"{item.Title} -> {item.ReleaseDate:dd.MM.yyyy}{Environment.NewLine}");
            }
        }


        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string Isbn { get; set; }
            public double Price { get; set; }
        }
    }
}

