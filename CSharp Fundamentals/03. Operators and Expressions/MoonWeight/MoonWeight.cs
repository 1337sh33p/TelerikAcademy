using System;

class MoonWeight
{
    static void Main()
    {
        float weight = float.Parse(Console.ReadLine());
        float gravity = 0.17f;
        float moonWeight = (weight * gravity);
        Console.WriteLine("{0:0.000}", moonWeight);
    }
}