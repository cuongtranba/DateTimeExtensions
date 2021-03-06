﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using DateTimeExtensions.WorkingDays;
using DateTimeExtensions.WorkingDays.CultureStrategies;
using NUnit.Framework;

namespace DateTimeExtensions.Tests
{
    [TestFixture]
    public class KRHolidaysNamesTest
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            //setup a default culture
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        [Test]
        public void AssertKoreanHolidaysAreTranslated()
        {
            //test holidays still on default culture (en-US)
            Assert.AreEqual(KO_KRHolidayStrategy.Seolnal.Name, "Seolnal");

            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("ko-KR");
            Assert.AreEqual("ko-KR", System.Threading.Thread.CurrentThread.CurrentUICulture.Name);

            Assert.AreEqual(KO_KRHolidayStrategy.Seolnal.Name, "설날");
            Assert.AreEqual(KO_KRHolidayStrategy.Samiljeol.Name, "삼일절");
            Assert.AreEqual(KO_KRHolidayStrategy.Eorininal.Name, "어린이날");
            Assert.AreEqual(KO_KRHolidayStrategy.SeokgaTansinil.Name, "석가탄신일");
            Assert.AreEqual(KO_KRHolidayStrategy.Hyeonchungil.Name, "현충일");
            Assert.AreEqual(KO_KRHolidayStrategy.Gwangbokjeol.Name, "광복절");
            Assert.AreEqual(KO_KRHolidayStrategy.Chuseok.Name, "추석");
            Assert.AreEqual(KO_KRHolidayStrategy.Gaecheonjeol.Name, "개천절");
            Assert.AreEqual(KO_KRHolidayStrategy.Hangulnal.Name, "한글날");

            Assert.AreEqual(ChristianHolidays.Christmas.Name, "성탄절");
            Assert.AreEqual(ChristianHolidays.NewYear.Name, "신정");
            Assert.AreEqual(GlobalHolidays.InternationalWorkersDay.Name, "근로자의 날");
        }
    }
}