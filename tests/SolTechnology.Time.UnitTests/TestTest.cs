namespace SolTechnology.Time.UnitTests
{
    public class TestTest
    {
        [Fact]
        public void Used_for_tests_creation()
        {
            var x = TimeZoneInfo.GetSystemTimeZones();
            var y = x.Select(a => a.DisplayName);

            var xdf = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");


            DateTime winterTime = DateTime.Now;
            DateTime summerTime = DateTime.Now.AddMonths(6);

            DateTime utcWinterTime = DateTime.UtcNow;
            DateTime utcSummerTime = DateTime.UtcNow.AddMonths(6);


            var a = TimeZoneInfo.ConvertTimeToUtc(winterTime);
            var b = TimeZoneInfo.ConvertTimeToUtc(summerTime);


            // TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            // DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cstZone);
        }
    }
}