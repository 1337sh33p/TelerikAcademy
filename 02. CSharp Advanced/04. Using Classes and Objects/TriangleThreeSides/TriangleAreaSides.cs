using System;

class TriangleAreaSides
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double s = (a + b + c) / 2.0;
        double result = s * (s - a) * (s - b) * (s - c);
        result = Math.Sqrt(result);

        Console.WriteLine("{0:F2}", result);
    }
}
