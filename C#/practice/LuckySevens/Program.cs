using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    class Program
    {
        static void Main(string[] args)
        {
            int money, die1, die2;
            int maxMoney=0, bestRolls=0, totalRolls = 0;
            Random diceRoller = new Random();
            Console.WriteLine("Welcome to Lucky Seven's:\n" +
                "How many dollars do you have?");
            money = Convert.ToInt32(Console.ReadLine());

            while(money > 0)
            {
                die1 = diceRoller.Next(1, 6);
                die2 = diceRoller.Next(1, 6);
                if(die1 + die2 == 7)
                {
                    money += 4;
                    //Console.WriteLine("You won");
                }
                else
                {
                    money -= 1;
                   //Console.WriteLine("You Lost");
                }
               
                totalRolls++;
                 if(money >= maxMoney)
                {
                    maxMoney = money;
                    bestRolls = totalRolls;
                }
            }
            Console.WriteLine("You ended rolling " + totalRolls + " times");
            Console.WriteLine("you should have quit after " + bestRolls + " when you had $" + maxMoney);
            Console.ReadLine();
        }
    }
}
