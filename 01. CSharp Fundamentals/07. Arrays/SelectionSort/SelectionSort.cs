using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] Numbers = new int[N];
            int min, temp;

            for (int i = 0; i < N; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Numbers.Length; i++)
            {
                min = i;
                for (int j = i+1; j < Numbers.Length; j++)
                {
                    if (Numbers[j] < Numbers[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = Numbers[i];
                    Numbers[i] = Numbers[min];
                    Numbers[min] = temp;
                }
            }
                foreach (var Number in Numbers)
                {
                    Console.WriteLine(Number);
                }
        }
    }
}
