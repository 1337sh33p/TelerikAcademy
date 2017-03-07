using System;
using System.Numerics;

namespace CalculateThree
{
    class Program
    {
        public static BigInteger FactorialCalculator(int number)
        {
            BigInteger result = 1;
            int factorial = 1;

            while (factorial <= number)
            {
                result *= factorial;
                factorial++;
            }

            return result;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger result = FactorialCalculator(n) / (FactorialCalculator(k) * (FactorialCalculator(n - k)));

            Console.WriteLine(result);
        }
    }
}
