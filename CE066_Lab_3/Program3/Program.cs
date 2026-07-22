using System;
using System.Collections.Generic;

namespace LINQLab
{
    class Customer
    {
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public string City { get; set; }


    }

    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double OrderAmount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { CustomerId = 1, Name = "Amit Shah", City = "Ahmedabad" },
                new Customer { CustomerId = 2, Name = "Arun Patel", City = "Rajkot" },
                new Customer { CustomerId = 3, Name = "Mehul Datt", City = "Mumbai" },
                new Customer { CustomerId = 4, Name = "Virat Sharma", City = "Morbi" },
                new Customer { CustomerId = 5, Name = "Rajdeep Singh", City = "Ahmedabad" },
                new Customer { CustomerId = 6, Name = "Ranjeet Patel", City = "Jamnagar" },
            };

            List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 101, CustomerId = 1, ProductName = "Laptop", Category = "Electronics", OrderAmount = 65000 },
                new Order { OrderId = 102, CustomerId = 6, ProductName = "SmartPhone", Category = "Electronics", OrderAmount = 45000 },
                new Order { OrderId = 103, CustomerId = 2, ProductName = "Sofa", Category = "Furniture", OrderAmount = 10500 },
                new Order { OrderId = 104, CustomerId = 3, ProductName = "PS5", Category = "Electronics", OrderAmount = 50000 },
                new Order { OrderId = 105, CustomerId = 5, ProductName = "Shirt", Category = "Cloth", OrderAmount = 2500 },
                new Order { OrderId = 106, CustomerId = 4, ProductName = "Laptop", Category = "Electronics", OrderAmount = 65000 },
                new Order { OrderId = 107, CustomerId = 2, ProductName = "AirConditioner", Category = "Home Appliance", OrderAmount = 45000 },
            };

            // ==========================================================
            // Write LINQ queries below
            // ==========================================================

            // Query 1:
            // Display the names of all customers along with the products they have ordered.
            // (Use Join)
            var result1 = from order in orders
                          join customer in customers on order.CustomerId equals customer.CustomerId
                          select new
                          {
                              CustomerId = customer.CustomerId,
                              CustomerName = customer.Name,
                              ProductName = order.ProductName
                          };

            Console.WriteLine("Names of all customers along with the products they have ordered.");
            foreach (var item in result1)
                Console.WriteLine($"CustomerId = {item.CustomerId},CustomerName = {item.CustomerName},ProductName = {item.ProductName}");

            // Query 2:
            // Display the details of the first order whose amount is greater than ₹20,000.
            var result2 = orders.First(o => o.OrderAmount > 20000);

            Console.WriteLine("\nFirst Order Greater than ₹20,000");
            Console.WriteLine($"OrderId = {result2.OrderId},CustomerId = {result2.CustomerId},ProductName = {result2.ProductName},Category = {result2.Category},OrderAmount = {result2.OrderAmount}\n");

            // Query 3:
            // Display all customers from Ahmedabad along with the total amount they have spent on orders.
            // (Use Join, Where, GroupBy, and Sum)
            var result3 = customers
            .Join(
                orders,
                c => c.CustomerId,
                o => o.CustomerId,
                (c, o) => new
                {
                    c.Name,
                    c.City,
                    o.OrderAmount
                })
            .Where(x => x.City == "Ahmedabad")
            .GroupBy(x => x.Name)
            .Select(g => new
            {
                CustomerName = g.Key,
                TotalSpent = g.Sum(x => x.OrderAmount)
            });

            Console.WriteLine("Customers from Ahmedabad");
            foreach (var item in result3)
            {
                Console.WriteLine($"Customer: {item.CustomerName}, Total Spent: {item.TotalSpent}");
            }


            // Query 4:
            // Display the customer who has placed the highest-value order,
            // along with the product name and order amount.
            // (Use Join and OrderByDescending())
            Console.WriteLine("\nHighest-Value order along with product name and order amount");
            var result4 = customers
            .Join(
                orders,
                c => c.CustomerId,
                o => o.CustomerId,
                (c, o) => new
                {
                    CustomerName = c.Name,
                    ProductName = o.ProductName,
                    OrderAmount = o.OrderAmount
                })
            .OrderByDescending(x => x.OrderAmount)
            .FirstOrDefault();

            Console.WriteLine($"Customer: {result4.CustomerName},Product: {result4.ProductName},Order Amount: {result4.OrderAmount}");

            Console.ReadKey();
        }
    }
}
