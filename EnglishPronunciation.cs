using System;

   class EnglishPronunciation
{

    static string a, b, c;
    static void HelpNameSmall(int number)
    {
        switch (number)
        {
            case (0): a = "zero"; break;
            case (1): a = "one"; break;
            case (2): a = "two"; break;
            case (3): a = "three"; break;
            case (4): a = "four"; break;
            case (5): a = "five"; break;
            case (6): a = "six"; break;
            case (7): a = "seven"; break;
            case (8): a = "eight"; break;
            case (9): a = "nine"; break;
            case (10): a = "ten"; break;
            case (11): a = "eleven"; break;
            case (12): a = "twelve"; break;
        }
    }
     static void HelpNameBig(int number)
    {
        switch (number)
        {
            case (2): b = "twen"; break;
            case (3): b = "thir"; break;
            case (4): b = "four"; break;
            case (5): b = "fif"; break;
            case (6): b = "six"; break;
            case (7): b = "seven"; break;
            case (8): b = "eigh"; break;
            case (9): b = "nine"; break;
        }
    }

    static void NameOfNumber(int number)
    {
        if (number <= 12)
        {
            HelpNameSmall(number);
            Console.WriteLine('\"' + a + '\"');
        }
        else if (number > 12 && number < 20)
        {
            HelpNameBig(number % 10);
            Console.WriteLine('\"' + b + "teen" + '\"');
        }
        else if (number >= 20 && number < 100)
        {
            HelpNameBig(number / 10);
            HelpNameSmall(number % 10);
            if (a == "zero")
                Console.WriteLine('\"' + b + "ty" + '\"');
            else
                Console.WriteLine('\"' + b + "ty " + a + '\"');
        }
        else if (number >= 100 && number <= 999)
        {
            HelpNameSmall(number / 100);
            c = a;
            number = number % 100;
            if (number <= 12)
            {
                HelpNameSmall(number);
                Console.WriteLine('\"' + c + " hundred and " + a + '\"');
            }
            else if (number > 12 && number < 20)
            {
                HelpNameBig(number % 10);
                Console.WriteLine('\"' + c + " hundred and " + b + "teen" + '\"');
            }
            else if (number >= 20 && number < 100)
            {
                HelpNameBig(number / 10);
                HelpNameSmall(number % 10);
                if (a == "zero")
                    Console.WriteLine('\"' + c + " hundred and " + b + "ty" + '\"');
                else
                    Console.WriteLine('\"' + c + " hundred " + b + "ty " + a + '\"');
            }

        }

    }


    static void Main()
    {
        Console.WriteLine("Enter number with max 3 digits");
        int number = int.Parse(Console.ReadLine());
        NameOfNumber(number);
    }    
}

