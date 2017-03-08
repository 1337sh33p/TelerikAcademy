using System;

class ReverseNumber
{
    static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        decimal X = decimal.Parse(Console.ReadLine());
        Console.WriteLine(Reverse(X.ToString()));    
    }
}
