namespace SolTechnology.Time
{
    public record struct DateTimeZone
    {
        public DateOnly Date { get; init; }
        public TimeOnly Time { get; init; }
        public TimeZoneInfo Zone { get; init; }


        public DateTimeZone(DateOnly date, TimeOnly time, TimeZoneInfo zone) : this()
        {
            Date = date;
            Time = time;
            Zone = zone;
        }

        public DateTimeZone(DateOnly date, TimeOnly time)
        {
            Date = date;
            Time = time;
            Zone = TimeZoneInfo.Utc;
        }

        public DateTimeZone(DateTime dateTime) : this()
        {
            Date = DateOnly.FromDateTime(dateTime);
            Time = TimeOnly.FromDateTime(dateTime);

            Zone = dateTime.Kind switch
            {
                DateTimeKind.Local => IdentifyLocalTimeZone(),
                _ => TimeZoneInfo.Utc
            };
        }

        public DateTimeZone(DateTime dateTime, TimeZoneInfo zone) : this()
        {
            Date = DateOnly.FromDateTime(dateTime);
            Time = TimeOnly.FromDateTime(dateTime);
            Zone = zone;
        }

        private TimeZoneInfo IdentifyLocalTimeZone()
        {
            var localTimezone = TimeZoneInfo.Local;

            var result = TimeZoneInfo.FindSystemTimeZoneById(localTimezone.Id);
            return result;
        }
    }
}