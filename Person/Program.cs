using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persone = new List<Person>();
            
                persone.Add(new Person("Серафима", 17));
                persone.Add(new Person("Анна", 28));
                persone.Add(new Person("Тимофей", 11));

            foreach (Person elem in persone)
            {
                Console.WriteLine($"{elem.Name} {elem.Age}");
            }
            persone.Sort();
            foreach (Person elem in persone)
            {
                Console.WriteLine($"{elem.Name} {elem.Age}");
            }
            Console.ReadKey();
        }
    }
}
