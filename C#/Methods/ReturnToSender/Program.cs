﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnToSender
{
    class Program
    {
        static void Main(string[] args)
        {
            char aMystery = Mystery();
            String totallyUnexpected = Unexpected();
            double aSurprise = Surprise();
            bool itsClassified = Classified();
            int aSecret = Secret();

            Console.WriteLine("The methods have returned! Their results...\n");
            Console.WriteLine("Mysterious: " + aMystery);
            Console.WriteLine("Secret: " + aSecret);
            Console.WriteLine("Surprising: " + aSurprise);
            Console.WriteLine("Classified: " + itsClassified);
            Console.WriteLine("Unexpected: " + totallyUnexpected);
            Console.ReadLine();
        }
        public static int Secret()
        {
            return 42;
        }
        public static double Surprise()
        {
            return 3.14;
        }
        public static char Mystery()
        {
            return 'X';
        }
        public static bool Classified()
        {
            return true;
        }
        public static String Unexpected()
        {
            return "Spanish Inquisition";
        }
    }
}
