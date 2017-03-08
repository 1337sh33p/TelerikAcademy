using System;
using System.Text;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            var input = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            result.Append(input[0]);
            var counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == result[counter])
                {
                    continue;
                }
                else
                {
                    result.Append(input[i]);
                    counter++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
