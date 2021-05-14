using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOPractice
{
    public class MainMenu
    {
        private const string separatorBar = "===================================";
        public static void Show()
        {
            while (true)
            {
                Console.WriteLine("StudentManagement System");
                Console.WriteLine(separatorBar);
                Console.WriteLine("1. List Students");
                Console.WriteLine("2. Add Students");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Edit Student GPA");
                Console.WriteLine("");
                Console.WriteLine("Q - Quit");
                Console.WriteLine(separatorBar);
                Console.WriteLine("");
                Console.Write("Enter choice: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "Q":
                        return;
                    default:
                        Console.WriteLine("that is not a valid choice. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            
            }
        }
    }
}
