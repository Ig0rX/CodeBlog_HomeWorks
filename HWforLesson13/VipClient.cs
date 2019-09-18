using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson13
{
    class VipClient : IClientAccount
    {


        public int CurrentSum => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetIncome()
        {
            throw new NotImplementedException();
        }

        public void Put(int sum)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int sum)
        {
            throw new NotImplementedException();
        }
    }
}
