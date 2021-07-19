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
    public class RemoveWorkFlow
    {
        public void Execute()
        {
            string orderDate;
            int orderNumber;
            bool isOrderNumberValid;
            OrderManager manager = OrderManagerFactory.Create();

            Console.Clear();
            Console.WriteLine("Remove Order");
            Console.WriteLine("-------------------------------");
            orderDate = ConsoleIO.validateDateOrder();
            while (true)
            {
                orderNumber = Convert.ToInt32(ConsoleIO.GetRequiredNumberString("Enter Order Number: "));
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

            //Use display single order
            OrderLookUpResponse lookUpOrder = new OrderLookUpResponse();
            lookUpOrder = manager.LookUpOrder(orderDate);

            Order deleteOrder = lookUpOrder.OrderList.Orders[orderNumber];
            ConsoleIO.DisplaySingleOrder(deleteOrder, orderDate);
            //Display Order Condition
            //Query user to delete the order information
            string userInput = ConsoleIO.GetRequiredStringFormuser("Are you sure you want to delete this order?(y/n)");
            if(userInput != "y")
            {
                return;
            }
            //Figure out how to show error if not y or n

            //Turn order Date into a int
            OrderRemoveResponse response = manager.RemoveOrder(orderDate, orderNumber);

            if (response.Success)
            {
                Console.WriteLine("Order was Successfully Deleted");
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
