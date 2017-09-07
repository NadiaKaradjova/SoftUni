using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9_Book_Library
{
    public class task9_Book_Library
    {
        public static void Main()
        {
            //int n = int.Parse(Console.ReadLine());

            var input = File.ReadLines("input.txt");

            var books = new List<Book>();

            foreach (var item in input)
            
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


            var authors = books.Select(a => a.Author).Distinct().ToList();

            var authorSales = new Dictionary<string, double>();

            foreach (var item in authors)
            {
                var sales = books.Where(a => a.Author == item).Sum(x => x.Price);
                authorSales.Add(item, sales);
            }
            authorSales = authorSales.OrderByDescending(a => a.Value).ThenBy(b => b.Key).ToDictionary(x=>x.Key, y=>y.Value);
            if (File.Exists("output.txt"))
            {
                File.Delete("output.txt");
            }

            foreach (var item in authorSales)
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value:f2}{Environment.NewLine}");
               
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

