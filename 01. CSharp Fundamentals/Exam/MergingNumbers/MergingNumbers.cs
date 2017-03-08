using System;

namespace MergingNumbers
{
    class MergingNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] digits = new int[N];
            int[] merged = new int[N - 1];
            int[] sum = new int[N - 1];
            int b = 0;
            int c = 0;
            int merg = 0;

            for (int i = 0; i < N; i++)
            {
                digits[i] = int.Parse(Console.ReadLine());
            }
            for (int k = 1; k < N; k++)
            {
                b = digits[k - 1] - ((digits[k - 1] / 10) * 10);
                c = digits[k] / 10;
                if (c == 0)
                {
                    b *= b * 10;
                }
                else
                {
                    merg = (b * 10) + c;
                    merged[k - 1] = merg;
                }
                
            }
            for (int j = 1; j < N; j++)
            {
                sum[j - 1] = digits[j] + digits[j - 1];
            }
                Console.WriteLine(String.Join(" ", merged));
                Console.WriteLine(String.Join(" ", sum));
        }
    }
}
