using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch
{
    public class WatchDigital : ITimeSettings
    {
        public void GetTimeSettings(Time currentTime, Time realTime)
        {
            Console.WriteLine($"Переведите часы на:\n{realTime.Hour - currentTime.Hour} часов\n{realTime.Minute - currentTime.Minute} минут");
        }
    }
}
