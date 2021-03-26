using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeManager.Models;

namespace CoffeeManager.Data
{

    public class CoffeeRepository
    {
        Coffee[] coffeeList;
        public CoffeeRepository()
        {
            coffeeList = new Coffee[10];

            Coffee coffee1 = new Coffee
            {
                CoffeeId = 0,
                CoffeeName = "Dark Magic",
                CoffeePrice = .5f,
                CoffeeRoast = "Dark",
                CoffeeRating = 7
            };
            coffeeList[0] = coffee1;

            Coffee coffee2 = new Coffee
            {
                CoffeeId = 1,
                CoffeeName = "Donut Shop",
                CoffeePrice = 1.5f,
                CoffeeRoast = "Medium",
                CoffeeRating = 8
            };
            coffeeList[1] = coffee2;
        }
        public Coffee CreateCoffee(Coffee coffee)
        {
            for (int i = 0; i < coffeeList.Length; i++)
            {
                if (coffeeList[i] == null)
                {
                    coffee.CoffeeId = i;
                    coffeeList[i] = coffee;
                    return coffee;
                }
            }
            return null;
        }
        public Coffee[] ReadAll()
        {
            return coffeeList;
        }
        public Coffee ReadById(int id)
        {
            Coffee coffee = coffeeList[id];
            return coffee;
        }
        public void UpdateCoffee(int id, Coffee coffee)
        {
            DeleteCoffee(id);
            CreateCoffee(coffee);
           
        }
        public void DeleteCoffee(int id)
        {
            coffeeList[id] = null;
        }
    }
}
