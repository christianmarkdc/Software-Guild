using FlooringMastery.BLL;
using FlooringMastery.Models;
using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.UI.Workflow
{
    public class EditWorkFlow
    {
        public void Execute()
        {
            string orderDate;
            int orderNumber;
            bool isOrderNumberValid;
            OrderManager manager = OrderManagerFactory.Create();

            Console.Clear();
            Console.WriteLine("Edit an Order");
            Console.WriteLine("-------------------------------");
            orderDate = ConsoleIO.validateDateOrder();
            //Validate OrderNumber
            //call orderList from date
            //get count from list
            //keep count
            while (true)
            {
                orderNumber = Convert.ToInt32(ConsoleIO.GetRequiredNumberString("Enter Order Number:  "));
                isOrderNumberValid = manager.OrderNumberCount(orderDate, orderNumber);
                if (isOrderNumberValid == false)
                {
                    Console.WriteLine("Not a Valid Order Number");
                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }



            //Look Up Response
            //Then Edit the Repsonse
            OrderLookUpResponse lookUpOrder = manager.LookUpOrder(orderDate);

            Order editedOrder = lookUpOrder.OrderList.Orders[orderNumber];

            Console.WriteLine($"Enter customer name [{editedOrder.CustomerName}]: ");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                editedOrder.CustomerName = name;
            }
            Console.WriteLine($"Enter State Name [{editedOrder.State}]: ");
            string state = Console.ReadLine();
            if (!string.IsNullOrEmpty(state))
            {
                //Turn from state name to abbrivation
                editedOrder.State = state;
            }
            Console.WriteLine($"Enter Product Type [{editedOrder.ProductType}]: ");
            string productType = Console.ReadLine();
            if (!string.IsNullOrEmpty(productType))
            {
                editedOrder.ProductType = productType;
            }
            Console.WriteLine($"Enter Area [{ editedOrder.Area}]: ");
            string area =Console.ReadLine();
            if(!string.IsNullOrEmpty(area))
            {
                editedOrder.Area = Convert.ToDecimal(area);
            }
            //Shows what field was editted

            OrderEditResponse response = manager.EditOrder(orderDate, editedOrder, orderNumber);
            
            if (response.Success)
            {
                //List<Order> orders = TestOrderList.LoadOrders();
                ConsoleIO.DisplaySingleOrder(response.OrderList.Orders[orderNumber], orderDate);
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
