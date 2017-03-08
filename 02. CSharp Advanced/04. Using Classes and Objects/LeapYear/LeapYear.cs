using System;


class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        if (year % 4 != 0)
        {
            Console.WriteLine("Common");
        }
        else if (year % 100 != 0)
        {
            Console.WriteLine("Leap");
        }
        else if (year % 400 != 0)
        {
            Console.WriteLine("Common");
        }
        else
        {
            Console.WriteLine("Leap");
        }
    }
}
