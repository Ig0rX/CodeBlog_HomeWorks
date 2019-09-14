using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Car<Benzin> car = new Car<Benzin>
            {
                Name = "Lada",
                CurrFuelLevel = 10,
                MaxSpeed = 150,
                MaxFuelVolume = 50,
                Engine = new Engine<Benzin>
                {
                    Fuel = new Benzin(),
                    Power = 100,
                    Volume = 1600

                }
            };

           var result = car.AddFuel(new Benzin(), 10);
            Console.WriteLine(result);
            var result2 = car.AddFuel(new Benzin(), 40);
            Console.WriteLine(result2);
            

        }
    }
}
