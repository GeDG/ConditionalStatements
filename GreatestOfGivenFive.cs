using System;

class GreatestOfGivenFive
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number");
        int e = int.Parse(Console.ReadLine());

        int[] arr = new int[5];
        arr[0] = a;
        arr[1] = b;
        arr[2] = c;
        arr[3] = d;
        arr[4] = e;

        int max = arr[0];

        for (int i = 1; i < 5; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        Console.WriteLine(max);
    }
}

