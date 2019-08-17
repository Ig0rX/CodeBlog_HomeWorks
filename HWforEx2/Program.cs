using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HWforLesson2
{
    class Program
    {
        delegate void ShowMsg(string text);

        static void Main(string[] args)
        {
            string txt1 = "Wake up, Neo...";
            string txt2 = "The Matrix has you...";
            string txt3 = "Follow the white Rabbit.";
            string txt4 = "Knock, knock, Neo.";

            NeoConsole neoConsole = new NeoConsole(500, ConsoleColor.Green);
            Action<string, bool> show = new Action<string, bool>(neoConsole.Show);

            show(txt1, false);
            show(txt2, false);
            show(txt3, false);
            show(txt4, true);
        }
    }

    class NeoConsole
    {
        private readonly int textDelay;
        private readonly ConsoleColor consoleColor;

        public NeoConsole(int textDelay, ConsoleColor consoleColor)
        {
            this.textDelay = textDelay;
            this.consoleColor = consoleColor;
        }


        public void Show(string text, bool showimmediately)
        {
            Console.ForegroundColor = consoleColor;

            if (showimmediately)
            {
                Console.Write(text);
            }
            else
            foreach (var item in text)
            {
                System.Threading.Thread.Sleep(textDelay);
                Console.Write(item);
                
            }
            System.Threading.Thread.Sleep(textDelay*10);
            Console.Clear();
        }
    }
}
