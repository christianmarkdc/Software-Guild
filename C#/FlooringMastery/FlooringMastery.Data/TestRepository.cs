using FlooringMastery.Models;
using FlooringMastery.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Data
{
    public class TestRepository : IOrderRepository
    {
        private static OrderList orders = TestOrderList.LoadOrders();
        private static List<Tax> taxes = new List<Tax>();
        private static List<Products> products = new List<Products>();
       
        public OrderList List(string OrderDate)
        {
            //check date
            //create file if not have date
            //keep same list
            
            if(orders.OrderDate != OrderDate)
            {
                return null;
            }

            return orders;
            
            
        }

        public Order LoadOrder(string orderDate, int orderNumber)
        {
            //OrderList
            if(orders.OrderDate != orderDate)
            {
                return null;
            }
            else
            {
                return orders.Orders[orderNumber];
            }
        }

        public List<Products> LoadProducts()
        {
            products = TestOrderList.LoadProducts();
            return products;
        }

        public List<Tax> LoadTaxes()
        {
            taxes = TestOrderList.LoadTaxes();
            return taxes;
        }

        //Load in tax Files and Prod Files

        public void SaveOrder(OrderList orderList, string orderDate)
        {
            orders = orderList;
        }
    }
}
