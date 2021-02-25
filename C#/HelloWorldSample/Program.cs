using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Testing");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i + " Times");
            }
            Console.WriteLine("My Name is Christian");
            Console.ReadLine();
        }
    }
}
