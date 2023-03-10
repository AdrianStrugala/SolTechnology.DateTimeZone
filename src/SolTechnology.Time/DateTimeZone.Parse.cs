using System.Globalization;
using System.Text;

namespace SolTechnology.Time
{
    public readonly partial record struct DateTimeZone
    {
        // public override string Parse()
        // {
        //     var dateTime = Date.ToDateTime(Time, DateTimeKind.Unspecified);
        //
        //     var dateString = dateTime.ToString(CultureInfo.InvariantCulture);
        //     var zone = Zone.Id;
        //     return $"{dateString} ({zone})";
        // }

        public static DateTimeZone Parse(string dateTimeZoneString)
        {
            // StringBuilder result = new StringBuilder();
            //
            // var dateTime = Date.ToDateTime(Time, DateTimeKind.Unspecified);
            //
            // var zIndex = format.IndexOf('z');
            // int zCount = 0;
            // if (zIndex >= 0)
            // {
            //     zCount = FindCount(format, zIndex, 'z');
            //     format = format.Remove(zIndex, zCount);
            // }
            //
            // result.Append(dateTime.ToString(format));
            // FormatCustomizedTimeZone(Zone.BaseUtcOffset, zCount, result);
            //
            // return result.ToString();
            return new DateTimeZone();
        }
    }
}