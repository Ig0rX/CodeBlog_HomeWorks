using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson14_Exception
{
    class Database : IDatabase
    {
        Random rnd = new Random();

        private bool RandomResult()
        {
            var result = rnd.Next(0, 2);
            if (result == 0) return false;
            else return true;
        }

        public bool Connect()
        {
            if (!RandomResult()) throw new DBConnectException("Не удалось подключиться к БД");
            return true;
        }

        public bool VerifyLoggin(string login)
        {
            if (!RandomResult()) throw new LoginCheckException("Не верный логин");
            return true;
        }

        public bool VerifyPassword(string password)
        {
            if (!RandomResult()) throw new PasswordCheckException("Не верный пароль");
            return true;
        }
    }
}
