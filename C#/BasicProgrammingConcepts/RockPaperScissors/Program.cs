using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            int round = 0;
            char choice = 'y';


            while (choice == 'y')
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors");
                Console.WriteLine("Enter the number of rounds you wish to play(1-10)");
                round = Convert.ToInt32(Console.ReadLine());
                if (round > 10 || round < 1)
                {
                    return;
                }
                RPSGame(round);
                Console.WriteLine("Do you want to play again? (y/n)");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();

        }
        static void RPSGame(int totalRounds)
        {
            Random computerAction = new Random();
            int userAction, randAction, win = 0, lose = 0, draw = 0, currentRound = 0;
            while (totalRounds != currentRound)
            {
                Console.WriteLine("Enter the number corresponding to the action\n" +
                "1:Rock\n" +
                "2:Paper\n" +
                "3:Scissors\n");
                userAction = Convert.ToInt32(Console.ReadLine());
                randAction = computerAction.Next(1, 3);
                if ((userAction == 1 && randAction == 3) || (userAction == 2 && randAction == 1) || (userAction == 3 && randAction == 2))
                {
                    Console.WriteLine("You won");
                    win++;
                    currentRound++;
                }
                else if ((userAction == 1 && randAction == 2) || (userAction == 2 && randAction == 3) || (userAction == 3 && randAction == 1))
                {
                    Console.WriteLine("You lost");
                    lose++;
                    currentRound++;
                }
                else if (userAction == randAction)
                {
                    Console.WriteLine("You drew");
                    draw++;
                    currentRound++;
                }
                else
                {
                    Console.WriteLine("Enter a current value.");
                }

            }
            if (win > lose)
            {
                Console.WriteLine("You have won. Great Job");

            }
            else if (win < lose)
            {
                Console.WriteLine("You have lose. Maybe next time");
            }
            else
            {
                Console.WriteLine("You drew. Too bad");
            }
            Console.WriteLine($"{win} wins, {lose} loses, {draw} draws");
        }
    }
}
