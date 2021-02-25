using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstHalf = { 3, 7, 9, 10, 16, 19, 20, 34, 35, 45, 47, 49 }; // 12 numbers
            int[] secondHalf = { 51, 54, 68, 71, 75, 78, 82, 84, 85, 89, 91, 100 }; // also 12!

            int[] wholeNumbers = new int[24];

            for(int i = 0; i<firstHalf.Length; i++)
            {
                wholeNumbers[i] = firstHalf[i];
                wholeNumbers[i + 12] = secondHalf[i];
            }

            Console.WriteLine("All together now!: ");
            for(int i = 0; i < wholeNumbers.Length; i++)
            {
                Console.Write(wholeNumbers[i]+ " ");
            }
            Console.ReadLine();
        }
    }
}
