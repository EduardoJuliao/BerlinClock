using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class Hour : IClockHour
    {

        public Hour(int value)
        {
            this.CurrentValue = value;
        }

        public int CurrentValue { get; }

        public int MaxValue => 4;

        public char Color => 'R';
    }
}
