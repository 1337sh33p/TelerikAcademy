using System;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double answer = Math.Max(a, b);
            Console.WriteLine(answer);
        }
    }
}
