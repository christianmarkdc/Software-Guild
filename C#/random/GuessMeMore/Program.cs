using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMeMore
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int guess;
            int x = randomizer.Next(-100, 100);

            Console.WriteLine("Welcome to Guess the Number. Please enter in your guess");
            guess = Convert.ToInt32(Console.ReadLine());

            while(x != guess)
            {
                if (guess < x)
                {
                    Console.WriteLine("Too Low. Try again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if(guess > x)
                {
                    Console.WriteLine("Too high. Try again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("You did it Nice");
            Console.ReadLine();
        }
    }
}
