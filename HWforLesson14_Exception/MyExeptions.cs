using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson14_Exception
{
    class DBConnectException : Exception
    {
        public DBConnectException(string message) : base(message)
        {
        }
    }

    class LoginCheckException : Exception
    {
        public LoginCheckException(string message) : base(message)
        {
        }
    }

    class PasswordCheckException : Exception
    {
        public PasswordCheckException(string message) : base(message)
        {
        }
    }
}
