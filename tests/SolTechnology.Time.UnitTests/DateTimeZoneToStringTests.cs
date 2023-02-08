using FluentAssertions;
using SolTechnology.Time.Zone;

namespace SolTechnology.Time.UnitTests
{
    public class DateTimeZoneToStringTests
    {
        [Fact]
        public void Applies_given_dateTime_format_includes_proper_zone()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).ToString("MM dd, yyyy H:mm:ss zzz");


            //Assert
            result.Should().Be("04 02, 2005 21:37:00 -06:00");
        }

        [Fact]
        public void Applies_given_dateTime_format_skis_zone_if_not_provided()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).ToString("MM dd, yyyy H:mm:ss");


            //Assert
            result.Should().Be("04 02, 2005 21:37:00");
        }

        [Fact]
        public void ToString_applies_default_formatting()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).ToString();

            //Assert
            result.Should().Be("04/02/2005 21:37:00 (Central America Standard Time)");
        }
    }
}
