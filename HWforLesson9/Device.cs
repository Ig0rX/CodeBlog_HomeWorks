using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson9
{
    public abstract class Device
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public string PartNumber { get; set; }
        public abstract bool HasNetInterface { get; }

    }
}
