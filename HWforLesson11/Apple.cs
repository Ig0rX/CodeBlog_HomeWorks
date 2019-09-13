using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HWforLesson11
{
    class Apple : Product
    {
        public Apple(string name, int calorie) : base(name, calorie)
        {
        }

        public static Apple operator+ (Apple ap1, Apple ap2)
        {


            return new Apple("Tst", 26);
        }
    }
}
