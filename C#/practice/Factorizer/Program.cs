using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 0;
            Console.WriteLine("What number would you like to factor? ");
            num = Convert.ToInt32(Console.ReadLine());
            Factor(num,count);
            
            CheckPerfect(num);
            CheckPrime(num);
            Console.ReadLine();
        }

        static void CheckPerfect(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if(n%i == 0)
                {
                    sum += i;

                }
            }
            if(sum == n)
            {
                Console.WriteLine(n + " is a Perfect number");
            }
            else
            {
                Console.WriteLine(n + " is not a Perfect Number");
            }
        }

        static void CheckPrime(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if(n % i ==0 && n != i)
                {
                    Console.WriteLine(n + " is not a Prime Number");
                    return;
                }
            }
            Console.WriteLine(n + " is a Prime Number");
        }
        static void Factor(int n,int count)
        {

            for (int i = 1; i <= n; i++)
            {

                if(n % i == 0)
                {
                    count++;
                    Console.Write(i + " ");
                    
                }
            }
            Console.WriteLine("\n" +n + " has " + count + " factors");
        }
    }
}
