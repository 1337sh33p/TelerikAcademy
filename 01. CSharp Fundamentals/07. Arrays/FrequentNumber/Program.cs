using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class Program
    {
        public static int[] ApperanceCount(int[] array)
        {
            int count = 1;
            int maxCount = 0;
            int theNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    count = 1;
                    theNumber = array[i];
                }
                count = 1;
            }
            int[] result = new int[2];
            result[0] = maxCount;
            result[1] = theNumber;
            return result;
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] result = ApperanceCount(array);
            Console.WriteLine("{0} ({1} times)", result[1], result[0]);
        }
    }
}
