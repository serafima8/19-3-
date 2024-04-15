using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshop
{
    class Autoshop : IComparable<Autoshop>
    {
        public string ID { get; set; }
        public string Stamp { get; set; }
        public double Speed { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public Autoshop() { }
        public Autoshop(string id, string stamp, double speed, double price, double discount)
        {
            this.ID = id;
            this.Stamp = stamp;
            this.Speed = speed;
            this.Price = price;
            this.Discount = discount;
        }
        public int CompareTo(Autoshop obj)
        {
            return Price.CompareTo(obj.Price);
        }
    }
}
