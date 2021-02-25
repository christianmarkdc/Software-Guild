using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeNow = 5;
            int bedTime = 11;
            
            while(timeNow < bedTime)
            {
                Console.WriteLine("it's only " + timeNow + " o'clock!");
                Console.WriteLine("I think I'll stay up just a littler longer...");
                timeNow++; //Time passes
            }
            Console.WriteLine("Oh. It's " + timeNow + "o'clock");
            Console.WriteLine("Guess I should go to the d...");
            Console.ReadLine();
        }
    }
}
