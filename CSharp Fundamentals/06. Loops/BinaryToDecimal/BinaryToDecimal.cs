using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            BigInteger n, p = 1, dec = 0, i = 1, d;
            n = BigInteger.Parse(Console.ReadLine());
            for (BigInteger j = n; j > 0 ; j = j / 10)
            {
                d = j % 10;
                    if(i == 1)
                    {
                    p = p * 1;
                    }
                    else
                    {
                    p = p * 2;
                    }
                dec = dec + (d * p);
                i++;
            }
            Console.WriteLine(dec);
        }
    }
}
