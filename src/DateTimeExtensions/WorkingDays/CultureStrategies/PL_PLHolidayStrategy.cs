﻿// using DateTimeExtensions.Common;
//
// namespace DateTimeExtensions.WorkingDays.CultureStrategies
// {
//     [Locale("pl-PL")]
//     public class PL_PLHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
//     {
//         public PL_PLHolidayStrategy()
//         {
//             this.InnerCalendarDays.Add(GlobalHolidays.NewYear);
//
//             this.InnerCalendarDays.Add(ChristianHolidays.Epiphany);
//             this.InnerCalendarDays.Add(ChristianHolidays.Easter);
//             this.InnerCalendarDays.Add(ChristianHolidays.EasterMonday);
//
//             this.InnerCalendarDays.Add(GlobalHolidays.InternationalWorkersDay);
//
//             this.InnerCalendarDays.Add(May3rdConstitutionDay);
//
//             this.InnerCalendarDays.Add(ChristianHolidays.Pentecost);
//             this.InnerCalendarDays.Add(ChristianHolidays.CorpusChristi);
//             this.InnerCalendarDays.Add(ChristianHolidays.Assumption);
//             this.InnerCalendarDays.Add(ChristianHolidays.AllSaints);
//
//             this.InnerCalendarDays.Add(NationalIndependenceDay);
//
//             this.InnerCalendarDays.Add(ChristianHolidays.Christmas);
//             this.InnerCalendarDays.Add(ChristianHolidays.StStephansDay);
//         }
//
//         private static Holiday may3rdConstitutionDay;
//
//         public static Holiday May3rdConstitutionDay
//         {
//             get
//             {
//                 if (may3rdConstitutionDay == null)
//                 {
//                     may3rdConstitutionDay = new FixedHoliday("May 3rd Constitution Day", 3, 5);
//                 }
//                 return may3rdConstitutionDay;
//             }
//         }
//
//         private static Holiday nationalIndependenceDay;
//
//         public static Holiday NationalIndependenceDay
//         {
//             get
//             {
//                 if (nationalIndependenceDay == null)
//                 {
//                     nationalIndependenceDay = new FixedHoliday("National Independence Day", 11, 11);
//                 }
//                 return nationalIndependenceDay;
//             }
//         }
//     }
// }
=======
﻿using DateTimeExtensions.Common;

namespace DateTimeExtensions.WorkingDays.CultureStrategies
{
    [Locale("pl-PL")]
    public class PL_PLHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
    {
        public PL_PLHolidayStrategy()
        {
            this.InnerHolidays.Add(GlobalHolidays.NewYear);

            this.InnerHolidays.Add(ChristianHolidays.Epiphany);
            this.InnerHolidays.Add(ChristianHolidays.Easter);
            this.InnerHolidays.Add(ChristianHolidays.EasterMonday);

            this.InnerHolidays.Add(GlobalHolidays.InternationalWorkersDay);

            this.InnerHolidays.Add(May3rdConstitutionDay);

            this.InnerHolidays.Add(ChristianHolidays.Pentecost);
            this.InnerHolidays.Add(ChristianHolidays.CorpusChristi);
            this.InnerHolidays.Add(ChristianHolidays.Assumption);
            this.InnerHolidays.Add(ChristianHolidays.AllSaints);

            this.InnerHolidays.Add(NationalIndependenceDay);

            this.InnerHolidays.Add(ChristianHolidays.Christmas);
            this.InnerHolidays.Add(ChristianHolidays.StStephansDay);
        }

        private static Holiday may3rdConstitutionDay;

        public static Holiday May3rdConstitutionDay
        {
            get
            {
                if (may3rdConstitutionDay == null)
                {
                    may3rdConstitutionDay = new FixedHoliday("May 3rd Constitution Day", 5, 3);
                }
                return may3rdConstitutionDay;
            }
        }

        private static Holiday nationalIndependenceDay;

        public static Holiday NationalIndependenceDay
        {
            get
            {
                if (nationalIndependenceDay == null)
                {
                    nationalIndependenceDay = new FixedHoliday("National Independence Day", 11, 11);
                }
                return nationalIndependenceDay;
            }
        }
    }
}
