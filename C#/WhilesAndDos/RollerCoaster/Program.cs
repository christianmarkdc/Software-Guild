﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We're going to go on a roller coaster..");
            Console.WriteLine("Let me know when you want to get off!");

            String keepRiding = "y";
            int loopsLooped = 0;
            while (keepRiding.Equals("y"))
            {
                Console.Write("WHEEEEEEEEeEEEeEeEE.......!!!!");
                Console.Write("Want to keep going? (y/n):");
                keepRiding = Console.ReadLine();
                loopsLooped++;
            }
            Console.WriteLine("Wow, that was FUN!");
            Console.WriteLine("We looped that loop " + loopsLooped + " times!!");
            Console.ReadLine();
        }
    }
}
