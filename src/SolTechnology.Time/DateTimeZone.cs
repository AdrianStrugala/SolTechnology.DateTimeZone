namespace SolTechnology.Time
{
    public record struct DateTimeZone
    {
        public DateOnly Date { get; init; }
        public TimeOnly Time { get; init; }
        public TimeZoneInfo Zone { get; init; }


        public DateTimeZone(DateOnly date, TimeOnly time, TimeZoneInfo zone)
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

        public DateTimeZone(DateTime dateTime)
        {
            Date = DateOnly.FromDateTime(dateTime);
            Time = TimeOnly.FromDateTime(dateTime);

            //here - get timezone from DateTime

            Zone = TimeZoneInfo.Utc;
        }

        public DateTimeZone(DateTime dateTime, TimeZoneInfo zone)
        {
            Date = DateOnly.FromDateTime(dateTime);
            Time = TimeOnly.FromDateTime(dateTime);
            Zone = zone;
        }
    }
}