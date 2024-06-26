﻿using DateTimeExtensions.WorkingDays;
using DateTimeExtensions.WorkingDays.CultureStrategies;
using NUnit.Framework;
using System.Globalization;

namespace DateTimeExtensions.Tests.HolidaysTranslations
{
    [TestFixture]
    public class GermanHolidayNamesTest
    {
        [OneTimeSetUp]
        public void Setup()
        {
            //setup a default culture
           new CultureInfo("en-US").SetCurrentUICultureInfo();
        }

        [Test]
        public void AssertGermanHolidaysAreTranslated()
        {
            //test holidays still on default culture (en-US)
            Assert.AreEqual(DE_DEHolidayStrategy.GermanUnityDay.Value.Name, "German Unity Day");

            new CultureInfo("de-DE").SetCurrentUICultureInfo();
            Assert.AreEqual("de-DE", CultureInfo.CurrentUICulture.Name);

            Assert.AreEqual(DE_DEHolidayStrategy.GermanUnityDay.Value.Name, "Tag der Deutschen Einheit");

            Assert.AreEqual(ChristianHolidays.Christmas.Value.Name, "Weihnachten");
            Assert.AreEqual(GlobalHolidays.NewYear.Value.Name, "Neujahr");
            Assert.AreEqual(ChristianHolidays.Epiphany.Value.Name, "Heilige Drei Könige");
            Assert.AreEqual(ChristianHolidays.Carnival.Value.Name, "Fasching");
            Assert.AreEqual(ChristianHolidays.AllSaints.Value.Name, "Allerheiligen");
            Assert.AreEqual(ChristianHolidays.CorpusChristi.Value.Name, "Fronleichnam");
            Assert.AreEqual(ChristianHolidays.Easter.Value.Name, "Ostern");
            Assert.AreEqual(ChristianHolidays.GoodFriday.Value.Name, "Karfreitag");
            Assert.AreEqual(ChristianHolidays.MaundyThursday.Value.Name, "Gründonnerstag");
            Assert.AreEqual(ChristianHolidays.Assumption.Value.Name, "Maria Himmelfahrt");
            Assert.AreEqual(ChristianHolidays.ImaculateConception.Value.Name, "Maria Empfängnis");
            Assert.AreEqual(ChristianHolidays.Pentecost.Value.Name, "Pfingsten");
            Assert.AreEqual(ChristianHolidays.PentecostMonday.Value.Name, "Pfingstmontag");
            Assert.AreEqual(GlobalHolidays.InternationalWorkersDay.Value.Name, "Tag der Arbeit");
            Assert.AreEqual(ChristianHolidays.Christmas.Name, "1. Weihnachtsfeiertag");
            Assert.AreEqual(ChristianHolidays.StStephansDay.Name, "2. Weihnachtsfeiertag");
            Assert.AreEqual(ChristianHolidays.Ascension.Name, "Christi Himmelfahrt");
            Assert.AreEqual(GlobalHolidays.NewYear.Name, "Neujahr");
            Assert.AreEqual(ChristianHolidays.Epiphany.Name, "Heilige Drei Könige");
            Assert.AreEqual(ChristianHolidays.Carnival.Name, "Fasching");
            Assert.AreEqual(ChristianHolidays.AllSaints.Name, "Allerheiligen");
            Assert.AreEqual(ChristianHolidays.CorpusChristi.Name, "Fronleichnam");
            Assert.AreEqual(ChristianHolidays.Easter.Name, "Ostern");
            Assert.AreEqual(ChristianHolidays.GoodFriday.Name, "Karfreitag");
            Assert.AreEqual(ChristianHolidays.MaundyThursday.Name, "Gründonnerstag");
            Assert.AreEqual(ChristianHolidays.Assumption.Name, "Maria Himmelfahrt");
            Assert.AreEqual(ChristianHolidays.ImaculateConception.Name, "Maria Empfängnis");
            Assert.AreEqual(ChristianHolidays.Pentecost.Name, "Pfingsten");
            Assert.AreEqual(ChristianHolidays.PentecostMonday.Name, "Pfingstmontag");
            Assert.AreEqual(GlobalHolidays.InternationalWorkersDay.Name, "Tag der Arbeit");
        }
    }
}
