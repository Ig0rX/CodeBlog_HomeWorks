using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson13
{
    class Client : IAccount, IClient
    {
        private int _sum;       

        public int CurrentSum => _sum;

        public string Name { get; set; }

        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (_sum >= sum) _sum -= sum;
        }
    }
}
