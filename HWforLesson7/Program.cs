using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbs = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                int value = random.Next(0, 99);
                numbs.Add(value);
            }


            string input;
            do
            {

                Console.Write("Введите числа (Exit или E для прекращение: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    numbs.Add(result);
                }
                else if(input != "exit" | input != "e")
                {
                    Console.WriteLine("Введите только числа или Exit/'E' для выхода");
                }
            }
            while (input != "exit" & input != "e") ;

            Console.Write($"Доступны следующие числа: ");
            StringBuilder sb = new StringBuilder();
            foreach (var item in numbs)
            {
                Console.Write(item  +", ");
                sb.Append(item.ToString() + ", ");
            }
            sb.Remove(sb.Length - 2, 2);

            int sum = 0;
            int div = 0;
            long mult = 1;

            for (int i = 0; i < numbs.Count; i++)
            {
                sum += numbs[i];
            }

            int index = 0;
            while (++index < numbs.Count)
            {
                div -= numbs[index-1];
            }

            index = 1;
            do
            {
                mult *= numbs[index-1];

            }
            while (++index < numbs.Count);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {div}");
            Console.WriteLine($"Произведение: {mult}");


        }
    }
}
