using System;

class DivideSevenFive
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        if (x % 35 == 0)
        {
            Console.WriteLine("true " + x);
        }
        else
        {
            Console.WriteLine("false " + x);
        }
    }
}