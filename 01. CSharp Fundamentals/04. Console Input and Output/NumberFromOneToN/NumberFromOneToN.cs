using System;

namespace NumberFromOneToN
{
    class NumberFromOneToN
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint counter = 1;

            while (counter <= number)
            {
                Console.Write("{0} ",counter);
                counter++;
            }
        }
    }
}
