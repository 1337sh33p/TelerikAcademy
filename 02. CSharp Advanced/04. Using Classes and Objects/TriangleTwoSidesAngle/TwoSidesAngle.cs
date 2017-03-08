using System;


class TwoSidesAngle
{
    static double RadianToDegree(double radian)
    {
        return radian * (180.0 / Math.PI);
    }

    static double DegreeToRadian(double degree)
    {
        return Math.PI * degree / 180.0;
    }
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        var sin = Math.Sin(DegreeToRadian(angle));
        var area = 0.5 * (a * b) * sin;

        Console.WriteLine("{0:F2}", area);
    }
}
