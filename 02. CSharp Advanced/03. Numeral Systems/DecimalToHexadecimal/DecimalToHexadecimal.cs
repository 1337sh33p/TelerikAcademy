using System;

class DecimalToHexadecimal
{
    static string ConvertDecimalToHexadecimal(long num)
    {
        string hex = string.Empty;

        while (num > 0)
        {
            long check = num % 16;
            switch(num%16)
            {
                case 10: hex = "A" + hex;  break;
                case 11: hex = "B" + hex; break;
                case 12: hex = "C" + hex; break;
                case 13: hex = "D" + hex; break;
                case 14: hex = "E" + hex; break;
                case 15: hex = "F" + hex; break;
                default: hex = num % 16 + hex; break;
            }
            num >>= 4;
        }
        return hex;
    }

    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToHexadecimal(number));
    }
}
