﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicHoliday;
using System;

namespace PublicHolidayTests
{
    [TestClass]
    public class TestAustriaPublicHoliday
    {
        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(1, 6)]
        [DataRow(4, 17)]
        [DataRow(5, 1)]
        [DataRow(5, 25)]
        [DataRow(6, 5)]
        [DataRow(6, 15)]
        [DataRow(8, 15)]
        [DataRow(10, 26)]
        [DataRow(11, 1)]
        [DataRow(12, 8)]
        [DataRow(12, 25)]
        [DataRow(12, 26)]
        public void TestHolidays2017(int month, int day)
        {
            var holiday = new DateTime(2017, month, day);
            var holidayCalendar = new AustriaPublicHoliday();
            var actual = holidayCalendar.IsPublicHoliday(holiday);
            Assert.IsTrue(actual, $"{holiday.ToString("D")} is not a holiday");
        }

        [TestMethod]
        public void TestHolidays2017Lists()
        {
            var holidayCalendar = new AustriaPublicHoliday();
            var hols = holidayCalendar.PublicHolidays(2017);
            var holNames = holidayCalendar.PublicHolidayNames(2017);
            Assert.IsTrue(13 == hols.Count, "Should be 10 holidays in 2017");
            Assert.IsTrue(holNames.Count == hols.Count, "Names and holiday list are same");
        }
    }
}