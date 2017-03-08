using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobbyAvokadoto
{
    class Startup
    {
        static void Main()
        {
            uint theHead = uint.Parse(Console.ReadLine());
            uint combCount = uint.Parse(Console.ReadLine());

            int bestComb = 0;
            int bestBitCount = 0;

            for (int i = 0; i < combCount; i++)
            {
                int comb = int.Parse(Console.ReadLine());
                if ((theHead & comb) == 0)
                {
                    int currentBitCount = 0;
                    string combAsString = Convert.ToString(comb, 2);
                    for (int j = 0; j < combAsString.Length; j++)
                    {
                        if (combAsString[j] == '1')
                        {
                            currentBitCount++;
                        }
                    }
                    if (currentBitCount > bestBitCount)
                    {
                        bestBitCount = currentBitCount;
                        bestComb = comb;
                    }
                }
            }
            Console.WriteLine(bestComb);
        }
    }
}
