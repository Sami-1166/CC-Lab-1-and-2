using System;

class ScientificCalculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Scientific Calculator");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Sine (sin)");
            Console.WriteLine("2. Cosine (cos)");
            Console.WriteLine("3. Tangent (tan)");
            Console.WriteLine("4. Logarithm (log)");
            Console.WriteLine("5. Exit");
            
            int choice = int.Parse(Console.ReadLine());

            if (choice == 5)
            {
                break;
            }

            Console.WriteLine("Enter the value (in degrees for trigonometric functions):");
            double value = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1: // Sine
                    result = Math.Sin(DegreeToRadian(value));
                    Console.WriteLine($"sin({value}) = {result}");
                    break;
                case 2: // Cosine
                    result = Math.Cos(DegreeToRadian(value));
                    Console.WriteLine($"cos({value}) = {result}");
                    break;
                case 3: // Tangent
                    result = Math.Tan(DegreeToRadian(value));
                    Console.WriteLine($"tan({value}) = {result}");
                    break;
                case 4: // Logarithm
                    if (value > 0)
                    {
                        result = Math.Log(value);
                        Console.WriteLine($"log({value}) = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Logarithm of non-positive numbers is undefined.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    // method to convert degrees to radians
    static double DegreeToRadian(double degree)
    {
        return degree * Math.PI / 180;
    }
}
