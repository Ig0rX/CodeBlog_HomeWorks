using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWforLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Целочисленные
            //Знаковые
            sbyte sb = -1;
            short sh = 100;
            int i = 1_000_000;
            long l = 1_000_000_000;
            //Без знаковые
            byte b = 100;
            ushort us= 1000;
            uint ui = 2_000_000;
            ulong ul = 2_000_000_000;
            #endregion
            #region Дробные
            float fl = 0.1F;
            double db = 0.1D;
            #endregion

            #region Логические
            bool bl1 = false;
            bool bl2 = true;
            #endregion

            #region Строковые
            char chr = 'A';
            string str = "Это строка";
            #endregion

            #region Специальные
            decimal dc = 0.0001M;
            #endregion
        }
    }
}
