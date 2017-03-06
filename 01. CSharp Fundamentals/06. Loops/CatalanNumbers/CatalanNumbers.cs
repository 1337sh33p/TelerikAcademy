using System;
using System.Numerics;


namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int catNumber = int.Parse(Console.ReadLine());
            BigInteger fact2N = 1;
            BigInteger factN1 = 1;
            BigInteger factN = 1;
            
            for (int i = 1; i <= 2 * catNumber; i++)
            {
                fact2N *= i;
                if (i <= catNumber)
                {
                    factN *= i;
                }
            }
            for (int i = 1; i <= catNumber + 1; i++)
            {
                factN1 *= i;
            }
            Console.WriteLine("{0}", fact2N / (factN1 *
    factN));
        }
    }
}
