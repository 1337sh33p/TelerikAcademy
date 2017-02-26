using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string TF = "true";
        if (number == 0 || number == 1)
        {
            TF = "false";
        }
        else if (number <= 1 || number >= 100)
        {
            TF = "false";
        }
        else
        {
            for (int x = 2; x <= Math.Sqrt(number); x++)
            {
                if (number % x == 0)
                {
                    TF = "false";
                }
            }
        }
        Console.WriteLine(TF);
    }
}