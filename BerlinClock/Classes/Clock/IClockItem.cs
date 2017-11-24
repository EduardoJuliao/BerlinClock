using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    /// <summary>
    /// A item from the clock
    /// </summary>
    public interface IClockItem : IClockHour, IClockMinute
    {
    }
}
