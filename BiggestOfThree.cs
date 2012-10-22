using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        int c = int.Parse(Console.ReadLine());
        if (a > b && a > c)
            Console.WriteLine(a + " is max number");
        else if (b > a && b > c)
            Console.WriteLine(b + " is max number");
        else
            Console.WriteLine(c + " is max number");
    }
}

