using System;

namespace Allocate_array
{
    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] fives = new int[n];
            for (int i = 0; i <= n-1; i++)
            {
                fives[i] = 5 * i;
                Console.WriteLine(fives[i]);
            }

        }
    }
}
