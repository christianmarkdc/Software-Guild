using FlooringMastery.Models;
using FlooringMastery.Models.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Data
{
    public class ProductRepository : IOrderRepository
    {
        //Read in Tax and Product Files
        //Create Files for orders

        public OrderList List(string OrderDate)
        {
            string _filePath = string.Format(@".\Orders_{0}.txt", OrderDate);
            //Load in FIle 
            //check by order date
            //return the list by orderDate
            //put orderDate into FilePath
            //if File exist read it in
            //if not create FIle
            OrderList orderList = new OrderList();
            orderList.Orders = new List<Order>();
            orderList.OrderDate = OrderDate;
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }
            else
            {
                
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    sr.ReadLine();
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Order order = new Order();

                        string[] columns = line.Split(',');

                        order.OrderNumber = Convert.ToInt32(columns[0]);
                        order.CustomerName = columns[1];
                        order.State = columns[2];
                        order.TaxRate = Convert.ToDecimal(columns[3]);
                        order.ProductType = columns[4];
                        order.Area = Convert.ToDecimal(columns[5]);
                        order.CostPerSquareFoot = Convert.ToDecimal(columns[6]);
                        order.LaborCostPerSquareFoot = Convert.ToDecimal(columns[7]);
                        order.MaterialCost = Convert.ToDecimal(columns[8]);
                        order.LaborCost = Convert.ToDecimal(columns[9]);
                        order.Tax = Convert.ToDecimal(columns[10]);
                        order.Total = Convert.ToDecimal(columns[11]);

                        orderList.Orders.Add(order);
                    }
                }
            }
            
            return orderList;
        }
        public void SaveOrder(OrderList orderList, string OrderDate)
        {
            string _filePath = string.Format(@".\Orders_{0}.txt", OrderDate);
            using (StreamWriter wr = new StreamWriter(_filePath))
            {
                wr.WriteLine("OrderNumber,CustomerName,State,TaxRate,ProductType,Area,CostPerSquareFoot,LaborCostPerSquareFoot,MaterialCost,LaborCost,Tax,Total");
                for (int i = 0; i < orderList.Orders.Count; i++)
                {
                    wr.WriteLine($"{orderList.Orders[i].OrderNumber},{orderList.Orders[i].CustomerName},{orderList.Orders[i].State}" +
                        $",{orderList.Orders[i].TaxRate},{orderList.Orders[i].ProductType},{orderList.Orders[i].Area},{orderList.Orders[i].CostPerSquareFoot}," +
                        $"{orderList.Orders[i].LaborCostPerSquareFoot},{orderList.Orders[i].MaterialCost},{orderList.Orders[i].LaborCost},{orderList.Orders[i].Tax},{orderList.Orders[i].Total}");
                }
            }
            
        }

        public List<Tax> LoadTaxes()
        {
            List<Tax> TaxList = new List<Tax>();
            //Read in Tax Files
            string _filePath = @".\Taxes.txt";
            using (StreamReader sr = new StreamReader(_filePath))
            {
                sr.ReadLine();
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Tax tax = new Tax();
                    string[] columns = line.Split(',');

                    tax.StateAbbreviation = columns[0];
                    tax.StateName = columns[1];
                    tax.TaxRate = Convert.ToDecimal(columns[2]);

                    TaxList.Add(tax);
                }

            }
            return TaxList;
        }

        public List<Products> LoadProducts()
        {
            //REad in Prodcuts
            List<Products> ProductList = new List<Products>();
            string _filePath = @".\Products.txt";
            using (StreamReader sr = new StreamReader(_filePath))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Products product = new Products();
                    string[] columns = line.Split(',');

                    product.ProductType = columns[0];
                    product.CostPerSquareFoot = Convert.ToDecimal(columns[1]);
                    product.LaborCostPerSquareFoot = Convert.ToDecimal(columns[2]);

                    ProductList.Add(product);
                }
            }
            return ProductList;
        }

        public Order LoadOrder(string orderDate, int orderNumber)
        {
            //Load in the files then return only one order
            OrderList orderList = List(orderDate);
            Order order = orderList.Orders.FirstOrDefault(p => p.OrderNumber == orderNumber);

            return order;
        }


    }
}
