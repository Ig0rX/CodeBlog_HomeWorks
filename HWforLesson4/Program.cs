using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int i2 = 1000;

            byte b = (byte)i;
            byte b2 = (byte)i2;

            long l = i;
            
            Console.WriteLine($"i = {i}, b = {b}; i2 = {i2}, b2 = {b2}");

            float f = 1.5f;
            double d = f;

            Console.WriteLine($"f = {f}, d = {f}");



        }
    }
}
