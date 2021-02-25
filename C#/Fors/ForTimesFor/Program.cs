using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTimesFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, guess, sum;
            int points = 0;

            Console.WriteLine("Which times table shall I recite?");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<=15; i++)
            {
                sum = i * num;
                Console.WriteLine(i + " * " + num + " is: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if(guess == sum)
                {
                    Console.WriteLine("Correct!");
                    points++;
                }
                else
                {
                    Console.WriteLine("No, the answer is : " + sum);
                }
            }
            Console.WriteLine("You got " + points + " correct");
            Console.ReadLine();
        }
    }
}
