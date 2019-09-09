using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hi all";
            bool r = s.Equals("hi all", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine(r.ToString());

            Computer computer = new Computer();
            computer.IP = System.Net.IPAddress.Parse("192.168.0.1");
            computer.MACAddress = "00:00";
            computer.Name = "MegaComputer";

            Device device = computer;
            Device printer = new PrintUnit();
            Console.WriteLine(device.HasNetInterface);

            switch(printer)
            {
                case Computer c: Console.WriteLine("This is Computer"); break;
                case PrintUnit p: Console.WriteLine("This is Printer"); break;
                default: break;
            }

        }
    }
}
