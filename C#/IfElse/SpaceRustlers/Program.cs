using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRustlers
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaceships = 10;
            int aliens = 25;
            int cows = 100;
            
            if(aliens >= spaceships)
            {
                Console.WriteLine("VRoom, vromm! Let's getgoing!");
            }
            else
            {
                Console.WriteLine("There aren't enought green guys to drive these ships!");
            }
            if (cows == spaceships)
            {
                Console.WriteLine("Wow, way to plan ahead! JUST enough room for all these wlaking hamburgers!");
            }
            else
            {
                Console.WriteLine("Too many ships! Not enough cows.");
            }
            if(aliens > cows)
            {
                Console.WriteLine("Hurrah, we've got the grub! Hamburger party on ALphaCentauri!");
            }
            else if(aliens < cows)
            {
                Console.WriteLine("Oh, no! The herds got restless and took over! Looks like we're huamburger now!!");
            }
            else
            {
                Console.WriteLine("We have just enogut hfor a small hamburger gathering!");
            }
            Console.ReadLine();
        }
    }
}
