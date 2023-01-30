using System.Globalization;

namespace SolTechnology.Time
{
    public readonly partial record struct DateTimeZone
    {
        public override string ToString()
        {
            var dateTimeUtc = GetUtcDateTime();
            var dateTimeWithZone = TimeZoneInfo.ConvertTime(dateTimeUtc, Zone);

            var date =  dateTimeWithZone.ToString(CultureInfo.InvariantCulture);
            var zone = Zone.StandardName;
            return $"{date} [{zone}]";
        }

        public string ToString(string? format)
        {
            var dateTimeUtc = GetUtcDateTime();
            var dateTimeWithZone = TimeZoneInfo.ConvertTime(dateTimeUtc, Zone);

            return dateTimeWithZone.ToString(format);
        }

        private DateTime GetUtcDateTime()
        {
            var dateTime = TimeZoneInfo.ConvertTimeToUtc(Date.ToDateTime(Time, DateTimeKind.Utc));
            var utcOffset = Zone.GetUtcOffset(dateTime);
            dateTime = dateTime.Add(-utcOffset);
            return dateTime;
        }
    }
}