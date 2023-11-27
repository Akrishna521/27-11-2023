using System;

public delegate T Operation<T>(T a, T b);

public static class Operations
{
    public static T Add<T>(T a, T b)
    {
        return (dynamic)a + (dynamic)b;
    }

    public static T Subtract<T>(T a, T b)
    {
        return (dynamic)a - (dynamic)b;
    }

    public static T Multiply<T>(T a, T b)
    {
        return (dynamic)a * (dynamic)b;
    }

    public static T Divide<T>(T a, T b)
    {
        return (dynamic)a / (dynamic)b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Operation<int> add = Operations.Add<int>;
        Operation<int> subtract = Operations.Subtract<int>;
        Operation<int> multiply = Operations.Multiply<int>;
        Operation<int> divide = Operations.Divide<int>;
        Console.WriteLine("Enter two integers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose an operation: ");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        int operation = int.Parse(Console.ReadLine());
        int result;
        switch (operation)
        {
            case 1:
                result = add(a, b);
                break;
            case 2:
                result = subtract(a, b);
                break;
            case 3:
                result = multiply(a, b);
                break;
            case 4:
                result = divide(a, b);
                break;
            default:
                throw new Exception("Invalid operation");
        }
        Console.WriteLine("The result is: {0}", result);
    }
}