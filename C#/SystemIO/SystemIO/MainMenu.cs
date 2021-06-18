using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemIO.Helpers;
using SystemIO.Workflows;

namespace SystemIO
{
    public class MainMenu
    {
        
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("StudentManagement System");
            Console.WriteLine(ConsoleIO.separatorBar);
            Console.WriteLine("1. List Students");
            Console.WriteLine("2. Add Students");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Edit Student GPA");
            Console.WriteLine("");
            Console.WriteLine("Q - Quit");
            Console.WriteLine(ConsoleIO.separatorBar);
            Console.WriteLine("");
            Console.Write("Enter choice: ");
        }
        private static bool ProcessChoice()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ListStudentWorkflow listWorkflow = new ListStudentWorkflow();  
                    listWorkflow.Execute();
                    Console.ReadKey();
                    break;
                case "2":
                    AddStudentWorkflow addWorkflow = new AddStudentWorkflow();
                    addWorkflow.Execute();
                    Console.ReadKey();
                    break;
                case "3":
                    RemoveStudentWorkflow removeWorkflow = new RemoveStudentWorkflow();
                    removeWorkflow.Execute();
                    Console.ReadKey();
                    break;
                case "4":
                    EditStudentWorkflow editWorkflow = new EditStudentWorkflow();
                    editWorkflow.Execute();
                    Console.ReadKey();
                    break;
                case "Q":
                    return false;
                default:
                    Console.WriteLine("that is not a valid choice. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
            return true;
        }
        public static void Show()
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                DisplayMenu();
                continueRunning = ProcessChoice();
            }
        }
    }
}
