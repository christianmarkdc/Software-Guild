using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int theAnswer;
            int playerGuess;
            string playerInput;
            int guessCount = 0;
            char choice;
            int maxNum = 0;
            Random r = new Random();
            


            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine(
                "a. Easy mode 1-5\n" +
                "b. Normal mode 1-20\n" +
                "c. Hard mode 1-50");
            choice = Convert.ToChar(Console.ReadLine());

            switch(choice){
                case 'a':
                    maxNum = 5;
                    break;
                case 'b':
                    maxNum = 20;
                    break;
                case 'c':
                    maxNum = 50;
                    break;

            }
            theAnswer = r.Next(1, maxNum +1);
            Console.WriteLine($"{name}, You can quit at any point typing q");
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                // get player input
                Console.Write($"Enter your guess,{name} (1-{maxNum}): ");
                playerInput = Console.ReadLine();

                if (playerInput.Contains('q'))
                {
                    return;
                }


                //attempt to convert the string to a number
                if (int.TryParse(playerInput, out playerGuess))
                {

                    if (playerGuess <= maxNum && playerGuess >= 0)
                    {
                        guessCount++;
                        if (playerGuess == theAnswer)
                        {
                            Console.WriteLine($"{theAnswer} was the number, {name}.  You Win!");
                            break;
                        }
                        else
                        {
                            if (playerGuess > theAnswer)
                            {
                                Console.WriteLine($"{name}, Your guess was too High!");
                            }
                            else
                            {
                                Console.WriteLine($"{name}, Your guess was too low!");
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine($"{name}, that number wasn't in range!",Console.ForegroundColor);
                    }
                }


            } while (true);
            Console.ForegroundColor = ConsoleColor.Green;
            if (guessCount == 1){
                Console.WriteLine($"{name}, You got it first try. GOOD JOB");
                Console.WriteLine($"{name}, Press any key to quit.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{name}, it took you {guessCount} times to guess correctly");
                Console.WriteLine($"{name}, Press any key to quit.");
                Console.ReadKey();
            }


        }
    }
}
