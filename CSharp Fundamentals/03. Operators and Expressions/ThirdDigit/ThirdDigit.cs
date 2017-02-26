using System;

class ThirdDigit
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = (a / 100);
        int c = (b % 10);
        if (c == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + c);
        }
    }
}