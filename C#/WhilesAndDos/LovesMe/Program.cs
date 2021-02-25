using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovesMe
{
    class Program
    {
        static void Main(string[] args)
        {

            int pedals = 34;
            int love = 1;

            Console.WriteLine("Well Here goes nothing");

            do
            {
                if (love == 1)
                {
                    
                    Console.WriteLine("It LOVES me!");
                    love--;
                }
                else if (love == 0)
                {
                   
                    Console.WriteLine("it loves me NOT!");
                    love++;
                }

                pedals--;
            } while (pedals > 0);
                if (love == 0)
            {
                Console.WriteLine("It REALLY LOVES me!");
            }
            else if (love == 1)
            {
                Console.WriteLine("I DONT DESERVE LOVE");
            }
            Console.ReadLine();
        }
    }
}
