using System;
using System.Text;

class StringLength
{
    static void StringChecker(string i)
    {
        if (i.Length == 20)
        {
            Console.WriteLine(i);
        }
        else if (i.Length < 20)
        {
        StringBuilder makeNew = new StringBuilder();
            makeNew.Append(i);
            for (int ind = 0; ind < 20-i.Length; ind++)
            {
                makeNew.Append('*');
            }
            Console.WriteLine(makeNew.ToString());
        }
    }

    static void Main()
    {
        var input = Console.ReadLine();
        StringChecker(input);
    }
}