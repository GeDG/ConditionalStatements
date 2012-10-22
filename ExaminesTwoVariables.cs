using System;

class ExaminesTwoVariables
{
    static void Main()
    {
        Console.WriteLine("Enter first variable");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second variable");
        int b = int.Parse(Console.ReadLine());
        int k;
        if (a > b)
        {
            k = a;
            a = b;
            b = k;
        }
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

