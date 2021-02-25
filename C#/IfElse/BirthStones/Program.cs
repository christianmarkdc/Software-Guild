using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;

            Console.WriteLine("What month's birthstone do you want to know");
            month = Convert.ToInt32(Console.ReadLine());

            if (month == 1)
            {
                Console.WriteLine("January's birthstone is Garnet.");
            }
            else if (month == 2)
            {
                Console.WriteLine("February's birthstone is Amethyst");
            }
            else if(month == 3)
            {
                Console.WriteLine("March's birthstone is Aquamarine");
            }
            else if(month == 4)
            {
                Console.WriteLine("April is Diamond");
            }
            else if (month == 5)
            {
                Console.WriteLine("May's birthstone is Emerald");
            }
            else if (month == 6)
            {
                Console.WriteLine("June's brithstone is Pearl");
            }
            else if (month == 7)
            {
                Console.WriteLine("July's birthstone is Ruby");
            }
            else if (month == 8)
            {
                Console.WriteLine("August's birthstone is Peridot");
            }
            else if (month == 9)
            {
                Console.WriteLine("September's birthstone is Sapphire");
            }
            else if (month == 10)
            {
                Console.WriteLine("October's birthstone is Opal");
            }
            else if (month == 11)
            {
                Console.WriteLine("Novemeber's birthstone is Topaz");
            }
            else if (month == 12)
            {
                Console.WriteLine("December's birthstone is Turquoise");
            }
            else
            {
                Console.WriteLine("What are you doing!!!! Write a number that corresponds to a month");
            }
            Console.ReadLine();
        }
    }
}
