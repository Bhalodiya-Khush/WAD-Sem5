using System;
using System.Threading.Tasks;

public class Calculator
{
    public double op1;
    public double op2;

    public async Task<double> AddAsync()
    {
        await Task.Delay(2000);
        return op1 + op2;
    }

    public async Task<double> SubAsync()
    {
        await Task.Delay(2000);
        return op1 - op2;
    }

    public async Task<double> MulAsync()
    {
        await Task.Delay(2000);
        return op1 * op2;
    }

    public async Task<double> DivAsync()
    {
        await Task.Delay(2000);

        if (op2 == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        return op1 / op2;
    }
}

public class Program
{
    public static async Task Main()
    {
        Calculator calc = new Calculator();

        Console.Write("Enter Operand 1: ");
        calc.op1 = double.Parse(Console.ReadLine());

        Console.Write("Enter Operand 2: ");
        calc.op2 = double.Parse(Console.ReadLine());

        Console.Write("Enter Operator (+, -, *, /)");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "+":
                double addition = await calc.AddAsync();
                Console.WriteLine("Addition: " + addition);
                break;

            case "-":
                double subtraction = await calc.SubAsync();
                Console.WriteLine("Subtraction: " + subtraction);
                break;

            case "*":
                double multiplication = await calc.MulAsync();
                Console.WriteLine("Multiplication: " + multiplication);
                break;

            case "/":
                double division = await calc.DivAsync();
                Console.WriteLine("Division: " + division);
                break;

            case "A":
            case "a":

                Console.WriteLine("\nExecuting all operations...");

                Task<double> additionTask = calc.AddAsync();
                Task<double> subtractionTask = calc.SubAsync();
                Task<double> multiplicationTask = calc.MulAsync();
                Task<double> divisionTask = calc.DivAsync();

                double[] results = await Task.WhenAll(
                    additionTask,
                    subtractionTask,
                    multiplicationTask,
                    divisionTask
                );

                Console.WriteLine("===== Results =====");
                Console.WriteLine($"Addition       : {results[0]}");
                Console.WriteLine($"Subtraction    : {results[1]}");
                Console.WriteLine($"Multiplication : {results[2]}");
                Console.WriteLine($"Division       : {results[3]}");

                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
