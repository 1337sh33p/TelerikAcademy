using System;

namespace MMSA_Of_N_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double min= double.MaxValue;
            double max= double.MinValue;

            double number;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());

                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;

            }
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", sum/n);
        }
    }
}