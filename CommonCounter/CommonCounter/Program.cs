using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonCounter
{
    class Program
    {
        private static int _commonCounter;
        private static Object _locker = new Object();
        private static bool _switch = true;

        static void Main(string[] args)
        {
            Thread GatesThread = new Thread(Gates);
            Thread AsterisksThread = new Thread(Asterisks);

            GatesThread.Start();
            AsterisksThread.Start();
        }

        private static void Gates()
        {
            while (true)
            {
                Printer('#');
            }
        }

        private static void Asterisks()
        {
            while (true)
            {
                Printer('*');
            }
        }

        private static void Printer(char c)
        {
            Monitor.Enter(_locker);
           
            for (int i = 0; i < 60; i++)
            {
                Console.Write(c);
                _commonCounter++;
                Thread.Sleep(10);
            }
            Console.Write(" " + _commonCounter + "\n");
            Monitor.Exit(_locker);
            
        }
    }
}
