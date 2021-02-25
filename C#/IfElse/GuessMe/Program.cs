using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMe
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            int num = 5;

            Console.WriteLine("Enter a number to guess the value");
            guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your guess is " + guess);

            if(guess == num)
            {
                Console.WriteLine("Wow, nice guess! That was it");
            }
            else if(guess < num)
            {
                Console.WriteLine("Ha, nice try - too low! I chose " + num);
            }
            else if(guess > num)
            {
                Console.WriteLine("Too bad, way too hight. I chose " + num);
            }

            Console.ReadLine();
        }
    }
}
