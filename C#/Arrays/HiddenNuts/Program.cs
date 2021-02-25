using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenNuts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hidingSpots = new string[100];
            Random squirrel = new Random();
            hidingSpots[squirrel.Next(0, hidingSpots.Length)] = "Nut";
            Console.WriteLine("The nut has been hidden ...");

            for(int i = 0; i<hidingSpots.Length; i++)
            {
                if (hidingSpots[i] == "Nut")
                {
                    Console.WriteLine("Found it! It's in spot #" + i);
                }
            }
            Console.ReadLine();
        }
    }
}
