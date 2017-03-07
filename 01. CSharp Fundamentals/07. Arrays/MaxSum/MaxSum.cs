using System;

namespace MaxSum
{
    class MaxSum
    {
        public static int[] GenerateDataForArray(int[] array)
        {
            var result = array;
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        public static int GetMaxSum(int[] array,int numbersToSum)
        {
            int counter = 1;
            int result = 0;
            for (int i = array.Length -1; counter <= numbersToSum; i--)
            {
                result += array[i];
                counter++;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int K = int.Parse(Console.ReadLine());

            array = GenerateDataForArray(array);
            Array.Sort(array);

            int maxSum = GetMaxSum(array, K);
           
            Console.WriteLine(maxSum);
        }
    }
}
