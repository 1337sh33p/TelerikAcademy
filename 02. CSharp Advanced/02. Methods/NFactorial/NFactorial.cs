using System;
using System.Numerics;

class NFactorial
{
    static BigInteger CalculateFactorial(int x)
    {
        int[] factorial = new int[x];
        int counter = 1;
        BigInteger fact = 1;
        for (int i = 0; i < x; i++)
        {
            factorial[i] = counter;
            counter++;
            fact *= factorial[i];
        }
        return fact;
    }

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(CalculateFactorial(N));
    }
}
