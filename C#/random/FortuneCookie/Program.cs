using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            Console.WriteLine("Welcome, Welcome. Time to get your fortune told");

            int x = randomizer.Next(10);

            switch (x)
            {
                case 1:
                    Console.WriteLine("Keep falling out of your hobbies");
                    break;
                case 2:
                    Console.WriteLine("Stop trying");
                    break;
                case 3:
                    Console.WriteLine("Yearn for Gender Eqaulity");
                    break;
                case 4:
                    Console.WriteLine("Thats what a lady knight must do");
                    break;
                case 5:
                    Console.WriteLine("You life is in your hands");
                    break;
                case 6:
                    Console.WriteLine("Sleeping might be benefical");
                    break;
                case 7:
                    Console.WriteLine("Darkness blacker than black and darker than dark, I beseech thee, combine with my deep crimson.\n The time of awakening cometh.\n Justice, fallen upon the infallible boundary, appear now as an intangible distortions!\n Dance, dance, dance!\n I desire for my torrent of power a destructive force: a destructive force without equal!\n Return all creation to cinders, and come from the abyss!\n This is the mightiest means of attack known to man, the ultimate attack magic!");
                    break;
                case 8:
                    Console.WriteLine("Explosion!!!");
                    break;
                case 9:
                    Console.WriteLine("Try again");
                    break;
                case 10:
                    Console.WriteLine("Try harder");
                    break;

            }
            Console.WriteLine("Please do come again");
            Console.ReadLine();
        }
    }
}
