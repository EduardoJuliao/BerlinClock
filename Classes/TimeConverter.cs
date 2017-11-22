using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        /// <summary>
        /// Convert a given time to Berlin clock format
        /// </summary>
        /// <param name="aTime">time input</param>
        /// <returns></returns>
        public string convertTime(string aTime)
        { 
            var split = aTime.Split(':');
            int hour, minute, second;
            hour = split.Length > 0 ? Convert.ToInt32(split[0]) : 0;
            minute = split.Length > 1 ? Convert.ToInt32(split[1]): 0;
            second = split.Length > 2 ? Convert.ToInt32(split[2]) : 0;
            if (hour == 24 && minute > 0)
                hour = 0;

            var clockItems = CreateClock(hour, minute);

            var sb = new StringBuilder();
            sb.AppendLine("\"\"\"");
            sb.Append(second % 2 == 0 ? "Y" : "O");
            foreach (IClockItem item in clockItems)
            {
                sb.AppendLine();

                for (var i = 0; i < item.MaxValue; i++)
                {
                    if (i < item.CurrentValue)
                    {
                        if (item.Divider != null && i > 0 && (i + 1) % Convert.ToInt32(item.Divider) == 0)
                            sb.Append(item.AltColor);
                        else
                            sb.Append(item.Color);
                    }
                    else
                    {
                        sb.Append("O");
                    }
                }
            }
            sb.AppendLine();
            sb.AppendLine("\"\"\"");
            return sb.ToString();
        }

        /// <summary>
        /// Create All Berlin clock rows
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <returns></returns>
        static IEnumerable<IClockItem> CreateClock(int hour, int minute)
        {
            var FHour = hour / 5;
            var SHour = hour - (FHour * 5);
            var FMin = minute / 5;
            var SMin = minute - (FMin * 5);

            return new ClockFactory()
                .AddHour(new Hour(FHour))
                .AddHour(new Hour(SHour))
                .AddMinute(new Minute(FMin, 11, 3))
                .AddMinute(new Minute(SMin, 4))
                .BuildClock();
        }
    }
}
