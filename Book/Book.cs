using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book : IComparable<Book>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Book() { }
        public Book(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public int CompareTo(Book obj)
        {
            return Name.CompareTo(obj.Name);
        }
    }
}
