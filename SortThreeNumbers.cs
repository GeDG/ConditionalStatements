using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        int c = int.Parse(Console.ReadLine());

        if (a <= b && a <= c)
        {
            if (b < c)
                Console.WriteLine(a + " " + b + " " + c + " !");
            else
                Console.WriteLine(a + " " + c + " " + b + " !");
        }
        else if (b <= a && b <= c)
        {
            if (a < c)
                Console.WriteLine(b + " " + a + " " + c + " !");
            else
                Console.WriteLine(b + " " + c + " " + a + " !");
        }
        else
        {
            if (b < a)
                Console.WriteLine(c + " " + b + " " + a + " !");
            else
                Console.WriteLine(c + " " + a + " " + b + " !");
        }
    }
}
