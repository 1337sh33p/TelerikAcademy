using System;

class UnicodeCharacters
{
    static void Main()
    {
        var input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            string unichar = string.Format("\\u{0:X4}", (int)input[i]);
            Console.Write("{0}", unichar);
        }
        Console.WriteLine();
    }
}