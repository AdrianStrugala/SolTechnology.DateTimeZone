namespace SolTechnology.Time.UnitTests
{
    public class DateTimeZoneParseTests
    {
        [Fact]
        public void Parses_valid_DateTimeZone()
        {
            //Arrange 
            var dateTimeZoneString = "04/02/2005 21:37:00 (Central America Standard Time)";


            //Act
            var result = DateTimeZone.Parse(dateTimeZoneString);


            //Assert
            result.Date.Should().Be(new DateOnly(2005, 04, 02));
            result.Time.Should().Be(new TimeOnly(21, 37));
            result.Zone.Should().Be(TimeZoneInfo.FindSystemTimeZoneById(ZoneSelector.CentralAmericaStandardTime.ToString()));
        }

        [Fact]
        public void Parses_valid_DateTimeZone_with_short_Zone()
        {
            //Arrange 
            var dateTimeZoneString = "04 02, 2005 21:37:00 -06:00";


            //Act
            var result = DateTimeZone.Parse(dateTimeZoneString);


            //Assert
            result.Date.Should().Be(new DateOnly(2005, 04, 02));
            result.Time.Should().Be(new TimeOnly(21, 37));
            //note that only BaseUtcOffset is ensured to be the same in this case. Example:  Expected result.Zone to be (UTC-06:00) Central Time (Guatemala), but found (UTC-06:00) Central Time (Bahia Banderas).
            result.Zone.BaseUtcOffset.Should().Be(TimeZoneInfo.FindSystemTimeZoneById(ZoneSelector.CentralAmericaStandardTime.ToString()).BaseUtcOffset);
        }


        [Fact]
        public void For_DateTime_without_Zone_assumes_zone_as_UTC()
        {
            //Arrange 
            var dateTimeZoneString = "04 02, 2005 21:37:00";


            //Act
            var result = DateTimeZone.Parse(dateTimeZoneString);


            //Assert
            result.Date.Should().Be(new DateOnly(2005, 04, 02));
            result.Time.Should().Be(new TimeOnly(21, 37));
            result.Zone.Should().Be(TimeZoneInfo.Utc);
        }
    }
}
