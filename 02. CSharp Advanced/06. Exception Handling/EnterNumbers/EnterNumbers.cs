using System;

class EnterNumbers
{
    static void Main()
    {
        //input
        int[] numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int[] check = new int[10];
        //logic
        try
        {
            for (int i = 1; i < 10; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    check[i - 1] = numbers[i - 1];
                    check[i] = numbers[i];
                }
                else if (numbers[i - 1] >= numbers[i])
                {
                    throw new Exception();
                }
            }
            if (check[9] != 0 && check[9] <= 99)
            {
                Console.Write("1 <");
                foreach (var num in check)
                {
                    Console.Write(" {0} <", num);
                }
                Console.WriteLine(" 100");
            }
            else
            {
                throw new Exception();
            }

        }
        catch (Exception)
        {

            Console.WriteLine("Exception");
        }
    }
}