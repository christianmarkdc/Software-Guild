using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun1, noun2, pNoun1, pNoun2, pNoun3, adjective1, adjective2, verb, pverb;
            int num;

            Console.WriteLine("Welcome to Mad Libs");
            Console.WriteLine("First, Give a Noun");
            noun1 = Console.ReadLine();

            Console.WriteLine("Now give an adjective");
            adjective1 = Console.ReadLine();

            Console.WriteLine("Give another noun");
            noun2 = Console.ReadLine();

            Console.WriteLine("Give a number");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give another Adjective");
            adjective2 = Console.ReadLine();

            Console.WriteLine("Give a plural noun");
            pNoun1 = Console.ReadLine();

            Console.WriteLine("Give another plural noun");
            pNoun2 = Console.ReadLine();

            Console.WriteLine("Another plural noun");
            pNoun3 = Console.ReadLine();

            Console.WriteLine("Now give a verb");
            verb = Console.ReadLine();

            Console.WriteLine("Give the past tense version of the verb you gave before");
            pverb = Console.ReadLine();

            Console.WriteLine("\n " + noun1 + ": the " + adjective1 + " frontier. There are the voyages of the starship " + noun2 + ". Its " + num
                + "-year mission: to explore strange " + adjective2 + " " + pNoun1 + ", to seek out " + adjective2 + " " + pNoun2 + "and " +
                adjective2 + " " + pNoun3 + ", to boldly " + verb + " where no one has " + pverb + " before.");
            Console.ReadLine();

        }
    }
}
