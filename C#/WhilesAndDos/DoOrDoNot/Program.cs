using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoOrDoNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Should I do it? (y/n) ");
            bool doIt;

            if (Console.ReadLine().Equals("y"))
            {
                doIt = true; //DO IT!
            }
            else
            {
                doIt = false; //DON'T YOU DARE!
            }
            bool iDidIt = false;

            do
            {
                iDidIt = true;
                break;
            } while (doIt);

            if(doIt && iDidIt)
            {
                Console.WriteLine("I did it!");
            }
            else if(!doIt && iDidIt)
            {
                Console.WriteLine("I know you said not to ... but I totally did anyways.");
            }
            else
            {
                Console.WriteLine("Don't look at me, I didn't do anything!");
            }
            Console.ReadLine();
        }
    }
}
