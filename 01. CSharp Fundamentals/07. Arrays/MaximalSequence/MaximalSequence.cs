using System;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            int maxCount = 0;
            int currentCount = 1;
            int sequence = 0;

            for (int i = 0; i < number; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (i != 0)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        sequence = i + 1 - maxCount;
                    }
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}
            