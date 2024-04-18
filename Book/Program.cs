using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { Name = "Алые паруса", Price = 210 });
            books.Add(new Book { Name = "Преступление и наказание", Price = 350 });
            books.Add(new Book { Name = "Доктор Живаго", Price = 135 });
            books.Add(new Book { Name = "Отцы и дети", Price = 300 });
            books.Add(new Book { Name = "Война и мир", Price = 400 });
            books.Sort();
            foreach (Book elem in books)
            {
                Console.WriteLine($"{elem.Name} {elem.Price}");
            }
            Console.ReadKey();
        }
    }
}
