using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeItLovesMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomPetal = new Random();
            int pedals = randomPetal.Next(100)+1;

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
