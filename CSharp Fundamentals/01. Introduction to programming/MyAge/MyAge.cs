using System;

namespace MyAge
{
    class MyAge
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthday in this format: Month.Day.Year");
            DateTime Birthday = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", System.Globalization.CultureInfo.InvariantCulture); // asks for birthday and accepts only valid DateTime format
            DateTime today = DateTime.Now; // makes a variable with the current date

                int MyAge = ((today - Birthday).Days / 365); // calculates the user's age based on the current date minus the input. after it divides it by 365 days in order to get the result in years
                int myFutureAge;
                myFutureAge = MyAge + 10;

            Console.WriteLine("Your age now is " + MyAge);
            Console.WriteLine("Your age in ten years will be: " + myFutureAge);
        }
    }
}