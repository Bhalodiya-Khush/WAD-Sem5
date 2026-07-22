using System;

namespace Program3
{
    public delegate double CalculatorDelegate(double a, double b);

    class Calculator
    {
        public event CalculatorDelegate Calculate;

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not possible.");
                return 0;
            }
            return a / b;
        }

        public void PerformCalculation(double a, double b)
        {
            if (Calculate != null)
            {
                foreach (CalculatorDelegate del in Calculate.GetInvocationList())
                {
                    Console.WriteLine("Result = " + del(a, b));
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    c.Calculate += c.Add;
                    break;

                case 2:
                    c.Calculate += c.Subtract;
                    break;

                case 3:
                    c.Calculate += c.Multiply;
                    break;

                case 4:
                    c.Calculate += c.Divide;
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            c.PerformCalculation(num1, num2);

            Console.ReadKey();
        }
    }
}