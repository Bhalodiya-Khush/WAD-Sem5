using System;
namespace Program3
{
    class calculator
    {
        static void Main(String[] args)
        {
            Console.Write("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the operation (+, -, *, /):");
            char operation = Console.ReadLine()[0];
            
            switch(operation)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Result: " + (num1 / num2));
                    break;
                case '%':
                    Console.WriteLine("Result: " + (num1 % num2));
                    break;
            }
        }
    }
}
