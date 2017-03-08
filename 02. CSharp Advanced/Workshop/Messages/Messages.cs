using System;
using System.Numerics;

class Messages
{
    static string Decrypt(string number)
    {
        string decryptNumber = string.Empty;
        string decimalNumber = string.Empty;

        for (int i = 0; i < number.Length - 2; i += 3)
        {
            decryptNumber = String.Join("", number[i], number[i + 1], number[i + 2]);
            string[] decrypt = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
            decimalNumber += Array.IndexOf(decrypt, decryptNumber);
            decryptNumber = string.Empty;
        }

        return decimalNumber;
    }

    static string Encrypt(BigInteger number)
    {
        string encrypt = string.Empty;

        while (number > 0)
        {
            BigInteger pos = number % 10;

            string[] encryptWith = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
            encrypt = encryptWith[(int)pos] + encrypt;
            number /= 10;
        }
        return encrypt;
    }

    static BigInteger ToNumber(string number)
    {
        BigInteger realNumber = 0;
        BigInteger power = 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int num = number[i] - '0';
            realNumber += num * power;
            power *= 10;
        }
        return realNumber;
    }

    static void Main()
    {
        string firstNumber = Console.ReadLine();
        char operation = char.Parse(Console.ReadLine());
        string secondNumber = Console.ReadLine();
        BigInteger value = 0;
        bool add = (operation == '+');
        BigInteger first = ToNumber(Decrypt(firstNumber));
        BigInteger second = ToNumber(Decrypt(secondNumber));

        if (add)
        {
            value = first + second;
        }
        else
        {
            value = first - second;
        }

        Console.WriteLine(Encrypt(value));
    }
}
