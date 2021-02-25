using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName;
            Random DNA = new Random();
            int breed1, breed2, breed3, breed4, breed5, total;
            Console.WriteLine("What is your dog's name");
            //check if total goes out of bounds
            //probably put a method here that you can use 
            //so you can call the method 
            //yeah
            dogName = Console.ReadLine();
            breed1 = DNA.Next(0, 100);
            total = 100 - breed1;
            breed2 = DNA.Next(0, total);
            total -= breed2;
            breed3 = DNA.Next(0, total);
            total -= breed3;
            breed4 = DNA.Next(0, total);
            total -= breed4;
            breed5 = total;

            Console.WriteLine(dogName + " is:");
            Console.WriteLine(breed1 + "% St.Bernard");
            Console.WriteLine(breed2 + "% Chihuahua");
            Console.WriteLine(breed3 + "% Dramatic RedNosed Asian Pug");
            Console.WriteLine(breed4 + "% Common Cur");
            Console.WriteLine(breed5 + "% King Doberman");

            Console.WriteLine("That's QUITE the dog!");
            Console.ReadLine();

        }
    }
}
