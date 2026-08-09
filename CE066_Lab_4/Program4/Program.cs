using System;
public abstract class shape
{
    public abstract double calculateArea(int l, int b = 1);
}
public class circle : shape
{
    public override double calculateArea(int l, int b = 1)
    {
        return Math.PI * l * l;
    }
}
public class rectangle : shape
{
    public override double calculateArea(int l, int b = 1)
    {
        return l * b;
    }
}
public class Program4
{
    static void Main(string[] args)
    {
        rectangle r = new rectangle();
        Console.WriteLine("Enter dimensions for rectangle:");
        int length = int.Parse(Console.ReadLine());
        int breadth = int.Parse(Console.ReadLine());
        Console.WriteLine("Area of rectangle : " + r.calculateArea(length, breadth));
        Console.WriteLine("Enter radius for circle:");
        int radius = int.Parse(Console.ReadLine());
        circle c = new circle();
        Console.WriteLine("Area of circle : " + c.calculateArea(radius));
    }
}
