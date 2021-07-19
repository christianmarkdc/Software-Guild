using FlooringMastery.BLL;
using FlooringMastery.Data;
using FlooringMastery.Models;
using FlooringMastery.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.UI.Workflow
{
    public class DisplayWorkFlow
    {
        public void Execute()
        {
            string orderDate;
            OrderManager manager = OrderManagerFactory.Create();

            Console.Clear();
            Console.WriteLine("Look Up An Order");
            Console.WriteLine("-------------------------------");
            orderDate = ConsoleIO.validateDateOrder();
           

            //Turn order Date into a int
            OrderLookUpResponse response = manager.LookUpOrder(orderDate); 
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
