using FluentAssertions;

namespace SolTechnology.Time.UnitTests
{
    public class DateTimeZoneToStringTests
    {
        [Fact]
        public void Applies_given_string_format()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = TimeZoneInfo.Local;


            //Act
            var result = new DateTimeZone(date, time, zone).ToString("MM dd, yyyy H:mm:ss zzz");


            //Assert
            result.Should().Be("04 02, 2005 21:37:00 +02:00");
        }
    }
}
