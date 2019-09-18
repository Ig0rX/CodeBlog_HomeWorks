using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount client = new Client("Tom", 3000);
            client.Put(500);
            Console.WriteLine(client.CurrentSum);
            client.Withdraw(600);
            Console.WriteLine(client.CurrentSum);

            string name = (client as IClient)?.Name;

        }
    }
}
