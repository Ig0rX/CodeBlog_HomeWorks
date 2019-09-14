using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson12
{
    class Car<T> where T : Fuel
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxFuelVolume { get; set; }
        public int CurrFuelLevel { get; set; }

        public Engine<T> Engine { get; set; }

        public string AddFuel(Fuel fuel, int volume)
        {
            if (!(fuel is T f))
            {
                return "Wrong Fuel";
            }

            if (CurrFuelLevel + volume > MaxFuelVolume)
            {
                return "Fuel is already max";
            }
        
            CurrFuelLevel += volume;
            return "OK";
        }
    }
}
