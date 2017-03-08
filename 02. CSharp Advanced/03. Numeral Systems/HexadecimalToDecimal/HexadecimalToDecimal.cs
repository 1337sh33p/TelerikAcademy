using System;

class HexadecimalToDecimal
{
    static long HexToDecimal(string a)
    {
        long power = 1;
        long dec = 0;

        for (int i = a.Length -1 ; i >= 0; i--)
        {
            if (a[i] == '1' || a[i] == '2' || a[i] == '3' || a[i] == '4' || a[i] == '5'|| a[i] == '6'|| a[i] == '7' || a[i] == '8' || a[i] == '9')
            {
                var digit = a[i] - '0';
                dec += digit * power;
                power <<= 4;
            }
            else if (a[i] == 'A' || a[i] == 'B' || a[i] == 'C' || a[i] == 'D' || a[i] == 'E' || a[i] == 'F')
            {
                var digit = a[i] - '7';
                dec += digit * power;
                power <<= 4;
            }
            else
            {
                power <<= 4;
            }
        }
        return dec;
    }

    static void Main()
    {
        string hexNumber = Console.ReadLine();

        Console.WriteLine(HexToDecimal(hexNumber));
    }
}
