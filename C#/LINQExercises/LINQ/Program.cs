using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //PrintAllProducts();
            //PrintAllCustomers();
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9();
            //Exercise10();
            //Exercise11();
            //Exercise12();
            //Exercise13();
            //Exercise14();
            //Exercise15();
            //Exercise16();
            //Exercise17();
            //Exercise18();
            //Exercise19();
            //Exercise20();
            //Exercise21();
            //Exercise22();
            //Exercise23();
            //Exercise24();
            //Exercise25();
            //Exercise26();
            //Exercise27();
            //Exercise28();
            //Exercise29();
            //Exercise30();
            //Exercise31();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        #region "Sample Code"
        /// <summary>
        /// Sample, load and print all the product objects
        /// </summary>
        static void PrintAllProducts()
        {
            List<Product> products = DataLoader.LoadProducts();
            PrintProductInformation(products);
        }

        /// <summary>
        /// This will print a nicely formatted list of products
        /// </summary>
        /// <param name="products">The collection of products to print</param>
        static void PrintProductInformation(IEnumerable<Product> products)
        {
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }

        }

        /// <summary>
        /// Sample, load and print all the customer objects and their orders
        /// </summary>
        static void PrintAllCustomers()
        {
            var customers = DataLoader.LoadCustomers();
            PrintCustomerInformation(customers);
        }

        /// <summary>
        /// This will print a nicely formated list of customers
        /// </summary>
        /// <param name="customers">The collection of customer objects to print</param>
        static void PrintCustomerInformation(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine(customer.Address);
                Console.WriteLine("{0}, {1} {2} {3}", customer.City, customer.Region, customer.PostalCode, customer.Country);
                Console.WriteLine("p:{0} f:{1}", customer.Phone, customer.Fax);
                Console.WriteLine();
                Console.WriteLine("\tOrders");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
                }
                Console.WriteLine("==============================================================================");
                Console.WriteLine();
            }
        }
        #endregion

        /// <summary>
        /// Print all products that are out of stock.
        /// </summary>
        /// Exercise1
        static void Exercise1()
        {
            List<Product> products = DataLoader.LoadProducts();
            var OutOfStock = from p in products
                             where p.UnitsInStock == 0
                             select p;
            PrintProductInformation(OutOfStock);

        }

        /// <summary>
        /// Print all products that are in stock and cost more than 3.00 per unit.
        /// </summary>
        /// Exercise2
        static void Exercise2()
        {
            List<Product> products = DataLoader.LoadProducts();
            var InStock = from p in products
                          where p.UnitsInStock != 0 && p.UnitPrice > 3.0M
                          select p;
            PrintProductInformation(InStock);
        }

        /// <summary>
        /// Print all customer and their order information for the Washington (WA) region.
        /// </summary>
        /// Exercise3
        static void Exercise3()
        {
            List<Customer> customers = DataLoader.LoadCustomers();
            var WashingtonCustomers = from c in customers
                                      where c.Region == "WA"
                                      select c;
            PrintCustomerInformation(WashingtonCustomers);
        }

        /// <summary>
        /// Create and print an anonymous type with just the ProductName
        /// </summary>
        /// Exercise4
        static void Exercise4()
        {
            var products = from p in DataLoader.LoadProducts()
                           select new { Name = p.ProductName };
            Console.WriteLine("Product Name");
            Console.WriteLine("==============================================================================");
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }

        }

        /// <summary>
        /// Create and print an anonymous type of all product information but increase the unit price by 25%
        /// </summary>
        /// Exercise5
        static void Exercise5()
        {
            var products = from p in DataLoader.LoadProducts()
                           select new { unitPrice = p.UnitPrice * 1.25M, p.UnitsInStock, p.ProductID, p.ProductName, p.Category };
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.unitPrice, product.UnitsInStock);
            }

        }

        /// <summary>
        /// Create and print an anonymous type of only ProductName and Category with all the letters in upper case
        /// </summary>
        /// Exercise6
        static void Exercise6()
        {
            var products = from p in DataLoader.LoadProducts()
                           select new { nameCapital = p.ProductName.ToUpper(), categoryCapital = p.Category.ToUpper() };

            string line = "{0,-35} {1,-15}";
            Console.WriteLine(line, "Product Name", "Category");
            Console.WriteLine("==============================================");
            foreach (var product in products)
            {
                //string productName = product.nameCapital.ToUpper();
                Console.WriteLine(line, product.nameCapital, product.categoryCapital);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra bool property ReOrder which should 
        /// be set to true if the Units in Stock is less than 3
        /// 
        /// Hint: use a ternary expression
        /// </summary>
        /// Exercise7
        static void Exercise7()
        {
            var products = from p in DataLoader.LoadProducts()
                           select new { p.ProductID, p.ProductName, p.Category, p.UnitPrice, p.UnitsInStock, reOrder = p.UnitsInStock < 3 ? "ReOrder" : "In StocK" };

            string line = "{0,-5} {1,-35} {2,-15} {3,8:c} {4,6} {5, 4}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock", "ReOrder");
            Console.WriteLine("==================================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock, product.reOrder);
            }

        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra decimal called 
        /// StockValue which should be the product of unit price and units in stock
        /// </summary>
        /// Exercise8
        static void Exercise8()
        {
            var products = from p in DataLoader.LoadProducts()
                           select new { p.ProductID, p.ProductName, p.Category, p.UnitPrice, p.UnitsInStock, StockValue = p.UnitPrice * p.UnitsInStock };

            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6} {5, 9:c}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock", "StockValue");
            Console.WriteLine("==================================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock, product.StockValue);
            }
        }

        /// <summary>
        /// Print only the even numbers in NumbersA
        /// </summary>
        /// Exercise9
        static void Exercise9()
        {
            var numbers = DataLoader.NumbersA;
            var onlyEvens = numbers.Where(number => number % 2 == 0 && number != 0);
            foreach (var num in onlyEvens)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print only customers that have an order whos total is less than $500
        /// </summary>
        static void Exercise10()
        {
            var customers = from c in DataLoader.LoadCustomers()
                            from o in c.Orders
                            where o.Total < 500.00M
                            select c;
            PrintCustomerInformation(customers);
        }

        /// <summary>
        /// Print only the first 3 odd numbers from NumbersC
        /// </summary>
        static void Exercise11()
        {
            var numbers = DataLoader.NumbersC;
            var firstThreeOdds = numbers.Where(number => number % 2 == 1).Take(3);
            foreach (var num in firstThreeOdds)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print the numbers from NumbersB except the first 3
        /// </summary>
        static void Exercise12()
        {
            var numbers = DataLoader.NumbersB;
            var NotFirstThree = numbers.Skip(3);

            foreach (var num in NotFirstThree)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print the Company Name and most recent order for each customer in Washington
        /// </summary>
        /// Exercise13
        static void Exercise13()
        {
            var WashingtonCustomers = from c in DataLoader.LoadCustomers()
                                      where c.Region == "WA"
                                      select c;
            var orders = from c in WashingtonCustomers
                         group c by new { c.CompanyName, recentOrders = c.Orders.Max(o => o.OrderDate) } into order
                         orderby order.Key.recentOrders
                         select order;
            foreach (var o in orders)
            {
                Console.WriteLine("{0}, Most Recent Order {1}", o.Key.CompanyName, o.Key.recentOrders);
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC until a number is >= 6
        /// </summary>
        /// Exercise 14
        static void Exercise14()
        {
            var numbers = DataLoader.NumbersC;
            // var lessThan6 = numbers.Where(number => number < 6);
            var lessThan6 = numbers.TakeWhile(number => number < 6);

            foreach (var num in lessThan6)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC that come after the first number divisible by 3
        /// </summary>
        /// Exercise15
        static void Exercise15()
        {
            var numbers = DataLoader.NumbersC;
            var divisibleBy3 = numbers.SkipWhile(number => number % 3 != 0);

            foreach (var num in divisibleBy3)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print the products alphabetically by name
        /// </summary>
        /// Exercise16
        static void Exercise16()
        {
            var products = from p in DataLoader.LoadProducts()
                           .OrderBy(p => p.ProductName).ToList()
                           select p.ProductName;
            foreach (var pro in products)
            {
                Console.WriteLine(pro);
            }
        }

        /// <summary>
        /// Print the products in descending order by units in stock
        /// </summary>
        /// Exercise17
        static void Exercise17()
        {
            var products = from p in DataLoader.LoadProducts()
                           .OrderByDescending(p => p.UnitsInStock).ToList()
                           select p;
            PrintProductInformation(products);

        }

        /// <summary>
        /// Print the list of products ordered first by category, then by unit price, from highest to lowest.
        /// </summary>
        /// Exercise18
        static void Exercise18()
        {
            var products = from p in DataLoader.LoadProducts()
                           .OrderBy(c => c.Category)
                           .ThenByDescending(c => c.UnitPrice)
                           select p;
            Console.WriteLine("Ordered By Category, Then by Unit Price(High - Low)");

            PrintProductInformation(products);


        }

        /// <summary>
        /// Print NumbersB in reverse order
        /// </summary>
        /// Exercise19
        static void Exercise19()
        {
            var numbers = DataLoader.NumbersB;
            var Reverse = numbers.Reverse();

            foreach (var num in Reverse)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Group products by category, then print each category name and its products
        /// ex:
        /// 
        /// Beverages
        /// Tea
        /// Coffee
        /// 
        /// Sandwiches
        /// Turkey
        /// Ham
        /// </summary>
        static void Exercise20()
        {
            var products = from p in DataLoader.LoadProducts()
                           group p by p.Category into category
                           orderby category.Key
                           select category;
            foreach (var p in products)
            {
                Console.WriteLine($"Category: {p.Key}");
                foreach (var name in p)
                {
                    Console.WriteLine("\t" + name.ProductName);
                }
            }
        }

        /// <summary>
        /// Print all Customers with their orders by Year then Month
        /// ex:
        /// 
        /// Joe's Diner
        /// 2015
        ///     1 -  $500.00
        ///     3 -  $750.00
        /// 2016
        ///     2 - $1000.00
        /// </summary>
        /// Exercise21
        static void Exercise21()
        {
            var orders = from c in DataLoader.LoadCustomers()
                         from o in c.Orders
                         group c by new
                         {
                             c.CompanyName,
                             o.OrderDate,
                             o.Total
                         } into orderGroup
                         select new
                         {
                             total = orderGroup.Key.Total,
                             name = orderGroup.Key.CompanyName,
                             year = from y in orderGroup
                                    group y by orderGroup.Key.OrderDate.Year into yr
                                    select new
                                    {
                                        yrGroup = yr.Key,
                                        month = from m in orderGroup
                                                group m by orderGroup.Key.OrderDate.Month into mm
                                                select new
                                                {
                                                    monthGroup = mm.Key
                                                }
                                    }
                         };
            var name = "";
            int yearDate =0;
            foreach (var c in orders)
            {

                if (name != c.name)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine(c.name);
                    
                }
                name = c.name;
                foreach (var o in c.year)
                {
                    if(yearDate != o.yrGroup)
                    {
                        Console.WriteLine(o.yrGroup);
                    }
                    yearDate = o.yrGroup;
                    foreach (var month in o.month)
                    {
                        Console.WriteLine("\t {0} - {1:c}",month.monthGroup, c.total);
                    }
                }
            }
        }

        /// <summary>
        /// Print the unique list of product categories
        /// </summary>
        /// Exercise22
        static void Exercise22()
        {
            var products = (from p in DataLoader.LoadProducts()
                            select p.Category)
                           .Distinct().ToList();
            foreach (var name in products)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Write code to check to see if Product 789 exists
        /// </summary>
        /// Exercise23
        static void Exercise23()
        {
            var product = (from p in DataLoader.LoadProducts()
                           select p.ProductID).Contains(789);
            if (product == true)
            {
                Console.WriteLine("Product 789 Does Exist");
            }
            else
            {
                Console.WriteLine("Product 789 Doesn't Exsit");
            }

        }

        /// <summary>
        /// Print a list of categories that have at least one product out of stock
        /// </summary>
        /// Exercise 24
        static void Exercise24()
        {
            //Fix this It writes the thing based on each product
            var OutOfStock = (from c in DataLoader.LoadProducts()
                              where c.UnitsInStock == 0
                              select c.Category)
                             .Distinct().ToList();
            Console.WriteLine("Categories where a Product is out of Stock ");
            Console.WriteLine("================================");
            foreach (var stock in OutOfStock)
            {
                Console.WriteLine(stock);
            }
        }

        /// <summary>
        /// Print a list of categories that have no products out of stock
        /// </summary>
        /// Exercise 25
        static void Exercise25()
        {
            //Fix this It writes the thing based on each product
            var OutOfStock = (from c in DataLoader.LoadProducts()
                              where c.UnitsInStock == 0
                              select c.Category)
                             .Distinct().ToList();
            var InStock = (from c in DataLoader.LoadProducts()
                           select c.Category).Except(OutOfStock);

            Console.WriteLine("Categories where all prodcuts are In Stock ");
            Console.WriteLine("================================");
            foreach (var stock in InStock)
            {
                Console.WriteLine(stock);
            }
        }

        /// <summary>
        /// Count the number of odd numbers in NumbersA
        /// </summary>
        /// Exercise 26
        static void Exercise26()
        {
            var numbers = DataLoader.NumbersA;
            var CountOdds = numbers.Count(number => number % 2 == 1);

            Console.WriteLine("There are {0} odds in NumbersA", CountOdds);
        }

        /// <summary>
        /// Create and print an anonymous type containing CustomerId and the count of their orders
        /// </summary>
        /// Exercise 27
        static void Exercise27()
        {
            var customerId = from c in DataLoader.LoadCustomers()
                             select new { c.CustomerID, countOrder = c.Orders.Count() };

            string line = "{0,3} {1,11}";
            Console.WriteLine(line, "Customer ID", "Order Count");
            Console.WriteLine("==================================================================================");

            foreach (var c in customerId)
            {
                Console.WriteLine(line, c.CustomerID, c.countOrder);
            }

        }

        /// <summary>
        /// Print a distinct list of product categories and the count of the products they contain
        /// </summary>
        /// Exercise 28
        static void Exercise28()
        {
            var products = (from p in DataLoader.LoadProducts()
                            select p.Category)
                          .Distinct().ToList();
            var productCount = (from p in DataLoader.LoadProducts()
                                group p by p.Category into category
                                select category.Count()).ToList();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i]);
                Console.WriteLine(productCount[i]);
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the total units in stock
        /// </summary>
        /// Exercise 29
        static void Exercise29()
        {
            var stockCount = from p in DataLoader.LoadProducts()
                             group p by p.Category into s
                             select new { category = s.Key, totalUnits = s.Sum(u => u.UnitsInStock) };



            foreach (var s in stockCount)
            {
                Console.WriteLine(s.category);
                Console.WriteLine(s.totalUnits);
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the lowest priced product in that category
        /// </summary>
        /// Exercise 30
        static void Exercise30()
        {
            var lowestPrice = from p in DataLoader.LoadProducts()
                              group p by p.Category into s
                              select new { category = s.Key, lowestPriceProduct = s.Min(u => u.UnitPrice) };
            foreach (var s in lowestPrice)
            {
                Console.WriteLine(s.category);
                Console.WriteLine("{0:c}", s.lowestPriceProduct);
            }
        }

        /// <summary>
        /// Print the top 3 categories by the average unit price of their products
        /// </summary>
        /// Exercise 31
        static void Exercise31()
        {
            var averagePriceProduct = (from p in DataLoader.LoadProducts()
                                       group p by p.Category into s
                                       select new { category = s.Key, averagePrice = s.Average(u => u.UnitPrice) });
            var topThreeProducts = averagePriceProduct.OrderByDescending(s => s.averagePrice)
                                   .Take(3);
            foreach (var s in topThreeProducts)
            {
                Console.WriteLine(s.category);
                Console.WriteLine("{0:c}", s.averagePrice);
            }
        }
    }
}
