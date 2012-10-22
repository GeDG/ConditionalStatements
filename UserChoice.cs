using System;

class UserChoice
{
    static void Main()
    {
        string choice = Console.ReadLine();
        double number;
        switch(double.TryParse(choice,out number)) 
        {
            case true: Console.WriteLine(number + 5); break;
            case false: Console.WriteLine(choice + '*'); break;
        }
        
    }
}
