using System;
using System.Text;

namespace BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            var inputNumber = short.Parse(Console.ReadLine());
            bool isPositive = inputNumber >= 0;
            if (isPositive)
            {
            Console.WriteLine(ShortToBinary(inputNumber));
            }
            else
            {

                string negative = Convert.ToString(inputNumber, 2);
                Console.WriteLine(negative);
            }

        }

        static string ShortToBinary(int N)
        {
            var number = N;

                string binNum = "";
            do
            {
                StringBuilder binNumber = new StringBuilder();
                binNumber.Append((number % 2) + binNum);
                number /= 2;
                binNum = binNumber.ToString();

            } while (number != 0);

            while (binNum.Length < 16)
            {
                StringBuilder leading = new StringBuilder();
                leading.Append(binNum);
                leading.Insert(0, '0');
                binNum = leading.ToString();
            }
            return binNum;
        }
    }
}
