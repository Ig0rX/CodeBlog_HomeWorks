using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson14_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = ShowExcMessage;

            IDatabase db = new Database();
            try
            {
                action("Подключение к БД...");
                db.Connect();
                action("Проверка логина...");
                db.VerifyLoggin("Login");
                action("Проверка пароля...");
                db.VerifyPassword("Password");
            }
            catch (DBConnectException ex)
            {
                action(ex.Message);
            }
            catch (LoginCheckException ex)
            {
                action(ex.Message);
            }
            catch (PasswordCheckException ex)
            {
                action(ex.Message);
            }
            finally
            {
                Console.WriteLine("Закрытие БД");
            }
        
        }

        private static void ShowExcMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
