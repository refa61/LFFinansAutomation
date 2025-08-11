using LF.Finans.PageObjects.Base;
using LF.Finans.PageObjects.Pages;
using LF.Finans.PageObjects.Pages.LanPengar.FöretagsLan;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestAutomation.UnitTests
{
   public class ForetagPgaeTest
    {
        private IWebDriver driver;
        private HomePage hoempage;
        private WebDriverBase driverbase;
        private ForetaglanPage foretagpage;

   // SetUp *************************************
   [SetUp]
   public void SetUp()
        {
            var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();

            hoempage = new HomePage(driver);
            driverbase = new WebDriverBase(driver);
            foretagpage = new ForetaglanPage(driver);

        }

     
        // Test **********************************
         
    [Test]
    public void ForetagPageTest()
        { 
            
            hoempage.OpenUrl();
            Thread.Sleep(200);

            hoempage.AcceptCookies();

            Thread.Sleep(200);

            foretagpage.foretagClick();       
            Thread.Sleep(200);
            
            foretagpage.LeasingClick();

            Thread.Sleep(100);
            foretagpage.foretagClick();
            
            Thread.Sleep(200);
            foretagpage.HallbarFinansieringClick();

            Thread.Sleep(200);
            foretagpage.foretagClick();

            Thread.Sleep(200);
            foretagpage.DelbetalningbutikClick();

            Thread.Sleep(200);
            foretagpage.foretagClick();

            Thread.Sleep(200);
            foretagpage.Mashin_finansieringkClick();

            Thread.Sleep(200);

            string actualtitle = driverbase.GetPageTitle();
            Console.WriteLine("Rubrik är:" + actualtitle);

            string exceptedtitle = "Maskinfinansiering - leasing maskiner & fordon - LF Finans";

            Thread.Sleep(200);

            Assert.AreEqual(exceptedtitle, actualtitle);

        }


        // TearDown ******************************
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


        // End ***********************************
    }
}
