using System;

namespace Odd_and_Even_Product
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string inputNumbers = Console.ReadLine();
            string[] splitNumbers = inputNumbers.Split(' ');

            int[] numbers = new int[n];
            long odd = 1;
            long even = 1;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(splitNumbers[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if(i % 2 ==0)
                {
                    odd *= numbers[i];
                }
                else
                {
                    even *= numbers[i];
                }
            }
            if (odd == even)
            {
                Console.WriteLine("yes {0}", odd);
            }
            else
            {
                Console.WriteLine("no {0} {1}", odd, even);
            }
  
        }
    }
}
