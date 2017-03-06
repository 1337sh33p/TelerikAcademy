using System;
using System.Numerics;

namespace Calculate_Again
{
    class Program
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());

            BigInteger difference = N - K;
            BigInteger factorial = K + 1;
            for (BigInteger i = factorial+1; i <=N; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
            
        }
    }
}
