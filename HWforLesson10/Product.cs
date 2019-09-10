using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson10
{
    abstract class Product
    {
        //protected Product(string name, string manufacturer, double price)
        //{
        //    Name = name;
        //    Manufacturer = manufacturer;
        //    Price = price;
        //}

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        public double GetDiscontPrice => Price - Price * 0.1;

        public abstract void Inform();
    }
}
