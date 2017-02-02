using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex05Tue_Threads
{
    class Program
    {
        private static int _currentTemp = 0;
        internal static int _alarmTimesTriggered = 0;

        private static  Random _random = new Random(); 

        static void Main(string[] args)
        {
            bool threadAlive = true;

            Thread checkTempThread = new Thread(CheckTemp);
            Thread generateTempThread = new Thread(RndTemp);

            checkTempThread.Start();
            generateTempThread.Start();

            while (threadAlive)
            {
                if (!checkTempThread.IsAlive)
                {
                    threadAlive = false;
                    Console.WriteLine("Alarm-Wire terminated");
                    Thread.Sleep(1000);
                }
            }

            checkTempThread.Abort();
            generateTempThread.Abort();
        }

        private static void RndTemp()
        {
            while (true)
            {
                _currentTemp = _random.Next(141) - 20;
                Thread.Sleep(2000);
            }
        }

        static void CheckTemp()
        {
            while (true)
            {
                if (_currentTemp < 0 || _currentTemp > 100)
                {
                    Console.WriteLine("Alarm triggered temperature outside of safe range\nCurrent Temp: " + _currentTemp);
                    _alarmTimesTriggered++;
                    if (_alarmTimesTriggered == 3)
                    {
                        Thread.CurrentThread.Abort();
                    }
                }
                else
                {
                    Console.WriteLine("Current Temp: " + _currentTemp);
                }
                Thread.Sleep(2000);
            }
        }
    }
}
