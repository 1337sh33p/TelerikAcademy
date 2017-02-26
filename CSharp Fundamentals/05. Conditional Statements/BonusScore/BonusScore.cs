﻿/*Description

Write a program that applies bonus score to given score in the range [1…9] by the following rules:

    If the score is between 1 and 3, the program multiplies it by 10.
    If the score is between 4 and 6, the program multiplies it by 100.
    If the score is between 7 and 9, the program multiplies it by 1000.
    If the score is less than 0 or more than 9, the program prints "invalid score".

Input

    The only input line will contain one integer number - the score

Output

    Output the score with the applied bonus

Constraints

    The score will always be a valid integer number
    Time limit: 0.1s
    Memory limit: 16MB

Sample tests
Input 	Output
2 	20
4 	400
9 	9000
10 	invalid score*/

using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            uint score = uint.Parse(Console.ReadLine());

            if (score >= 1 && score <= 3)
            {
                Console.WriteLine(score * 10);
            }
            else if (score >= 4 && score <= 6)
            {
                Console.WriteLine(score * 100);
            }
            else if (score >= 7 && score <= 9)
            {
                Console.WriteLine(score * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
