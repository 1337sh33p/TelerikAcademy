using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int NumberToPrint;
            for (int x = 2; x <= 11; x++)
            {
                if (x % 2 == 0)
                {
                    NumberToPrint = x;
                }
                else
                {
                    NumberToPrint = x * (-1);
                }
                Console.WriteLine(NumberToPrint);
            }
        }
    }
}
