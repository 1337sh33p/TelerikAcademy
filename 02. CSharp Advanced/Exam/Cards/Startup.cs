using System;

namespace Cards
{
    class Startup
    {
        public static void EvenApperanceCardPrinter(bool[]cardApperance)
        {
            string[] cards = { "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
            "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
            "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
            "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"};

            for (int i = 0; i < 52; i++)
            {
                if (cardApperance[i] == false)
                {
                    if (i != 51)
                    {
                        Console.Write("{0} ",cards[i]);
                    }
                    else
                    {
                        Console.Write(cards[i]);
                    }
                }
            }
        }

        static void Main()
        {
            int numberOfHands = int.Parse(Console.ReadLine());

            bool[] evenApperance = new bool[52];
            bool[] cardsAlreadyMet = new bool[52];

            for (int hand = 1; hand <= numberOfHands; hand++)
            {
                ulong handInput = ulong.Parse(Console.ReadLine());

                for (int i = 0; i < 52; i++)
                {
                    if (((int)(handInput >> i) & 1) == 1)
                    {
                        cardsAlreadyMet[i] = true;
                        evenApperance[i] = !evenApperance[i];
                    }
                }
            }

            if (Array.IndexOf(cardsAlreadyMet, false) == -1)
            {
                Console.WriteLine("Full deck");
            }
            else
            {
                Console.WriteLine("Wa wa!");
            }
            EvenApperanceCardPrinter(evenApperance);
        }
    }
}
