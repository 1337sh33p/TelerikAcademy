using System;

namespace GCD
{
    class GCD
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split();

            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int remainder;

            do
            {
                remainder = a % b;
                if (a % b == 0)
                {
                    Console.WriteLine(b);
                    break;
                }
                else
                {
                    a = b;
                    b = remainder;
                }
            }
                while (true) ;
        }
    }
}
