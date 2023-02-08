namespace SolTechnology.Time
{
    public readonly partial record struct DateTimeZone
    {
        public void AddYears(int years)
        {
            Date.AddYears(years);
        }

        public void AddMonths(int months)
        {
            Date.AddMonths(months);
        }

        public void AddDays(int days)
        {
            Date.AddDays(days);
        }

        public void AddHours(double hours)
        {
            Time.AddHours(hours, out var wrappedDays);
            Date.AddDays(wrappedDays);
        }

        public void AddMinutes(double minutes)
        {
            Time.AddMinutes(minutes, out var wrappedDays);
            Date.AddDays(wrappedDays);
        }

        public void AddSeconds(double seconds)
        {
            Time.AddMinutes(seconds / 60, out var wrappedDays);
            Date.AddDays(wrappedDays);
        }

        public void AddMilliseconds(double milliseconds)
        {
            Time.AddMinutes(milliseconds / 6000, out var wrappedDays);
            Date.AddDays(wrappedDays);

        }

        public void AddTicks(long ticks)
        {
            var ticksTimespan = new TimeSpan(ticks);
            Time.Add(ticksTimespan, out var wrappedDays);
            Date.AddDays(wrappedDays);
        }

        public void Add(TimeOnly time)
        {
            Time.Add(time.ToTimeSpan(), out var wrappedDays);
            Date.AddDays(wrappedDays);
        }

        public void Add(DateOnly date)
        {
            Date.AddYears(date.Year);
            Date.AddMonths(date.Month);
            Date.AddDays(date.Day);
        }

        public void Add(TimeSpan time)
        {
            Time.Add(time, out var wrappedDays);
            Date.AddDays(wrappedDays);
        }
    }
}