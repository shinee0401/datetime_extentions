﻿using System.Globalization;
using DateTimeExtensions.WorkingDays;
using DateTimeExtensions.WorkingDays.CultureStrategies;
using NUnit.Framework;

namespace DateTimeExtensions.Tests.HolidaysTranslations
{
    [TestFixture]
    public class ViHolidaysNamesTest
    {
        [OneTimeSetUp]
        public void Setup()
        {
            new CultureInfo("vi-VN").SetCurrentUICultureInfo();
        }

        [Test]
        public void AssertVietNamHolidaysAreTranslated()
        {
            StringAssert.AreEqualIgnoringCase("Quốc khánh", ViVNHolidayStrategy.NationalDay.Value.Name);
            StringAssert.AreEqualIgnoringCase("Ngày Giải phóng miền Nam thống nhất đất nước", ViVNHolidayStrategy.LiberationDay.Value.Name);
            StringAssert.AreEqualIgnoringCase("Ngày Quốc tế Lao động", GlobalHolidays.InternationalWorkersDay.Value.Name);
            StringAssert.AreEqualIgnoringCase("Giỗ tổ Hùng Vương", ViVNHolidayStrategy.HungKingsCommemorations.Value.Name);
            StringAssert.AreEqualIgnoringCase("tết tây", GlobalHolidays.NewYear.Value.Name);
        }
    }
}