using System;

class AddingPolynomials
{
    static int[] AddPolynoms(int[] a, int[] b) // adds the two arrays and outputs polynomials in an array
    {
        int[] addedPolys = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            addedPolys[i] = a[i] + b[i];
        }
        return addedPolys;
    }

    static int[] CreateArray(int l) // outputs an array with lenght of the inputed number and asks for that many numbers
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
        int N = int.Parse(Console.ReadLine());
        foreach (var n in AddPolynoms(CreateArray(N), CreateArray(N)))
        {
            Console.Write("{0} ",n);
        }
    }
}
