using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class MyLongSequence
    {
        static void Main()
        {
            int PrintThisNumber;
            for (int x = 2; x <= 1001; x++) ;
            {
                if (x % 2 == 0) ;
                {
                    PrintThisNumber = x;
                }
                else
                {
                    PrintThisNumber = x * (-1);
                }
                Console.WriteLine(PrintThisNumber);
            }
                
        }
    }
}
