using System;

class CorrectBrackets
{
    static void BracketChecker(string i)
    {
        int counter = 0;
        foreach (var c in i)
        {
            if (c == '(')
            {
                counter += 1;
            }
            else if (c == ')')
            {
                counter -= 1;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
                
    }

    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        BracketChecker(input);
    }
}