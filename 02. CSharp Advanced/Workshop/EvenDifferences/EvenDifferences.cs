using System;
using System.Linq;

class EvenDifferences
{
    static void Main()
    {
        //input
        var numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(long.Parse)
                        .ToArray();
        //logic
        long[] absoluteDifferences = new long[numbers.Length];
        int ind = 0;

        for (int i = 1; i < numbers.Length;)
        {
            var absDiff = AbsoluteDifference(numbers[i - 1], numbers[i]);
            // if difference is even move 2 positions
            if (absDiff % 2 == 0)
            {
                i += 2;
            }
            // if difference is odd move 1 position
            else if (absDiff % 2 != 0)
            {
                i++;
            }
            
            absoluteDifferences[ind] = absDiff;
            ind++;
        }
        //result
        long finalResult = 0;
            //sum all even differences
        for (int i = 0; i < absoluteDifferences.Length; i++)
        {
            if (absoluteDifferences[i] % 2 == 0)
            {
                finalResult += absoluteDifferences[i];
            }
        }
        Console.WriteLine(finalResult);
    }

    static long AbsoluteDifference(long a, long b)
    {
        long result = 0;
        if (a > b)
        {
            result = a - b;
        }
        else
        {
            result = b - a;
        }
        return result;
    }
}