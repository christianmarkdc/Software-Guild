using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Random diceRoller = new Random();

            int rollResult = diceRoller.Next(6) + 1;
            Console.WriteLine("TIME TO ROLL THE DICE!");
            Console.WriteLine("I rolled a " + rollResult + ".");

            if(rollResult == 1)
            {
                Console.WriteLine("You rolled a critical failure!");
            }
            Console.ReadLine();
        }
    }
}
