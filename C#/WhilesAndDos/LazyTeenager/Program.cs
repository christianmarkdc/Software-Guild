using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyTeenager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int teenager = 1;
            int times = 0;
            int clean;
            do
            {
                Console.WriteLine("Clean your room !!");
                clean = randomizer.Next(10)+1;
                if(teenager >= clean)
                {
                    Console.WriteLine("OK I WILL CLEAN MY ROOM");
                    break;
                }
                teenager++;
                times++;
            } while (times < 7);
            if( times >= 7)
            {
                Console.WriteLine("IM TAKING YOUR SHIT AND YOU ARE GOING TO DIE");
            }
            Console.ReadLine();
        }
    }
}
