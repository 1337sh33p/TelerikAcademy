using System;

namespace MaximalIncreasingSequence
{
    class IncreasingSequence
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] numbers = new int[lenght];
            int sequence = 1;
            int maxSequence = 0;

            for (int index = 0; index < lenght; index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());

                if (index != 0)
                {
                    if(numbers[index] > numbers[index-1])
                    {
                        sequence++;
                    }
                    else
                    {
                        sequence = 1;
                    }
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                    }
                }
            }  
                Console.WriteLine(maxSequence);
        }
    }
}
