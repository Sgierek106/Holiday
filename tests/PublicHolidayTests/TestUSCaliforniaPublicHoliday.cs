using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicHoliday;
using System;

namespace PublicHolidayTests
{
    /// <summary>
    /// Using official calendar from http://www.opm.gov/fedhol/2006.asp
    /// </summary>
    [TestClass]
    public class TestUSCaliforniaPublicHoliday
    {
        [TestMethod]
        public void TestThanksgiving2018()
        {
            var expected = new DateTime(2018, 11, 22);
            var actual = USACaliforniaPublicHoliday.Thanksgiving(2018);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBlackFriday2018()
        {
            var expected = new DateTime(2018, 11, 23);
            var actual = USACaliforniaPublicHoliday.BlackFriday(2018);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNewYear2004()
        {
            var expected = new DateTime(2004, 1, 1);
            var actual = USACaliforniaPublicHoliday.NewYear(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMartinLutherKing2004()
        {
            var expected = new DateTime(2004, 1, 19);
            var actual = USACaliforniaPublicHoliday.MartinLutherKing(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWashington2004()
        {
            var expected = new DateTime(2004, 2, 16);
            var actual = USACaliforniaPublicHoliday.PresidentsDay(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMemorial2004()
        {
            var expected = new DateTime(2004, 5, 31);
            var actual = USACaliforniaPublicHoliday.MemorialDay(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIndependence2004()
        {
            var expected = new DateTime(2004, 7, 5);
            var actual = USACaliforniaPublicHoliday.IndependenceDay(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLabor2004()
        {
            var expected = new DateTime(2004, 9, 6);
            var actual = USACaliforniaPublicHoliday.LaborDay(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCesarChavez2004()
        {
            var expected = new DateTime(2004, 3, 31);
            var actual = USACaliforniaPublicHoliday.CesarChavezDay(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestVeterans2004()
        {
            var expected = new DateTime(2004, 11, 11);
            var actual = USACaliforniaPublicHoliday.VeteransDay(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThanksgiving2004()
        {
            var expected = new DateTime(2004, 11, 25);
            var actual = USACaliforniaPublicHoliday.Thanksgiving(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBlackFriday2004()
        {
            var expected = new DateTime(2004, 11, 26);
            var actual = USACaliforniaPublicHoliday.BlackFriday(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestChristmas2004()
        {
            var expected = new DateTime(2004, 12, 25);
            var actual = USACaliforniaPublicHoliday.Christmas(2004);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNewYear()
        {
            var expected = new DateTime(2006, 1, 2);
            var actual = USACaliforniaPublicHoliday.NewYear(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMartinLutherKingDay()
        {
            var expected = new DateTime(2006, 1, 16);
            var actual = USACaliforniaPublicHoliday.MartinLutherKing(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWashington()
        {
            var expected = new DateTime(2006, 2, 20);
            var actual = USACaliforniaPublicHoliday.PresidentsDay(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMemorial()
        {
            var expected = new DateTime(2006, 5, 29);
            var actual = USACaliforniaPublicHoliday.MemorialDay(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIndependence()
        {
            var expected = new DateTime(2006, 7, 4);
            var actual = USACaliforniaPublicHoliday.IndependenceDay(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLabor()
        {
            var expected = new DateTime(2006, 9, 4);
            var actual = USACaliforniaPublicHoliday.LaborDay(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCesarChavez()
        {
            var expected = new DateTime(2006, 3, 31);
            var actual = USACaliforniaPublicHoliday.CesarChavezDay(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestVeterans()
        {
            var expected = new DateTime(2006, 11, 11);
            var actual = USACaliforniaPublicHoliday.VeteransDay(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThanksgiving()
        {
            var expected = new DateTime(2006, 11, 23);
            var actual = USACaliforniaPublicHoliday.Thanksgiving(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBlackFriday()
        {
            var expected = new DateTime(2006, 11, 24);
            var actual = USACaliforniaPublicHoliday.BlackFriday(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestChristmas()
        {
            var expected = new DateTime(2006, 12, 25);
            var actual = USACaliforniaPublicHoliday.Christmas(2006);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThanksgiving1999()
        {
            var expected = new DateTime(1999, 11, 25);
            var actual = USACaliforniaPublicHoliday.Thanksgiving(1999);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBlackFriday1999()
        {
            var expected = new DateTime(1999, 11, 26);
            var actual = USACaliforniaPublicHoliday.BlackFriday(1999);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsPublicHoliday()
        {
            var thanksgiving = new DateTime(1999, 11, 25);
            var result = new USACaliforniaPublicHoliday().IsPublicHoliday(thanksgiving);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestNextWorkingDay()
        {
            var thanksgiving = new DateTime(1999, 11, 25);
            var result = new USACaliforniaPublicHoliday().NextWorkingDay(thanksgiving);
            Assert.AreEqual(new DateTime(1999, 11, 29), result);
        }

        [TestMethod]
        public void TestNextWorkingDayCesarChavez()
        {
            var result = new USACaliforniaPublicHoliday().NextWorkingDay(new DateTime(2006, 3, 31));
            Assert.AreEqual(new DateTime(2006, 4, 3), result);
        }

        [TestMethod]
        public void TestPublicHolidays()
        {
            var thanksgiving = new DateTime(1999, 11, 25);
            var result = new USACaliforniaPublicHoliday().PublicHolidays(1999);
            Assert.AreEqual(11, result.Count);
            Assert.IsTrue(result.Contains(thanksgiving));
        }

        [TestMethod]
        public void TestPublicHolidayInformation()
        {
            var USACaliforniaPublicHoliday = new USACaliforniaPublicHoliday();
            var hols = USACaliforniaPublicHoliday.PublicHolidays(2017);
            var infos = USACaliforniaPublicHoliday.PublicHolidaysInformation(2017);
            Assert.AreEqual(hols.Count, infos.Count);
            foreach (var info in infos)
            {
                Assert.IsTrue(hols.Contains(info), "observed date is implicitly in both lists");
            }
        }

        [TestMethod]
        public void TestAddBusinessDays()
        {
            var USACaliforniaPublicHoliday = new USACaliforniaPublicHoliday();
            
            var startDt = new DateTime(2021, 3, 23);
            var businessDays = 10;

            var expected = new DateTime(2021, 4, 7);
            var actual = USACaliforniaPublicHoliday.AddBusinessDays(startDt, businessDays);

            Assert.AreEqual(expected, actual);
        }
    }
}