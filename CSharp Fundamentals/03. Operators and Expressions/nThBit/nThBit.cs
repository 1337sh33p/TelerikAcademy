using System;

class nThBit
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        int possition = int.Parse(Console.ReadLine());
        long mask = 1 << possition;
        long numAndMask = number & mask;
        long thirdBit = numAndMask >> possition;

        Console.WriteLine(thirdBit);
    }
}