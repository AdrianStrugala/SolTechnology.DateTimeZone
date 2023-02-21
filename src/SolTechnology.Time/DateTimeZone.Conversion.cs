using SolTechnology.Time.Zone;

namespace SolTechnology.Time
{
    public readonly partial record struct DateTimeZone
    {
        public DateTimeZone ToUtc()
        {
            var result = new DateTimeZone(Date, Time, ZoneSelector.UTC);
            result = result.Add(Zone.BaseUtcOffset);

            return result;
        }

        public DateTimeZone ToTimeZone(TimeZoneInfo timeZoneInfo)
        {
            var result = new DateTimeZone(Date, Time, timeZoneInfo);
            result = result.Add(timeZoneInfo.BaseUtcOffset - Zone.BaseUtcOffset);

            return result;
        }

        public DateTimeZone ToTimeZone(ZoneSelector zoneSelector)
        {
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(zoneSelector.ToString());
            var result = new DateTimeZone(Date, Time, timeZoneInfo);
            result = result.Add(timeZoneInfo.BaseUtcOffset - Zone.BaseUtcOffset);

            return result;
        }

        public DateTime ToDateTime()
        {
            var utcDateTimeZone = ToUtc();
            var result = utcDateTimeZone.Date.ToDateTime(utcDateTimeZone.Time, DateTimeKind.Utc);

            return result;
        }
    }
}