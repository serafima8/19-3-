using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autoshop> autoshops = new List<Autoshop>();
            
            autoshops.Add(new Autoshop { ID = "ММ 0000 55",Stamp = "УАЗ", Speed = 120, Price = 100000, Discount = 30});
            autoshops.Add(new Autoshop { ID = "ММ 0000 44",Stamp = "Toyota", Speed = 140, Price = 480000, Discount = 10});
            autoshops.Add(new Autoshop { ID = "ММ 0000 33",Stamp = "Tesla", Speed = 180, Price = 350000, Discount = 15});
            Console.WriteLine("Все автомобили: ");
            foreach(Autoshop elem in autoshops)
            {
                Console.WriteLine($"ID: {elem.ID}\tStamp: {elem.Stamp}\tSpeed: {elem.Speed}\tPrice: {elem.Price}\tDiscount: {elem.Discount}");
            }
            autoshops.Sort();
            Console.WriteLine("\nАвтомобили, отсортированные по цене: ");
            foreach(var elem in autoshops)
            {
                Console.WriteLine($"ID: {elem.ID}\tStamp: {elem.Stamp}\tSpeed: {elem.Speed}\tPrice: {elem.Price}\tDiscount: {elem.Discount}");
            }
            Console.ReadKey();
        }
    }
}
