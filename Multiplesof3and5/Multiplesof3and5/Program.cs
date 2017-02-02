using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplesof3and5
{
    class Program
    {
        private static List<int> _nrToRemove = new List<int>();
        static List<int> _intList = new List<int>();
        private static int output = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    output += i;
                }
            }
            
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
