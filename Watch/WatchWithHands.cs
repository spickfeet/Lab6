using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch
{
    public class WatchWithHands
    {
        public void GetAngleOfRotation(Time currentTime,Time realTime)
        {
            int currentMin = currentTime.Hour * 60 + currentTime.Minute;
            int realMin = realTime.Hour * 60 + realTime.Minute;
            if (realMin < currentMin)
            {
                Console.WriteLine(360 * 12 - (currentMin - realMin) * 6);
                return;
            }
            Console.WriteLine((realMin - currentMin) * 6);
        }
    }
}
