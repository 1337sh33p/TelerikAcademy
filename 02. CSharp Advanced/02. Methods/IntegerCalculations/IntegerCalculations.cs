using System;

class IntegerCalculations
{
    static int Min(int[] a)
    {
        int lowest = int.MaxValue;
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] < a[i + 1] && lowest > a[i])
            {
                lowest = a[i];
            }
            else if (lowest > a[i+1])
            {
                lowest = a[i + 1];
            }
        }
        return lowest;
    }

    static int Max(int[] a)
    {
        int highest = int.MinValue;
        for (int i = 0; i < a.Length - 1; i++)
        {
            if(a[i] > a[i+1] && highest < a[i])
            {
                highest = a[i];
            }
            else if(highest < a[i+1])
            {
                highest = a[i + 1];
            }
        }
        return highest;
    }

    static double Average(int[] a)
    {
        double avg = 0;
        foreach (var index in a)
        {
            avg += index;
        }
        avg /= a.Length;
        return avg;
    }
    static int Sum (int[] a)
    {
        int sum = 0;
        foreach (var item in a)
        {
            sum += item;
        }
        return sum;
    }

    static long Product(int[] a)
    {
        long product = 1;
        foreach (var item in a)
        {
            product *= item;
        }
        return product;
    }

    static int[] CreateArray(int l)
    {
        string numbers = Console.ReadLine();
        string[] arrayToBegining = numbers.Split(' ');
        int[] newArray = new int[l];
        for (int i = 0; i < arrayToBegining.Length; i++)
        {
            bool isInt = int.TryParse(arrayToBegining[i], out newArray[i]);
        }
        return newArray;
    }

    static void Main()
    {
        int[] numbers = CreateArray(5);
        Console.WriteLine(Min(numbers));
        Console.WriteLine(Max(numbers));
        Console.WriteLine("{0:F2}",Average(numbers));
        Console.WriteLine(Sum(numbers));
        Console.WriteLine(Product(numbers));
    }
}
