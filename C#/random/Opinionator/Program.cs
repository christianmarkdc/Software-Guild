using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opinionator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            Console.WriteLine("I can't decide what animal I like the best.");
            Console.WriteLine("I know! Random can decide FOR ME!");

            int x = randomizer.Next(5);

            Console.WriteLine("The number we chose was : " + x);

            switch (x)
            {
                case 0:
                    Console.WriteLine("llamas are the best!");
                    break;
                case 1:
                    Console.WriteLine("Dodos are the best");
                    break;
                case 2:
                    Console.WriteLine("Wooly mammoths are DEFINITELY the best!");
                    break;
                case 3:
                    Console.WriteLine("Sharks are the greatest! They even have their own week!");
                    break;
                case 4:
                    Console.WriteLine("Cockatoos are just so awesome!");
                    break;
                case 5:
                    Console.WriteLine("have you ever met a naked mole-rat. They're GREAT!");
                    break;
            }
            Console.WriteLine("Thanks Random, maybe YOU'RE the best!");
            Console.ReadLine();
        }
    }
}
