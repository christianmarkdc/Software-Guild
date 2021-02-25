using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayPositive
{
    class Program
    {
        static void Main(string[] args)
        {

            int countDown = 10;
            Console.WriteLine("Input a value to count down from");
            countDown = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Counting Down...");
            while(countDown >= 0)
            {
                Console.Write(countDown+" ");
                countDown--;
            }

            Console.WriteLine("Blast off!");
            Console.ReadLine();
        }
    }
}
