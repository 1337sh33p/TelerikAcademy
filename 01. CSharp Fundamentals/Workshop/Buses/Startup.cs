using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    class Startup
    {
        static void Main()
        {
            int numberOfBuses = int.Parse(Console.ReadLine());
            int groupsOfBussesCount = 0;
            int currentBusSpeed = 1500;

            for (int i = 0; i < numberOfBuses; i++)
            {
                int speedOfBus = int.Parse(Console.ReadLine());
                if (speedOfBus < currentBusSpeed)
                {
                    groupsOfBussesCount++;
                    currentBusSpeed = speedOfBus;
                }
                else if (speedOfBus == currentBusSpeed)
                {
                    groupsOfBussesCount++;
                    currentBusSpeed = speedOfBus;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(groupsOfBussesCount);
        }
    }
}
