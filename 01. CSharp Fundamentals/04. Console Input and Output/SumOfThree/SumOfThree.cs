﻿using System;

namespace SumOfThree
{
    class SumOfThree
    {
        static void Main()
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double sum = first + second + third;
            Console.WriteLine(sum);
        }
    }
}
