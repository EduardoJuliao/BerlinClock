using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClockHour
    {
        int CurrentValue { get; }
        int MaxValue { get; }
        char Color { get; }
    }
}
