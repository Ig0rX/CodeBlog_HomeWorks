using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson13
{
    interface IClientAccount : IAccount, IClient
    {
        void GetIncome();
    }
}
