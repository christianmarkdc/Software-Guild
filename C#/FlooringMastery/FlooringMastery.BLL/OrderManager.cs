using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringMastery.Models;
using FlooringMastery.Models.Interface;
using FlooringMastery.Models.Responses;

namespace FlooringMastery.BLL
{
    public class OrderManager
    {
        private IOrderRepository _orderRepository;
        private List<Tax> _Tax;
        private List<Products> _Products;
        //pr
        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public OrderLookUpResponse LookUpOrder(string orderDate)
        {
            OrderLookUpResponse response = new OrderLookUpResponse();

            response.OrderList = _orderRepository.List(orderDate);

            if (response.OrderList.OrderDate != orderDate)
            {
                response.Success = false;
                response.Message = $"{orderDate} is not a valid date";
            }
            else if (response.OrderList == null)
            {
                //Does this ever get triggered
                response.Success = false;
                response.Message = $"Order List is null";
            }
            else
            {
                response.Success = true;
            }
            return response;
        }

        public OrderAddResponse AddOrder(string OrderDate, Order order)
        {
            OrderAddResponse response = new OrderAddResponse();
            response.OrderList = _orderRepository.List(OrderDate);
            int listCount = response.OrderList.Orders.Count();
            //Check if order can be sent to state
            //Load in Taxes and return the tax information for the order
            _Tax = _orderRepository.LoadTaxes();
            Tax taxRate = _Tax.FirstOrDefault(p => p.StateAbbreviation == order.State);
            order.TaxRate = taxRate.TaxRate;
            //Check if order is Empty
            if (order.TaxRate.Equals(null))
            {
                response.Success = false;
                response.Message = "Could not get Tax Rate from the State";
            }

            //Load in Products and return product type information
            _Products = _orderRepository.LoadProducts();
            Products orderProduct = (Products)_Products.FirstOrDefault(p => p.ProductType == order.ProductType);
            if (orderProduct == null)
            {
                response.Success = false;
                response.Message = "Could not get ProductType form order";
            }

            //Add the values to the different properties and Do Math
            order.CostPerSquareFoot = orderProduct.CostPerSquareFoot;
            order.LaborCostPerSquareFoot = orderProduct.LaborCostPerSquareFoot;
            order.OrderNumber = listCount++;

            order = OrderCalculations(order);
            //Add Order to list
            response.OrderList.Orders.Add(order);

            if (!response.OrderList.Orders.Contains(order))
            {
                response.Success = false;
                response.Message = "Order was not Added";
            }
            else
            {
                //_orderRepository.SaveOrder(order, listCount++);
                _orderRepository.SaveOrder(response.OrderList, response.OrderList.OrderDate);
                response.Success = true;
            }

            return response;
        }

        public OrderEditResponse EditOrder(string OrderDate, Order Order, int OrderNumber)
        {
            //Can Only change CustomerName, State, ProductType, Area
            OrderEditResponse response = new OrderEditResponse();
            Order oldOrder = _orderRepository.LoadOrder(OrderDate, OrderNumber);
            response.OrderList = _orderRepository.List(OrderDate);
            _Tax = _orderRepository.LoadTaxes();
            _Products = _orderRepository.LoadProducts();
            //return orders then match it up
            if (Order.State != oldOrder.State && Order.State!=null)
            {
                //This is abbriv
                oldOrder.State = Order.State;
                Tax tax = _Tax.FirstOrDefault(p => p.StateAbbreviation == Order.State);
                oldOrder.TaxRate = tax.TaxRate;

            }
            if (Order.ProductType != oldOrder.ProductType)
            {
                oldOrder.ProductType = Order.ProductType;
                Products products = _Products.FirstOrDefault(p => p.ProductType == Order.ProductType);
                oldOrder.LaborCostPerSquareFoot = products.LaborCostPerSquareFoot;
                oldOrder.CostPerSquareFoot = products.CostPerSquareFoot;
                //Get Cost Per Square Foot
                //Get Labor Cost
            }
            if (Order.Area != oldOrder.Area)
            {
                oldOrder.Area = Order.Area;
            }
            if (Order.CustomerName != oldOrder.CustomerName)
            {
                oldOrder.CustomerName = Order.CustomerName;
            }

            oldOrder = OrderCalculations(oldOrder);
            response.OrderList.Orders[OrderNumber] = oldOrder;
           
            //Show new price if Changed
            if (response.OrderList.Orders[OrderNumber] == null)
            {
                response.Success = false;
                response.Message = "Order could not be Edited";
            }
            else
            {
                // _orderRepository.SaveOrder(response.Order, OrderNumber);
                _orderRepository.SaveOrder(response.OrderList, response.OrderList.OrderDate);
                response.Success = true;
            }


            return response;
        }

        public OrderRemoveResponse RemoveOrder(string orderDate, int OrderNumber)
        {
            OrderRemoveResponse response = new OrderRemoveResponse();
            response.OrderList = _orderRepository.List(orderDate);

            Order order = response.OrderList.Orders.SingleOrDefault(p => p.OrderNumber == OrderNumber);
            if (order != null)
            {
                response.OrderList.Orders.Remove(order);
            }
            //Call in the current list with the orderDate
            //If orderDate doens't exsit errror
            //var order = list.Single or dault x = x.OrderNumber == orderNumber
            //if order is not null List.Remove(item);
            if (response.OrderList.Orders.Contains(order) == true)
            {
                response.Success = false;
                response.Message = "Order could not be Deleted";
            }
            else
            {
                _orderRepository.SaveOrder(response.OrderList, response.OrderList.OrderDate);
                response.Success = true;
            }

            return response;
        }

        public Order OrderCalculations(Order order)
        {
            order.LaborCost = (order.Area * order.LaborCostPerSquareFoot);
            order.MaterialCost = (order.Area * order.CostPerSquareFoot);
            order.Tax = ((order.MaterialCost + order.LaborCost) * (order.TaxRate / 100));
            order.Total = (order.MaterialCost + order.LaborCost + order.Tax);
            return order;
        }

        public bool checkIfSoldInState(string state)
        {
            _Tax = _orderRepository.LoadTaxes();
            bool stateCheck = _Tax.Any(p => p.StateAbbreviation == state);
            return stateCheck;
        }
        public List<Products> Products()
        {
            _Products = _orderRepository.LoadProducts();
            return _Products;
        }
        public bool checkIfProductOnList(string productType)
        {
            _Products = _orderRepository.LoadProducts();
            bool checkProduct = _Products.Any(p => p.ProductType == productType);
            return checkProduct;
        }
        public bool validateDateTime(string orderDate)
        {
            string format = "MMddyyyy";
            DateTime dateTime;
            //Validate the Date
            bool isDateTime = DateTime.TryParseExact(orderDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
            return isDateTime;
        }
        public bool OrderNumberCount(string OrderDate,int orderNumber)
        {
            OrderList countList = _orderRepository.List(OrderDate);
            bool checkOrderNumber = countList.Orders.Any(p => p.OrderNumber == orderNumber);
            return checkOrderNumber;

        }
    }
}
