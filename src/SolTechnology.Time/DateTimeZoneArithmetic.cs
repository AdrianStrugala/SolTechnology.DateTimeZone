namespace SolTechnology.Time
{
    public readonly partial record struct DateTimeZone
    {
        public DateTimeZone AddYears(int years)
        {
            return new DateTimeZone(Date.AddYears(years), Time, Zone);
        }

        public DateTimeZone AddMonths(int months)
        {
            return new DateTimeZone(Date.AddMonths(months), Time, Zone);
        }

        public DateTimeZone AddDays(int days)
        {
            return new DateTimeZone(Date.AddDays(days), Time, Zone);
        }

        public DateTimeZone AddHours(double hours)
        {
            var time = Time.AddHours(hours, out var wrappedDays);

            return new DateTimeZone(Date.AddDays(wrappedDays), time, Zone);
        }

        public DateTimeZone AddMinutes(double minutes)
        {
            var time = Time.AddMinutes(minutes, out var wrappedDays);
            return new DateTimeZone(Date.AddDays(wrappedDays), time, Zone);
        }

        public DateTimeZone AddSeconds(double seconds)
        {
            var time = Time.AddMinutes(seconds / 60, out var wrappedDays);
            return new DateTimeZone(Date.AddDays(wrappedDays), time, Zone);
        }

        public DateTimeZone AddMilliseconds(double milliseconds)
        {
            var time = Time.AddMinutes(milliseconds / 60000, out var wrappedDays);
            return new DateTimeZone(Date.AddDays(wrappedDays), time, Zone);
        }

        public DateTimeZone AddTicks(long ticks)
        {
            var ticksTimespan = new TimeSpan(ticks);
            var time = Time.Add(ticksTimespan, out var wrappedDays);
            return new DateTimeZone(Date.AddDays(wrappedDays), time, Zone);
        }

        public DateTimeZone Add(TimeOnly time)
        {
            var newTime = Time.Add(time.ToTimeSpan(), out var wrappedDays);
            return new DateTimeZone(Date.AddDays(wrappedDays), newTime, Zone);
        }

        public DateTimeZone Add(DateOnly date)
        {
            var newDate = Date.AddYears(date.Year);
            newDate = newDate.AddMonths(date.Month);
            newDate = newDate.AddDays(date.Day);
            return new DateTimeZone(newDate, Time, Zone);
        }

        public DateTimeZone Add(TimeSpan time)
        {
            var newTime = Time.Add(time, out var wrappedDays);
            return new DateTimeZone(Date.AddDays(wrappedDays), newTime, Zone);
        }
    }
}