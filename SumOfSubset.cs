using System;

class SumOfSubset
{

    static void FindNumbers(int[] list, int index, int current, int sum, ref int howMany)
    {
        if (list.Length < index)
            return;
        for (int i = index; i < list.Length; i++)
        {
            if (current + list[i] == sum)
            {
                howMany++;
                if (list[i] <= 0)
                {
                    FindNumbers(list, i + 1, current + list[i], sum, ref howMany);
                }
            }
            else if (list[i] <= 0 || current + list[i] < sum)
            {
                FindNumbers(list, i + 1, current + list[i], sum, ref howMany);
            }
        }
    }



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
        Array.Sort(arr);

        int br = 0;

        FindNumbers(arr,0,0,0,ref br);
        if (br != 0)
        {
            Console.WriteLine("We have subset " + br);
        }
        else 
        {
            Console.WriteLine("Nu subsets");
        }
    }
}

