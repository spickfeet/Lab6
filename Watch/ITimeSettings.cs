using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch
{
    public interface ITimeSettings
    {
        public void GetTimeSettings(Time currentTime, Time realTime);
    }
}
