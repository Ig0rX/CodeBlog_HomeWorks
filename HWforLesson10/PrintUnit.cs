using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson10
{
     class PrintUnit : Product
    {
        public string PaperSize { get; set; }
        public bool HasADF { get; set; }

        public PrintUnit(string name, string manufacturer, string papersize, bool hasadf = false, double price = 0)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            PaperSize = papersize;
            HasADF = hasadf;
        }

        public override void Inform()
        {
            Console.WriteLine($"МФУ {Name}, размер бумаги {PaperSize}, стоит - {Price}");

        }
    }
}
