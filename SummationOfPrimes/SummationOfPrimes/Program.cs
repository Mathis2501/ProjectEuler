using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        public void Run()
        {
            bool[] name = new bool[100-1];

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = true;
                
            }
            
            bool running = true;
            int p = 2;
            while (running)
            {
                for (int i = p; i < name.Length; i+=p)
                {
                    name[i] = false;
                    
                }
                int tempP = p;
                for (int i = p; i < name.Length; i++)
                {
                    if (name[i] == true && p < i+2)
                    {
                        p = i+2;
                    }
                }
                if (tempP == p)
                {
                    running = false;
                }
                
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == true)
                {
                    Console.WriteLine(i+2);
                }

            }
            Console.Read();
            
        }
    }
}
