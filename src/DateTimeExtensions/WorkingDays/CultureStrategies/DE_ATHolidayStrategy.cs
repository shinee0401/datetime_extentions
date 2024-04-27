using System;
using DateTimeExtensions.Common;
using DateTimeExtensions.WorkingDays.OccurrencesCalculators;

namespace DateTimeExtensions.WorkingDays.CultureStrategies
{
    [Locale("de-AT")]
    public class DE_ATHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
    {
        public DE_ATHolidayStrategy()
        {
            this.InnerCalendarDays.Add(new Holiday(GlobalHolidays.NewYear));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.Epiphany));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.GoodFriday));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.EasterMonday));
            this.InnerCalendarDays.Add(new Holiday(GlobalHolidays.InternationalWorkersDay));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.Ascension));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.PentecostMonday));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.CorpusChristi));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.Assumption));
            this.InnerCalendarDays.Add(new Holiday(AustrianNationalHoliday));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.AllSaints));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.ImaculateConception));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.Christmas));
            this.InnerCalendarDays.Add(new Holiday(ChristianHolidays.StStephansDay));
            this.InnerCalendarDays.Add(new Holiday(GlobalHolidays.NewYearsEve));
            this.InnerHolidays.Add(GlobalHolidays.NewYear);
            this.InnerHolidays.Add(ChristianHolidays.Epiphany);
            this.InnerHolidays.Add(ChristianHolidays.EasterMonday);
            this.InnerHolidays.Add(GlobalHolidays.InternationalWorkersDay);
            this.InnerHolidays.Add(ChristianHolidays.Ascension);
            this.InnerHolidays.Add(ChristianHolidays.PentecostMonday);
            this.InnerHolidays.Add(ChristianHolidays.CorpusChristi);
            this.InnerHolidays.Add(ChristianHolidays.Assumption);
            this.InnerHolidays.Add(AustrianNationalHoliday);
            this.InnerHolidays.Add(ChristianHolidays.AllSaints);
            this.InnerHolidays.Add(ChristianHolidays.ImaculateConception);
            this.InnerHolidays.Add(ChristianHolidays.Christmas);
            this.InnerHolidays.Add(ChristianHolidays.StStephansDay);
            this.InnerHolidays.Add(GlobalHolidays.NewYearsEve);
        }

        private static Holiday austrianNationalHoliday;

        public static Holiday AustrianNationalHoliday
        {
            get
            {
                if (austrianNationalHoliday == null)
                {
                    austrianNationalHoliday = new FixedHoliday("Austrian National Holiday", 10, 26);
                }
                return austrianNationalHoliday;
            }
        }
            
        public static NamedDayInitializer AustrianNationalHoliday { get; } = new NamedDayInitializer(() =>
            new NamedDay("Austrian National Holiday", new FixedDayStrategy(Month.October, 26)));
    }
}
