namespace SolTechnology.Time
{
    public readonly partial record struct DateTimeZone
    {
        public static DateTimeZone Parse(string dateTimeZoneString)
        {
            DateTime dateTime;
            var dateTimeString = dateTimeZoneString;
            var zone = TimeZoneInfo.Utc;

            //dateTime (zone) format
            int zoneStartIndex = dateTimeZoneString.IndexOf('(');
            if (zoneStartIndex != -1)
            {
                int zoneEndIndex = dateTimeZoneString.LastIndexOf(')');
                if (zoneEndIndex == -1)
                {
                    throw new DateTimeZoneException($"Parsing error: dateTimeZone string [{dateTimeZoneString}] contains zone opener '(', but does not contain zone closer ')'.");
                }
                string zoneId = dateTimeZoneString.Substring(zoneStartIndex + 1, zoneEndIndex - zoneStartIndex - 1);
                zone = TimeZoneInfo.FindSystemTimeZoneById(zoneId);

                dateTimeString = dateTimeZoneString.Substring(0, zoneStartIndex);
            }

            //dateTime +-zone format
            zoneStartIndex = dateTimeZoneString.IndexOf('+');
            if (zoneStartIndex == -1)
            {
                zoneStartIndex = dateTimeZoneString.IndexOf('-');
            }

            if (zoneStartIndex != -1)
            {
                string zoneOffset = dateTimeZoneString.Substring(zoneStartIndex, dateTimeZoneString.Length - zoneStartIndex);
                TimeZoneInfo? foundTimeZone = FindTimeZoneByOffset(TimeSpan.Parse(zoneOffset));

                if (foundTimeZone == null)
                {
                    throw new DateTimeZoneException($"Parsing error: zone offset [{zoneOffset}] is not a valid value.");
                }
                zone = foundTimeZone;

                dateTimeString = dateTimeZoneString.Substring(0, zoneStartIndex);
            }

            //assume UTC
            var parsingResult = DateTime.TryParse(dateTimeString, out dateTime);
            if (parsingResult == false)
            {
                throw new DateTimeZoneException($"Parsing error: dateTimeZone string [{dateTimeZoneString}] contains invalid dateTime: [{dateTimeString}]");
            }
            return new DateTimeZone(dateTime, zone);
        }

        static TimeZoneInfo? FindTimeZoneByOffset(TimeSpan targetOffset)
        {
            return TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(timeZone => timeZone.BaseUtcOffset == targetOffset);
        }
    }
}