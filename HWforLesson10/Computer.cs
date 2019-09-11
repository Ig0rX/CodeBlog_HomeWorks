using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson10
{
    class Computer : Product
    {
        public string Devices { get; set; }

        public Computer(string devices, string name, string manufacturer, double price = 0) 
        {
            Devices = devices;
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override void Inform()
        {
           Console.WriteLine($"Компьютер {Name}, {Devices} - стоит {Price:c}");
        }
    }
}
