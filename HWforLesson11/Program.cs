using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple redApple = new Apple("Красное яблоко", 52);
            redApple.Weight = 120;
            Apple greenApple = new Apple("Зеленное яблоко", 42);
            greenApple.Weight = 95;

            Product product = redApple;
            Console.WriteLine(product);

            //TODO: реализовать операции +, - и т.д.
        }
    }
}
