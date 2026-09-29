using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter First Number : ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Addition = " + (a + b));
        Console.WriteLine("Subtraction = " + (a - b));
        Console.WriteLine("Multiplication = " + (a * b));
        if (b != 0)
            Console.WriteLine("Division = " + (a / b));
        else
            Console.WriteLine("Division by Zero is not Allowed.");
    }
}