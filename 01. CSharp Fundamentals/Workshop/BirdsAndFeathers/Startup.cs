using System;

namespace BirdsAndFeathers
{
    class Startup
    {
        static void Main()
        {
            int birds = int.Parse(Console.ReadLine());
            int feathers = int.Parse(Console.ReadLine());
            double averageNumberOfFeathers = feathers / (double)birds;

            double result;

            if (birds % 2 == 0)
            {
                result = averageNumberOfFeathers * 123123123123;
            }
            else
            {
                result = averageNumberOfFeathers / 317;
            }

            Console.WriteLine("{0:F4}", result);
        }
    }
}
