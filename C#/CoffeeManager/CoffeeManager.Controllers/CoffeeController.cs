using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeManager.Models;
using CoffeeManager.View;
using CoffeeManager.Data;


namespace CoffeeManager.Controllers
{
    public class CoffeeController
    {
        private CoffeeView View;
        private CoffeeRepository repository;
        private UserIO userIO;
        public CoffeeController()
        {
            View = new CoffeeView();
            repository = new CoffeeRepository();
            userIO = new UserIO();
        }

        public void Run()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                int menuChoice = View.GetMenuChoice();

                switch (menuChoice)
                {
                    case 1:
                        CreateCoffee();
                        break;
                    case 2:
                        DisplayCoffee();
                        break;
                    case 3:
                        SearchCoffee();
                        break;
                    case 4:
                        EditCoffee();
                        break;
                    case 5:
                        RemoveCoffee();
                        break;
                    case 6:
                        //Exit
                        keepRunning = false;
                        break;
                }
            }
        }
        private void CreateCoffee()
        {
            Coffee newCoffee = View.GetNewCoffeeInfo();
            Coffee addedCoffee = repository.CreateCoffee(newCoffee);

            if (addedCoffee != null)//Added Repoitory
            {
                View.DisplayCoffee(addedCoffee);

            }
            else
            {
                //failed
            }

        }
        private void DisplayCoffee()
        {
            Coffee[] coffeeList = repository.ReadAll();
            for (int i = 0; i <= coffeeList.Length-1; i++)
            {
                if (coffeeList[i] == null)
                {
                    
                }
                else
                {
                    View.DisplayCoffee(coffeeList[i]);
                }

            }

        }
        private void SearchCoffee()
        {
            int id = userIO.ReadInt("Enter Coffee Id", 0, 10);
            Coffee coffee = repository.ReadById(id);
            View.DisplayCoffee(coffee);
        }
        private void EditCoffee()
        {

            int id = userIO.ReadInt("Enter Coffee Id", 0, 10);
            Coffee editedCoffee = repository.ReadById(id);

            editedCoffee = View.EditCoffeeInfo(editedCoffee);

            repository.UpdateCoffee(id, editedCoffee);
            View.DisplayCoffee(editedCoffee);

        }
        private void RemoveCoffee()
        {
            Coffee[] coffeeList = repository.ReadAll();
            int id = userIO.ReadInt("Enter Coffee Id to Delete", 0, 10);

            bool delete = View.ConfirmRemoveCoffee(coffeeList[id]);
            if (delete == true)
            {
                repository.DeleteCoffee(id);
            }
            else
            {
                Console.WriteLine("Nothing was deleted");
            }
        }
    }
}
