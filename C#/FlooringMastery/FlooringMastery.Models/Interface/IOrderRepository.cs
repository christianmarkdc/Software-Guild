using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Models.Interface
{
    public interface IOrderRepository
    {
        Order LoadOrder(string orderDate,int orderNumber);
        void SaveOrder(OrderList orderlist, string orderDate);
        OrderList List(string OrderDate);
        List<Tax> LoadTaxes();
        List<Products> LoadProducts();
    }
}
