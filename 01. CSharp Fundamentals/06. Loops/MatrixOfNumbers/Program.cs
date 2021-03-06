﻿using System;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int countCol = 1;
            if (n < 1 || n > 20)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < 2 * n; j++)
                {
                    if (countCol <= n)
                    {
                        Console.Write("{0} ", j);
                        countCol++;
                    }
                }
                Console.WriteLine();
                countCol = 1;
            }
        }
    }
}
