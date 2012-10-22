using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter first coeff");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second coeff");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third coeff");
        double c = double.Parse(Console.ReadLine());
        
        double D = b * b - 4 * a * c;
        double x1;
        double x2;
        if (D < 0)
        {
            Console.WriteLine("no roots");
            return;
        }
        if (D == 0) 
        {
            Console.WriteLine("1 root");
            x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine(x1);
            return;
        }
        x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
        x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine("x1= " + x1 + " x2= " + x2);
    }
}

