using FlooringMastery.BLL;
using FlooringMastery.Models;
using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.UI.Workflow
{
    public class AddWorkFlow
    {
        public void Execute()
        {
            string orderDate;
            string format = "MMddyyyy";
            OrderManager manager = OrderManagerFactory.Create();

            Console.Clear();
            Console.WriteLine("Add an Order");
            Console.WriteLine("-------------------------------");

            //Must be in the future
            while (true)
            {
                orderDate = ConsoleIO.GetRequiredStringFormuser("Enter Order Date (MMDDYYYY) " );
                //Validate the Date
                if (manager.validateDateTime(orderDate)==false)
                {
                    Console.WriteLine("Please put it in the Order Date Format with 8 numbers");
                    Console.ReadKey();
                }
                //Convert to Date Time
                DateTime userOrderDate = DateTime.ParseExact(orderDate, format, null);
                DateTime CurrentTime = DateTime.Now;
                if (userOrderDate < CurrentTime)
                {
                    Console.WriteLine("Need to have an Order Date in the Future");
                }
                else
                {
                    break;
                }
            }

            Order newOrder = new Order();

            newOrder.CustomerName = ConsoleIO.GetRequiredStringFormuser("Customer Name:  ");
            while (true)
            {
                newOrder.State = ConsoleIO.GetRequiredStringFormuser("State:  ");
                bool stateCheck = manager.checkIfSoldInState(newOrder.State);
                if (stateCheck == false)
                {
                    Console.WriteLine("Sorry we do not ship to that state currently");
                    Console.WriteLine("Please choose a state that we can ship too");
                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }
            //Show Product List
            while (true)
            {
                ConsoleIO.DisplayProductList(manager.Products());
                newOrder.ProductType = ConsoleIO.GetRequiredStringFormuser("Product Type:  ");
                bool productCheck = manager.checkIfProductOnList(newOrder.ProductType);
                if(productCheck == false)
                {
                    Console.WriteLine("Sorry that product is not on the list");
                    Console.WriteLine("Please choose a product on the List");
                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                newOrder.Area = Convert.ToDecimal(ConsoleIO.GetRequiredStringFormuser("Area:  "));
                if (newOrder.Area < 100)
                {
                    Console.WriteLine("Sorry you have to have a minium order size of 100 square feet");
                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }

            OrderAddResponse response = manager.AddOrder(orderDate, newOrder);
            if (response.Success)
            {
                //List<Order> orders = TestOrderList.LoadOrders();
                ConsoleIO.DisplayOrders(response.OrderList.Orders, orderDate);
            }
            else
            {
                Console.WriteLine("An Error Occured");
                Console.WriteLine(response.Message);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
