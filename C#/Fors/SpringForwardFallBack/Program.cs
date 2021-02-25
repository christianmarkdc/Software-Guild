using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringForwardFallBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's spring!");
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\nOh no, it's fall....");
            for (int i = 10; i> 0; i--)
            {
                Console.Write(i + ", ");
            }
            Console.ReadLine();
        }
    }
}
