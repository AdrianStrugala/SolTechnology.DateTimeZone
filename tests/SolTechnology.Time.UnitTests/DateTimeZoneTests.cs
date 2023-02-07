using FluentAssertions;
using SolTechnology.Time.Zone;

namespace SolTechnology.Time.UnitTests
{
    public class DateTimeZoneTests
    {
        [Fact]
        public void Sets_provided_Date_Time_and_Zone()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = TimeZoneInfo.Utc;


            //Act
            var result = new DateTimeZone(date, time, zone);


            //Assert
            result.Date.Should().Be(date);
            result.Time.Should().Be(time);
            result.Zone.Should().Be(zone);
        }

        [Fact]
        public void Sets_provided_Date_and_Time_but_zone_defaults_to_UTC()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);


            //Act
            var result = new DateTimeZone(date, time);


            //Assert
            result.Date.Should().Be(date);
            result.Time.Should().Be(time);
            result.Zone.Should().Be(TimeZoneInfo.Utc);
        }

        [Fact]
        public void Sets_provided_DateTime_and_Zone()
        {
            //Arrange 
            var dateTime = new DateTime(2005, 04, 02, 21, 37, 00);
            var zone = TimeZoneInfo.Utc;


            //Act
            var result = new DateTimeZone(dateTime, zone);


            //Assert
            result.Date.Should().Be(DateOnly.FromDateTime(dateTime));
            result.Time.Should().Be(TimeOnly.FromDateTime(dateTime));
            result.Zone.Should().Be(zone);
        }

        [Fact]
        public void Sets_provided_DateTime_and_extracts_zone()
        {
            //Arrange 
            var dateTime = new DateTime(2005, 04, 02, 21, 37, 00, DateTimeKind.Local);

            //Act
            var result = new DateTimeZone(dateTime);


            //Assert
            result.Date.Should().Be(DateOnly.FromDateTime(dateTime));
            result.Time.Should().Be(TimeOnly.FromDateTime(dateTime));
            result.Zone.Should().Be(TimeZoneInfo.Local);
        }

        [Fact]
        public void Sets_provided_DateTime_and_defaults_zone_to_UTC()
        {
            //Arrange 
            var dateTime = new DateTime(2005, 04, 02, 21, 37, 00, DateTimeKind.Unspecified);

            //Act
            var result = new DateTimeZone(dateTime);


            //Assert
            result.Date.Should().Be(DateOnly.FromDateTime(dateTime));
            result.Time.Should().Be(TimeOnly.FromDateTime(dateTime));
            result.Zone.Should().Be(TimeZoneInfo.Utc);
        }

        [Fact]
        public void Sets_correct_zone_by_ZoneSelector()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.IndiaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone);


            //Assert
            result.Date.Should().Be(date);
            result.Time.Should().Be(time);
            result.Zone.Should().Be(TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
        }
    }
}