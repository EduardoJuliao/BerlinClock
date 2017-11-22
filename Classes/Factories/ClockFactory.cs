using System.Collections.Generic;

namespace BerlinClock.Classes
{
    public class ClockFactory
    {
        readonly IList<IClockItem> Items;

        public ClockFactory()
        {
            Items = new List<IClockItem>();
        }

        public ClockFactory AddHour(IClockHour hour)
        {
            Items.Add(new ClockItem
            {
                Color = hour.Color,
                CurrentValue = hour.CurrentValue,
                MaxValue = hour.MaxValue
            });
            return this;
        }

        public ClockFactory AddMinute(IClockMinute minute)
        {
            Items.Add(new ClockItem
            {
                Color = minute.Color,
                CurrentValue = minute.CurrentValue,
                MaxValue = minute.MaxValue,
                AltColor = minute.AltColor,
                Divider = minute.Divider
            });
            return this;
        }

        public IList<IClockItem> BuildClock()
        {
            return this.Items;
        }

    }
}
