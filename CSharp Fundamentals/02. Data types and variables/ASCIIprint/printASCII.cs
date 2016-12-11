using System;

namespace ASCIIprint
{
    class printASCII
    {
        static void Main()
        {
            for (byte number = 33; number <= 126; number++)
                {
                Console.Write((char)number);
                }
        }
    }
}