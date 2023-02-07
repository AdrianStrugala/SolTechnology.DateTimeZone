namespace SolTechnology.Time.Zone
{
    public class ZoneSelector
    {
        private readonly string _zoneId;

        private ZoneSelector(string zoneId)
        {
            _zoneId = zoneId;
        }

        public override string ToString()
        {
            return _zoneId;
        }


        public static ZoneSelector DatelineStandardTime = new("Dateline Standard Time");
        public static ZoneSelector UTCMinus11 = new("UTC-11");
        public static ZoneSelector AleutianStandardTime = new("Aleutian Standard Time");
        public static ZoneSelector HawaiianStandardTime = new("Hawaiian Standard Time");
        public static ZoneSelector MarquesasStandardTime = new("Marquesas Standard Time");
        public static ZoneSelector AlaskanStandardTime = new("Alaskan Standard Time");
        public static ZoneSelector UTCMinus09 = new("UTC-09");
        public static ZoneSelector PacificStandardTimeMexico = new("Pacific Standard Time (Mexico)");
        public static ZoneSelector UTCMinus08 = new("UTC-08");
        public static ZoneSelector PacificStandardTime = new("Pacific Standard Time");
        public static ZoneSelector USMountainStandardTime = new("US Mountain Standard Time");
        public static ZoneSelector MountainStandardTimeMexico = new("Mountain Standard Time (Mexico)");
        public static ZoneSelector MountainStandardTime = new("Mountain Standard Time");
        public static ZoneSelector YukonStandardTime = new("Yukon Standard Time");
        public static ZoneSelector CentralAmericaStandardTime = new("Central America Standard Time");
        public static ZoneSelector CentralStandardTime = new("Central Standard Time");
        public static ZoneSelector EasterIslandStandardTime = new("Easter Island Standard Time");
        public static ZoneSelector CentralStandardTimeMexico = new("Central Standard Time (Mexico)");
        public static ZoneSelector CanadaCentralStandardTime = new("Canada Central Standard Time");
        public static ZoneSelector SAPacificStandardTime = new("SA Pacific Standard Time");
        public static ZoneSelector EasternStandardTimeMexico = new("Eastern Standard Time (Mexico)");
        public static ZoneSelector EasternStandardTime = new("Eastern Standard Time");
        public static ZoneSelector HaitiStandardTime = new("Haiti Standard Time");
        public static ZoneSelector CubaStandardTime = new("Cuba Standard Time");
        public static ZoneSelector USEasternStandardTime = new("US Eastern Standard Time");
        public static ZoneSelector TurksAndCaicosStandardTime = new("Turks And Caicos Standard Time");
        public static ZoneSelector ParaguayStandardTime = new("Paraguay Standard Time");
        public static ZoneSelector AtlanticStandardTime = new("Atlantic Standard Time");
        public static ZoneSelector VenezuelaStandardTime = new("Venezuela Standard Time");
        public static ZoneSelector CentralBrazilianStandardTime = new("Central Brazilian Standard Time");
        public static ZoneSelector SAWesternStandardTime = new("SA Western Standard Time");
        public static ZoneSelector PacificSAStandardTime = new("Pacific SA Standard Time");
        public static ZoneSelector NewfoundlandStandardTime = new("Newfoundland Standard Time");
        public static ZoneSelector TocantinsStandardTime = new("Tocantins Standard Time");
        public static ZoneSelector EastSouthAmericaStandardTime = new("E. South America Standard Time");
        public static ZoneSelector SAEasternStandardTime = new("SA Eastern Standard Time");
        public static ZoneSelector ArgentinaStandardTime = new("Argentina Standard Time");
        public static ZoneSelector GreenlandStandardTime = new("Greenland Standard Time");
        public static ZoneSelector MontevideoStandardTime = new("Montevideo Standard Time");
        public static ZoneSelector MagallanesStandardTime = new("Magallanes Standard Time");
        public static ZoneSelector SaintPierreStandardTime = new("Saint Pierre Standard Time");
        public static ZoneSelector BahiaStandardTime = new("Bahia Standard Time");
        public static ZoneSelector UTCMinus02 = new("UTC-02");
        public static ZoneSelector MidAtlanticStandardTime = new("Mid-Atlantic Standard Time");
        public static ZoneSelector AzoresStandardTime = new("Azores Standard Time");
        public static ZoneSelector CapeVerdeStandardTime = new("Cape Verde Standard Time");
        public static ZoneSelector UTC = new("UTC");
        public static ZoneSelector GMTStandardTime = new("GMT Standard Time");
        public static ZoneSelector GreenwichStandardTime = new("Greenwich Standard Time");
        public static ZoneSelector SaoTomeStandardTime = new("Sao Tome Standard Time ");
        public static ZoneSelector MoroccoStandardTime = new("Morocco Standard Time");
        public static ZoneSelector WestEuropeStandardTime = new("W. Europe Standard Time");
        public static ZoneSelector CentralEuropeStandardTime = new("Central Europe Standard Time");
        public static ZoneSelector RomanceStandardTime = new("Romance Standard Time");
        public static ZoneSelector CentralEuropeanStandardTime = new("Central European Standard Time");
        public static ZoneSelector WestCentralAfricaStandardTime = new("W. Central Africa Standard Time");
        public static ZoneSelector GTBStandardTime = new("GTB Standard Time");
        public static ZoneSelector MiddleEastStandardTime = new("Middle East Standard Time");
        public static ZoneSelector EgyptStandardTime = new("Egypt Standard Time");
        public static ZoneSelector EastEuropeStandardTime = new("E. Europe Standard Time");
        public static ZoneSelector SyriaStandardTime = new("Syria Standard Time");
        public static ZoneSelector WestBankStandardTime = new("West Bank Standard Time");
        public static ZoneSelector SouthAfricaStandardTime = new("South Africa Standard Time");
        public static ZoneSelector FLEStandardTime = new("FLE Standard Time");
        public static ZoneSelector IsraelStandardTime = new("Israel Standard Time");
        public static ZoneSelector SouthSudanStandardTime = new("South Sudan Standard Time");
        public static ZoneSelector KrolewiecStandardTime = new("Kaliningrad Standard Time");
        public static ZoneSelector SudanStandardTime = new("Sudan Standard Time");
        public static ZoneSelector LibyaStandardTime = new("Libya Standard Time");
        public static ZoneSelector NamibiaStandardTime = new("Namibia Standard Time");
        public static ZoneSelector JordanStandardTime = new("Jordan Standard Time");
        public static ZoneSelector ArabicStandardTime = new("Arabic Standard Time");
        public static ZoneSelector TurkeyStandardTime = new("Turkey Standard Time");
        public static ZoneSelector ArabStandardTime = new("Arab Standard Time");
        public static ZoneSelector BelarusStandardTime = new("Belarus Standard Time");
        public static ZoneSelector RussianStandardTime = new("Russian Standard Time");
        public static ZoneSelector EastAfricaStandardTime = new("E. Africa Standard Time");
        public static ZoneSelector VolgogradStandardTime = new("Volgograd Standard Time");
        public static ZoneSelector IranStandardTime = new("Iran Standard Time");
        public static ZoneSelector ArabianStandardTime = new("Arabian Standard Time");
        public static ZoneSelector AstrakhanStandardTime = new("Astrakhan Standard Time");
        public static ZoneSelector AzerbaijanStandardTime = new("Azerbaijan Standard Time");
        public static ZoneSelector RussiaTimeZone3 = new("Russia Time Zone 3");
        public static ZoneSelector MauritiusStandardTime = new("Mauritius Standard Time");
        public static ZoneSelector SaratovStandardTime = new("Saratov Standard Time");
        public static ZoneSelector GeorgianStandardTime = new("Georgian Standard Time");
        public static ZoneSelector CaucasusStandardTime = new("Caucasus Standard Time");
        public static ZoneSelector AfghanistanStandardTime = new("Afghanistan Standard Time");
        public static ZoneSelector WestAsiaStandardTime = new("West Asia Standard Time");
        public static ZoneSelector EkaterinburgStandardTime = new("Ekaterinburg Standard Time");
        public static ZoneSelector PakistanStandardTime = new("Pakistan Standard Time");
        public static ZoneSelector QyzylordaStandardTime = new("Qyzylorda Standard Time");
        public static ZoneSelector IndiaStandardTime = new("India Standard Time");
        public static ZoneSelector SriLankaStandardTime = new("Sri Lanka Standard Time");
        public static ZoneSelector NepalStandardTime = new("Nepal Standard Time");
        public static ZoneSelector CentralAsiaStandardTime = new("Central Asia Standard Time");
        public static ZoneSelector BangladeshStandardTime = new("Bangladesh Standard Time");
        public static ZoneSelector OmskStandardTime = new("Omsk Standard Time");
        public static ZoneSelector MyanmarStandardTime = new("Myanmar Standard Time");
        public static ZoneSelector SEAsiaStandardTime = new("SE Asia Standard Time");
        public static ZoneSelector AltaiStandardTime = new("Altai Standard Time");
        public static ZoneSelector WestMongoliaStandardTime = new("W. Mongolia Standard Time");
        public static ZoneSelector NorthAsiaStandardTime = new("North Asia Standard Time");
        public static ZoneSelector NorthCentralAsiaStandardTime = new("N. Central Asia Standard Time");
        public static ZoneSelector TomskStandardTime = new("Tomsk Standard Time");
        public static ZoneSelector ChinaStandardTime = new("China Standard Time");
        public static ZoneSelector NorthAsiaEastStandardTime = new("North Asia East Standard Time");
        public static ZoneSelector SingaporeStandardTime = new("Singapore Standard Time");
        public static ZoneSelector WestAustraliaStandardTime = new("W. Australia Standard Time");
        public static ZoneSelector TaipeiStandardTime = new("Taipei Standard Time");
        public static ZoneSelector UlaanbaatarStandardTime = new("Ulaanbaatar Standard Time");
        public static ZoneSelector AusCentralWestStandardTime = new("Aus Central W. Standard Time");
        public static ZoneSelector TransbaikalStandardTime = new("Transbaikal Standard Time");
        public static ZoneSelector TokyoStandardTime = new("Tokyo Standard Time");
        public static ZoneSelector NorthKoreaStandardTime = new("North Korea Standard Time");
        public static ZoneSelector KoreaStandardTime = new("Korea Standard Time");
        public static ZoneSelector YakutskStandardTime = new("Yakutsk Standard Time");
        public static ZoneSelector CentralAustraliaStandardTime = new("Cen. Australia Standard Time");
        public static ZoneSelector AUSCentralStandardTime = new("AUS Central Standard Time");
        public static ZoneSelector EastAustraliaStandardTime = new("E. Australia Standard Time");
        public static ZoneSelector AUSEasternStandardTime = new("AUS Eastern Standard Time");
        public static ZoneSelector WestPacificStandardTime = new("West Pacific Standard Time");
        public static ZoneSelector TasmaniaStandardTime = new("Tasmania Standard Time");
        public static ZoneSelector VladivostokStandardTime = new("Vladivostok Standard Time");
        public static ZoneSelector LordHoweStandardTime = new("Lord Howe Standard Time");
        public static ZoneSelector BougainvilleStandardTime = new("Bougainville Standard Time");
        public static ZoneSelector RussiaTimeZone10 = new("Russia Time Zone 10");
        public static ZoneSelector MagadanStandardTime = new("Magadan Standard Time");
        public static ZoneSelector NorfolkStandardTime = new("Norfolk Standard Time");
        public static ZoneSelector SakhalinStandardTime = new("Sakhalin Standard Time");
        public static ZoneSelector CentralPacificStandardTime = new("Central Pacific Standard Time");
        public static ZoneSelector RussiaTimeZone11 = new("Russia Time Zone 11");
        public static ZoneSelector NewZealandStandardTime = new("New Zealand Standard Time");
        public static ZoneSelector UTCPlus12 = new("UTC+12");
        public static ZoneSelector FijiStandardTime = new("Fiji Standard Time");
        public static ZoneSelector KamchatkaStandardTime = new("Kamchatka Standard Time");
        public static ZoneSelector ChathamIslandsStandardTime = new("Chatham Islands Standard Time");
        public static ZoneSelector UTCPlus13 = new("UTC+13");
        public static ZoneSelector TongaStandardTime = new("Tonga Standard Time");
        public static ZoneSelector SamoaStandardTime = new("Samoa Standard Time");
        public static ZoneSelector LineIslandsStandardTime = new("Line Islands Standard Time");
    }
}
