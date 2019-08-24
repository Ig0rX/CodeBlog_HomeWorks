using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите числа через запятую: ");
            string input = Console.ReadLine();

            var numbers = input.Split(',').Select(x=>int.Parse(x)).ToArray();
            var minNumber = numbers.Min();

            Console.WriteLine($"Меньшее число: {minNumber}") ;

            switch(minNumber)
            {
                case int i when i % 2 == 0: Console.WriteLine($"Число {minNumber} чётное"); break;
                case int i when i % 2 != 0: Console.WriteLine($"Число {minNumber} нечётное"); break;
            }

        }
    }
}
