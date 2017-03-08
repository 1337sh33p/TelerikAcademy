using System;

namespace Say_Hello
{
    class SayHello
    {
        static void Greetings(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            string name = Console.ReadLine();
            Greetings(name);
        }
    }
}
