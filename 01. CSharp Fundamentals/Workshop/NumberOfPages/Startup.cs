using System;

namespace NumberOfPages
{
    class Startup
    {
        static void Main()
        {
            int numberOfDigits = int.Parse(Console.ReadLine());
            int numberOfPages = 0;

            for (int page = 1; numberOfDigits != 0; page++)
            {
                numberOfPages++;
                numberOfDigits -= page.ToString().Length;
            }
            Console.WriteLine(numberOfPages);
        }
    }
}
