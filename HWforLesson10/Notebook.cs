using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson10
{
    class Notebook : Product
    {
        public double ScreenSize { get; set; }
        public int BatterySize { get; set; }

        public Notebook(string name, string manufacturer,  double screensize, int batterysize, double price = 0)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            ScreenSize = screensize;
            BatterySize = batterysize;
        }

        public override void Inform()
        {
            Console.WriteLine($"Ноутбук {Name}, диагональ {ScreenSize}, батарея {BatterySize} стоит - {Price}");
        }
    }
}
