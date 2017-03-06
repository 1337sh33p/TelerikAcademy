using System;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {
            string cardNumber = Console.ReadLine();
            int cardRank = 0;
            string faceCard = "";
            switch (cardNumber)
            {
                case "2": cardRank = 2; break;
                case "3": cardRank = 3; break;
                case "4": cardRank = 4; break;
                case "5": cardRank = 5; break;
                case "6": cardRank = 6; break;
                case "7": cardRank = 7; break;
                case "8": cardRank = 8; break;
                case "9": cardRank = 9; break;
                case "10": cardRank = 10; break;
                case "J": cardRank = 11; break;
                case "Q": cardRank = 12; break;
                case "K": cardRank = 13; break;
                case "A": cardRank = 14; break;
            }

            for (int face = 2; face <= cardRank; face++)
            {
                switch (face)
                {
                    case 2: faceCard = "2"; break;
                    case 3: faceCard = "3"; break;
                    case 4: faceCard = "4"; break;
                    case 5: faceCard = "5"; break;
                    case 6: faceCard = "6"; break;
                    case 7: faceCard = "7"; break;
                    case 8: faceCard = "8"; break;
                    case 9: faceCard = "9"; break;
                    case 10: faceCard = "10"; break;
                    case 11: faceCard = "J"; break;
                    case 12: faceCard = "Q"; break;
                    case 13: faceCard = "K"; break;
                    case 14: faceCard = "A"; break;
                }
                for (int suit = 0; suit < 4; suit++)
                {
                    switch (suit)
                    {
                        case 0:
                            Console.Write("{0} of spades, ", faceCard);
                            break;
                        case 1:
                            Console.Write("{0} of clubs, ", faceCard);
                            break;
                        case 2:
                            Console.Write("{0} of hearts, ", faceCard);
                            break;
                        case 3:
                            Console.WriteLine("{0} of diamonds", faceCard);
                            break;
                    }
                }
            }
        }
    }
}