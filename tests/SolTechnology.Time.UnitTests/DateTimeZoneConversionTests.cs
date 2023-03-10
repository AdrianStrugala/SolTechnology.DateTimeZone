namespace SolTechnology.Time.UnitTests
{
    public class DateTimeZoneConversionTests
    {
        [Fact]
        public void Converts_from_different_timezone_to_utc()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).ToUtc();


            //Assert
            result.Date.Should().Be(date);
            result.Time.Should().Be(time.AddHours(-6));
            result.Zone.Should().Be(TimeZoneInfo.Utc);
        }

        [Fact]
        public void Converts_from_different_timezone_to_utc_and_applies_elapsed_day()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.UTCPlus12;


            //Act
            var result = new DateTimeZone(date, time, zone).ToUtc();


            //Assert
            result.Date.Should().Be(date.AddDays(1));
            result.Time.Should().Be(time.AddHours(12));
            result.Zone.Should().Be(TimeZoneInfo.Utc);
        }

        [Fact]
        public void Converts_between_two_time_zones()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.UTCPlus12;

            var newZone = TimeZoneInfo.FindSystemTimeZoneById("Central America Standard Time");

            //Act
            var result = new DateTimeZone(date, time, zone).ToTimeZone(newZone);


            //Assert
            result.Date.Should().Be(date);
            result.Time.Should().Be(time.AddHours(-18));
            result.Zone.Should().Be(newZone);
        }

        [Fact]
        public void Converts_between_two_time_zones_applies_day_change()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;

            var newZone = ZoneSelector.UTCPlus12;

            //Act
            var result = new DateTimeZone(date, time, zone).ToTimeZone(newZone);


            //Assert
            result.Date.Should().Be(date.AddDays(1));
            result.Time.Should().Be(time.AddHours(18));
            result.Zone.Should().Be(TimeZoneInfo.FindSystemTimeZoneById(newZone.ToString()));
        }

        [Fact]
        public void Converts_to_DateTime_with_UTC_timezone_kind()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;

            //Act
            var result = new DateTimeZone(date, time, zone).ToDateTime();


            //Assert
            DateOnly.FromDateTime(result).Should().Be(date);
            TimeOnly.FromDateTime(result).Should().Be(time.AddHours(-6));
            result.Kind.Should().Be(DateTimeKind.Utc);
        }
    }
}
