using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson9
{
    public abstract class NetDevice : Device
    {
        public string MACAddress { get; set; }
        public IPAddress IP { get; set; }
        public override bool HasNetInterface => (IP != null && !string.IsNullOrEmpty(MACAddress));
    }
}
