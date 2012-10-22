using System;

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter points");
        int points = int.Parse(Console.ReadLine());
        int allPoints = 0;

        if (points >= 1 && points <= 3)
        {
            allPoints += 10 * points;
            Console.WriteLine(allPoints);
        }
        else if (points >= 4 && points <= 6)
        {
            allPoints += 100 * points;
            Console.WriteLine(allPoints);
        }
        else if (points >= 7 && points <= 9)
        {
            allPoints += 1000 * points;
            Console.WriteLine(allPoints);
        }
        else if (points > 9 || points == 0) 
        {
            Console.WriteLine("ERROR!!!");
        }
    }
}

