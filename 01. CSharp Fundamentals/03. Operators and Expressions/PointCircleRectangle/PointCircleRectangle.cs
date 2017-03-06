using System;

class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double a = (1 - x);
        double b = (1 - y);

        double result = Math.Sqrt(a * a + b * b);
        if (result <= 1.5 && result >= 0)
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }
        if ((-1 <= x && x <= 5) && (-1 <= y && y <= 1))
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }
    }
}