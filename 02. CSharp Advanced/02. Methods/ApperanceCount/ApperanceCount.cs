using System;


class ApperanceCount
{
    static int ArrayChecker(int[] B, int X)
    {
        int counter = 0;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] == X)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string numbers = Console.ReadLine();
        string[] stringNumbers = numbers.Split(' ');
        int X = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[N];
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            bool isInt = int.TryParse(stringNumbers[i], out arrayOfNumbers[i]);
        }

        Console.WriteLine(ArrayChecker(arrayOfNumbers, X));
        
    }
}
