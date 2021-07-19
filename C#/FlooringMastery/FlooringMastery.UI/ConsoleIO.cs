using FlooringMastery.BLL;
using FlooringMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.UI
{
    public class ConsoleIO
    {
        OrderManager manager = OrderManagerFactory.Create();
        public static void DisplayOrders(List<Order> Orders, string OrderDate)
        {
            //Put Orders in a List so that You can Cycle Through them

            foreach (var customerOrder in Orders)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine($"{customerOrder.OrderNumber}  |  {OrderDate}");
                Console.WriteLine(customerOrder.CustomerName);
                Console.WriteLine(customerOrder.State);
                Console.WriteLine($"Product : {customerOrder.ProductType}");
                Console.WriteLine($"Materials : {customerOrder.MaterialCost:C}");
                Console.WriteLine($"Labor: {customerOrder.LaborCost:C}");
                Console.WriteLine($"Tax:  {customerOrder.Tax:C}");
                Console.WriteLine($"Total: {customerOrder.Total:C}");
                Console.WriteLine("**************************************");
            }


        }
        public static string GetRequiredStringFormuser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must enter valid text.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    return input;
                }
            }
        }

        public static string GetRequiredNumberString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt );
                string input = Console.ReadLine();
                var isNumeric = int.TryParse(input, out _);
                if (string.IsNullOrEmpty(input)||!isNumeric)

                {
                    Console.WriteLine("You must enter valid Number.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    return input;
                }
            }
        }
        public static void DisplaySingleOrder(Order Order, string OrderDate)
        {
                    Console.WriteLine("**************************************");
                    Console.WriteLine($"{Order.OrderNumber}  |  {OrderDate}");
                    Console.WriteLine(Order.CustomerName);
                    Console.WriteLine(Order.State);
                    Console.WriteLine($"Product : {Order.ProductType:C}");
                    Console.WriteLine($"Materials : {Order.MaterialCost:C}");
                    Console.WriteLine($"Labor: {Order.LaborCost:C}");
                    Console.WriteLine($"Tax:  {Order.Tax:C}");
                    Console.WriteLine($"Total: {Order.Total:C}");
                    Console.WriteLine("**************************************");
        }
        public static void DisplayProductList(List<Products> productList)
        {
            foreach(var products in productList)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine($"Product Type: {products.ProductType}");
                Console.WriteLine($"Cost per Square Foot: {products.CostPerSquareFoot}");
                Console.WriteLine($"Labor cost per Square Foot: {products.LaborCostPerSquareFoot}");
                Console.WriteLine("**************************************");
            }
        }
        public static string validateDateOrder()
        {
            string orderDate;
            OrderManager manager = OrderManagerFactory.Create();
            while (true)
            {
                orderDate = GetRequiredStringFormuser("Enter Order Date:  ");
                if (manager.validateDateTime(orderDate) == false)
                {
                    Console.WriteLine("Please put it in the Order Date Format with 8 numbers");
                    Console.ReadKey();
                }
                else
                {
                    return orderDate;
                }
            }
        }
    }
}
