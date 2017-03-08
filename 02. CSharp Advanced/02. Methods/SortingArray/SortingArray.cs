using System;

class SortingArray
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

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] sortArray = CreateArray(N);
        Array.Sort(sortArray);
        foreach (var n in sortArray)
        {
            Console.Write("{0} ",n);
        }
    }
}