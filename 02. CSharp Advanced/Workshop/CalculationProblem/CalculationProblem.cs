using System;
using System.Text;

class CalculationProblem
{
    static void Main()
    {
        //input
        var input23Base = Console.ReadLine();
        var split = input23Base.Split(' ');

        //logic
        var numberInDec = 0;
        var resultInDec = 0;
        for (int i = 0; i < split.Length; i++)
        {
            numberInDec = BaseTransform(23, split[i]);
            resultInDec += numberInDec;
            numberInDec = 0;
        }
        var finalInDec = resultInDec;
        StringBuilder resultIn23 = new StringBuilder();
        while (resultInDec > 0)
        {
            var number = resultInDec % 23;
            number += 'a';
            resultIn23.Insert(0,(char)number);
            resultInDec /= 23;
        }

        //result
        Console.WriteLine("{0} = {1}",resultIn23, finalInDec);
    }
    static int BaseTransform(int NumBase, string number)
    {
        int result = 0;
        foreach (var digit in number)
        {
            result = result * NumBase + (digit - 'a');
        }
        return result;
    }
}