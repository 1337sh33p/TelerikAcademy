using System;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] first = new int[size];
            int[] second = new int[size];
            bool areEqual = false;

            for (int i = 0; i <= size -1; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= size-1; i++)
            {
                second[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= size-1; i++)
            {
                if (first[i] != second[i])
                {
                    areEqual = false;
                    break;
                }
                else
                {
                    areEqual = true;
                }
            }
            if (areEqual == true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
