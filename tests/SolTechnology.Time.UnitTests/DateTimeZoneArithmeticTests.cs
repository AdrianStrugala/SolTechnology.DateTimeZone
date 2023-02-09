using FluentAssertions;
using SolTechnology.Time.Zone;

namespace SolTechnology.Time.UnitTests
{
    public class DateTimeZoneArithmeticTests
    {
        [Fact]
        public void Adds_years_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).AddYears(18);


            //Assert
            result.Date.Year.Should().Be(2023);
            result.Date.Month.Should().Be(04);
            result.Date.Day.Should().Be(02);
            result.Time.Hour.Should().Be(21);
            result.Time.Minute.Should().Be(37);
            result.Time.Second.Should().Be(00);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_months_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).AddMonths(18);


            //Assert
            result.Date.Year.Should().Be(2006);
            result.Date.Month.Should().Be(10);
            result.Date.Day.Should().Be(02);
            result.Time.Hour.Should().Be(21);
            result.Time.Minute.Should().Be(37);
            result.Time.Second.Should().Be(00);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_days_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).AddDays(38);


            //Assert
            result.Date.Year.Should().Be(2005);
            result.Date.Month.Should().Be(05);
            result.Date.Day.Should().Be(10);
            result.Time.Hour.Should().Be(21);
            result.Time.Minute.Should().Be(37);
            result.Time.Second.Should().Be(00);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_hours_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).AddHours(38);


            //Assert
            result.Date.Year.Should().Be(2005);
            result.Date.Month.Should().Be(04);
            result.Date.Day.Should().Be(04);
            result.Time.Hour.Should().Be(11);
            result.Time.Minute.Should().Be(37);
            result.Time.Second.Should().Be(00);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_minutes_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).AddMinutes(605);


            //Assert
            result.Date.Year.Should().Be(2005);
            result.Date.Month.Should().Be(04);
            result.Date.Day.Should().Be(03);
            result.Time.Hour.Should().Be(07);
            result.Time.Minute.Should().Be(42);
            result.Time.Second.Should().Be(00);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_seconds_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).AddSeconds(70);


            //Assert
            result.Date.Year.Should().Be(2005);
            result.Date.Month.Should().Be(04);
            result.Date.Day.Should().Be(02);
            result.Time.Hour.Should().Be(21);
            result.Time.Minute.Should().Be(38);
            result.Time.Second.Should().Be(10);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_millis_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).AddMilliseconds(6010);


            //Assert
            result.Date.Year.Should().Be(2005);
            result.Date.Month.Should().Be(04);
            result.Date.Day.Should().Be(02);
            result.Time.Hour.Should().Be(21);
            result.Time.Minute.Should().Be(37);
            result.Time.Second.Should().Be(6);
            result.Time.Millisecond.Should().Be(10);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_ticks_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).AddTicks(2137);


            //Assert
            result.Date.Year.Should().Be(2005);
            result.Date.Month.Should().Be(04);
            result.Date.Day.Should().Be(02);
            result.Time.Hour.Should().Be(21);
            result.Time.Minute.Should().Be(37);
            result.Time.Second.Should().Be(0);
            result.Time.Millisecond.Should().Be(0);
            result.Time.Ticks.Should().Be(778200002137);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_timeOnly_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).Add(new TimeOnly(12, 12));


            //Assert
            result.Date.Year.Should().Be(2005);
            result.Date.Month.Should().Be(04);
            result.Date.Day.Should().Be(03);
            result.Time.Hour.Should().Be(09);
            result.Time.Minute.Should().Be(49);
            result.Time.Second.Should().Be(0);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_dateOnly_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).Add(new DateOnly(04, 09, 01));


            //Assert
            result.Date.Year.Should().Be(2010);
            result.Date.Month.Should().Be(01);
            result.Date.Day.Should().Be(03);
            result.Time.Hour.Should().Be(21);
            result.Time.Minute.Should().Be(37);
            result.Time.Second.Should().Be(0);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }

        [Fact]
        public void Adds_timeSpan_correctly()
        {
            //Arrange 
            var date = new DateOnly(2005, 04, 02);
            var time = new TimeOnly(21, 37);
            var zone = ZoneSelector.CentralAmericaStandardTime;


            //Act
            var result = new DateTimeZone(date, time, zone).Add(new TimeSpan(04, 09, 01));


            //Assert
            result.Date.Year.Should().Be(2005);
            result.Date.Month.Should().Be(04);
            result.Date.Day.Should().Be(03);
            result.Time.Hour.Should().Be(01);
            result.Time.Minute.Should().Be(46);
            result.Time.Second.Should().Be(01);
            result.Zone.Id.Should().Be("Central America Standard Time");
        }
    }
}
