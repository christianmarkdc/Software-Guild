using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummativeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1, sum2, sum3;
            int[] array1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] array2 = { 999, -60, -77, 14, 160, 301 };
            int[] array3 = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130,
                            140, 150, 160, 170, 180, 190, 200, -99 };

            sum1 = arraySum(array1);
            sum2 = arraySum(array2);
            sum3 = arraySum(array3);
            Console.WriteLine(
                $"#1 Array Sum: {sum1}\n" +
                $"#2 Array Sum: {sum2}\n" +
                $"#3 Array Sum: {sum3}");
            Console.ReadLine();

        }

        static int arraySum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
