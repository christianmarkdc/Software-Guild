using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            float age,maxHeartRate, minHRZone, maxHRZone;
            Console.WriteLine("What is your age? ");
            age = Convert.ToSingle(Console.ReadLine());
            maxHeartRate = 220 - age;
            minHRZone = maxHeartRate * (.5f);
            maxHRZone = maxHeartRate * (.85f);
            Console.WriteLine($"Your maximun heart rate should be {maxHeartRate} beats per minute\n" +
                $"Your target HR Zone is {minHRZone} - {maxHRZone} beats per minute");
            Console.ReadLine();
        }
    }
}
