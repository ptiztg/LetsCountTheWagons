using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCountTheWagons
{
    static class Human
    {
        private static int position = 0;
        private static int capacity = 0;
        public static bool movingForward = true;

        public static int Position { get => position; }
        public static int Capacity { get => capacity; }

        public static void CountWagons(Wagon start)
        {
            Wagon currentWagon = start;
            bool isHeadLightsOn = currentWagon.IsLightsOn;
            bool ready = false;

            while (!ready)
            {
                if (movingForward)
                {
                    currentWagon = currentWagon.NextWagon;
                    position++;
                    if (currentWagon.IsLightsOn == isHeadLightsOn)
                    {
                        currentWagon.IsLightsOn = !currentWagon.IsLightsOn;
                        capacity = position;
                        movingForward = false;
                    }
                }
                else
                {
                    if (position == 0)
                    {
                        if (currentWagon.IsLightsOn != isHeadLightsOn)
                            ready = true;
                        else
                            movingForward = true;
                    }
                    else
                    {
                        currentWagon = currentWagon.PrevWagon;
                        position--;
                    }
                }
            }
        }
    }
}
