using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch
{
    public class WatchWithHandsAdapter : ITimeSettings
    {
        private WatchWithHands _watchWithHands;
        public WatchWithHandsAdapter(WatchWithHands watchWithHands)
        {
            _watchWithHands = watchWithHands;
        }

        public void GetTimeSettings(Time currentTime, Time realTime)
        {
            _watchWithHands.GetAngleOfRotation(currentTime, realTime);
        }
    }
}
