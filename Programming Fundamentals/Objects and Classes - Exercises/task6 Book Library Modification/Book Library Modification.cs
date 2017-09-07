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

            var library = new Library();
            library.Books = new List<Book>();

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
            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InstalledUICulture);
                        
            var titleDate = new Dictionary<string, DateTime>();

            foreach (var item in library.Books)
            {
                var title = item.Title;
                var dateReleased = item.ReleaseDate;

                if (!titleDate.ContainsKey(title))
                {
                    titleDate.Add(title, dateReleased);
                }

                else titleDate[title] = dateReleased;
            }
            
            foreach (var item in titleDate.OrderBy(x => x.Value).ThenBy(y => y.Key))
            {
                var currentDate = item.Value.Date;

                if (item.Value > date)
                {
                    Console.WriteLine($"{item.Key} -> {currentDate:dd.MM.yyyy}");
                }
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
