using ClientSide.Web.VOEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Extentions;

namespace TestWebProject
{
    
    
    /// <summary>
    ///This is a test class for ChallengingResultVOEntityTest and is intended
    ///to contain all ChallengingResultVOEntityTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ChallengingResultVOEntityTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SetCurrentDay
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("c:\\users\\itengineer\\documents\\visual studio 2010\\Projects\\Obm.Projects.Challenging\\ClientSide.Web", "/")]
        [UrlToTest("http://localhost:1060/")]
        public void SetCurrentDayTest()
        {
            ChallengingResultVOEntity target = new ChallengingResultVOEntity(); // TODO: Initialize to an appropriate value
            DayOfWeek tuesday = DayOfWeek.Tuesday; // TODO: Initialize to an appropriate value
            target.SetCurrentDay(tuesday);
            Assert.IsTrue(target.Tuesday.IsCurrent);
            /*Assert.IsFalse(target.Monday.IsCurrent);
            Assert.IsFalse(target.Thursday.IsCurrent);
            Assert.IsFalse(target.Wednesday.IsCurrent);
            Assert.IsFalse(target.Friday.IsCurrent);*/
        }

        /// <summary>
        ///A test for SetCurrentWeek
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("c:\\users\\itengineer\\documents\\visual studio 2010\\Projects\\Obm.Projects.Challenging\\ClientSide.Web", "/")]
        [UrlToTest("http://localhost:1060/")]
        public void SetCurrentWeekTest()
        {
            ChallengingResultVOEntity target = new ChallengingResultVOEntity(); // TODO: Initialize to an appropriate value
            WeekOfMonth second = WeekOfMonth.SecondWeek; // TODO: Initialize to an appropriate value
            target.SetCurrentWeek(second);
            Assert.IsTrue(target.Second.Week == second);
            //Assert.IsFalse(target.First.IsCurrent);
            //Assert.IsFalse(target.Third.IsCurrent);
            //Assert.IsFalse(target.Fourth.IsCurrent);
        }
    }
}
