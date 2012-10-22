using System;

class SignOfThreeReal
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        double c = double.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
            Console.WriteLine('+');
        else if (a < 0 && b < 0 && c < 0)
            Console.WriteLine('+');
        else if (a > 0 && b > 0 && c < 0)
            Console.WriteLine('-');
        else if (a > 0 && b < 0 && c > 0)
           Console.WriteLine('-');
        else if (a < 0 && b > 0 && c > 0)
            Console.WriteLine('-');
        else if (a < 0 && b < 0 && c > 0)
            Console.WriteLine('+');
        else if (a < 0 && b > 0 && c < 0)
            Console.WriteLine('+');
        else if (a > 0 && b < 0 && c < 0)
            Console.WriteLine('+');
    }
}
