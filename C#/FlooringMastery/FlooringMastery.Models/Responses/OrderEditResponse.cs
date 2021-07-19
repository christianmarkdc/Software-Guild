using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringMastery.Models.Responses
{
    public class OrderEditResponse : Response
    {
        public OrderList OrderList { get; set; }
        public Order Order { get; set; }
        
    }
}
