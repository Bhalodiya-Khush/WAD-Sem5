using System;
using System.Collections.Generic;
class Product
{
    public int Id { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public double price { get; set; }
    public double discount { get; set; }
    public string store { get; set; }
    public Product(int Id, string name, string category, double price, double discount, string store)
    {
        this.Id = Id;
        this.name = name;
        this.category = category;
        this.price = price;
        this.discount = discount;
        this.store = store;
    }
}
public class DiscountManagementSystem
{
    static void Main()
    {
        List<Product> ProductList = new List<Product>
        {
            new Product(101,"Laptop","Electronics",75000,10,"SalesIndia"),
            new Product(101,"Mobile","Electronics",25000,20,"Umiyastore"),
            new Product(101,"Headphone","Electronics",5000,7.5,"Phonewala")
        };
        Func<Product, double> Discount = p => (p.price * p.discount) / 100.00;
        Func<Product, double> FinalPrice = p => p.price - (p.price * p.discount) / 100.00;
        Action<Product> DisplayProduct = p =>
        {
            Console.WriteLine("ProductId : " + p.Id);
            Console.WriteLine("Product Name : " + p.name);
            Console.WriteLine("Product Category : " + p.category);
            Console.WriteLine("Price : " + p.price);
            Console.WriteLine("Discount : " + p.discount);
            Console.WriteLine("store : " + p.store);
            Console.WriteLine("Discount : " + Discount(p));
            Console.WriteLine("Final Price : " + FinalPrice(p));
        };

        foreach (Product product in ProductList)
        {
            DisplayProduct(product);

        }
    }
}
