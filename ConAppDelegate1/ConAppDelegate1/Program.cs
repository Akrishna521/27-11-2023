using System;

namespace ArithmeticOperations
{
    public delegate int ArithmeticOperation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperation operation;
            Console.WriteLine("Enter the arithmetic operation you want to perform:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    operation = Add;
                    break;
                case 2:
                    operation = Subtract;
                    break;
                case 3:
                    operation = Multiply;
                    break;
                case 4:
                    operation = Divide;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
            Console.WriteLine("Enter the first number:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            int result = operation(x, y);
            Console.WriteLine("The result is: {0}", result);

            Console.ReadKey();
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Subtract(int x, int y)
        {
            return x - y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }

        private static int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return x / y;
        }
    }
}
