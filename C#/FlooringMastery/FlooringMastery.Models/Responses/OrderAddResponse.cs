using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Models.Responses
{
    public class OrderAddResponse : Response
    {
        public OrderList OrderList { get; set; }
        public Order Order { get; set; }
        public string OrderDate { get; set; }
        public string State { get; set; }
        public string ProductType { get; set; }
        public int Area { get; set; }
    }
}
