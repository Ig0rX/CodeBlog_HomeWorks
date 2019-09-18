using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson14_Exception
{
    interface IDatabase
    {
        bool Connect();
        bool VerifyLoggin(string login);
        bool VerifyPassword(string password);
    }
}
