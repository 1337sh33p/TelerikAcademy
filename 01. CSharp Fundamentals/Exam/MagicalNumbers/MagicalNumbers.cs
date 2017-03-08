using System;

namespace MagicalNumbers
{
    class MagicalNumbers
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint oddOrEven = number / 10;
            bool even = true;
            uint first = 0, second = 0, third = 0;
            first = number / 100;
            second = (number - (first * 100)) / 10;
            third = (number - (first * 100)) - (second * 10);
            double sum = 0;
            double product = 1;

            if (oddOrEven % 2 == 0)
            {
                even = true;
                sum = (first + second) * (double)third;
                Console.WriteLine("{0:F2}", sum);
            }
            else
            {
                even = false;
                product = (first * second) / (double)third;
                Console.WriteLine("{0:F2}",product);
            }
        }
    }
}
