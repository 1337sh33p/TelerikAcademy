using System;

namespace CircleAreaPerimeter
{
    class CircleAreaPerimeter
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * (radius * radius);
            double circumference = (Math.PI + Math.PI) * radius;
            Console.WriteLine("{1:0.00} {0:0.00}", area, circumference);
        }
    }
}
