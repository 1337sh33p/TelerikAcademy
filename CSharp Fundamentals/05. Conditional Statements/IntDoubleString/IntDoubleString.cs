using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string choice = Console.ReadLine();
            string value = Console.ReadLine();
            int whole;
            double real;
            Int32.TryParse(value, out whole);
            Double.TryParse(value, out real);

            switch (choice)
            {
                case "integer": Console.WriteLine("{0}", whole + 1); break;
                case "real": Console.WriteLine("{0:F2}", real + 1); break;
                case "text": Console.WriteLine("{0}", value + "*"); break;
            }
        }
    }
}
