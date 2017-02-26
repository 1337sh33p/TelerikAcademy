using System;

namespace Interval
{
    class Interval
    {
        static void Main()
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = min + 1; i < max; i++)
            {
                if (i % 5 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
