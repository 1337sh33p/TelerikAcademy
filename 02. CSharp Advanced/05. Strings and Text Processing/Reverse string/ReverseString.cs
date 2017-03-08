using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var output = input.Reverse();
        foreach (var s in output)
        {
            Console.Write(s);
        }
        Console.WriteLine();
    }
}
