using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarelyControlledChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();  
            int colorChoice = randomizer.Next(1, 7);
            int animalChoice = randomizer.Next(1, 5);
            int ranInt = randomizer.Next(10, 99);
            string color = RandomColor(colorChoice);
            string animal = RandomAnimal(animalChoice);
            string colorAgain = RandomColor(colorChoice);
            int weight = randomizer.Next(5, 200);
            int distance = randomizer.Next(10, 20);
            int number = randomizer.Next(10000, 20000);
            int time = randomizer.Next(2, 6);

            Console.WriteLine("Once, when I was very small..");
            Console.WriteLine("I was chased by a " + color + ", " + weight + "lb" + " miniature " +
                animal + " for over " + distance + " miles!!");
            Console.WriteLine("I had to hide in a field of over " + number + " " + colorAgain +
                " poppies for nearly " + time + " hours until it left me alone!");
            Console.WriteLine("\nIt was QUITE the experience, let me tell you!");
            Console.ReadLine();
        }

        static string RandomColor(int x)
        {
            switch (x)
            {
                case 1:
                    return "purple";
                case 2:
                    return "green";
                   
                case 3:
                    return "blue";
                   
                case 4:
                    return "red";
                   
                case 5:
                    return "yellow";
                   
                case 6:
                    return "grey";
                    
                case 7:
                    return "orange";

            }
            return "null";
        }
        static string RandomAnimal(int x)
        {
            switch (x)
            {
                case 1:
                    return "turtle";
                case 2:
                    return "bird";
                case 3:
                    return "whale";
                case 4:
                    return "shark";
                case 5:
                    return "octopus";
            }
            return "null";
        }
    }
}
