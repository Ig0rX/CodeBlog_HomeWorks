using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "HP 6300 SFF";
            string manufacturer = "HP";
            string devices = "Intel Pentium";
            double price = 500.0;

            Product product1 = new Computer(devices, name, manufacturer, price);
            Product product2 = new Notebook("Acer M60", "Acer", 14.1, 3000, 1000);
            Product product3 = new PrintUnit("Xerox 3325", "Xerox", "A4", true, 350);

            List<Warehouse> warehouses = new List<Warehouse>
            {
                new Warehouse{ Product = product1, Amount = 10},
                new Warehouse{ Product = product2, Amount = 5},
                new Warehouse{ Product = product3, Amount = 3}
            };

            Console.WriteLine("На складе следующие позиции:");

            foreach ((Warehouse p, int index) in warehouses.Select((value, i) => (value, i+1)))
            {
                Console.WriteLine($"Позиция {index}");
                p.Product.Inform();
                Console.WriteLine($"Всего: {p.Amount}");
            }

            Console.WriteLine();


        }

    }
}
