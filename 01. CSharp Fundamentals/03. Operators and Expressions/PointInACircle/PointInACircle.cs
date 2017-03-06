using System;

class PointInACircle
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double a = (0 - x);
        double b = (0 - y);

        double result = Math.Sqrt(a * a + b * b);
        if (result <= 2 && result >= 0)
        {
            Console.WriteLine("yes {0:F2}", result);
        }
        else
        {
            Console.WriteLine("no {0:F2}", result);
        }
    }
}