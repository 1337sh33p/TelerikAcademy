using System;
using System.Numerics;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            BigInteger number;
            BigInteger i;
            BigInteger binaryN = 0;

            number = BigInteger.Parse(Console.ReadLine());
            i = 1;

            for (BigInteger j = number; j > 0; j=j/2)
            {
                binaryN = binaryN + (number % 2) * i;
                i = i * 10;
                number = number / 2;
            }
            Console.WriteLine(binaryN);
        }
    }
}
