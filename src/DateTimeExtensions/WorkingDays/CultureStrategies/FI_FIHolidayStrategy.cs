﻿// #region License
//
// // 
// // Copyright (c) 2011-2012, João Matos Silva <kappy@acydburne.com.pt>
// // 
// // Licensed under the Apache License, Version 2.0 (the "License");
// // you may not use this file except in compliance with the License.
// // You may obtain a copy of the License at
// //
// //   http://www.apache.org/licenses/LICENSE-2.0
// //
// // Unless required by applicable law or agreed to in writing, software
// // distributed under the License is distributed on an "AS IS" BASIS,
// // WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// // See the License for the specific language governing permissions and
// // limitations under the License.
// // 
//
// #endregion
//
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using DateTimeExtensions.Common;
//
// namespace DateTimeExtensions.WorkingDays.CultureStrategies
// {
//     [Locale("fi-FI")]
//     public class FI_FIHolidayStrategy : HolidayStrategyBase, IHolidayStrategy
//     {
//         public FI_FIHolidayStrategy()
//         {
//             this.InnerCalendarDays.Add(GlobalHolidays.NewYear);
//             this.InnerCalendarDays.Add(ChristianHolidays.Epiphany);
//             this.InnerCalendarDays.Add(ChristianHolidays.GoodFriday);
//             this.InnerCalendarDays.Add(ChristianHolidays.Easter);
//             this.InnerCalendarDays.Add(ChristianHolidays.EasterMonday);
//             this.InnerCalendarDays.Add(GlobalHolidays.MayDay);
//             this.InnerCalendarDays.Add(ChristianHolidays.Ascension);
//             this.InnerCalendarDays.Add(ChristianHolidays.Pentecost);
//             this.InnerCalendarDays.Add(GlobalHolidays.MidsummerEve);
//             this.InnerCalendarDays.Add(GlobalHolidays.MidsummerDay);
//             this.InnerCalendarDays.Add(AllSaintsDay);
//             this.InnerCalendarDays.Add(IndependanceDay);
//             this.InnerCalendarDays.Add(ChristianHolidays.ChristmasEve);
//             this.InnerCalendarDays.Add(ChristianHolidays.Christmas);
//             this.InnerCalendarDays.Add(ChristianHolidays.StStephansDay);
//         }
//
//         private static Holiday independanceDay;
//
//         public static Holiday IndependanceDay
//         {
//             get
//             {
//                 if (independanceDay == null)
//                 {
//                     independanceDay = new FixedHoliday("Independance Day", 12, 6);
//                 }
//                 return independanceDay;
//             }
//         }
//
//         //All Saints' Day - Saturday between 31 October and 6 November
//         // - Same as ChristianHolidays.AllSaints but has diferent ocurrence
//         private static Holiday allSaintsDay;
//
//         public static Holiday AllSaintsDay
//         {
//             get
//             {
//                 if (allSaintsDay == null)
//                 {
//                     allSaintsDay = new NthDayOfWeekAfterDayHoliday("All Saint's Day", 1, DayOfWeek.Saturday, 10, 31);
//                 }
//                 return allSaintsDay;
//             }
//         }
//     }
// }