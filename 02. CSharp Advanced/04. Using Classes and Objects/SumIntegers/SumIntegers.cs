using System;


class SumIntegers
{
    static ulong Sum(string n)
    {
        string[] numbers = n.Split(' ');
        uint[] integers = new uint[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            bool isNumber = uint.TryParse(numbers[i], out integers[i]);
        }
        ulong sumOfNumbers = 0;
        foreach (var number in integers)
        {
            sumOfNumbers += number;
        }
        return sumOfNumbers;
    }
    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(Sum(input));
    }
}
