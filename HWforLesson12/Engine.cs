using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson12
{
    class Engine<T> where T : Fuel 
    {
        public T Fuel { get; set; }
        public int Power { get; set; }
        public int Volume { get; set; }
    }
}
