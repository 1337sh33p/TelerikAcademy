using System;

class SquareRoot
{
    static double Sqrt(double num)
    {
        if (num < 0)
        {
            throw new FormatException();
        }
        return Math.Sqrt(num);
    }
    static void Main()
    {

        try
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}