using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeManager.Models;

namespace CoffeeManager.View
{
    public class CoffeeView
    {
        private UserIO userIO;
        public CoffeeView()
        {
            userIO = new UserIO();
        }
        public int GetMenuChoice()
        {
            Console.WriteLine("\n Enter a choice from the menu");
            Console.WriteLine("1. Add Coffee");
            Console.WriteLine("2. List All");
            Console.WriteLine("3. Find by Id");
            Console.WriteLine("4. Edit Coffee");
            Console.WriteLine("5. Remove Coffee");
            Console.WriteLine("6. EXIT");
            int userChoice = userIO.ReadInt("Enter your Choice:", 1, 6);
            return userChoice;

        }
        public Coffee GetNewCoffeeInfo()
        {
            Coffee coffee = new Coffee();

            coffee.CoffeeName = userIO.ReadString("\nEnter in Coffee's Name");
            coffee.CoffeePrice = userIO.ReadFloat("Enter in the Coffee's Price", 0, 100);
            coffee.CoffeeRoast = userIO.ReadString("Enter in the Coffee's Roast");
            coffee.CoffeeRating = userIO.ReadInt("Enter in the Coffee's Rating", 0, 10);
            return coffee;
        }
        public void DisplayCoffee(Coffee coffee)
        {
            Console.WriteLine("\nCoffee Id: {0}", coffee.CoffeeId);
            Console.WriteLine("Coffee Name: {0}", coffee.CoffeeName);
            Console.WriteLine("Coffee Price: {0}", coffee.CoffeePrice);
            Console.WriteLine("Coffee Roast: {0}", coffee.CoffeeRoast);
            Console.WriteLine("Coffee Rating: {0}", coffee.CoffeeRating);
        }
        public Coffee EditCoffeeInfo(Coffee coffee)
        {
            DisplayCoffee(coffee);
            Console.WriteLine("Edit The Coffee's Properties");
            coffee = GetNewCoffeeInfo();
            return coffee;
        }
        public int SearchCoffee(Coffee[] coffee)
        {
            Console.WriteLine("Search Coffee by Name");
            string userInput = userIO.ReadString("Enter the Name to Search it");
            for (int i = 0; i < coffee.Length; i++)
            {
                if (userInput == coffee[i].CoffeeName)
                {
                    return coffee[i].CoffeeId;
                }
            }
            return 0;
        }
        public bool ConfirmRemoveCoffee(Coffee coffee)
        {
            string userInput = "n";
            Console.WriteLine("Do you want to REMOVE Coffee Entry(y/n)");
            //Make it a character then change it
            userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
