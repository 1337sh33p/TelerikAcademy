using System;


class BinaryToDecimal
{
    static long ConvertBinaryToDecimal(string b)
    {
        long power = 1;
        long dec = 0;
        for (int i = b.Length - 1; i >= 0; i--)
        {
            var digit = b[i] - '0';
            dec += digit * power;
            power <<= 1;
        }
        return dec;
    }

    static void Main(string[] args)
    {
        string bin = Console.ReadLine();
        Console.WriteLine(ConvertBinaryToDecimal(bin));
    }
}