using System;


class Sub_stringInText
{
    static void Main()
    {
        var thePattern = Console.ReadLine().ToLower();
        var theText = Console.ReadLine().ToLower();

        var counter = -1;
        var position = -1;

        do
        {
            position = theText.IndexOf(thePattern, position+1);
            counter++;

        } while (position != -1);

        Console.WriteLine(counter);
    }
}