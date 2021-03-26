using CoffeeManager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeController controller = new CoffeeController();
            controller.Run();
        }
    }
}
