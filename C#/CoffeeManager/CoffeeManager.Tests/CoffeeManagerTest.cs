using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CoffeeManager.Models;
using CoffeeManager.Data;
using CoffeeManager.View;
using CoffeeManager.Controllers;

namespace CoffeeManager.Tests
{

    [TestFixture]
    public class CoffeeManagerTest
    {
        private CoffeeRepository repository;
        private CoffeeView view;

        public CoffeeManagerTest()
        {
            repository = new CoffeeRepository();
        }
        [Test]
        public void CanCreateCoffee()
        {
            Coffee coffee = new Coffee();
            repository.CreateCoffee(coffee);

            Assert.AreEqual(2, coffee.CoffeeId);

        }
        [Test]
        public void CanEditCoffee()
        {
            Coffee coffee = new Coffee
            {
                CoffeeId = 1,
                CoffeeName = "Bad Coffee",
                CoffeePrice = 3.7f,
                CoffeeRating = 1,
                CoffeeRoast = "light"
            };
            repository.UpdateCoffee(1, coffee);
            Coffee newCoffee = repository.ReadById(1);
            Assert.AreEqual(coffee.CoffeeName, newCoffee.CoffeeName);

        }
        [Test]
        public void CanDeleteCoffee()
        {
            Coffee coffee = new Coffee
            {
                CoffeeId = 2,
                CoffeeName = "Good Coffee",
                CoffeePrice = 2.00f,
                CoffeeRating = 9,
                CoffeeRoast = "Medium"
            };

            repository.CreateCoffee(coffee);
            Coffee newCoffee = repository.ReadById(2);



            repository.DeleteCoffee(2);
            Assert.AreEqual(null, newCoffee.CoffeeName);
        }
    }
}
