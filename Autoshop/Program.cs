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
            
                autoshops.Add(new Autoshop($"Идентификатор: {"ММ 0000 55"}\nМарка: {"УАЗ"}\nМаксимальная скорость: {120}\nСкидка: {30}"));
        
        }
    }
}
