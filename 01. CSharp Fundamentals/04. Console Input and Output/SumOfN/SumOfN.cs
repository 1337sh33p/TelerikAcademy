using System;

namespace SumOfN
{
    class SumOfN
    {
        static void Main()
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            double sumOfNumber = 0.00;
                
            for (int i = 0; i < numberOfNumbers; i++)
            {
               double number = double.Parse(Console.ReadLine());
                sumOfNumber += number;
            }
            Console.WriteLine(sumOfNumber);
        }
    }
}
