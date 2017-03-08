using System;

class NumberAsArray
{
    static int[] CreateArray(int lenght)
    {
        string numbers = Console.ReadLine();
        string[] arrayToBegining = numbers.Split(' ');
        int[] newArray = new int[lenght];
        for (int i = 0; i < arrayToBegining.Length; i++)
        {
            bool isInt = int.TryParse(arrayToBegining[i], out newArray[i]);
        }
        return newArray;
    }

    static int[] SumArrays(int[] a, int[] b)
    {
        int counter = 0;
        int[] Summed;
        if (a[a.Length-1] + b[b.Length-1] >= 10 || (a[a.Length-2] + b[b.Length-2])+1 >= 10)
        {
            Summed = new int[a.Length+1];
        }
        else
        {
            Summed = new int[a.Length];
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] + b[i] + counter >=10)
            {
                Summed[i] = (a[i] + b[i] + counter) % 10;
                counter = 1;
            }
            else if (a[i] + b[i] + counter < 10)
            {
                Summed[i] = a[i] + b[i] + counter;
                counter = 0;
            }
        }
        return Summed;
    }

    static void Main()
    {
        string arrayLenghts = Console.ReadLine();
        string[] lenghts = arrayLenghts.Split(' ');
        int first = int.Parse(lenghts[0]);
        int second = int.Parse(lenghts[1]);
        int bigger = Math.Max(first, second);

        int[] firstArr = CreateArray(bigger);
        int[] secondArr = CreateArray(bigger);

        int[] Summed = SumArrays(firstArr, secondArr);

        foreach (var num in Summed)
        {
            Console.Write("{0} ",num);
        }
    }
}
