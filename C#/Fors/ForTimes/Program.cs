using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Which times table shall I recite?");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i =1; i <=15; i++)
            {
                Console.WriteLine(i + " * " + num + " is: " + (num * i));
            }
            Console.ReadLine();
        }
    }
}
