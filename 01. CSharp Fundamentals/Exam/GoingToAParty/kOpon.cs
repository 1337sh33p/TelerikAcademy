using System;

namespace GoingToAParty
{
    class kOpon
    {
        static void Main()
        {
            int movement = 0;
            int position = 0;

            string direction = Console.ReadLine();
            char[] directions = direction.ToCharArray();
            for (int i = 0; i < directions.Length;)
            {
                if (directions[i] == 94)
                {
                    Console.WriteLine("Djor and Djano are at the party at {0}!", position);
                    break;
                }
                else if (directions[i] >= 65 && directions[i] <= 90)
                {
                    movement = directions[i] - 64;
                    position -= movement;
                    i = position;

                    if (position < 0)
                    {
                        Console.WriteLine("Djor and Djano are lost at {0}!", position);
                        break;
                    }
                }
                else if (directions[i] >= 97 && directions[i] <= 122)
                {
                    movement = directions[i] - 96;
                    position += movement;
                    i = position;

                    if (position > directions.Length)
                    {
                        Console.WriteLine("Djor and Djano are lost at {0}!", position);
                        break;
                    }
                }
            }
        }
    }
}
