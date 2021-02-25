using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingTheTuringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, color, food;
            int number;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + " My name is Wilson");
            Console.WriteLine("What is your favorite color");
            color = Console.ReadLine();

            Console.WriteLine("Interesting, " + color + ". Mine is Purple with green in it");
            Console.WriteLine("What is your favorite food");
            food = Console.ReadLine();
            
            Console.WriteLine("WOW so," + food + " is your favorite  food. Personally I like fish");
            Console.WriteLine("What is your favorite number");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So your favorite number is " + number + ". WOw. Mine is 72");
            Console.WriteLine("GOOD BYE");
            Console.ReadLine();
        }
    }
}
