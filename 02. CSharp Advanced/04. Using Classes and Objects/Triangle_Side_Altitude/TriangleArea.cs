using System;

class TriangleArea
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());
        double area = (side * hight) * 0.5;
        Console.WriteLine("{0:F2}", area);
    }
}
