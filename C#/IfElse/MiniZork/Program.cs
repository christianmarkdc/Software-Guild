﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniZork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are standing in an open field west of a white house,");
            Console.WriteLine("WIth a boarded front door.");
            Console.WriteLine("There is a small mailbox here.");
            Console.Write("Go to the house, or open the mailbox? ");

            String action = Console.ReadLine();

            if (action.Equals("open the mailbox"))
            {
                Console.WriteLine("You open the mailbox.");
                Console.WriteLine("It's really dark in there.");
                Console.WriteLine("Look inside or stick your hand in? ");
                action = Console.ReadLine();

                if (action.Equals("look inside"))
                {
                    Console.WriteLine("You peer inside the mailbox.");
                    Console.WriteLine("It's really very dark. So... so very dark.");
                    Console.Write("Run away or Keep looking? ");
                    action = Console.ReadLine();

                    if (action.Equals("keep looking"))
                    {
                        Console.WriteLine("Turns out, handing out around dark places isn't a good idea.");
                        Console.WriteLine("You've been eaten by a grue.");
                    }
                    else if (action.Equals("run away"))
                    {
                        Console.WriteLine("You run away screaming across the fields - looking very foolish.");
                        Console.WriteLine("But you're alive. Possibly a wise choice");
                    }
                }
                else if (action.Equals("stick your hand in"))
                {

                }
            }
            else if (action.Equals("go to the house")) { }
            Console.ReadLine();
        }
    }
}
