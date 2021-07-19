using FlooringMastery.BLL;
using FlooringMastery.Data;
using FlooringMastery.Models;
using FlooringMastery.Models.Responses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Tests
{
    [TestFixture]
    class TestRepostioryTests
    {
        [Test]
        public void CanDisplayOrders()
        {

            OrderManager manager = OrderManagerFactory.Create();
            OrderLookUpResponse response = new OrderLookUpResponse();
            response = manager.LookUpOrder("12202021");


            Assert.IsNotNull(response.OrderList);
            Assert.IsTrue(response.Success);
            Assert.AreEqual(response.OrderList.OrderDate, "12202021");
        }
        [Test]
        public void CanAddOrders()
        {
            OrderManager manager = OrderManagerFactory.Create();
            OrderAddResponse response = new OrderAddResponse();
            string orderDate = "12202021";
            Order addOrder = new Order
            {
                CustomerName = "Bob",
                State = "OH",
                ProductType = "Wood",
                Area = 150.00M
            };
            response = manager.AddOrder(orderDate, addOrder);

            Assert.AreEqual("Bob", response.OrderList.Orders[2].CustomerName);
            Assert.AreEqual("OH", response.OrderList.Orders[2].State);
            Assert.AreEqual("Wood", response.OrderList.Orders[2].ProductType);
            Assert.AreEqual(150.00M, response.OrderList.Orders[2].Area);
        }
        //public void CanAddOrders()
        [Test]
        public void CanEditOrders()
        {
            OrderManager manager = OrderManagerFactory.Create();
            OrderAddResponse response = new OrderAddResponse();
            string orderDate = "12202021";
            Order addOrder = new Order
            {
                CustomerName = "Bob",
                State = "OH",
                ProductType = "Wood",
                Area = 150.00M
            };
            response = manager.AddOrder(orderDate, addOrder);

            Assert.AreEqual("Bob", response.OrderList.Orders[2].CustomerName);
            Assert.AreEqual("OH", response.OrderList.Orders[2].State);
            Assert.AreEqual("Wood", response.OrderList.Orders[2].ProductType);
            Assert.AreEqual(150.00M, response.OrderList.Orders[2].Area);

            OrderEditResponse editedResponse = new OrderEditResponse();

            Order editedOrder = new Order
            {
                CustomerName = "Bob",
                State = "PA",
                ProductType = "Wood",
                Area = 100.00M
            };

            editedResponse = manager.EditOrder(orderDate, editedOrder, 0);

            Assert.AreEqual(100.00, editedResponse.OrderList.Orders[0].Area);
        }

        //Public void canEditOrders()
        [Test]
        public void CanRemoveOrder()
        {
            OrderManager manager = OrderManagerFactory.Create();
            OrderAddResponse response = new OrderAddResponse();
            string orderDate = "12202021";
            Order addOrder = new Order
            {
                CustomerName = "Bob",
                State = "OH",
                ProductType = "Wood",
                Area = 150.00M
            };
            response = manager.AddOrder(orderDate, addOrder);

            Assert.AreEqual("Bob", response.OrderList.Orders[2].CustomerName);
            Assert.AreEqual("OH", response.OrderList.Orders[2].State);
            Assert.AreEqual("Wood", response.OrderList.Orders[2].ProductType);
            Assert.AreEqual(150.00M, response.OrderList.Orders[2].Area);

            OrderRemoveResponse removeResponse = new OrderRemoveResponse();

            removeResponse = manager.RemoveOrder(orderDate, 2);

            Assert.IsTrue(removeResponse.Success);
        }
        //Public void CanRemoveOrders()
    }
}
