using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class Minute : IClockMinute
    {
        public Minute(int value, int maxValue, int? divider = null)
        {
            this.CurrentValue = value;
            this.MaxValue = maxValue;
            this.Divider = divider;
        }

        public int CurrentValue { get; }

        public int MaxValue { get; }

        public char Color => 'Y';

        public int? Divider { get; }

        public char? AltColor => 'R';
    }
}
