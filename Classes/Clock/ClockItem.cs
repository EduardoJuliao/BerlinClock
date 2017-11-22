using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class ClockItem : IClockItem
    {
        public int CurrentValue { get; internal set; }
        public int MaxValue { get; internal set; }
        public int? Divider { get; internal set; }
        public char Color { get; internal set; }
        public char? AltColor { get; internal set; }
    }
}
