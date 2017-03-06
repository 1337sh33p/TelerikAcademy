using System;

namespace DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int numberOne;
            if (number == String.Empty)
            {
                Console.WriteLine("not a digit");
            }
            else if (Int32.TryParse(number, out numberOne) == false)
            {
                Console.WriteLine("not a digit");
            }
            else
            {
                Int32.TryParse(number, out numberOne);
                if (numberOne >= 0 && numberOne <= 9)
                {
                    switch (numberOne)
                    {
                        case 0: Console.WriteLine("zero"); break;
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;
                        default: Console.WriteLine("not a digit"); break;
                    }
                }
                else
                {
                    Console.WriteLine("not a digit");
                }
            }

        }
    }
}
