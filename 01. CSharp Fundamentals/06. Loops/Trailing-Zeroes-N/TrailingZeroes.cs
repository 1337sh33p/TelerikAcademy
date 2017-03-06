using System;

namespace Trailing_Zeroes_N
{
    class TrailingZeroes
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int temp = 0;
            int zeroes = 0;

            while (Math.Pow(5,temp)<N)
            {
                temp++;
                zeroes += N / (int)(Math.Pow(5, temp));
            }
            Console.WriteLine(zeroes);
        }
    }
}
