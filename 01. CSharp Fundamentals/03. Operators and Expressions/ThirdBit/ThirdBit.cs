using System;

class ThirdBit
{
    static void Main()
    {
        int possition = 3;
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << possition;
        int numAndMask = number & mask;
        int thirdBit = numAndMask >> possition;

        Console.WriteLine(thirdBit);
    }
}