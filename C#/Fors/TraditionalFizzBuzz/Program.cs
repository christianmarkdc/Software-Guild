using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraditionalFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizzBuzz;
            int count = 0;

            Console.WriteLine("How many units of fizzing and buzzing do you need in your life?");
            fizzBuzz = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    count++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    count++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    count++;
                }
                else
                {
                    Console.WriteLine(i);
                }
                if(count == fizzBuzz)
                {
                    break;
                }
            }

            Console.WriteLine("TRADITION");
            Console.ReadLine();
        }
    }
}
