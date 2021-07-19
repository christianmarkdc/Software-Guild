using FlooringMastery.UI.Workflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.UI
{
    public static class Menu
    {
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("**************************************");
                Console.WriteLine("* Flooring Program");
                Console.WriteLine("*");
                Console.WriteLine("* 1. Display Orders");
                Console.WriteLine("* 2. Add an Order");
                Console.WriteLine("* 3. Edit an Order");
                Console.WriteLine("* 4. Remove an Order");
                Console.WriteLine("* 5. Quit");
                Console.WriteLine("*");
                Console.WriteLine("**************************************");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DisplayWorkFlow displayWorkFlow = new DisplayWorkFlow();
                        displayWorkFlow.Execute();
                        break;
                    case "2":
                        AddWorkFlow addWorkFlow = new AddWorkFlow();
                        addWorkFlow.Execute();
                        break;
                    case "3":
                        EditWorkFlow editWorkFlow = new EditWorkFlow();
                        editWorkFlow.Execute();
                        break;
                    case "4":
                        RemoveWorkFlow removeWorkFlow = new RemoveWorkFlow();
                        removeWorkFlow.Execute();
                        break;
                    case "5":
                        return;
                }
            }

        }
    }
}
