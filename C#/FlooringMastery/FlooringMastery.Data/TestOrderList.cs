using FlooringMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Data
{
    public class TestOrderList
    {
        private static OrderList _orderList = new OrderList();
        private static List<Tax> _tax = new List<Tax>();
        private static List<Products> _products = new List<Products>();

        public static OrderList LoadOrders()
        {
            //Create diffrent orderLists
            _orderList.OrderDate = "12202021";
            if (_orderList != null)
            {
                _orderList.Orders = new List<Order>
                {
                    new Order{
                        OrderNumber = 0,
                        CustomerName = "Wise",
                        State = "OH",
                        TaxRate = 6.25M,
                        ProductType = "Wood",
                        Area = 100M,
                        CostPerSquareFoot = 5.15M,
                        LaborCostPerSquareFoot = 4.75M,
                        MaterialCost = 515,
                        LaborCost = 475.0M,
                        Tax = 61.88M,
                        Total = 1051.88M
                    },
                    new Order
                    {
                        OrderNumber = 1,
                        CustomerName = "Bob",
                        State = "OH",
                        TaxRate = 6.25M,
                        ProductType = "Wood",
                        Area = 100M,
                        CostPerSquareFoot = 5.15M,
                        LaborCostPerSquareFoot = 4.75M,
                        MaterialCost = 515,
                        LaborCost = 475.0M,
                        Tax = 61.88M,
                        Total = 1051.88M
                    }
                };
            }

            return _orderList;
        }
        //can use Linq to find it
        /*
        public static Tax Taxes
        {
            //put in a list
            //put each tax thing in a lsit
            //if a state code matches
            //return the tax rate
            //Calculate on BLL
        }*/
        public static List<Tax> LoadTaxes()
        {
            if (_tax != null)
            {
                _tax = new List<Tax>
                {
                    new Tax
                    {
                        StateName = "Ohio",
                        StateAbbreviation = "OH",
                        TaxRate =6.25M
                    },
                    new Tax
                    {
                        StateName = "Pennsylvania",
                        StateAbbreviation = "PA",
                        TaxRate = 6.75M
                    }
                };
            }
            return _tax;
        }
        public static List<Products> LoadProducts()
        {
            if(_products != null)
            {
                _products = new List<Products>
                {
                    new Products
                    {
                        ProductType = "Carpet",
                        CostPerSquareFoot = 2.25M,
                        LaborCostPerSquareFoot = 2.10M
                    },
                    new Products
                    {
                        ProductType = "Wood",
                        CostPerSquareFoot = 5.15M,
                        LaborCostPerSquareFoot = 4.75M
                    },
                    new Products
                    {
                        ProductType = "Laminate",
                        CostPerSquareFoot = 1.75M,
                        LaborCostPerSquareFoot = 2.10M
                    }
                };
            }
            return _products;
        }
    }
}
