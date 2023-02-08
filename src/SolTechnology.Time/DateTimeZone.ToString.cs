using System.Globalization;
using System.Text;

namespace SolTechnology.Time
{
    public readonly partial record struct DateTimeZone
    {
        public override string ToString()
        {
            var dateTime = Date.ToDateTime(Time, DateTimeKind.Unspecified);

            var dateString = dateTime.ToString(CultureInfo.InvariantCulture);
            var zone = Zone.Id;
            return $"{dateString} ({zone})";
        }

        public string ToString(string format)
        {
            StringBuilder result = new StringBuilder();

            var dateTime = Date.ToDateTime(Time, DateTimeKind.Unspecified);

            var zIndex = format.IndexOf('z');
            int zCount = 0;
            if (zIndex >= 0)
            {
                zCount = FindCount(format, zIndex, 'z');
                format = format.Remove(zIndex, zCount);
            }

            result.Append(dateTime.ToString(format));
            FormatCustomizedTimeZone(Zone.BaseUtcOffset, zCount, result);

            return result.ToString();
        }

        // private DateTime GetUtcDateTime()
        // {
        //     var dateTime = TimeZoneInfo.ConvertTimeToUtc(Date.ToDateTime(Time, DateTimeKind.Utc));
        //     var utcOffset = Zone.GetUtcOffset(dateTime);
        //     dateTime = dateTime.Add(-utcOffset);
        //     return dateTime;
        // }

        internal static int FindCount(string format, int pos, char patternChar)
        {
            int len = format.Length;
            int index = pos + 1;
            while ((index < len) && (format[index] == patternChar))
            {
                index++;
            }

            return index - pos;
        }


        private static void FormatCustomizedTimeZone(TimeSpan offset, int count, StringBuilder result)
        {
            if (count == 0)
            {
                return;
            }
            if (offset.Ticks >= 0)
            {
                result.Append('+');
            }
            else
            {
                result.Append('-');
                // get a positive offset, so that you don't need a separate code path for the negative numbers.
                offset = offset.Negate();
            }

            if (count <= 1)
            {
                // 'z' format e.g "-7"
                result.Append(CultureInfo.InvariantCulture, $"{offset.Hours:0}");
            }
            else
            {
                // 'zz' or longer format e.g "-07"
                result.Append(CultureInfo.InvariantCulture, $"{offset.Hours:00}");
                if (count >= 3)
                {
                    // 'zzz*' or longer format e.g "-07:30"
                    result.Append(CultureInfo.InvariantCulture, $":{offset.Minutes:00}");
                }
            }
        }
    }
}