using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Need to add the extra challenge ex:Monthly,daily,menu type
namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double principal, interestRate, years;
            int i = 1;
            int choice = 0;
            Console.WriteLine(
                "Welcome, Choose Which Program you want to use \n" +
                "1. Compound Yearly Interest\n" +
                "2. Compond Monthly Interest\n" +
                "3. Compound Daily Interest\n" +
                "4. Exit");
            choice = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How much do you want to invest? ");
            principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many years are you investing? ");
            years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the annual intest rate % growth? ");
            interestRate = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AnnualInterest(principal, years, interestRate, i);
                    break;
                case 2:
                    MonthlyInterest(principal, years, interestRate, i);
                    break;
                case 3:
                    DailyInterest(principal, years, interestRate, i);
                    break;
                case 4:
                    return;
            }
            Console.ReadLine();
        }

        static double interestCalculator(double money, double interest)
        {
            double earned = 0;
            earned = money * (interest / 100);
            Console.WriteLine($"Earned  {earned:C}");
            money = money * (1 + (interest / 100));
            Console.WriteLine($"Ended with {money:C}");
            return money;
        }
        static void AnnualInterest(double money, double year, double interest, int i)
        {

            if (i > year)
            {
                return;
            }
            else
            {
                Console.WriteLine("\nCalculating...");
                Console.WriteLine("Year " + i + ":");
                Console.WriteLine($"Began with {money:C}");
                money = interestCalculator(money, interest);
                i++;
                AnnualInterest(money, year, interest, i);
            }
        }
        static void MonthlyInterest(double money, double year, double interest, int i)
        {
            double month = year / 12;
            interest
            if (i > month)
            {
                return;
            }
            else
            {
                Console.WriteLine("\nCalculating...");

                Console.WriteLine("month" + i + ":");
                Console.WriteLine($"Began with {money:C}");
                money = interestCalculator(money, interest);
                i++;
                AnnualInterest(money, year, interest, i);
            }
        }
        static void DailyInterest(double money, double year, double interest, int i)
        {
            double month = year / 12;
            interest
            if (i > month)
            {
                return;
            }
            else
            {
                Console.WriteLine("\nCalculating...");

                Console.WriteLine("month" + i + ":");
                Console.WriteLine($"Began with {money:C}");
                money = interestCalculator(money, interest);
                i++;
                AnnualInterest(money, year, interest, i);
            }
        }
    }
}
