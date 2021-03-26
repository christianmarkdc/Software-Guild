using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.Models
{
    public class Coffee
    {
        public int CoffeeId { get; set; }
        public string CoffeeName { get; set; }
        public string CoffeeRoast { get; set; }
        public int CoffeeRating { get; set; }
        public float CoffeePrice { get; set; }


    }
}
