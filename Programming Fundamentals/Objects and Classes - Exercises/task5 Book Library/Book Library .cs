using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace task5_Book_Library
{
    public class task5_Book_Library
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var library = new Library() { Name = "Prosveta", Books = new List<Book>() };

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var book = new Book()
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InstalledUICulture),
                    Isbn = input[4],
                    Price = double.Parse(input[5])                    
                };

                library.Books.Add(book);
            }
            
            var authors = library.Books.Select(a => a.Author).Distinct().ToArray();

           var authorSales = new Dictionary<string, double>();

            foreach (var item in authors)
            {
                var sales = library.Books.Where(a => a.Author == item).Sum(y => y.Price);
                authorSales[item] = sales;               
            }

            authorSales = authorSales.OrderByDescending(a => a.Value).ThenBy(y => y.Key).ToDictionary(x => x.Key, z => z.Value);
            
            foreach (var item in authorSales)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }

   
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
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
