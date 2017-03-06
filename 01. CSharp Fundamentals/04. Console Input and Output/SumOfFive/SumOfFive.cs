using System;

namespace SumOfFive
{
    class SumOfFive
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int fifth = int.Parse(Console.ReadLine());
            int sum = first + second + third + fourth + fifth;
            Console.WriteLine(sum);
        }
    }
}
