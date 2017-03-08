using System;


class DecimalToBinary
{
    static string ConvertDecimalToBinary(long num)
    {
        string binary = string.Empty;

        while (num > 0)
        {
            binary = (num % 2) + binary;
            num >>= 1;
        }
        return binary;
    }
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToBinary(number));
    }
}