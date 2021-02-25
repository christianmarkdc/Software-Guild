using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLifeInMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int year;

            Console.WriteLine("Hello, I am the bot to make you feel old, \n What is your name");
            name = Console.ReadLine();

            Console.WriteLine("Ok, "+ name + ". What year were you born?");
            year = Convert.ToInt32(Console.ReadLine());

            if(year < 2005)
            {
                Console.WriteLine("Pixar's \'Up\' came out over a decade ago");
            }
            if(year < 1995)
            {
                Console.WriteLine("The first Harry Potter came out sover 15 years ago");
            }
            if(year < 1985)
            {
                Console.WriteLine("Space Jam came out not last decade, but the one before that");
            }
            if(year < 1975)
            {
                Console.WriteLine("The Original Jurassic Park release is closer to the first lunar landing than today");
            }
            if(year < 1965)
            {
                Console.WriteLine("MASH TV has been around for almost half a century");
            }
            Console.WriteLine("Feel old yet?");
            Console.ReadLine();

        }
    }
}
